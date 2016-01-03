CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Email] NVARCHAR(255) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [DisplayName] NVARCHAR(50) NOT NULL
)
