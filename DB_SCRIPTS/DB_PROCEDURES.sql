USE UsersAwards
GO


SET ANSI_NULLS ON
GO

CREATE PROCEDURE [AddUser]
	@Name nvarchar(100),
	@Birthday date
AS
BEGIN
	INSERT INTO [dbo].[User]
		([Name]
		,[Birthday])
	VALUES
		(@Name
		,@Birthday)

	SELECT SCOPE_IDENTITY()
END
GO


CREATE PROCEDURE [AddAward]
	@Title nvarchar(50),
	@Description nvarchar(600)
AS
BEGIN
	INSERT INTO [dbo].[Award]
		([Title]
		,[Description])
	VALUES
		(@Title, @Description)

	SELECT SCOPE_IDENTITY()
END
GO


CREATE PROCEDURE [DeleteUser]
	@IDUser int
AS
BEGIN
	DELETE FROM [dbo].[User]
	WHERE [IDUser] = @IDUser

	SELECT SCOPE_IDENTITY()
END
GO


CREATE PROCEDURE [GetUserByID]
	@IDUser int
AS
BEGIN
	SELECT [IDUser]
		,[Name]
		,[Birthday]
	FROM [dbo].[User]
	WHERE [IDUser] = @IDUser
END
GO


SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [GetUserByName]
	@Name nvarchar(100)
AS
BEGIN
	SELECT [IDUser]
	FROM [dbo].[User]
	WHERE [Name] LIKE @Name + '%'
	ORDER BY [Name] ASC
END
GO


CREATE PROCEDURE [UpdateUser]
	@IDUser int,
	@Name nvarchar(100),
	@Birthday date
AS
BEGIN
	UPDATE [dbo].[User]
	SET
	[Name] = @Name,
	[Birthday] = @Birthday
	WHERE [IDUser] = @IDUser
END
GO


CREATE PROCEDURE [GetAllAwards]
AS
BEGIN
	SELECT [IDAward]
		,[Title]
		,[Description]
	FROM [dbo].[Award]
END
GO


CREATE PROCEDURE [GetUserAwards]
	@IDUser int
AS
BEGIN
	SELECT [AWARD].[IDAward]
		,[AWARD].[Title]
		,[AWARD].[Description]
	FROM [dbo].[Award] AS AWARD, [dbo].User_Award AS USER_AWARD
	WHERE [USER_AWARD].IDUser = @IDUser
END
GO


CREATE PROCEDURE [GetAwardByID]
	@IDAward int
AS
BEGIN
	SELECT
		[IDAward]
		,[Title]
		,[Description]
	FROM [dbo].[Award]
	WHERE [dbo].[Award].[IDAward] = @IDAward

	SELECT SCOPE_IDENTITY()
END
GO


CREATE PROCEDURE [UpdateAward]
	@IDAward int,
	@Title nvarchar(50),
	@Description nvarchar(600)
AS
BEGIN
	UPDATE [dbo].Award
	SET
		[Title] = @Title
		,[Description] = @Description
	WHERE [IDAward] = @IDAward
END
GO


CREATE PROCEDURE [DeleteAward]
	@IDAward int
AS
BEGIN
	DELETE FROM [dbo].[Award]
	WHERE [IDAward] = @IDAward

	SELECT SCOPE_IDENTITY()
END
GO


CREATE PROCEDURE [Reward]
	@IDUser int,
	@IDAward int
AS
BEGIN
	INSERT INTO [dbo].User_Award
		([IDUser]
		,[IDAward])
	VALUES
		(@IDUser
		,@IDAward)

	SELECT SCOPE_IDENTITY()
END
GO


-- AND USING JOIN (SUGGESTED)
CREATE PROCEDURE [dbo].[GetUserJoinAwards]
	@IDUser int
AS
BEGIN
	--Extract Username and Award title
	SELECT 
		[Name]
		,[Title]
	FROM [dbo].[User_Award] AS UA
	JOIN [Award] ON UA.IDAward = [Award].[IDAward],
	[dbo].[User]
	WHERE UA.[IDUser] = @IDUser
END
GO
