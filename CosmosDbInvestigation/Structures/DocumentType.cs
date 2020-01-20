namespace CosmosDbInvestigation.Structures
{
  public enum DocumentType
  {
    None = 0,

    // Security Assets
    Tenant = 1001,
    User = 1002,
    Group = 1003,

    /// <summary>
    /// Junction between Tenants and Users
    /// </summary>
    TenantUser = 1101,

    /// <summary>
    /// Junction between Groups and Users
    /// </summary>
    GroupUser = 1102,

    /// <summary>
    /// Permissions for a User accessing a Document
    /// </summary>
    UserDocumentPermission = 1201,

    /// <summary>
    /// Permissions for a Group accessing a Document
    /// </summary>
    GroupDocumentPermission = 1202,

    // Asset Types
    App = 2001,

    File = 2100

  }
}
