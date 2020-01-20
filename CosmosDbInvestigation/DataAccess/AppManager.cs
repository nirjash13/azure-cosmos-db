using CosmosDbInvestigation.Structures;
using Microsoft.Azure.Documents.Client;

namespace CosmosDbInvestigation.DataAccess
{
  public class AppManager : DocumentManager<AppDocument>
  {

    public override DocumentType DocumentType => DocumentType.App;

    public AppManager(DocumentClient client, string databaseName, string collectionName) 
      : base(client, databaseName, collectionName)
    {
    }

  }
}
