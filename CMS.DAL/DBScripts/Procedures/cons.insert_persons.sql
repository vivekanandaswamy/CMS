USE [ConstructionDB]
GO

/****** Object:  StoredProcedure [cons].[insert_persons]    Script Date: 19-02-2018 15:25:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [cons].[insert_persons]
(
	@pname varchar(30),
	@comments varchar(max)
)
AS
BEGIN
		INSERT INTO cons.Req_Persons(name,comments) VALUES(@pname,@comments)
END
GO


