USE [ConstructionDB]
GO

/****** Object:  Table [cons].[Typeofmaterial]    Script Date: 18-02-2018 15:33:45 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [cons].[Typeofmaterial](
	[tmid] [int] IDENTITY(1,1) NOT NULL,
	[mid] [int] NULL,
	[tmname] [varchar](max) NULL,
	[comments] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[tmid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [cons].[Typeofmaterial]  WITH CHECK ADD FOREIGN KEY([mid])
REFERENCES [cons].[Material] ([mid])
GO


