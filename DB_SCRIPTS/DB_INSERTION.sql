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
	(N'�������'
	,CONVERT(date, '16.07.2018', 104))


INSERT INTO [dbo].[User]
	([Name]
	,[Birthday])
VALUES
	(N'����'
	,CONVERT(date, '16.07.1993', 104))


INSERT INTO [dbo].[User]
	([Name]
	,[Birthday])
VALUES
	(N'������'
	,CONVERT(date, '08.11.1989', 104))


INSERT INTO [dbo].[User]
	([Name]
	,[Birthday])
VALUES
	(N'������'
	,CONVERT(date, '06.09.1983', 104))


------------------------------------------------
-------------------AWARDS-----------------------
------------------------------------------------
INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'�������� ��������'
	,N'������� ��������������� ���, ��� ��������� �������� ������� � ����� ������.')


INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'��������'
	,N'����� ����������� ������������.')


INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'������� 1��.'
	,N'��� ������������� �� 1000 ������.')


INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'������� 2��.'
	,N'��� ������������� �� 2000 ������.')


INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'̸����� ����'
	,N'�� ����������� �������� ������ �������� �����, ��� 33 ���.')


INSERT INTO [dbo].[Award]
	([Title]
	,[Description])
VALUES
	(N'������� ������'
	,N'������� ������������ ����, ��� �������� ����� 3000 ��������� � ������� �������.')


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