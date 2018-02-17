Create table cons.MaterialDealers
(
	mdid int identity(1,1) primary key,
	tmid int foreign key references cons.Typeofmaterial(tmid),
	name varchar(100),
	address varchar(max),
	mobile varchar(15),
)
