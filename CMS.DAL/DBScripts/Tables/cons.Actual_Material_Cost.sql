Create table cons.Actual_Material_Cost
(
	emcid int identity(1,1) primary key,
	mid int foreign key references cons.Material(mid),
	mdid int  foreign key references cons.MaterialDealers(mdid),
	tmid int  foreign key references cons.Typeofmaterial(tmid),
	description varchar(max),
	qty int,
	price int,
	comments varchar(max)
)