using Newtonsoft.Json;

namespace CosmosDbInvestigation.Structures
{
  public class TenantDocument: DocumentBase<Tenant>
  {

    public override DocumentType DocumentType => DocumentType.Tenant;

    #region Helper Properties for Quick Referencing (all with [JsonIgnore] to keep them from being serialized/deserialized)

    [JsonIgnore]
    public string Name => Payload?.Name;


    #endregion

  }
}
