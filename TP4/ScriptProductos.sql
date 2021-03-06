USE [master]
GO
/****** Object:  Database [utnTP4]    Script Date: 22/11/2020 14:26:49 ******/
CREATE DATABASE [utnTP4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'utnTP4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\utnTP4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'utnTP4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\utnTP4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [utnTP4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [utnTP4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [utnTP4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [utnTP4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [utnTP4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [utnTP4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [utnTP4] SET ARITHABORT OFF 
GO
ALTER DATABASE [utnTP4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [utnTP4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [utnTP4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [utnTP4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [utnTP4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [utnTP4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [utnTP4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [utnTP4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [utnTP4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [utnTP4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [utnTP4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [utnTP4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [utnTP4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [utnTP4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [utnTP4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [utnTP4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [utnTP4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [utnTP4] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [utnTP4] SET  MULTI_USER 
GO
ALTER DATABASE [utnTP4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [utnTP4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [utnTP4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [utnTP4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [utnTP4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [utnTP4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [utnTP4] SET QUERY_STORE = OFF
GO
USE [utnTP4]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 22/11/2020 14:26:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[nombre] [nvarchar](50) NOT NULL,
	[precio] [decimal](18, 2) NOT NULL,
	[stock] [int] NOT NULL,
	[codigo] [nvarchar](50) NOT NULL,
	[id] [int] IDENTITY(101,1) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Peras', CAST(87.45 AS Decimal(18, 2)), 4090, N'FD35D', 131)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Manzanas', CAST(41.60 AS Decimal(18, 2)), 2260, N'FB45H', 132)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Chocolinas', CAST(102.45 AS Decimal(18, 2)), 5252, N'FG56H', 133)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Pepas', CAST(40.36 AS Decimal(18, 2)), 3626, N'HJ64N', 134)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Chicles', CAST(19.44 AS Decimal(18, 2)), 19621, N'BV43D', 135)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Churros', CAST(36.25 AS Decimal(18, 2)), 1446, N'CG54DF', 136)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Medialunas', CAST(15.20 AS Decimal(18, 2)), 8931, N'GB45S', 137)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Gatorade', CAST(29.10 AS Decimal(18, 2)), 2390, N'DF34G', 138)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Coca Cola', CAST(140.61 AS Decimal(18, 2)), 3752, N'CM34E', 139)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Pepsi', CAST(106.00 AS Decimal(18, 2)), 2361, N'FG2FG', 140)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'DVDs', CAST(10.00 AS Decimal(18, 2)), 3567, N'LDF4FW', 141)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Limones', CAST(89.99 AS Decimal(18, 2)), 2743, N'6DF3F', 143)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Tang', CAST(65.50 AS Decimal(18, 2)), 1964, N'TG54J', 144)
INSERT [dbo].[Productos] ([nombre], [precio], [stock], [codigo], [id]) VALUES (N'Milanesa', CAST(78.98 AS Decimal(18, 2)), 44, N'KJG45G', 156)
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
USE [master]
GO
ALTER DATABASE [utnTP4] SET  READ_WRITE 
GO
