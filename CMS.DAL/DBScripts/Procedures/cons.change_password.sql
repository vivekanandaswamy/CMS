CREATE PROCEDURE cons.change_password
(
	@username varchar(30),
	@oldpasswd varchar(30),
	@newpasswd varchar(30),
	@conpasswd varchar(30)
)
AS
BEGIN
	IF EXISTS(SELECT 1 FROM [ConstructionDB].[cons].[Users] WHERE uname=@username AND passwd=@oldpasswd)
		UPDATE [ConstructionDB].[cons].[Users] SET passwd=@newpasswd,conpasswd=@conpasswd,UpdatedOn=GETDATE() WHERE uname=@username
		
END