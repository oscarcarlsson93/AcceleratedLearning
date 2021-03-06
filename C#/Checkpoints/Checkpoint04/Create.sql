USE [master]
GO
/****** Object:  Database [Churches]    Script Date: 2018-12-21 10:25:18 ******/
CREATE DATABASE [Churches]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Churches', FILENAME = N'C:\Users\Administrator\Churches.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Churches_log', FILENAME = N'C:\Users\Administrator\Churches_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Churches] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Churches].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Churches] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Churches] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Churches] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Churches] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Churches] SET ARITHABORT OFF 
GO
ALTER DATABASE [Churches] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Churches] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Churches] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Churches] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Churches] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Churches] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Churches] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Churches] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Churches] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Churches] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Churches] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Churches] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Churches] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Churches] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Churches] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Churches] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Churches] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Churches] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Churches] SET  MULTI_USER 
GO
ALTER DATABASE [Churches] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Churches] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Churches] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Churches] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Churches] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Churches] SET QUERY_STORE = OFF
GO
USE [Churches]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Churches]
GO
/****** Object:  Table [dbo].[Church]    Script Date: 2018-12-21 10:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Church](
	[ChurchId] [int] IDENTITY(1,1) NOT NULL,
	[LocationId] [int] NULL,
	[YearBuiltId] [int] NULL,
	[ChurchNameId] [int] NULL,
 CONSTRAINT [PK_Church] PRIMARY KEY CLUSTERED 
(
	[ChurchId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChurchName]    Script Date: 2018-12-21 10:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChurchName](
	[ChurchNameId] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_ChurchName] PRIMARY KEY CLUSTERED 
(
	[ChurchNameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 2018-12-21 10:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocationId] [int] IDENTITY(1,1) NOT NULL,
	[LocationName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 2018-12-21 10:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonId] [int] NOT NULL,
	[PersonName] [nvarchar](50) NULL,
	[LocationId] [int] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonLike]    Script Date: 2018-12-21 10:25:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonLike](
	[PersonLikeId] [int] NOT NULL,
	[PersonId] [int] NULL,
	[Church] [int] NULL,
	[ChurchName] [int] NULL,
 CONSTRAINT [PK_PersonLike] PRIMARY KEY CLUSTERED 
(
	[PersonLikeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Church] ON 

INSERT [dbo].[Church] ([ChurchId], [LocationId], [YearBuiltId], [ChurchNameId]) VALUES (1, 1, 1893, 1)
INSERT [dbo].[Church] ([ChurchId], [LocationId], [YearBuiltId], [ChurchNameId]) VALUES (2, 1, 1914, 2)
INSERT [dbo].[Church] ([ChurchId], [LocationId], [YearBuiltId], [ChurchNameId]) VALUES (3, 2, 1890, 3)
INSERT [dbo].[Church] ([ChurchId], [LocationId], [YearBuiltId], [ChurchNameId]) VALUES (4, 3, 1892, 4)
SET IDENTITY_INSERT [dbo].[Church] OFF
INSERT [dbo].[ChurchName] ([ChurchNameId], [Name]) VALUES (1, N'Oscar-Fredriks Church')
INSERT [dbo].[ChurchName] ([ChurchNameId], [Name]) VALUES (2, N'Masthuggs Church')
INSERT [dbo].[ChurchName] ([ChurchNameId], [Name]) VALUES (3, N'Sankt Georgios Church')
INSERT [dbo].[ChurchName] ([ChurchNameId], [Name]) VALUES (4, N'Mattues Church')
SET IDENTITY_INSERT [dbo].[Location] ON 

INSERT [dbo].[Location] ([LocationId], [LocationName]) VALUES (1, N'Göteborg')
INSERT [dbo].[Location] ([LocationId], [LocationName]) VALUES (2, N'Stockholm')
INSERT [dbo].[Location] ([LocationId], [LocationName]) VALUES (3, N'Norrköping')
SET IDENTITY_INSERT [dbo].[Location] OFF
INSERT [dbo].[Person] ([PersonId], [PersonName], [LocationId]) VALUES (1, N'Linnea', 1)
INSERT [dbo].[Person] ([PersonId], [PersonName], [LocationId]) VALUES (2, N'Harry', 2)
INSERT [dbo].[PersonLike] ([PersonLikeId], [PersonId], [Church], [ChurchName]) VALUES (1, 1, 1, NULL)
INSERT [dbo].[PersonLike] ([PersonLikeId], [PersonId], [Church], [ChurchName]) VALUES (2, 1, 4, NULL)
INSERT [dbo].[PersonLike] ([PersonLikeId], [PersonId], [Church], [ChurchName]) VALUES (3, 2, 4, NULL)
ALTER TABLE [dbo].[Church]  WITH CHECK ADD  CONSTRAINT [FK_Church_ChurchName] FOREIGN KEY([ChurchNameId])
REFERENCES [dbo].[ChurchName] ([ChurchNameId])
GO
ALTER TABLE [dbo].[Church] CHECK CONSTRAINT [FK_Church_ChurchName]
GO
ALTER TABLE [dbo].[Church]  WITH CHECK ADD  CONSTRAINT [FK_Church_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([LocationId])
GO
ALTER TABLE [dbo].[Church] CHECK CONSTRAINT [FK_Church_Location]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([LocationId])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person_Location]
GO
ALTER TABLE [dbo].[PersonLike]  WITH CHECK ADD  CONSTRAINT [FK_PersonLike_Church] FOREIGN KEY([Church])
REFERENCES [dbo].[Church] ([ChurchId])
GO
ALTER TABLE [dbo].[PersonLike] CHECK CONSTRAINT [FK_PersonLike_Church]
GO
ALTER TABLE [dbo].[PersonLike]  WITH CHECK ADD  CONSTRAINT [FK_PersonLike_ChurchName] FOREIGN KEY([ChurchName])
REFERENCES [dbo].[ChurchName] ([ChurchNameId])
GO
ALTER TABLE [dbo].[PersonLike] CHECK CONSTRAINT [FK_PersonLike_ChurchName]
GO
ALTER TABLE [dbo].[PersonLike]  WITH CHECK ADD  CONSTRAINT [FK_PersonLike_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([PersonId])
GO
ALTER TABLE [dbo].[PersonLike] CHECK CONSTRAINT [FK_PersonLike_Person]
GO
USE [master]
GO
ALTER DATABASE [Churches] SET  READ_WRITE 
GO
