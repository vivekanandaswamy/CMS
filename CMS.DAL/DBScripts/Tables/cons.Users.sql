Create table cons.Users
(
	uid int identity(1,1) primary key,
	fname varchar(30),
	lname varchar(30),
	uname varchar(20),
	passwd varchar(30),
	conpasswd varchar(30)
)


