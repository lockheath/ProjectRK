USE [master]
GO
/****** Object:  Database [ProjectV2]    Script Date: 27 เม.ย. 2561 14:41:36 ******/
CREATE DATABASE [ProjectV2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjectV2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ProjectV2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProjectV2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\ProjectV2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProjectV2] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectV2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectV2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectV2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectV2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectV2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectV2] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectV2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjectV2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectV2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectV2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectV2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectV2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectV2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectV2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectV2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectV2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectV2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectV2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectV2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectV2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectV2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectV2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectV2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectV2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProjectV2] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectV2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectV2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectV2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectV2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProjectV2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProjectV2] SET QUERY_STORE = OFF
GO
USE [ProjectV2]
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
USE [ProjectV2]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 27 เม.ย. 2561 14:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[Description] [ntext] NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriesD]    Script Date: 27 เม.ย. 2561 14:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriesD](
	[CategoryDID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryDName] [nvarchar](50) NULL,
	[Description] [ntext] NULL,
 CONSTRAINT [PK_CategoriesD] PRIMARY KEY CLUSTERED 
(
	[CategoryDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 27 เม.ย. 2561 14:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](200) NOT NULL,
	[Address] [nvarchar](200) NULL,
	[Phone] [nvarchar](24) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 27 เม.ย. 2561 14:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [nvarchar](200) NOT NULL,
	[Address] [nvarchar](200) NULL,
	[Phone] [nvarchar](24) NULL,
	[Photo] [image] NULL,
	[Username] [nvarchar](20) NULL,
	[Password] [nvarchar](20) NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 27 เม.ย. 2561 14:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[ExpensesID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ExpensesName] [nvarchar](500) NULL,
	[ExpensesPrice] [money] NULL,
	[ExpensesDate] [datetime] NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[ExpensesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 27 เม.ย. 2561 14:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[EmployeeID] [int] NULL,
	[OrderDate] [datetime] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersD]    Script Date: 27 เม.ย. 2561 14:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersD](
	[OrderDID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[EmployeeID] [int] NULL,
	[OrderDDate] [datetime] NULL,
 CONSTRAINT [PK_OrdersD] PRIMARY KEY CLUSTERED 
(
	[OrderDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersDetails]    Script Date: 27 เม.ย. 2561 14:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersDetails](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NULL,
	[Quantity] [smallint] NULL,
	[Discount] [real] NULL,
 CONSTRAINT [PK_OrdersDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrdersDetailsD]    Script Date: 27 เม.ย. 2561 14:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrdersDetailsD](
	[OrderDID] [int] NOT NULL,
	[ProductDID] [int] NOT NULL,
	[Donation] [money] NULL,
 CONSTRAINT [PK_OrdersDetailsD] PRIMARY KEY CLUSTERED 
(
	[OrderDID] ASC,
	[ProductDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 27 เม.ย. 2561 14:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[CategoryID] [int] NULL,
	[QuantityPerUnit] [nvarchar](500) NULL,
	[UnitPrice] [money] NULL,
	[UnitsInStock] [smallint] NULL,
	[Picture] [image] NULL,
	[DateAdd] [datetime] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductsD]    Script Date: 27 เม.ย. 2561 14:41:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductsD](
	[ProductDID] [int] IDENTITY(1,1) NOT NULL,
	[ProductDName] [nvarchar](50) NULL,
	[CategoryDID] [int] NULL,
	[QuantityPerUnit] [nvarchar](500) NULL,
 CONSTRAINT [PK_ProductsD] PRIMARY KEY CLUSTERED 
(
	[ProductDID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Employees]
GO
ALTER TABLE [dbo].[OrdersD]  WITH CHECK ADD  CONSTRAINT [FK_OrdersD_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[OrdersD] CHECK CONSTRAINT [FK_OrdersD_Customers]
GO
ALTER TABLE [dbo].[OrdersD]  WITH CHECK ADD  CONSTRAINT [FK_OrdersD_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[OrdersD] CHECK CONSTRAINT [FK_OrdersD_Employees]
GO
ALTER TABLE [dbo].[OrdersDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrdersDetails_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrdersDetails] CHECK CONSTRAINT [FK_OrdersDetails_Orders]
GO
ALTER TABLE [dbo].[OrdersDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrdersDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrdersDetails] CHECK CONSTRAINT [FK_OrdersDetails_Products]
GO
ALTER TABLE [dbo].[OrdersDetailsD]  WITH CHECK ADD  CONSTRAINT [FK_OrdersDetailsD_OrdersD] FOREIGN KEY([OrderDID])
REFERENCES [dbo].[OrdersD] ([OrderDID])
GO
ALTER TABLE [dbo].[OrdersDetailsD] CHECK CONSTRAINT [FK_OrdersDetailsD_OrdersD]
GO
ALTER TABLE [dbo].[OrdersDetailsD]  WITH CHECK ADD  CONSTRAINT [FK_OrdersDetailsD_ProductsD] FOREIGN KEY([ProductDID])
REFERENCES [dbo].[ProductsD] ([ProductDID])
GO
ALTER TABLE [dbo].[OrdersDetailsD] CHECK CONSTRAINT [FK_OrdersDetailsD_ProductsD]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[ProductsD]  WITH CHECK ADD  CONSTRAINT [FK_ProductsD_CategoriesD] FOREIGN KEY([CategoryDID])
REFERENCES [dbo].[CategoriesD] ([CategoryDID])
GO
ALTER TABLE [dbo].[ProductsD] CHECK CONSTRAINT [FK_ProductsD_CategoriesD]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'รหัสค่าใช้จ่าย' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expenses', @level2type=N'COLUMN',@level2name=N'ExpensesID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ค่าใช้จ่าย' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expenses', @level2type=N'COLUMN',@level2name=N'ExpensesName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'จำนวนเงิน' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expenses', @level2type=N'COLUMN',@level2name=N'ExpensesPrice'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'วันเวลา' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Expenses', @level2type=N'COLUMN',@level2name=N'ExpensesDate'
GO
USE [master]
GO
ALTER DATABASE [ProjectV2] SET  READ_WRITE 
GO
