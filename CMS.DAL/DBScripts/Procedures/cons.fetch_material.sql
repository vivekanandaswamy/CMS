USE [ConstructionDB]
GO

/****** Object:  StoredProcedure [cons].[fetch_material]    Script Date: 18-02-2018 23:04:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


  CREATE PROCEDURE [cons].[fetch_material]
  AS
  BEGIN
	SELECT *  FROM [ConstructionDB].[cons].[Material]
  END
GO


