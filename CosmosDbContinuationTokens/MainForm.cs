using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using CosmosDbInvestigation.Structures;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Newtonsoft.Json;

namespace CosmosDbContinuationTokens
{
  public partial class MainForm : Form
  {

    #region Fields

    private readonly string EndpointUrl;
    private readonly string PrimaryKey;
    private readonly string DatabaseName;
    private readonly string CollectionName;
    private readonly Uri DocumentCollectionUri; //= 

    //this one to create the database and collection if already not exists
    private DocumentClient client;

    private DocumentClient client1;
    private DocumentClient client2;
    private DocumentClient client3;

    private const string SQL = "SELECT  * FROM T WHERE T.typeId = 2001 AND T.tenantId = '2f1d80c0-f7bf-4d03-a3bb-500b430f800c'";

    private readonly BindingList<AppDocument> resultList = new BindingList<AppDocument>();

    #endregion

    public MainForm()
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


      this.queryGrid.DataSource = resultList;
    }

    private async void setupButton_Click(object sender, EventArgs e)
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

        var collectionResponse = await client.CreateDocumentCollectionIfNotExistsAsync(
            UriFactory.CreateDatabaseUri(DatabaseName),
            new DocumentCollection { Id = CollectionName });

        if (collectionResponse.StatusCode == HttpStatusCode.InternalServerError)
        {
          throw new InvalidOperationException(collectionResponse.ToString());
        }
      }

      client1 = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
      await client1.OpenAsync();
      client2 = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
      await client2.OpenAsync();
      client3 = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
      await client3.OpenAsync();

      MessageBox.Show("Database and collection are ready to use");
    }

    private void createButton_Click(object sender, EventArgs e)
    {
      //TODO
    }
    private async Task BeginQuery(DocumentClient client)
    {
      try
      {
        resultList.Clear();

        FeedOptions queryOptions = new FeedOptions
        {
          MaxItemCount = Convert.ToInt32(this.pageSizeSpinEdit.Value),
          PartitionKey = new PartitionKey("2f1d80c0-f7bf-4d03-a3bb-500b430f800c")
        };

        IQueryable<AppDocument> queryable = client.CreateDocumentQuery<AppDocument>
          (
            DocumentCollectionUri,
            SQL,
            queryOptions
          );

        IDocumentQuery<AppDocument> docQuery = queryable.AsDocumentQuery();

        FeedResponse<AppDocument> feedResponse = await docQuery.ExecuteNextAsync<AppDocument>();

        int numberOfRecordsReturned = feedResponse.Count;
        bool hasMoreResults = docQuery.HasMoreResults;
        string continuationToken = feedResponse.ResponseContinuation;
        
        foreach (AppDocument item in feedResponse)
        {
          resultList.Add(item);
        }

        var message = new
        {
          numberOfRecordsReturned,
          hasMoreResults,
          continuationToken, 
          feedResponse.SessionToken
        };

        this.continuationTokenTextBox.Text = continuationToken;

        MessageBox.Show(JsonConvert.SerializeObject(message, Formatting.Indented));

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
    private async void begin1Button_Click(object sender, EventArgs e)
    {
      await BeginQuery(client1);
    }

    private async void begin2Button_Click(object sender, EventArgs e)
    {
      await BeginQuery(client2);
    }

    private async void begin3Button_Click(object sender, EventArgs e)
    {
      await BeginQuery(client3);
    }
    private async Task ContinueQuery(DocumentClient client)
    {
      try
      {
        FeedOptions queryOptions = new FeedOptions
        {
          MaxItemCount = Convert.ToInt32(this.pageSizeSpinEdit.Value),
          PartitionKey = new PartitionKey("2f1d80c0-f7bf-4d03-a3bb-500b430f800c"),
          RequestContinuation = this.continuationTokenTextBox.Text
        };

        var queryable = this.client1.CreateDocumentQuery<AppDocument>
          (
            DocumentCollectionUri,
            SQL,
            queryOptions
          );

        IDocumentQuery<AppDocument> docQuery = queryable.AsDocumentQuery();

        FeedResponse<AppDocument> feedResponse = await docQuery.ExecuteNextAsync<AppDocument>();

        int numberOfRecordsReturned = feedResponse.Count;
        bool hasMoreResults = docQuery.HasMoreResults;
        string continuationToken = feedResponse.ResponseContinuation;

        foreach (AppDocument item in feedResponse)
        {
          resultList.Add(item);
        }

        var message = new
        {
          numberOfRecordsReturned,
          hasMoreResults,
          continuationToken,
          feedResponse.SessionToken
        };

        this.continuationTokenTextBox.Text = feedResponse.ResponseContinuation;

        MessageBox.Show(JsonConvert.SerializeObject(message, Formatting.Indented));

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void continue1Button_Click(object sender, EventArgs e)
    {
      await ContinueQuery(client1);
    }

    private async void continue2Button_Click(object sender, EventArgs e)
    {
      await ContinueQuery(client2);
    }

    private async void continue3Button_Click(object sender, EventArgs e)
    {
      await ContinueQuery(client3);
    }

    private void newInstanceButton_Click(object sender, EventArgs e)
    {
      Process.Start(System.Environment.CommandLine.Trim('\"', ' '));
    }
  }
}
