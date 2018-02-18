Create table cons.Est_Labouor_Cost
(
	elcid int identity(1,1) primary key,
	rpid int foreign key references cons.Req_Persons(rpid),
	pid int foreign key references cons.Persons_Details(pid),
	description varchar(max),
	qty int,
	price int,
	comments varchar(max)
)
