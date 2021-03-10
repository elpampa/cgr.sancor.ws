use [Master]

-- Ensuring that Service Broker is enabled - replace the Database with the desired Database name
ALTER DATABASE [Database] SET ENABLE_BROKER
GO 

-- Switching to our database - replace the Database with the desired Database name
use [Database]

IF EXISTS(SELECT 1 FROM sys.schemas WHERE NAME='domain\login')
BEGIN
DROP SCHEMA [domain\login]     
END
GO

CREATE SCHEMA [domain\login]
GO
 
IF NOT EXISTS(SELECT 1 FROM sys.syslogins WHERE NAME='domain\login')
BEGIN
  CREATE USER [domain\login] FOR LOGIN [domain\login] 
  WITH DEFAULT_SCHEMA = [domain\login]
END;
GO

ALTER USER [domain\login] 
WITH DEFAULT_SCHEMA = [domain\login]
GO 

ALTER AUTHORIZATION ON SCHEMA::[domain\login] TO [domain\login]
GO


IF NOT EXISTS(SELECT 1 FROM sys.database_principals WHERE NAME='sql_dependency_subscriber' AND type ='R')
BEGIN
CREATE ROLE sql_dependency_subscriber AUTHORIZATION [domain\login]
END
GO

ALTER AUTHORIZATION ON ROLE::[sql_dependency_subscriber] TO [domain\login]
GO

-- Permissions needed for [sql_dependency_subscriber]
GRANT CREATE PROCEDURE to [sql_dependency_subscriber] 
GRANT CREATE QUEUE to [sql_dependency_subscriber]
GRANT CREATE SERVICE to [sql_dependency_subscriber]
GRANT REFERENCES on 
CONTRACT::[http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]
  to [sql_dependency_subscriber] 
GRANT VIEW DEFINITION TO [sql_dependency_subscriber] 

-- Permissions needed for [sql_dependency_subscriber] 
GRANT SELECT to [sql_dependency_subscriber] 
GRANT SUBSCRIBE QUERY NOTIFICATIONS TO [sql_dependency_subscriber] 
GRANT RECEIVE ON QueryNotificationErrorsQueue TO [sql_dependency_subscriber] 
GRANT REFERENCES on 
CONTRACT::[http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]
  to [sql_dependency_subscriber] 

-- Making sure that my users are member of the correct role.
EXEC sp_addrolemember 'sql_dependency_subscriber', 'domain\login'