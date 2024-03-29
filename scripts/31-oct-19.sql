USE [master]
GO
/****** Object:  Database [oms]    Script Date: 10/31/2019 3:32:23 PM ******/
CREATE DATABASE [oms]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'orms', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\orms.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'orms_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\orms_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [oms] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [oms].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [oms] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [oms] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [oms] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [oms] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [oms] SET ARITHABORT OFF 
GO
ALTER DATABASE [oms] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [oms] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [oms] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [oms] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [oms] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [oms] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [oms] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [oms] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [oms] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [oms] SET  DISABLE_BROKER 
GO
ALTER DATABASE [oms] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [oms] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [oms] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [oms] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [oms] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [oms] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [oms] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [oms] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [oms] SET  MULTI_USER 
GO
ALTER DATABASE [oms] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [oms] SET DB_CHAINING OFF 
GO
ALTER DATABASE [oms] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [oms] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [oms] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [oms] SET QUERY_STORE = OFF
GO
USE [oms]
GO
/****** Object:  Table [dbo].[business_Setting]    Script Date: 10/31/2019 3:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[business_Setting](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[business_name] [nvarchar](50) NULL,
	[business_slogon] [nvarchar](150) NULL,
	[logo_url] [nvarchar](150) NULL,
	[email] [nvarchar](50) NULL,
	[contact_no] [nvarchar](50) NULL,
	[mobile_no] [nvarchar](50) NULL,
	[address] [nvarchar](150) NULL,
	[description] [nvarchar](250) NULL,
	[return_policy] [nvarchar](250) NULL,
	[terms_conditions] [nvarchar](250) NULL,
 CONSTRAINT [PK_business_Setting] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[customer]    Script Date: 10/31/2019 3:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customer](
	[cust_id] [int] IDENTITY(1,1) NOT NULL,
	[cust_name] [nvarchar](50) NULL,
	[cust_email] [nvarchar](50) NULL,
	[cust_contact_no] [nvarchar](50) NULL,
	[cust_whatsapp] [nvarchar](50) NULL,
	[cust_address] [nvarchar](150) NULL,
	[cust_company] [nvarchar](50) NULL,
	[added_by] [int] NULL,
	[added_date] [datetime] NULL,
	[updated_by] [int] NULL,
	[updated_date] [datetime] NULL,
 CONSTRAINT [PK_customer] PRIMARY KEY CLUSTERED 
(
	[cust_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[expense]    Script Date: 10/31/2019 3:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[expense](
	[expense_id] [int] IDENTITY(1,1) NOT NULL,
	[order_account_id] [int] NULL,
	[resource_id] [int] NULL,
	[type] [nvarchar](50) NULL,
	[Title] [nvarchar](50) NULL,
	[e_date] [date] NULL,
	[amount] [float] NULL,
	[paid_amount] [nchar](10) NULL,
	[paid_by] [int] NULL,
	[detail] [nvarchar](250) NULL,
	[work_status] [nchar](10) NULL,
	[amount_status] [bit] NULL,
	[added_by] [int] NULL,
	[added_date] [datetime] NULL,
	[modify_by] [int] NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_expense] PRIMARY KEY CLUSTERED 
(
	[expense_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 10/31/2019 3:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[cust_id] [int] NOT NULL,
	[order_taken_by] [int] NULL,
	[order_assign_to] [int] NULL,
	[opening_amount] [float] NULL,
	[current_amount] [float] NULL,
	[price_is_final] [nvarchar](10) NULL,
	[paid_amount] [float] NULL,
	[expense_amount] [float] NULL,
	[extra_amount] [float] NULL,
	[order_date] [date] NULL,
	[due_date] [date] NULL,
	[link] [nvarchar](150) NULL,
	[detail] [nvarchar](350) NULL,
	[status] [bit] NULL,
	[added_by] [int] NULL,
	[added_date] [datetime] NULL,
	[modify_by] [int] NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_account]    Script Date: 10/31/2019 3:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_account](
	[order_account_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[type] [nvarchar](50) NULL,
	[recevied_amount] [float] NOT NULL,
	[amount_taken_by] [int] NULL,
	[detail] [nvarchar](150) NULL,
	[status] [bit] NULL,
	[added_by] [int] NULL,
	[added_date] [datetime] NULL,
	[modify_by] [int] NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_order_amount] PRIMARY KEY CLUSTERED 
(
	[order_account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_detail]    Script Date: 10/31/2019 3:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_detail](
	[order_detail_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[type] [nvarchar](50) NULL,
	[product_id] [int] NOT NULL,
	[cust_qty] [int] NOT NULL,
	[cust_price] [float] NULL,
	[modify_by] [int] NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_order_detail] PRIMARY KEY CLUSTERED 
(
	[order_detail_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[outsource_resource]    Script Date: 10/31/2019 3:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[outsource_resource](
	[resource_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[company_name] [nvarchar](50) NULL,
	[detail] [nvarchar](150) NULL,
	[address] [nvarchar](150) NULL,
	[email] [nvarchar](50) NULL,
	[contact_no] [nvarchar](50) NULL,
	[company_no] [nvarchar](50) NULL,
	[added_by] [int] NULL,
	[added_date] [datetime] NULL,
 CONSTRAINT [PK_outsource_resource] PRIMARY KEY CLUSTERED 
(
	[resource_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[partner]    Script Date: 10/31/2019 3:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[partner](
	[partner_id] [int] IDENTITY(1,1) NOT NULL,
	[partner_name] [nvarchar](50) NULL,
	[contact_no] [nvarchar](50) NULL,
	[partner_email] [nvarchar](50) NULL,
	[partner_detail] [nvarchar](50) NULL,
	[partner_status] [bit] NULL,
	[su_roles] [nvarchar](50) NULL,
	[su_username] [nvarchar](50) NULL,
	[su_password] [nvarchar](50) NULL,
	[su_status] [bit] NULL,
 CONSTRAINT [PK_partner] PRIMARY KEY CLUSTERED 
(
	[partner_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[partner_account]    Script Date: 10/31/2019 3:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[partner_account](
	[partner_account_id] [int] IDENTITY(1,1) NOT NULL,
	[order_account_id] [int] NOT NULL,
	[amount_given_by] [int] NULL,
	[amount] [float] NULL,
	[received_accept_date] [datetime] NULL,
	[added_by] [int] NULL,
	[added_date] [datetime] NULL,
 CONSTRAINT [PK_partner_account] PRIMARY KEY CLUSTERED 
(
	[partner_account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 10/31/2019 3:32:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [nvarchar](50) NOT NULL,
	[detail] [nvarchar](150) NULL,
	[estimate_price] [float] NULL,
	[added_by] [int] NULL,
	[added_date] [datetime] NULL,
	[modify_by] [int] NULL,
	[modify_date] [datetime] NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'order_account'
GO
USE [master]
GO
ALTER DATABASE [oms] SET  READ_WRITE 
GO
