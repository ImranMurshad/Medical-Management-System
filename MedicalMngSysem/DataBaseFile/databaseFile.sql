USE [master]
GO
/****** Object:  Database [MedicalShopMngSys]    Script Date: 19-06-2022 17:16:52 ******/
CREATE DATABASE [MedicalShopMngSys] ON  PRIMARY 
( NAME = N'MedicalShopMngSys', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\MedicalShopMngSys.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MedicalShopMngSys_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\MedicalShopMngSys_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MedicalShopMngSys] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MedicalShopMngSys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MedicalShopMngSys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET ARITHABORT OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MedicalShopMngSys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MedicalShopMngSys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MedicalShopMngSys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MedicalShopMngSys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MedicalShopMngSys] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MedicalShopMngSys] SET  MULTI_USER 
GO
ALTER DATABASE [MedicalShopMngSys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MedicalShopMngSys] SET DB_CHAINING OFF 
GO
USE [MedicalShopMngSys]
GO
/****** Object:  Table [dbo].[Sale]    Script Date: 19-06-2022 17:16:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[total] [varchar](50) NULL,
 CONSTRAINT [PK_Sale] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sale_Product]    Script Date: 19-06-2022 17:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sale_Product](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[bid] [varchar](50) NULL,
	[date] [varchar](50) NULL,
	[name] [varchar](50) NULL,
	[address] [varchar](max) NULL,
	[mobno] [varchar](50) NULL,
	[sno] [varchar](50) NULL,
	[pname] [varchar](50) NULL,
	[srno] [varchar](50) NULL,
	[rate] [varchar](50) NULL,
	[qty] [varchar](50) NULL,
	[stotal] [varchar](50) NULL,
	[ftotal] [varchar](50) NULL,
 CONSTRAINT [PK_Sale_Product] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Customer]    Script Date: 19-06-2022 17:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Customer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[address] [varchar](max) NULL,
	[mobno] [varchar](50) NULL,
	[req] [varchar](max) NULL,
	[approve] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Stock]    Script Date: 19-06-2022 17:16:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Stock](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[srno] [varchar](50) NULL,
	[code] [varchar](50) NULL,
	[mname] [varchar](50) NULL,
	[indate] [varchar](50) NULL,
	[exdate] [varchar](50) NULL,
	[rate] [varchar](50) NULL,
	[qty] [varchar](50) NULL,
	[lockno] [varchar](50) NULL,
 CONSTRAINT [PK_tbl_Stock] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [MedicalShopMngSys] SET  READ_WRITE 
GO
