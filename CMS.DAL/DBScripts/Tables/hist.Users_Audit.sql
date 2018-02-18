USE [ConstructionDB]
GO

/****** Object:  Table [hist].[Users_Audit]    Script Date: 18-02-2018 06:10:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [hist].[Users_Audit](
	[uid] [int] NULL,
	[uname] [varchar](30) NULL,
	[passwd] [varchar](30) NULL,
	[Host] [varchar](30) NULL,
	[Action] [varchar](200) NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [hist].[Users_Audit]  WITH CHECK ADD FOREIGN KEY([uid])
REFERENCES [cons].[Users] ([uid])
GO


