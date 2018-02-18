USE [ConstructionDB]
GO

/****** Object:  Trigger [cons].[update_users_trigger]    Script Date: 18-02-2018 06:09:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create trigger [cons].[update_users_trigger]
ON [cons].[Users]
FOR UPDATE
AS
BEGIN
	DECLARE @uid INT
	DECLARE @uname varchar(30)
	DECLARE @passwd varchar(30)
	DECLARE @Host varchar(30)
	DECLARE @Action varchar(200)
	
	SELECT @uid=i.uid,@uname=i.uname,@passwd=i.passwd,@Host=i.Host FROM inserted i

	INSERT INTO hist.Users_Audit(uid,uname,passwd,Host,Action) Values(@uid,@uname,@passwd,@Host,'Updated')
END
GO


