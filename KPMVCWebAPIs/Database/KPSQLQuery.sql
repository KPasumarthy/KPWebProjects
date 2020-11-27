Use [EmployeeDB]
Select * From dbo.__EFMigrationsHistory
Select * From dbo.Employees


Use [FundAppsCourierKataContext-20190618174956]
Select * From dbo.[Parcels]

Use [AdventureWorks2017]
Select * From Person.Person 
Select * From INFORMATION_SCHEMA.COLUMNS Where TABLE_NAME = N'Person'
SELECT Top 100 * FROM Person.Person
Select * From Person.Person Where BusinessEntityID = 5
Select * From Person.Person
Select * From Person.Person Order By BusinessEntityID DESC
Select  Count(*) From Person.Person 


----KP : Kill All Existing & Orphaned Connections
USE [master];

DECLARE @kill varchar(8000) = '';  
SELECT @kill = @kill + 'kill ' + CONVERT(varchar(5), session_id) + ';'  
FROM sys.dm_exec_sessions
WHERE database_id  = db_id('MyDB')

EXEC(@kill);


----KP : Set Default App Pools & IIS
IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = 'IIS APPPOOL\DefaultAppPool')
BEGIN
    CREATE LOGIN [IIS APPPOOL\DefaultAppPool] 
      FROM WINDOWS WITH DEFAULT_DATABASE=[master], 
      DEFAULT_LANGUAGE=[us_english]
END
GO
CREATE USER [WebDatabaseUser] 
  FOR LOGIN [IIS APPPOOL\DefaultAppPool]
GO
EXEC sp_addrolemember 'db_owner', 'WebDatabaseUser'
GO


----KP : Set Default App Pools & IIS
IF NOT EXISTS (SELECT name FROM sys.server_principals WHERE name = 'IIS APPPOOL\Default Web Site')
BEGIN
    CREATE LOGIN [IIS APPPOOL\Default Web Site] 
      FROM WINDOWS WITH DEFAULT_DATABASE=[master], 
      DEFAULT_LANGUAGE=[us_english]
END
GO
--CREATE USER [WebDatabaseUser] 
ALTER USER [WebDatabaseUser] 
  WITH LOGIN [IIS APPPOOL\Default Web Site]
GO
EXEC sp_addrolemember 'db_owner', 'WebDatabaseUser'
GO
