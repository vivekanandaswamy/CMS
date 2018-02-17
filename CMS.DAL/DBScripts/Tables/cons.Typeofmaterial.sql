Create table cons.Typeofmaterial
(
	tmid int identity(1,1) primary key,
	mid int foreign key references cons.material(mid),
	tmname varchar(max),
	quantity int,
	units int,
	approxcost money
)
