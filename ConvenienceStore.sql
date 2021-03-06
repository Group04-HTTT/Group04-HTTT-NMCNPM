﻿USE [master]
GO
/****** Object:  Database [ConvenienceStore]    Script Date: 12/2/2019 12:34:38 AM ******/
CREATE DATABASE [ConvenienceStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ConvenienceStore', FILENAME = N'D:\ConvenienceStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ConvenienceStore_log', FILENAME = N'D:\ConvenienceStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ConvenienceStore] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ConvenienceStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ConvenienceStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ConvenienceStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ConvenienceStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ConvenienceStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ConvenienceStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [ConvenienceStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ConvenienceStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ConvenienceStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ConvenienceStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ConvenienceStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ConvenienceStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ConvenienceStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ConvenienceStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ConvenienceStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ConvenienceStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ConvenienceStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ConvenienceStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ConvenienceStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ConvenienceStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ConvenienceStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ConvenienceStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ConvenienceStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ConvenienceStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ConvenienceStore] SET  MULTI_USER 
GO
ALTER DATABASE [ConvenienceStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ConvenienceStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ConvenienceStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ConvenienceStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ConvenienceStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ConvenienceStore] SET QUERY_STORE = OFF
GO
USE [ConvenienceStore]
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 12/2/2019 12:34:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[bill_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[qty] [int] NULL,
	[unit_price] [money] NULL,
 CONSTRAINT [PK_BillDetails] PRIMARY KEY CLUSTERED 
(
	[bill_id] ASC,
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 12/2/2019 12:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[bill_id] [int] NOT NULL,
	[bill_createdate] [datetime] NULL,
	[total_amt] [int] NULL,
	[total_price] [money] NULL,
	[discount] [float] NULL,
	[total_money] [money] NULL,
	[mem_id] [int] NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[bill_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 12/2/2019 12:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[mem_id] [int] NOT NULL,
	[mem_name] [nvarchar](50) NULL,
	[mem_phone] [varchar](10) NULL,
	[mem_addr] [nvarchar](200) NULL,
	[mem_dob] DATE NULL,
	[mem_socialid] [varchar](10) NULL, 
	[mem_point] [int] NULL,
	[mem_gender] [int] NULL, --0:Male, 1:Female , 2: other
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[mem_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 12/2/2019 12:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[prod_id] [int] NOT NULL,
	[prod_name] [nvarchar](50) NULL,
	[prod_price] [money] NULL,
	[prod_supply] [nvarchar](50) NULL,
	[stock_instore] [int] NULL,
	[stock_inwarehouse] [int] NULL,
	[prodtype_id] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[prod_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTypes]    Script Date: 12/2/2019 12:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTypes](
	[prodtype_id] [int] NOT NULL,
	[prodtype_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProductTypes] PRIMARY KEY CLUSTERED 
(
	[prodtype_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 12/2/2019 12:34:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[staff_id] [int] NOT NULL,
	[staff_name] [nvarchar](50) NULL,
	[staff_phone] [varchar](10) NULL,
	[staff_addr] [nvarchar](200) NULL,
	[staff_dob] DATE NULL,
	[staff_pos] [int] NULL, --1:administrator, 2:staff, 3:warehouse staff
	[staff_socialid] [varchar](10) NULL, 
	[staff_gender] [int] NULL, --0:Male, 1:Female, 2: other
	[staff_pass] [nvarchar](16) NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[staff_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Bills] FOREIGN KEY([bill_id])
REFERENCES [dbo].[Bills] ([bill_id])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Bills]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_BillDetails_Products] FOREIGN KEY([product_id])
REFERENCES [dbo].[Products] ([prod_id])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_BillDetails_Products]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_Members] FOREIGN KEY([mem_id])
REFERENCES [dbo].[Members] ([mem_id])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_Members]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_ProductTypes] FOREIGN KEY([prodtype_id])
REFERENCES [dbo].[ProductTypes] ([prodtype_id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_ProductTypes]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [CK_BillDetails_Qty] CHECK  (([Qty]>=(1)))
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [CK_BillDetails_Qty]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [CK_BillDetails_unit_price] CHECK  (([unit_price]>=(0)))
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [CK_BillDetails_unit_price]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [CK_Bills_discount] CHECK  (([discount]>=(0)))
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [CK_Bills_discount]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [CK_Bills_bill_createdate] CHECK  (([bill_createdate]<=GETDATE()))
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [CK_Bills_bill_createdate]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [CK_Bills_total_amt] CHECK  (([total_amt]>=(0)))
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [CK_Bills_total_amt]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [CK_Bills_total_money] CHECK  (([total_money]=([total_price]-[discount])))
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [CK_Bills_total_money]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [CK_Bills_total_price] CHECK  (([total_price]>=(0)))
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [CK_Bills_total_price]
GO
ALTER TABLE [dbo].[Members]  WITH CHECK ADD  CONSTRAINT [CK_Members_mem_point] CHECK  (([mem_point]>=(0)))
GO
ALTER TABLE [dbo].[Members] CHECK CONSTRAINT [CK_Members_mem_point]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [CK_Products_prod_price] CHECK  (([prod_price]>=(0)))
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_Products_prod_price]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [CK_Products_stock_instore] CHECK  (([stock_instore]>=(0)))
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_Products_stock_instore]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [CK_Products_stock_inwarehouse] CHECK  (([stock_inwarehouse]>=(0)))
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [CK_Products_stock_inwarehouse]
GO
ALTER TABLE [dbo].[Staffs]  WITH CHECK ADD  CONSTRAINT [CK_Staffs_staff_pos] CHECK  (([staff_pos]>=(1) AND [staff_pos]<=(3)))
GO
ALTER TABLE [dbo].[Staffs] CHECK CONSTRAINT [CK_Staffs_staff_pos]
GO
USE [master]
GO
ALTER DATABASE [ConvenienceStore] SET  READ_WRITE 
GO
