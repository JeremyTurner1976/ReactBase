CREATE PROCEDURE [dbo].[Helpers_CleanTablesAndFillTestData]
AS
BEGIN

	DELETE FROM [dbo].[Users] 
	INSERT INTO [dbo].[Users] (
		[Email], 
		[Password], 
		[DisplayName],
		[CreatedDateTime]
	) values (
	    'Test [Email]',
		'Test [Password]',
		'Test [DisplayName]',
		GETDATE()
	)

	DELETE FROM [dbo].[Errors]
	INSERT INTO [dbo].[Errors] (
		[Message],
		[Source],
		[StackTrace],
		[UserId],
		[CreatedDateTime]
	) values (
	    'Test [Message]',
		'Test [Source]',
		'Test [StackTrace]',
		1,
		GETDATE()
	)

	DELETE FROM [dbo].[ChatMessages] 
	INSERT INTO [dbo].[ChatMessages] (
		[Content], 
		[UserId], 
		[CreatedDateTime], 
		[EditedDateTime] 
	) values (
	    'Test [Content]',
		1,
		GETDATE(),
		NULL
	)

END