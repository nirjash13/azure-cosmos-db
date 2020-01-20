using Newtonsoft.Json;

namespace CosmosDbInvestigation.Structures
{
  public class AppDocument : DocumentBase<App>
  {

    #region Properties

    public override DocumentType DocumentType => DocumentType.App;

    #endregion

    #region Helper Properties for Quick Referencing (all with [JsonIgnore] to keep them from being serialized/deserialized)


    [JsonIgnore]
    public string Title => Payload?.Title;

    #endregion

  }
}
