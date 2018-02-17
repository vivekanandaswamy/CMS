CREATE PROCEDURE cons.insert_user
(
	@fname varchar(30),
	@lname varchar(30),
	@uname varchar(30),
	@passwd varchar(30),
	@conpasswd varchar(30),
	@dor date,
	@host varchar(30)
)
AS
BEGIN
	INSERT INTO cons.Users(fname,lname,uname,passwd,conpasswd,DateOfRegistration,Host,CreatedOn)
	VALUES (@fname,@lname,@uname,@passwd,@conpasswd,@dor,@host,GETDATE())		
END