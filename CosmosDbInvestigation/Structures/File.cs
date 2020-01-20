using Newtonsoft.Json;

namespace CosmosDbInvestigation.Structures
{
  public class File
  {

    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

  }
}
