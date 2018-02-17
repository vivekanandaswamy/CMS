CREATE PROCEDURE cons.forgot_password
(
	@username varchar(30)
)
AS
BEGIN
	SELECT passwd FROM [ConstructionDB].[cons].[Users] WHERE uname=@username
END