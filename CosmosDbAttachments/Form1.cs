using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using CosmosDbInvestigation.Structures;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace CosmosDbAttachments
{
  public partial class Form1 : Form
  {
    #region Fields

    private readonly string EndpointUrl;
    private readonly string PrimaryKey;
    private readonly string DatabaseName;
    private readonly string CollectionName;
    private readonly Uri DocumentCollectionUri;

    private DocumentClient client;

    private readonly Guid tenantId = Guid.Parse("{53A36525-F7D9-448E-8333-27E8DB526FE7}");

    private readonly BindingList<FileDocument> fileList = new BindingList<FileDocument>();

    #endregion

    #region Constructor

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


      filesGrid.DataSource = fileList;
    }

    #endregion

    private async void startButton_Click(object sender, EventArgs e)
    {
      //Probably should have created a common class and method to do this
      //rather than copying the same code over and over again
      //I guess feeling too lazy right now. :(

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

      MessageBox.Show("Database and collection are ready to use");
    }

    private async void upsertButton_Click(object sender, EventArgs e)
    {
      try
      {
        var doc = new FileDocument()
        {
          Id = Guid.Parse(idTextBox.Text),
          TenantId = tenantId,
          Payload = new CosmosDbInvestigation.Structures.File()
          {
            Name = nameTextBox.Text
          }
        };

        var result = await client.UpsertDocumentAsync(DocumentCollectionUri, doc);
        MessageBox.Show(result.StatusCode.ToString());

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void refreshListButton_Click(object sender, EventArgs e)
    {
      try
      {
        var query = client.CreateDocumentQuery<FileDocument>(DocumentCollectionUri, new FeedOptions()
        {
          PartitionKey = new Microsoft.Azure.Documents.PartitionKey(tenantId.ToString())
        });

        fileList.Clear();

        foreach (var file in query)
        {
          fileList.Add(file);
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void newIdButton_Click(object sender, EventArgs e)
    {
      idTextBox.Text = Guid.NewGuid().ToString();
    }
    private async void refreshAttachmentsButton_Click(object sender, EventArgs e)
    {
      try
      {
        var attachmentsLink = UriFactory.CreateDocumentUri(DatabaseName, CollectionName, docIdTextBox.Text) + "/attachments";
        var response = await client.ReadAttachmentFeedAsync(attachmentsLink, new FeedOptions() { PartitionKey = new Microsoft.Azure.Documents.PartitionKey(tenantId.ToString()) });

        var attachments = new List<Attachment>();
        attachments.AddRange(response);
        attachmentsGrid.DataSource = attachments;

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void upsertAttachmentButton_Click(object sender, EventArgs e)
    {
      try
      {
        var docUri = UriFactory.CreateDocumentUri(DatabaseName, CollectionName, docIdTextBox.Text);
        var mediaOptions = new MediaOptions()
        {
          ContentType = mediaTypeTextBox.Text,
          Slug = attachmentIdTextBox.Text
        };
        var requestOptions = new RequestOptions()
        {
          PartitionKey = new Microsoft.Azure.Documents.PartitionKey(tenantId.ToString())
        };
        using (var fileStream = new FileStream(filePathTextBox.Text, FileMode.Open, FileAccess.Read))
        {
          var result2 = await client.UpsertAttachmentAsync(docUri, fileStream, mediaOptions, requestOptions);
          MessageBox.Show(result2.StatusCode.ToString());
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void editButton_Click(object sender, EventArgs e)
    {
      var file = filesGrid.SelectedRows?[0]?.DataBoundItem as CosmosDbInvestigation.Structures.FileDocument;
      if (file != null)
      {
        idTextBox.Text = file.Id.ToString();
        nameTextBox.Text = file.Name;
        tabControl1.SelectedIndex = 2;
      }
    }

    private void attachmentsButton_Click(object sender, EventArgs e)
    {
      //TODO
    }

    private async void attachmentsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      var attachment = attachmentsGrid.Rows[e.RowIndex].DataBoundItem as Attachment;
      if (attachment != null)
      {
        if (attachment.ContentType == "image/jpeg")
        {
          var mediaLinkResponse = await client.ReadMediaAsync(attachment.MediaLink);
          using (var stream = mediaLinkResponse.Media)
          {
            var img = Image.FromStream(stream);
            new ImageForm(img).Show();
          }
        }
      }
    }

    private async void deleteAttachmentButton_Click(object sender, EventArgs e)
    {
      try
      {
        var attachment = attachmentsGrid.SelectedRows?[0]?.DataBoundItem as Attachment;
        if (attachment == null)
        {
          throw new Exception("No attachment selected");
        }

        var attachmentsLink = UriFactory.CreateAttachmentUri(DatabaseName, CollectionName, docIdTextBox.Text, attachment.Id);
        var requestOptions = new RequestOptions()
        {
          PartitionKey = new Microsoft.Azure.Documents.PartitionKey(tenantId.ToString())
        };
        var response = await client.DeleteAttachmentAsync(attachmentsLink, requestOptions);
        MessageBox.Show(response.StatusCode.ToString());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
