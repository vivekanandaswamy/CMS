USE [ConstructionDB]
GO

/****** Object:  Table [cons].[Req_Persons]    Script Date: 18-02-2018 15:34:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [cons].[Req_Persons](
	[rpid] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](30) NULL,
	[comments] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[rpid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


