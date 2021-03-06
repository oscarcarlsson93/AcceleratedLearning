USE [master]
GO
/****** Object:  Database [Car Rental Supreme]    Script Date: 2018-12-20 16:36:53 ******/
CREATE DATABASE [Car Rental Supreme]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Car Rental Supreme', FILENAME = N'C:\Users\Administrator\Car Rental Supreme.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Car Rental Supreme_log', FILENAME = N'C:\Users\Administrator\Car Rental Supreme_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Car Rental Supreme] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Car Rental Supreme].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Car Rental Supreme] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET ARITHABORT OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Car Rental Supreme] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Car Rental Supreme] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Car Rental Supreme] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Car Rental Supreme] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Car Rental Supreme] SET  MULTI_USER 
GO
ALTER DATABASE [Car Rental Supreme] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Car Rental Supreme] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Car Rental Supreme] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Car Rental Supreme] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Car Rental Supreme] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Car Rental Supreme] SET QUERY_STORE = OFF
GO
USE [Car Rental Supreme]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Car Rental Supreme]
GO
/****** Object:  Table [dbo].[Adress]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adress](
	[AdressId] [int] NOT NULL,
	[Adress] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Adress] PRIMARY KEY CLUSTERED 
(
	[AdressId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingTable]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingTable](
	[BookingId] [int] NOT NULL,
	[BookingStart] [datetime] NULL,
	[CarId] [int] NOT NULL,
	[CustomerId] [int] NOT NULL,
	[PaymentMethod] [int] NOT NULL,
	[DriverId] [int] NOT NULL,
	[BookingEnd] [datetime] NULL,
	[LocationId] [int] NULL,
 CONSTRAINT [PK_BookingTable] PRIMARY KEY CLUSTERED 
(
	[BookingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[CarId] [int] IDENTITY(1,1) NOT NULL,
	[CarColorId] [int] NOT NULL,
	[CarTypeId] [int] NOT NULL,
	[CarBrandId] [int] NOT NULL,
	[Office] [int] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[CarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarBrand]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarBrand](
	[CarBrandId] [int] NOT NULL,
	[Brand] [nvarchar](50) NULL,
 CONSTRAINT [PK_CarBrand] PRIMARY KEY CLUSTERED 
(
	[CarBrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarColor]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarColor](
	[CarColorId] [int] NOT NULL,
	[Color] [nvarchar](50) NULL,
 CONSTRAINT [PK_CarColor] PRIMARY KEY CLUSTERED 
(
	[CarColorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarType]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarType](
	[CarTypeId] [int] NOT NULL,
	[Type] [nvarchar](50) NULL,
	[CarPrice] [decimal](3, 2) NULL,
 CONSTRAINT [PK_CarType] PRIMARY KEY CLUSTERED 
(
	[CarTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[DiscountLevel] [int] NULL,
	[PersonInfo] [int] NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Discount]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Discount](
	[DiscountId] [int] NOT NULL,
	[DiscountPercent] [decimal](3, 2) NULL,
	[DiscountLevel] [nvarchar](50) NULL,
 CONSTRAINT [PK_Discount] PRIMARY KEY CLUSTERED 
(
	[DiscountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Driver]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Driver](
	[DriverId] [int] IDENTITY(1,1) NOT NULL,
	[PersonInfo] [int] NOT NULL,
 CONSTRAINT [PK_Driver] PRIMARY KEY CLUSTERED 
(
	[DriverId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocationId] [int] NOT NULL,
	[City] [nvarchar](50) NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Office]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Office](
	[OfficeId] [int] NOT NULL,
	[LocationId] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Region] [int] NULL,
 CONSTRAINT [PK_Office] PRIMARY KEY CLUSTERED 
(
	[OfficeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parking]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parking](
	[ParkingSpotId] [int] IDENTITY(1,1) NOT NULL,
	[ParkingSize] [bit] NULL,
	[CarId] [int] NULL,
 CONSTRAINT [Unique_CarId] PRIMARY KEY CLUSTERED 
(
	[ParkingSpotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethod]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethod](
	[PaymentMethodId] [int] IDENTITY(1,1) NOT NULL,
	[Method] [nvarchar](50) NULL,
	[BillingAdress] [int] NULL,
 CONSTRAINT [PK_PaymentMethod] PRIMARY KEY CLUSTERED 
(
	[PaymentMethodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonInfo]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonInfo](
	[PersonInfoId] [int] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nchar](10) NULL,
	[PersonalNumber] [int] NULL,
	[Adress] [int] NOT NULL,
 CONSTRAINT [PK_PersonInfo] PRIMARY KEY CLUSTERED 
(
	[PersonInfoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Region]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Region](
	[RegionId] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Region] PRIMARY KEY CLUSTERED 
(
	[RegionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SharedCars]    Script Date: 2018-12-20 16:36:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SharedCars](
	[CarId] [int] NOT NULL,
	[OfficeId] [int] NOT NULL,
 CONSTRAINT [PK_SharedCars] PRIMARY KEY CLUSTERED 
(
	[CarId] ASC,
	[OfficeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BookingTable]  WITH CHECK ADD  CONSTRAINT [FK_BookingTable_Car] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([CarId])
GO
ALTER TABLE [dbo].[BookingTable] CHECK CONSTRAINT [FK_BookingTable_Car]
GO
ALTER TABLE [dbo].[BookingTable]  WITH CHECK ADD  CONSTRAINT [FK_BookingTable_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([CustomerId])
GO
ALTER TABLE [dbo].[BookingTable] CHECK CONSTRAINT [FK_BookingTable_Customer]
GO
ALTER TABLE [dbo].[BookingTable]  WITH CHECK ADD  CONSTRAINT [FK_BookingTable_Driver] FOREIGN KEY([DriverId])
REFERENCES [dbo].[Driver] ([DriverId])
GO
ALTER TABLE [dbo].[BookingTable] CHECK CONSTRAINT [FK_BookingTable_Driver]
GO
ALTER TABLE [dbo].[BookingTable]  WITH CHECK ADD  CONSTRAINT [FK_BookingTable_PaymentMethod1] FOREIGN KEY([PaymentMethod])
REFERENCES [dbo].[PaymentMethod] ([PaymentMethodId])
GO
ALTER TABLE [dbo].[BookingTable] CHECK CONSTRAINT [FK_BookingTable_PaymentMethod1]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_CarBrand] FOREIGN KEY([CarTypeId])
REFERENCES [dbo].[CarBrand] ([CarBrandId])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_CarBrand]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_CarColor] FOREIGN KEY([CarColorId])
REFERENCES [dbo].[CarColor] ([CarColorId])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_CarColor]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_CarType1] FOREIGN KEY([CarBrandId])
REFERENCES [dbo].[CarType] ([CarTypeId])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_CarType1]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Discount1] FOREIGN KEY([DiscountLevel])
REFERENCES [dbo].[Discount] ([DiscountId])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_Discount1]
GO
ALTER TABLE [dbo].[Customer]  WITH CHECK ADD  CONSTRAINT [FK_Customer_PersonInfo] FOREIGN KEY([PersonInfo])
REFERENCES [dbo].[PersonInfo] ([PersonInfoId])
GO
ALTER TABLE [dbo].[Customer] CHECK CONSTRAINT [FK_Customer_PersonInfo]
GO
ALTER TABLE [dbo].[Driver]  WITH CHECK ADD  CONSTRAINT [FK_Driver_PersonInfo] FOREIGN KEY([PersonInfo])
REFERENCES [dbo].[PersonInfo] ([PersonInfoId])
GO
ALTER TABLE [dbo].[Driver] CHECK CONSTRAINT [FK_Driver_PersonInfo]
GO
ALTER TABLE [dbo].[Office]  WITH CHECK ADD  CONSTRAINT [FK_Office_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([LocationId])
GO
ALTER TABLE [dbo].[Office] CHECK CONSTRAINT [FK_Office_Location]
GO
ALTER TABLE [dbo].[Office]  WITH CHECK ADD  CONSTRAINT [FK_Office_Region] FOREIGN KEY([Region])
REFERENCES [dbo].[Region] ([RegionId])
GO
ALTER TABLE [dbo].[Office] CHECK CONSTRAINT [FK_Office_Region]
GO
ALTER TABLE [dbo].[Parking]  WITH CHECK ADD  CONSTRAINT [FK_Parking_Car] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([CarId])
GO
ALTER TABLE [dbo].[Parking] CHECK CONSTRAINT [FK_Parking_Car]
GO
ALTER TABLE [dbo].[PaymentMethod]  WITH CHECK ADD  CONSTRAINT [FK_PaymentMethod_Adress] FOREIGN KEY([BillingAdress])
REFERENCES [dbo].[Adress] ([AdressId])
GO
ALTER TABLE [dbo].[PaymentMethod] CHECK CONSTRAINT [FK_PaymentMethod_Adress]
GO
ALTER TABLE [dbo].[PersonInfo]  WITH CHECK ADD  CONSTRAINT [FK_PersonInfo_Adress] FOREIGN KEY([Adress])
REFERENCES [dbo].[Adress] ([AdressId])
GO
ALTER TABLE [dbo].[PersonInfo] CHECK CONSTRAINT [FK_PersonInfo_Adress]
GO
ALTER TABLE [dbo].[SharedCars]  WITH CHECK ADD  CONSTRAINT [FK_SharedCars_Car] FOREIGN KEY([CarId])
REFERENCES [dbo].[Car] ([CarId])
GO
ALTER TABLE [dbo].[SharedCars] CHECK CONSTRAINT [FK_SharedCars_Car]
GO
ALTER TABLE [dbo].[SharedCars]  WITH CHECK ADD  CONSTRAINT [FK_SharedCars_Office] FOREIGN KEY([OfficeId])
REFERENCES [dbo].[Office] ([OfficeId])
GO
ALTER TABLE [dbo].[SharedCars] CHECK CONSTRAINT [FK_SharedCars_Office]
GO
USE [master]
GO
ALTER DATABASE [Car Rental Supreme] SET  READ_WRITE 
GO
