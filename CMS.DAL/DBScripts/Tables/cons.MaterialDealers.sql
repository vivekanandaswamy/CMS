USE [ConstructionDB]
GO

/****** Object:  Table [cons].[MaterialDealers]    Script Date: 18-02-2018 15:33:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [cons].[MaterialDealers](
	[mdid] [int] IDENTITY(1,1) NOT NULL,
	[tmid] [int] NULL,
	[name] [varchar](100) NULL,
	[address] [varchar](max) NULL,
	[mobile] [varchar](15) NULL,
	[comments] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[mdid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [cons].[MaterialDealers]  WITH CHECK ADD FOREIGN KEY([tmid])
REFERENCES [cons].[Typeofmaterial] ([tmid])
GO


