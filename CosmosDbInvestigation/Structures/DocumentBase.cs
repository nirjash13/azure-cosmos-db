using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CosmosDbInvestigation.Structures
{


  public abstract class DocumentBase
  {

    #region Properties


    [JsonProperty(PropertyName = "id", Order = 0)]
    public Guid Id { get; set; }

    [JsonProperty(PropertyName = "tenantId", Order = 3)]
    public Guid TenantId { get; set; }

    [JsonProperty(PropertyName = "typeName", Order = 2)]
    [JsonConverter(typeof(StringEnumConverter))]
    public abstract DocumentType DocumentType { get; }

    [JsonProperty(PropertyName = "typeId", Order = 1)]
    public DocumentType DocumentTypeId => this.DocumentType;


    #endregion

    #region Properties (Permissions)

    // This is not a concurrent dictionary. But for a transient POCO that gets used lightly and then discarded, it should be fine

    [JsonProperty(PropertyName = "userPermissions", Order = 1000)]
    private Dictionary<Guid, Dictionary<PermissionType, Permission>> _userPermissions = new Dictionary<Guid, Dictionary<PermissionType, Permission>>();

    [JsonIgnore]
    public Dictionary<Guid, Dictionary<PermissionType, Permission>> UserPermissions => _userPermissions;

    #endregion

    #region Properties (Metadata and Tags)

    [JsonProperty(PropertyName = "metadata", Order = 2000)]
    private Dictionary<string, string> _metadata = new Dictionary<string, string>();

    [JsonIgnore]
    public Dictionary<string, string> Metadata => _metadata;

    [JsonProperty(PropertyName = "tags", Order = 2001)]
    private List<string> _tags = new List<string>();

    [JsonIgnore]
    public List<string> Tags => _tags;

    #endregion

    #region Properties (ETag)

    [JsonProperty(propertyName: "_etag")]
    public string ETag { get; set; }

    #endregion

    #region Methods (Permissions)

    public void ChangeUserPermission(Guid userId, PermissionType permissionType, Permission permission)
    {
      Dictionary<PermissionType, Permission> dict;
      if(!_userPermissions.TryGetValue(userId, out dict))
      {
        dict = new Dictionary<PermissionType, Permission>();
        _userPermissions.Add(userId, dict);
      }

      if (permission == Permission.NotSet)
      {
        dict.Remove(permissionType);
      }
      else
      {
        dict[permissionType] = permission;
      }
    }

    #endregion

    #region Methods (ToString)

    public override string ToString()
    {
      return JsonConvert.SerializeObject(this);
    }

    public string ToString(Formatting formatting)
    {
      return JsonConvert.SerializeObject(this, formatting);
    }

    #endregion

  }

  public abstract class DocumentBase<TPayload> : DocumentBase
  {

    #region Properties

    [JsonProperty(PropertyName = "payload", Order = 2000)]
    public TPayload Payload { get; set; }

    

    #endregion


  }
}
