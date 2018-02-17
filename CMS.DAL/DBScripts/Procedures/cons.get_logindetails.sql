CREATE PROCEDURE cons.get_logindetails
  (
		@username varchar(30),
		@password varchar(30)
  )
  AS
  BEGIN
		SELECT * FROM [ConstructionDB].[cons].[Users] WHERE uname=@username AND passwd=@password
  END