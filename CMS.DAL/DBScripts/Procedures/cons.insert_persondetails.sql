USE [ConstructionDB]
GO

/****** Object:  StoredProcedure [cons].[insert_persondetails]    Script Date: 19-02-2018 16:29:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [cons].[insert_persondetails]
(
	@pname varchar(30),
	@paddress varchar(max),
	@rpid int,
	@mob1 varchar(15),
	@mob2 varchar(15),
	@mail varchar(300),
	@pcomments varchar(max)
)
AS
begin
	Insert into Persons_Details
	(name,address,rpid,mobile1,mobile2,email,comments)
	values
	(@pname,@paddress,@rpid,@mob1,@mob2,@mail,@pcomments)
end
GO


