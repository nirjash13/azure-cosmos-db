using Newtonsoft.Json;

namespace CosmosDbInvestigation.Structures
{
  public class FileDocument : DocumentBase<File>
  {
    public override DocumentType DocumentType => DocumentType.File;

    [JsonIgnore]
    public string Name => Payload.Name;

  }
}
