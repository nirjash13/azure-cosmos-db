using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using CosmosDbInvestigation.DataAccess;
using CosmosDbInvestigation.Structures;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace CosmosDbInvestigation
{
  public partial class Form1 : Form
  {

    #region Fields

    private readonly string EndpointUrl;
    private readonly string PrimaryKey;
    private readonly string DatabaseName;
    private readonly string CollectionName;
    private readonly Uri DocumentCollectionUri; //= 

    private DocumentClient client;
    private UserManager userRepository;

    private readonly BindingList<TenantDocument> tenantList = new BindingList<TenantDocument>();
    private readonly BindingList<UserDocument> userList = new BindingList<UserDocument>();

    private readonly BindingList<AppDocument> appList = new BindingList<AppDocument>();
    private readonly BindingList<AppDocument> readAppList = new BindingList<AppDocument>();

    private readonly Random random = new Random();
    private readonly string[] appTitles = new string[]
    {
      "Sales Forecast",
      "Announcements",
      "Ads",
      "Build Status",
      "Who is In?",
      "Splat",
      "FIDS",
      "Food Stand",
      "Weather",
      "Ski Conditions",
      "Emergency",
      "Nerd Counter"
    };

    #endregion

    #region constructor

    public Form1()
    {
      InitializeComponent();
      this.EndpointUrl = ConfigurationManager.AppSettings["EndpointUrl"];
      this.PrimaryKey = ConfigurationManager.AppSettings["PrimaryKey"];
      this.DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
      this.CollectionName = ConfigurationManager.AppSettings["CollectionName"];

      if (string.IsNullOrWhiteSpace(DatabaseName) || string.IsNullOrWhiteSpace(CollectionName))
      {
        throw new ArgumentNullException("Database name or Collection name can not be null");
      }

      this.DocumentCollectionUri = UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName);

      tenantGrid.DataSource = tenantList;
      userGrid.DataSource = userList;

      readAppsTenantComboBox.DataSource = tenantList;
      readAppsTenantComboBox.DisplayMember = "Name";
      readAppsTenantComboBox.ValueMember = "Id";

      createAppsTenantComboBox.DataSource = tenantList;
      createAppsTenantComboBox.DisplayMember = "Name";
      createAppsTenantComboBox.ValueMember = "Id";

      generateAppsTenantComboBox.DataSource = tenantList;
      generateAppsTenantComboBox.DisplayMember = "Name";
      generateAppsTenantComboBox.ValueMember = "Id";

      readAppUserComboBox.DataSource = userList;
      readAppUserComboBox.DisplayMember = "Name";
      readAppUserComboBox.ValueMember = "Id";

      appsGrid.DataSource = appList;
      readAppsGrid.DataSource = readAppList;

      readAppPermissionTypeComboBox.DataSource = Enum.GetValues(typeof(PermissionType));
      readAppPermissionComboBox.DataSource = Enum.GetValues(typeof(Structures.Permission));

    } 

    #endregion

    private async void startButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (string.IsNullOrWhiteSpace(EndpointUrl) || string.IsNullOrWhiteSpace(PrimaryKey))
        {
          throw new ArgumentNullException("EndpointUrl name or PrimaryKey name can not be null");
        }

        client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
        await client.OpenAsync();

        var database = new Database
        {
          Id = DatabaseName
        };
        var databaseResponse = await client.CreateDatabaseIfNotExistsAsync(database);

        if (databaseResponse.StatusCode == HttpStatusCode.Created
          || databaseResponse.StatusCode == HttpStatusCode.OK)
        {
          var databaseCollection = new DocumentCollection
          {
            Id = this.CollectionName
          };

          var requestOptions = new RequestOptions()
          {
            PartitionKey = new PartitionKey("tenantId")
          };

          var collectionResponse = await client.CreateDocumentCollectionIfNotExistsAsync(
              UriFactory.CreateDatabaseUri(DatabaseName),
              new DocumentCollection { Id = CollectionName });

          if (collectionResponse.StatusCode == HttpStatusCode.InternalServerError)
          {
            throw new InvalidOperationException(collectionResponse.ToString());
          }

          userRepository = new UserManager(client, DatabaseName, CollectionName);
        }

        MessageBox.Show("Database and collection is ready to use");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
        throw;
      }
    }

    private async void serializeButton_Click(object sender, EventArgs e)
    {
      try
      {
        var doc = new AppDocument()
        {
          Id = Guid.NewGuid(),
          TenantId = Guid.NewGuid(),
          Payload = new App()
          {
            Title = "Test app! " + new Random().Next().ToString()
          }
        };

        doc.Metadata.Add("City", "Concord");
        doc.Metadata.Add("State", "Ontario");
        doc.Metadata.Add("Country", "Canada");
        doc.Metadata.Add("Floor", "5");
        doc.Metadata.Add("Suite", "501");
        doc.Metadata.Add("Street", "Highway 7");

        doc.Tags.Add("Development");
        doc.Tags.Add("Sales");
        doc.Tags.Add("Marketing");

        serializeTextBox.Text = doc.ToString(Formatting.Indented);
      }
      catch (Exception ex)
      {
        serializeTextBox.Text = ex.Message;
      }
    }

    private async void deserializeButton_Click(object sender, EventArgs e)
    {
      try
      {
        var doc = JsonConvert.DeserializeObject<AppDocument>(serializeTextBox.Text);
        serializeTextBox.Text = doc.ToString(Formatting.Indented);
        MessageBox.Show(doc.Id.ToString());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    
    private async void clearAppGridButton_Click(object sender, EventArgs e)
    {
      appList.Clear();
    }

    private async void generateAppsButton_Click(object sender, EventArgs e)
    {

      try
      {
        if (tenantList.Count == 0)
        {
          throw new Exception("No tenants loaded in Tenants grid. These are needed to assign apps to random tenants.");
        }

        for (int i = 0; i < appsSpinEdit.Value; i++)
        {
          var app = new AppDocument()
          {
            Id = Guid.NewGuid(),
            TenantId = (Guid)createAppsTenantComboBox.SelectedValue, //_tenants[_random.Next(0, _tenants.Count - 1)].Id,
            Payload = new App()
            {
              Title = RandomAppTitle()
            }
          };
          appsGrid.SuspendLayout();
          appList.Add(app);
          appsGrid.ResumeLayout();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private string RandomAppTitle()
    {
      return string.Concat(appTitles[random.Next(0, appTitles.Length - 1)], " ", random.Next(1, 1000).ToString("0000"));
    }

    
    private async void insertAppsSerialButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (appList.Count == 0)
        {
          throw new Exception("No tenants in grid.");
        }
        var stopwatch = new Stopwatch();
        stopwatch.Start();
        foreach (var app in appList)
        {
          var result = await client.CreateDocumentAsync(DocumentCollectionUri, app);
          if (result.StatusCode != System.Net.HttpStatusCode.Created)
          {
            throw new Exception(result.StatusCode.ToString());
          }
        }
        stopwatch.Stop();

        MessageBox.Show("Done: " + stopwatch.ElapsedMilliseconds.ToString());

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void readAppsLimitCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      readAppsLimitSpinEdit.Enabled = readAppsLimitCheckBox.Checked;
    }

    private async void readAppsTenantCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      readAppsTenantComboBox.Enabled = readAppsTenantCheckBox.Checked;
    }

    private async void readAppsFromCosmosButton_Click(object sender, EventArgs e)
    {
      try
      {
        string sql = GetReadAppSQL();

        FeedOptions queryOptions = new FeedOptions
        {
          MaxItemCount = -1
        };

        IQueryable<AppDocument> query = this.client.CreateDocumentQuery<AppDocument>(
         DocumentCollectionUri,
         sql,
         queryOptions);

        readAppList.Clear();

        foreach (var app in query)
        {
          readAppList.Add(app);
        }

        MessageBox.Show(readAppList.Count.ToString());

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private string GetReadAppSQL()
    {
      var sql = $"SELECT ";
      if (readAppsLimitCheckBox.Checked)
      {
        sql += $"TOP {Convert.ToInt32(readAppsLimitSpinEdit.Value).ToString(CultureInfo.InvariantCulture)}";
      }
      sql += $" * FROM T WHERE T.typeId = {DocumentType.App.GetHashCode()}";
      if (readAppsTenantCheckBox.Checked)
      {
        var tenantId = (Guid)readAppsTenantComboBox.SelectedValue;
        sql += $" AND T.tenantId = '{tenantId}'";
      }
      if (readAppsWhereCheckBox.Checked && !string.IsNullOrWhiteSpace(readAppsWhereTextBox.Text))
      {
        sql += $" AND ({readAppsWhereTextBox.Text})";
      }
      if (readAppsUserCheckBox.Checked)
      {
        var userId = (Guid)readAppUserComboBox.SelectedValue;
        var permissionType = (PermissionType)readAppPermissionTypeComboBox.SelectedValue;
        var permission = (Structures.Permission)readAppPermissionComboBox.SelectedValue;
        if (permission != Structures.Permission.NotSet)
        {
          sql += $" AND (T.userPermissions[\"{userId}\"][\"{permissionType.ToString()}\"] = {permission.GetHashCode().ToString()})";
        }

      }
      if (readAppsOrderCheckBox.Checked && !string.IsNullOrWhiteSpace(readAppsOrderTextBox.Text))
      {
        sql += $" ORDER BY {readAppsOrderTextBox.Text}";
      }

      return sql;
    }

    private async void createStoredProceduresButton_Click(object sender, EventArgs e)
    {
      try
      {

        var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"StoredProcs\BulkImport.js");
        var sproc = new StoredProcedure
        {
          Id = "BulkImport",
          Body = System.IO.File.ReadAllText(path)
        };
        sproc = await client.CreateStoredProcedureAsync(DocumentCollectionUri, sproc);
        MessageBox.Show("Bulk import completed");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void insertAppsStoredProcButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (appList.Count == 0)
        {
          throw new Exception("No tenants in grid.");
        }

        // Group by Tenant Id because this is the partition key
        var groups = appList.GroupBy((appDoc) => appDoc.TenantId);

        var responses = new List<string>();

        var stopwatch = new Stopwatch();


        // Loop through the Groups
        foreach (var group in groups)
        {
          var ro = new RequestOptions()
          {
            PartitionKey = new PartitionKey(group.Key.ToString())
          };
          var args = new dynamic[]
          {
            group.ToArray()
          };
          stopwatch.Start();
          var response = await client.ExecuteStoredProcedureAsync<string>(UriFactory.CreateStoredProcedureUri(DatabaseName, CollectionName, "BulkImport"), ro, args);
          stopwatch.Stop();
          responses.Add(group.Key.ToString() + " " + group.Count().ToString() + " " + response);
        }
        responses.Add(stopwatch.ElapsedMilliseconds.ToString());
        MessageBox.Show(string.Join("\r\n", responses));

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void readAppsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var document = readAppsGrid.Rows[e.RowIndex].DataBoundItem;
      new DocumentForm(document).Show();
    }

    private async void createIndexPayloadTitleButton_Click(object sender, EventArgs e)
    {
      try
      {
        var ro = new RequestOptions()
        {

        };
        var x = await client.ReadDocumentCollectionAsync(DocumentCollectionUri);
        var collection = x.Resource;
        var includedPath = new IncludedPath()
        {
          Path = "/payload/Title/?"
        };
        includedPath.Indexes.Add(new RangeIndex(DataType.String, -1));
        collection.IndexingPolicy.IncludedPaths.Add(includedPath);
        var result = await client.ReplaceDocumentCollectionAsync(collection);
        MessageBox.Show(result.StatusCode.ToString());


      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void generateAppsButton2_Click(object sender, EventArgs e)
    {

      try
      {

        if (generateAppWithPermissionsCheckBox.Checked && userList.Count == 0)
        {
          throw new Exception("No users in the users grid. Cannot create permissions.");
        }

        var permissionTypes = System.Enum.GetValues(typeof(PermissionType)).OfType<PermissionType>().ToArray();
        var permissions = System.Enum.GetValues(typeof(Structures.Permission)).OfType<Structures.Permission>().ToArray();

        var apps = new List<object>();

        for (int i = 0; i < generateAppsSpinEdit.Value; i++)
        {
          var app = new AppDocument()
          {
            Id = Guid.NewGuid(),
            TenantId = (Guid)generateAppsTenantComboBox.SelectedValue,
            Payload = new App()
            {
              Title = RandomAppTitle()
            }
          };
          if (generateAppWithPermissionsCheckBox.Checked)
          {

            for (int j = 0; j < 10; j++)
            {
              var userId = userList[random.Next(0, userList.Count)].Id;
              var permissionType = permissionTypes[random.Next(0, permissionTypes.Length)];
              var permission = permissions[random.Next(0, permissions.Length)];
              app.ChangeUserPermission(userId, permissionType, permission);
            }
          }
          apps.Add(app);

        }

        var ro = new RequestOptions()
        {
          PartitionKey = new PartitionKey(((Guid)generateAppsTenantComboBox.SelectedValue).ToString())
        };
        var args = new dynamic[]
        {
            apps.ToArray()
        };

        var sw = new Stopwatch();
        sw.Start();
        var response = await client.ExecuteStoredProcedureAsync<string>(UriFactory.CreateStoredProcedureUri(DatabaseName, CollectionName, "BulkImport"), ro, args);
        sw.Stop();

        MessageBox.Show(response + " " + sw.ElapsedMilliseconds);

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }


    }

    private async void readAppsCountFromCosmosButton_Click(object sender, EventArgs e)
    {
      try
      {

        FeedOptions queryOptions = new FeedOptions
        {
          MaxItemCount = -1
        };

        var sql = $"SELECT COUNT(T.id) FROM T WHERE T.typeId = {DocumentType.App.GetHashCode()}";
        if (readAppsTenantCheckBox.Checked)
        {
          var tenantId = (Guid)readAppsTenantComboBox.SelectedValue;
          sql += $" AND T.tenantId = '{tenantId}'";
          queryOptions.PartitionKey = new PartitionKey(tenantId.ToString());
        }
        if (readAppsWhereCheckBox.Checked && !string.IsNullOrWhiteSpace(readAppsWhereTextBox.Text))
        {
          sql += $" AND ({readAppsWhereTextBox.Text})";
        }

        var query = this.client.CreateDocumentQuery(DocumentCollectionUri, sql, queryOptions);

        foreach (var result in query)
        {
          MessageBox.Show(result.ToString());
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void loadUsersFromFileButton_Click(object sender, EventArgs e)
    {
      try
      {
        var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"SampleData\Users.json");
        var json = System.IO.File.ReadAllText(path);
        var users = JsonConvert.DeserializeObject<UserDocument[]>(json);
        userList.Clear();
        foreach (var user in users)
        {
          userList.Add(user);
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void loadUsersFromCosmosButton_Click(object sender, EventArgs e)
    {
      try
      {

        var query = await userRepository.Read(Globals.SecurityAssetsTenantId);

        userList.Clear();

        foreach (var item in query)
        {
          userList.Add(item);
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

    }

    private async void insertUsersIntoCosmosButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (userList.Count == 0)
        {
          throw new Exception("No users in grid.");
        }

        await userRepository.Create(userList);

        MessageBox.Show("Done");

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void readAppsUserCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      readAppUserComboBox.Enabled = readAppsUserCheckBox.Checked;
      readAppPermissionTypeComboBox.Enabled = readAppsUserCheckBox.Checked;
      readAppPermissionComboBox.Enabled = readAppsUserCheckBox.Checked;
    }

    private void readAppSQLButton_Click(object sender, EventArgs e)
    {
      new DocumentForm(GetReadAppSQL()).Show();
    }

    private async void millionRandomButton_Click(object sender, EventArgs e)
    {

      try
      {


        var permissionTypes = System.Enum.GetValues(typeof(PermissionType)).OfType<PermissionType>().ToArray();
        var permissions = System.Enum.GetValues(typeof(Structures.Permission)).OfType<Structures.Permission>().ToArray();

        var batchSize = 1000;
        var totalRecords = 1000000;

        for (int k = 0; k < totalRecords; k += batchSize)
        {

          var apps = new List<object>();

          for (int i = 0; i < batchSize; i++)
          {
            var app = new AppDocument()
            {
              Id = Guid.NewGuid(),
              TenantId = (Guid)generateAppsTenantComboBox.SelectedValue,
              Payload = new App()
              {
                Title = RandomAppTitle()
              }
            };
            if (generateAppWithPermissionsCheckBox.Checked)
            {

              for (int j = 0; j < 10; j++)
              {
                var userId = userList[random.Next(0, userList.Count)].Id;
                var permissionType = permissionTypes[random.Next(0, permissionTypes.Length)];
                var permission = permissions[random.Next(0, permissions.Length)];
                app.ChangeUserPermission(userId, permissionType, permission);
              }
            }
            apps.Add(app);

          }

          var ro = new RequestOptions()
          {
            PartitionKey = new PartitionKey(((Guid)generateAppsTenantComboBox.SelectedValue).ToString())
          };
          var args = new dynamic[]
          {
            apps.ToArray()
          };

          var response = await client.ExecuteStoredProcedureAsync<string>(UriFactory.CreateStoredProcedureUri(DatabaseName, CollectionName, "BulkImport"), ro, args);
          this.Text = DateTime.Now.ToString() + " " + k.ToString() + " " + response.StatusCode.ToString();
        }

        MessageBox.Show("Done generating a million records.");

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void setLazyIndexingButton_Click(object sender, EventArgs e)
    {
      try
      {
        var ro = new RequestOptions()
        {

        };
        var x = await client.ReadDocumentCollectionAsync(DocumentCollectionUri);
        var collection = x.Resource;

        collection.IndexingPolicy.IndexingMode = IndexingMode.Lazy;
        var result = await client.ReplaceDocumentCollectionAsync(collection);
        MessageBox.Show(result.StatusCode.ToString());


      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

    }

    #region Tenant Grid Tab
    private async void refreshTenantGridButton_Click(object sender, EventArgs e)
    {
      tenantList.Clear();
    }
    private async void loadTenantsFromFile_Click(object sender, EventArgs e)
    {
      try
      {
        //Get the Tenants.Json file data
        var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"SampleData\Tenants.json");
        var json = System.IO.File.ReadAllText(path);

        var tenants = JsonConvert.DeserializeObject<TenantDocument[]>(json);
        tenantList.Clear();
        foreach (var tenant in tenants)
        {
          tenantList.Add(tenant);
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void loadTenantsFromCosmos_Click(object sender, EventArgs e)
    {
      try
      {

        var sql = $"SELECT * FROM T WHERE T.tenantId = '{Globals.SecurityAssetsTenantId}' AND T.typeId = {DocumentType.Tenant.GetHashCode()}";

        FeedOptions queryOptions = new FeedOptions
        {
          MaxItemCount = -1
        };

        IQueryable<TenantDocument> query = this.client.CreateDocumentQuery<TenantDocument>(
         DocumentCollectionUri,
         sql,
         queryOptions);

        tenantList.Clear();

        foreach (var tenant in query)
        {
          tenantList.Add(tenant);
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void insertTenantsIntoCosmosButton_Click(object sender, EventArgs e)
    {
      try
      {
        if (tenantList.Count == 0)
        {
          throw new Exception("No tenants in grid.");
        }
        foreach (var tenant in tenantList)
        {
          var uri = UriFactory.CreateDocumentUri(DatabaseName, CollectionName, tenant.Id.ToString());
          await client.CreateDocumentAsync(DocumentCollectionUri, tenant);
        }

        MessageBox.Show("Done");

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    #endregion
  }
}
