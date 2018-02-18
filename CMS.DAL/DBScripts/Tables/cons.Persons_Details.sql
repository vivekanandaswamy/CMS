Create table cons.Persons_Details
(
	pid int identity(1,1) primary key,
	name varchar(200),
	address varchar(max),
	rpid int foreign key references cons.Req_Persons(rpid),
	mobile1 varchar(15),
	mobile2 varchar(15),
	email varchar(300),
	comments varchar(max)
)