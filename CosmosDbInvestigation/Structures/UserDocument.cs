using Newtonsoft.Json;

namespace CosmosDbInvestigation.Structures
{
  public class UserDocument : DocumentBase<User>
  {
    public override DocumentType DocumentType => DocumentType.User;

    #region Helper Properties for Quick Referencing (all with [JsonIgnore] to keep them from being serialized/deserialized)


    [JsonIgnore]
    public string Name => Payload?.Name;

    [JsonIgnore]
    public string Email => Payload?.Email;

    #endregion

  }
}
