USE [ENT]
GO
/****** Object:  Table [dbo].[Shop]    Script Date: 07/18/2012 10:33:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shop](
	[Id] [int] NOT NULL,
	[Shop] [nvarchar](100) NULL,
	[Address] [nvarchar](max) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Good]    Script Date: 07/18/2012 10:33:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Good](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Article] [nvarchar](max) NULL,
	[Material] [nvarchar](max) NULL,
	[Color] [nvarchar](max) NULL,
	[Price] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 07/18/2012 10:33:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] NOT NULL,
	[Name] [nchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CashHeading]    Script Date: 07/18/2012 10:33:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CashHeading](
	[Id] [int] NOT NULL,
	[Id_customer] [int] NOT NULL,
	[Id_shop] [int] NOT NULL,
	[Date] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cash]    Script Date: 07/18/2012 10:33:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cash](
	[Id] [int] NOT NULL,
	[Id_good] [int] NOT NULL,
	[Id_cashheading] [int] NOT NULL
) ON [PRIMARY]
GO
