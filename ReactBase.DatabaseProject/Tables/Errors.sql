CREATE TABLE [dbo].[Errors]
(
	[Id] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Message] NVARCHAR(255) NOT NULL, 
    [Source] NVARCHAR(255) NOT NULL, 
    [StackTrace] NVARCHAR(4000) NULL, 
    [UserId] INT NOT NULL, 
    [CreatedDateTime] DATETIME2 NOT NULL DEFAULT GETDATE(), 
    CONSTRAINT [FK_Errors_ToUsers] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
) 
