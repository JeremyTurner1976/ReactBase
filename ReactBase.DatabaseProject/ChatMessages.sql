CREATE TABLE [dbo].[ChatMessages]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Content] NVARCHAR(4000) NOT NULL, 
    [UserId] INT NOT NULL, 
    [CreatedDateTime] DATETIME2 NOT NULL, 
    [EditedDateTime] DATETIME2 NULL, 
    CONSTRAINT [FK_ChatMessages_ToUsers] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
)
