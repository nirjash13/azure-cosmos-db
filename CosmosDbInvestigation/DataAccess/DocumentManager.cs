using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CosmosDbInvestigation.Structures;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace CosmosDbInvestigation.DataAccess
{
  public abstract class DocumentManager<TDocument>
    where TDocument : DocumentBase
  {

    #region Fields

    private readonly DocumentClient _client;
    private readonly string DatabaseName;
    private readonly string CollectionName;
    private readonly Uri DocumentCollectionUri;

    #endregion

    #region Properties

    public abstract DocumentType DocumentType { get; }

    #endregion

    #region Constructor

    public DocumentManager(DocumentClient client, string databaseName, string collectionName)
    {
      if (client == null)
      {
        throw new ArgumentNullException(nameof(client));
      }
      _client = client;
      DatabaseName = databaseName;
      CollectionName = collectionName;
      DocumentCollectionUri = UriFactory.CreateDocumentCollectionUri(databaseName, collectionName);
    }

    #endregion

    public IQueryable<TDocument> Read(Guid tenantId)
    {

      var sql = $"SELECT * FROM T WHERE T.tenantId = '{tenantId.ToString()}' AND T.typeId = {this.DocumentType.GetHashCode()}";

      FeedOptions queryOptions = new FeedOptions
      {
        MaxItemCount = -1,
        PartitionKey = new PartitionKey(tenantId.ToString())
      };

      return _client.CreateDocumentQuery<TDocument>(DocumentCollectionUri, sql, queryOptions);

    }

    public async void Create(TDocument item)
    {
      // TODO: changes should all be done through stored procs and subject to security

      var result = await _client.CreateDocumentAsync(DocumentCollectionUri, item);
      // TODO: Log all kinds of info from the result and respond to it
      // TODO: Handle failure much better than this
      if (result.StatusCode != System.Net.HttpStatusCode.Created)
      {
        throw new Exception(result.StatusCode.ToString());
      }
    }

    public async Task Create(IEnumerable<TDocument> documents)
    {

      // TODO: changes should all be done through stored procs and subject to security

      try
      {
        #region Validate

        if (!documents.Any())
        {
          return;
        } 

        #endregion

        // Group by Tenant Id because this is the partition key
        // Note that each partition will be separately updated
        var groups = documents.GroupBy((document) => document.TenantId);

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
          var response = await _client.ExecuteStoredProcedureAsync<string>(UriFactory.CreateStoredProcedureUri(DatabaseName, CollectionName, "BulkImport"), ro, args);
          stopwatch.Stop();
          responses.Add(group.Key.ToString() + " " + group.Count().ToString() + " " + response);
        }
        responses.Add(stopwatch.ElapsedMilliseconds.ToString());

      }
      catch (Exception ex)
      {
        throw;
      }
      
    }

    public async void Update(DocumentBase<TDocument> item)
    {

      // TODO: changes should all be done through stored procs and subject to security

      var result = await _client.ReplaceDocumentAsync(DocumentCollectionUri, item);
      // TODO: Log all kinds of info from the result and respond to it
      // TODO: Handle failure much better than this
      if (result.StatusCode != System.Net.HttpStatusCode.Created)
      {
        throw new Exception(result.StatusCode.ToString());
      }
    }

    public void Update(IEnumerable<DocumentBase<TDocument>> items)
    {
      // TODO: changes should all be done through stored procs and subject to security

      // Group by partition
    }

    public void Upsert(DocumentBase<TDocument> item)
    {
      // TODO: changes should all be done through stored procs and subject to security
    }

    public void Upsert(IEnumerable<DocumentBase<TDocument>> items)
    {
      // TODO: changes should all be done through stored procs and subject to security

      // Group by partition
    }

    // TODO: Reads should all be done through stored procs and subject to security

  }
}
