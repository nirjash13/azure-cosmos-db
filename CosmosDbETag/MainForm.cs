using DocumentDbInvestigation.Structures;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentDbETag
{
  public partial class MainForm : Form
  {

    #region Fields

    private const string EndpointUrl = "https://shayward-innovation.documents.azure.com:443/";
    private const string PrimaryKey = "p5nUymCFLKR0MQAiIU5qpUzJaqeMkaxALhhHPuhFy4dqd3SHft1rYg4ZD4htkCgHma2flOD3AiSbHB4M4nqaQA==";
    private const string DatabaseName = "Ink";
    private const string CollectionName = "AllCustomers";
    private readonly Uri DocumentCollectionUri = UriFactory.CreateDocumentCollectionUri(DatabaseName, CollectionName);

    private DocumentClient client;

    // Hard-coded to the tenant that currently has a bunch of records in my database
    // Something like a million records
    private const string SQL = "SELECT  * FROM T WHERE T.typeId = 2001 AND T.tenantId = '2f1d80c0-f7bf-4d03-a3bb-500b430f800c'";

    #endregion

    public MainForm()
    {
      InitializeComponent();
    }

    private async void setupButton_Click(object sender, EventArgs e)
    {
      client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
      await client.OpenAsync();

      MessageBox.Show("Ready");
    }

    private void newInstanceButton_Click(object sender, EventArgs e)
    {
      Process.Start(System.Environment.CommandLine.Trim('\"', ' '));
    }

    #region List

    private async Task BeginQuery(DocumentClient client)
    {
      try
      {
        var list = new List<AppDocument>();

        FeedOptions queryOptions = new FeedOptions
        {
          MaxItemCount = 25,
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

        // Get some helpful information
        int numberOfRecordsReturned = feedResponse.Count;
        bool hasMoreResults = docQuery.HasMoreResults;
        string continuationToken = feedResponse.ResponseContinuation;

        // Loop through the records returned
        foreach (AppDocument item in feedResponse)
        {
          list.Add(item);
        }

        var message = new
        {
          numberOfRecordsReturned,
          hasMoreResults,
          continuationToken,
          feedResponse.SessionToken
        };

        //this.continuationTokenTextBox.Text = continuationToken;

        this.dataGridView1.DataSource = list;
        

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private async void refreshListButton_Click(object sender, EventArgs e)
    {
      await BeginQuery(client);
    }
    private async void editAndUpsertButton_Click(object sender, EventArgs e)
    {
      try
      {
        var doc = dataGridView1.SelectedRows?[0]?.DataBoundItem as AppDocument;
        if (doc == null)
        {
          throw new Exception("No selected item.");
        }


        doc.Payload.Title = "SH " + DateTime.Now.TimeOfDay.ToString();

        var requestOptions = new RequestOptions()
        {
          PartitionKey = new PartitionKey("2f1d80c0-f7bf-4d03-a3bb-500b430f800c")
        };

        var response = await client.UpsertDocumentAsync(DocumentCollectionUri, doc, requestOptions, true);

        MessageBox.Show(response.StatusCode.ToString());

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
    private async void editAndUpsertWithAccessConditionsButton_Click(object sender, EventArgs e)
    {
      try
      {
        AppDocument doc = GetDocFromUI();

        doc.Payload.Title = "SH " + DateTime.Now.TimeOfDay.ToString();

        var accessCondition = new AccessCondition()
        {
          Condition = doc.ETag,
          Type = AccessConditionType.IfMatch
        };

        var requestOptions = new RequestOptions()
        {
          PartitionKey = new PartitionKey("2f1d80c0-f7bf-4d03-a3bb-500b430f800c"),
          AccessCondition = accessCondition
        };

        var response = await client.UpsertDocumentAsync
        (
          DocumentCollectionUri, 
          doc, 
          requestOptions, 
          true
        );

        MessageBox.Show(response.StatusCode.ToString());

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private AppDocument GetDocFromUI()
    {
      var doc = dataGridView1.SelectedRows?[0]?.DataBoundItem as AppDocument;
      if (doc == null)
      {
        throw new Exception("No selected item.");
      }

      return doc;
    }

    #endregion


  }
}
