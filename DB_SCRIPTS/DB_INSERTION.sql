-- INSERTION TO TEST
USE UsersAwards
GO

SET DATEFORMAT dmy;  
GO

------------------------------------------------
-------------------USERS------------------------
------------------------------------------------
INSERT INTO [dbo].[User]
	([Name]
	,[Birthday])
VALUES
	(N'Василий'
	,CONVERT(date, '16.07.2018', 104))


INSERT INTO [dbo].[User]
	([Name]
	,[Birthday])
VALUES
	(N'Иван'
	,CONVERT(date, '16.07.1993', 104))


INSERT INTO [dbo].[User]
	([Name]
	,[Birthday])
VALUES
	(N'Кирилл'
	,CONVERT(date, '08.11.1989', 104))


INSERT INTO [dbo].[User]
	([Name]
	,[Birthday])
VALUES
	(N'Виктор'
	,CONVERT(date, '06.09.1983', 104))


------------------------------------------------
-------------------AWARDS-----------------------
------------------------------------------------
INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'Активный участник'
	,N'Награда предоставляется тем, кто принимает активное участие в жизни форума.')


INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'Болтунус'
	,N'Самый общительный пользователь.')


INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'Меценат 1ур.'
	,N'Внёс пожертвование до 1000 рублей.')


INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'Меценат 2ур.'
	,N'Внёс пожертвование до 2000 рублей.')


INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'Мёртвая душа'
	,N'Не пользовался услугами нашего поратала более, чем 33 дня.')


INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'Заядлый геймер'
	,N'Награда присуждается тому, кто набирает более 3000 сообщений в игровом разделе.')


------------------------------------------------
------------LINKING USERS AND AWARDS------------
------------------------------------------------

--//Kirill has 3, 4, 6 awards!
INSERT INTO [dbo].[User_Award]
	([IDUser]
	,[IDAward])
VALUES
	(3, 3)


INSERT INTO [dbo].[User_Award]
	([IDUser]
	,[IDAward])
VALUES
	(3, 4)


INSERT INTO [dbo].[User_Award]
	([IDUser]
	,[IDAward])
VALUES
	(3, 6)