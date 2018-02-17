USE [ConstructionDB]
GO

/****** Object:  Table [cons].[Users]    Script Date: 17-02-2018 09:42:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [cons].[Users](
	[uid] [int] IDENTITY(1,1) NOT NULL,
	[fname] [varchar](30) NOT NULL,
	[lname] [varchar](30) NOT NULL,
	[uname] [varchar](20) NOT NULL,
	[passwd] [varchar](30) NOT NULL,
	[conpasswd] [varchar](30) NOT NULL,
	[DateOfRegistration] [Date] NOT NULL
PRIMARY KEY CLUSTERED 
(
	[uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


