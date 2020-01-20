using CosmosDbInvestigation.Structures;
using Microsoft.Azure.Documents.Client;

namespace CosmosDbInvestigation.DataAccess
{
  public class UserManager : DocumentManager<UserDocument>
  {

    public override DocumentType DocumentType => DocumentType.User;

    public UserManager(DocumentClient client, string databaseName, string collectionName) 
      : base(client, databaseName, collectionName)
    {
    }

  }
}
