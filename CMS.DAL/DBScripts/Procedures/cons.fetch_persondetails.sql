USE [ConstructionDB]
GO

/****** Object:  StoredProcedure [cons].[fetch_persondetails]    Script Date: 19-02-2018 19:55:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

 Create procedure [cons].[fetch_persondetails]
 AS
 begin
  Select 
  pd.pid as "Id"
  ,pd.name as "Name"
  ,rp.name as "Profession" 
  ,pd.address as "Address"
  ,pd.mobile1 as "Mobile-1"
  ,pd.mobile2 as "Mobile-2"
  ,pd.email as "Email"
  ,pd.comments as "Comments"
  from cons.req_persons rp
  Inner join [cons].[Persons_Details] pd on pd.rpid=rp.rpid
  end

GO


