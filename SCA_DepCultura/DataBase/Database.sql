USE [SCA_DepCultura]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 09/07/2017 9:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Permission](
	[idPermission] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[idPermission] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 09/07/2017 9:36:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](30) NOT NULL,
	[password] [varchar](30) NOT NULL,
	[permission] [int] NOT NULL,
	[HigthDate] [datetime] NOT NULL,
	[name] [varchar](30) NOT NULL DEFAULT (''),
	[secondName] [varchar](30) NOT NULL DEFAULT (''),
	[surname] [varchar](30) NULL DEFAULT (''),
	[secondSurname] [varchar](30) NULL DEFAULT (''),
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_User_Permission] FOREIGN KEY([permission])
REFERENCES [dbo].[Permission] ([idPermission])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_User_Permission]
GO
