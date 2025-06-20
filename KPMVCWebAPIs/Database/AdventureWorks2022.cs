// Licence file C:\Users\Kailash\OneDrive\Documents\ReversePOCO.txt not found.
// Please obtain your licence file at www.ReversePOCO.co.uk, and place it in your documents folder shown above.
// Defaulting to Trial version.


// ------------------------------------------------------------------------------------------------
// WARNING: Failed to load provider "System.Data.SqlClient" - A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: Named Pipes Provider, error: 40 - Could not open a connection to SQL Server)
// Allowed providers:
//    "System.Data.Odbc"
//    "System.Data.OleDb"
//    "System.Data.OracleClient"
//    "System.Data.SqlClient"
//    "Microsoft.SqlServerCe.Client.4.0"
//    "Microsoft.Data.SqlClient"

/*   at System.Data.SqlClient.SqlInternalConnectionTds..ctor(DbConnectionPoolIdentity identity, SqlConnectionString connectionOptions, SqlCredential credential, Object providerInfo, String newPassword, SecureString newSecurePassword, Boolean redirectedUserInstance, SqlConnectionString userConnectionOptions, SessionData reconnectSessionData, DbConnectionPool pool, String accessToken, Boolean applyTransientFaultHandling, SqlAuthenticationProviderManager sqlAuthProviderManager)
   at System.Data.SqlClient.SqlConnectionFactory.CreateConnection(DbConnectionOptions options, DbConnectionPoolKey poolKey, Object poolGroupProviderInfo, DbConnectionPool pool, DbConnection owningConnection, DbConnectionOptions userOptions)
   at System.Data.ProviderBase.DbConnectionFactory.CreatePooledConnection(DbConnectionPool pool, DbConnection owningObject, DbConnectionOptions options, DbConnectionPoolKey poolKey, DbConnectionOptions userOptions)
   at System.Data.ProviderBase.DbConnectionPool.CreateObject(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection)
   at System.Data.ProviderBase.DbConnectionPool.UserCreateRequest(DbConnection owningObject, DbConnectionOptions userOptions, DbConnectionInternal oldConnection)
   at System.Data.ProviderBase.DbConnectionPool.TryGetConnection(DbConnection owningObject, UInt32 waitForMultipleObjectsTimeout, Boolean allowCreate, Boolean onlyOneCheckConnection, DbConnectionOptions userOptions, DbConnectionInternal& connection)
   at System.Data.ProviderBase.DbConnectionPool.TryGetConnection(DbConnection owningObject, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal& connection)
   at System.Data.ProviderBase.DbConnectionFactory.TryGetConnection(DbConnection owningConnection, TaskCompletionSource`1 retry, DbConnectionOptions userOptions, DbConnectionInternal oldConnection, DbConnectionInternal& connection)
   at System.Data.ProviderBase.DbConnectionInternal.TryOpenConnectionInternal(DbConnection outerConnection, DbConnectionFactory connectionFactory, TaskCompletionSource`1 retry, DbConnectionOptions userOptions)
   at System.Data.SqlClient.SqlConnection.TryOpenInner(TaskCompletionSource`1 retry)
   at System.Data.SqlClient.SqlConnection.TryOpen(TaskCompletionSource`1 retry)
   at System.Data.SqlClient.SqlConnection.Open()
   at Microsoft.VisualStudio.TextTemplating131A712EEEC9230719866647FCF7BFE6580A26BF5A4A3B5B594CF15E59D7A9D874BDC14232B7F4C6D37436B4A7B9356A2DFCC7D0CC0AE08DD389EE951019485E.GeneratedTextTransformation.DatabaseReader.Init() in C:\Users\Kailash\source\repos\KPasumarthy\KPWebProjects\KPMVCWebAPIs\Database\EF.Reverse.POCO.v3.ttinclude:line 12640
   at Microsoft.VisualStudio.TextTemplating131A712EEEC9230719866647FCF7BFE6580A26BF5A4A3B5B594CF15E59D7A9D874BDC14232B7F4C6D37436B4A7B9356A2DFCC7D0CC0AE08DD389EE951019485E.GeneratedTextTransformation.SqlServerDatabaseReader.Init() in C:\Users\Kailash\source\repos\KPasumarthy\KPWebProjects\KPMVCWebAPIs\Database\EF.Reverse.POCO.v3.ttinclude:line 16606
   at Microsoft.VisualStudio.TextTemplating131A712EEEC9230719866647FCF7BFE6580A26BF5A4A3B5B594CF15E59D7A9D874BDC14232B7F4C6D37436B4A7B9356A2DFCC7D0CC0AE08DD389EE951019485E.GeneratedTextTransformation.Generator.Init(DatabaseReader databaseReader, String singleDbContextSubNamespace) in C:\Users\Kailash\source\repos\KPasumarthy\KPWebProjects\KPMVCWebAPIs\Database\EF.Reverse.POCO.v3.ttinclude:line 4336
   at Microsoft.VisualStudio.TextTemplating131A712EEEC9230719866647FCF7BFE6580A26BF5A4A3B5B594CF15E59D7A9D874BDC14232B7F4C6D37436B4A7B9356A2DFCC7D0CC0AE08DD389EE951019485E.GeneratedTextTransformation.GeneratorFactory.Create(FileManagementService fileManagementService, Type fileManagerType, String singleDbContextSubNamespace) in C:\Users\Kailash\source\repos\KPasumarthy\KPWebProjects\KPMVCWebAPIs\Database\EF.Reverse.POCO.v3.ttinclude:line 6593*/
// ------------------------------------------------------------------------------------------------

