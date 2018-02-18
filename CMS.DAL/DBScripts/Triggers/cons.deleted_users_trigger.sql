USE [ConstructionDB]
GO

/****** Object:  Trigger [cons].[deleted_users_trigger]    Script Date: 18-02-2018 06:08:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create trigger [cons].[deleted_users_trigger]
ON [cons].[Users]
FOR DELETE
AS
BEGIN
	DECLARE @uid INT
	DECLARE @uname varchar(30)
	DECLARE @passwd varchar(30)
	DECLARE @Host varchar(30)
	DECLARE @Action varchar(200)
	
	SELECT @uid=d.uid,@uname=d.uname,@passwd=d.passwd,@Host=d.Host FROM deleted d

	INSERT INTO hist.Users_Audit(uid,uname,passwd,Host,Action) Values(@uid,@uname,@passwd,@Host,'Deleted')
END
GO


