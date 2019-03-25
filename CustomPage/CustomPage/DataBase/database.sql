USE [master]
GO

CREATE DATABASE [CustomPage2019]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_CUSTOMPAGE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DB_CUSTOMPAGE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_CUSTOMPAGE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\DB_CUSTOMPAGE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CustomPage2019] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CustomPage2019].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CustomPage2019] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CustomPage2019] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CustomPage2019] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CustomPage2019] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CustomPage2019] SET ARITHABORT OFF 
GO
ALTER DATABASE [CustomPage2019] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CustomPage2019] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CustomPage2019] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CustomPage2019] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CustomPage2019] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CustomPage2019] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CustomPage2019] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CustomPage2019] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CustomPage2019] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CustomPage2019] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CustomPage2019] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CustomPage2019] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CustomPage2019] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CustomPage2019] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CustomPage2019] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CustomPage2019] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CustomPage2019] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CustomPage2019] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CustomPage2019] SET  MULTI_USER 
GO
ALTER DATABASE [CustomPage2019] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CustomPage2019] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CustomPage2019] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CustomPage2019] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CustomPage2019] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CustomPage2019] SET QUERY_STORE = OFF
GO
USE [CustomPage2019]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [CustomPage2019]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coffee](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Coffee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Lastname] [nvarchar](50) NOT NULL,
	[Comment] [nvarchar](400) NOT NULL,
	[Email] [nvarchar](400) NOT NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Coffee] ON 
GO
INSERT [dbo].[Coffee] ([Id], [Name], [Description]) VALUES (1, N'Espresso (Short Black)', N'The espresso (aka “short black”) is the foundation and the most important part to every espresso based drink. So much so that we’ve written a guide on how to make the perfect espresso shot. But for the purposes of this post an espresso consists of: 1 Shot of espresso in an espresso cup.')
GO
INSERT [dbo].[Coffee] ([Id], [Name], [Description]) VALUES (2, N'Double Espresso (Doppio)', N'A double espresso (aka “Doppio”) is just that, two espresso shots in one cup. Therefore a double espresso consists of: 2 shots of espresso in an espresso cup.')
GO
INSERT [dbo].[Coffee] ([Id], [Name], [Description]) VALUES (3, N'Short Macchiato', N'A short macchiato is similar to an espresso but with a dollop of steamed milk and foam to mellow the harsh taste of an espresso. You will find that baristas in different countries make short macchiatos differently. However the traditional way of making a short macchiato is as follows: 1 Shot of espresso in a short glass or espresso cup and a dollop of steamed milk and foam placed on top of the espresso.')
GO
INSERT [dbo].[Coffee] ([Id], [Name], [Description]) VALUES (4, N'Long Macchiato', N'A long macchiato is the same as a short macchiato but with a double shot of espresso. The same rule of thirds applies in the traditionally made long macchiato: 2 shots of espresso in a tumbler glass or cup and a dollop of steamed milk and foam placed on top of the espresso.')
GO
INSERT [dbo].[Coffee] ([Id], [Name], [Description]) VALUES (5, N'Ristretto', N'A ristretto is an espresso shot that is extracted with the same amount of coffee but half the amount of water. The end result is a more concentrated and darker espresso extraction. It is made as follows: Extract a standard espresso shot with half the amount of water, alternatively turn off a normal espresso extraction before the espresso starts to blonde')
GO
INSERT [dbo].[Coffee] ([Id], [Name], [Description]) VALUES (6, N'Long Black (Americano)', N'A long black (aka “americano”) is hot water with an espresso shot extracted on top of the hot water. It is made as follows:  Fill a cup with 2/3rds full of hot water, extract 1 shot of espresso over the hot water')
GO
SET IDENTITY_INSERT [dbo].[Coffee] OFF
GO
USE [master]
GO
ALTER DATABASE [CustomPage2019] SET  READ_WRITE 
GO
