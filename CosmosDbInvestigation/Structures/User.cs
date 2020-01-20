using Newtonsoft.Json;

namespace CosmosDbInvestigation.Structures
{
  public class User
  {

    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

  }
}
