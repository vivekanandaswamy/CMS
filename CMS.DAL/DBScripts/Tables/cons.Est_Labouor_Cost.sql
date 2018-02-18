USE [ConstructionDB]
GO

/****** Object:  Table [cons].[Est_Labouor_Cost]    Script Date: 18-02-2018 22:17:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [cons].[Est_Labouor_Cost](
	[lcid] [int] IDENTITY(1,1) NOT NULL,
	[rpid] [int] NULL,
	[pid] [int] NULL,
	[description] [varchar](max) NULL,
	[qty] [int] NULL,
	[price] [int] NULL,
	[dateofenquiry] int NULL,
	[comments] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[lcid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [cons].[Est_Labouor_Cost]  WITH CHECK ADD FOREIGN KEY([rpid])
REFERENCES [cons].[Req_Persons] ([rpid])
GO

ALTER TABLE [cons].[Est_Labouor_Cost]  WITH CHECK ADD FOREIGN KEY([pid])
REFERENCES [cons].[Persons_Details] ([pid])
GO


