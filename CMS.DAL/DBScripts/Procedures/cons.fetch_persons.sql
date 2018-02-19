USE [ConstructionDB]
GO

/****** Object:  StoredProcedure [cons].[fetch_persons]    Script Date: 19-02-2018 16:43:41 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create procedure [cons].[fetch_persons]
As
BEGIN
	select * from [cons].[Req_Persons]
END
GO


