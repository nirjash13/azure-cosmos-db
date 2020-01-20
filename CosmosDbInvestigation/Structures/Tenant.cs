using Newtonsoft.Json;

namespace CosmosDbInvestigation.Structures
{
  public class Tenant
  {

    [JsonProperty(PropertyName ="name")]
    public string Name { get; set; }

  }
}
