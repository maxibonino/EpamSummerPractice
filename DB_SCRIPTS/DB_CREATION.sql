USE master
GO


--DECLARE @DATABASE_NAME varchar(300);
--SET @DATABASE_NAME = 'UsersAwards';
--GO

IF EXISTS(SELECT * FROM sys.databases WHERE name='UsersAwards')
BEGIN
	DROP DATABASE UsersAwards
END
GO


CREATE DATABASE UsersAwards
GO


USE UsersAwards
GO


CREATE TABLE [User] (
	[IDUser] int NOT NULL IDENTITY(1, 1) CONSTRAINT [PK_User] PRIMARY KEY,
	[Name] nvarchar(100) NOT NULL,
	[Birthday] date NOT NULL,
	[UserPhoto] varbinary(MAX),
)
GO


CREATE TABLE [Award] (
	[IDAward] int NOT NULL IDENTITY(1, 1) CONSTRAINT [PK_Award] PRIMARY KEY,
	[Title] nvarchar(50) NOT NULL,
	[Description] nvarchar(600),
	[AwardImage] varbinary(MAX),
)
GO


CREATE TABLE [User_Award] (
	[ID] int NOT NULL IDENTITY(1, 1) CONSTRAINT [PK_User_Award] PRIMARY KEY,
	[IDUser] int NOT NULL,
	[IDAward] int NOT NULL,
)
GO

ALTER TABLE [User_Award] ADD CONSTRAINT [FK_User_Award_ON_User]
FOREIGN KEY ([IDUser]) REFERENCES [User](IDUser)
ON DELETE CASCADE
ON UPDATE CASCADE
GO

ALTER TABLE [User_Award] ADD CONSTRAINT [FK_User_Award_ON_Award]
FOREIGN KEY ([IDAward]) REFERENCES [Award]([IDAward])
ON DELETE CASCADE
ON UPDATE CASCADE
GO
