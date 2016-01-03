CREATE PROCEDURE [dbo].[Helper_GetDatabaseTableNames]
AS
SELECT TABLE_NAME FROM [information_schema].[tables]

