USE [master]
GO
/****** Object:  Database [CarParkingDB]    Script Date: 5/21/2025 7:23:07 PM ******/
CREATE DATABASE [CarParkingDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarParkingDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SOUTHSIDE\MSSQL\DATA\CarParkingDB.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CarParkingDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SOUTHSIDE\MSSQL\DATA\CarParkingDB.ldf' , SIZE = 270336KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CarParkingDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarParkingDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarParkingDB] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [CarParkingDB] SET ANSI_NULLS ON 
GO
ALTER DATABASE [CarParkingDB] SET ANSI_PADDING ON 
GO
ALTER DATABASE [CarParkingDB] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [CarParkingDB] SET ARITHABORT ON 
GO
ALTER DATABASE [CarParkingDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarParkingDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarParkingDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarParkingDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarParkingDB] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [CarParkingDB] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [CarParkingDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarParkingDB] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [CarParkingDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarParkingDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarParkingDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarParkingDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarParkingDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarParkingDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarParkingDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarParkingDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarParkingDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarParkingDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CarParkingDB] SET  MULTI_USER 
GO
ALTER DATABASE [CarParkingDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarParkingDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarParkingDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarParkingDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CarParkingDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CarParkingDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CarParkingDB', N'ON'
GO
ALTER DATABASE [CarParkingDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [CarParkingDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CarParkingDB]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 5/21/2025 7:23:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](max) NULL,
	[vertify_email] [nvarchar](max) NULL,
	[roleId] [int] NULL,
	[status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 5/21/2025 7:23:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[Id] [nvarchar](10) NOT NULL,
	[vehicle_id] [int] NULL,
	[serviceId] [int] NULL,
	[cost] [decimal](10, 2) NULL,
	[fine] [decimal](8, 2) NULL,
	[note] [nvarchar](max) NULL,
	[day_print] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contract]    Script Date: 5/21/2025 7:23:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contract](
	[contractId] [int] IDENTITY(1,1) NOT NULL,
	[contractType] [nvarchar](50) NULL,
	[vehicleId] [int] NULL,
	[customerId] [int] NULL,
	[startDate] [datetime] NULL,
	[endDate] [datetime] NULL,
	[price] [int] NULL,
	[staffId] [int] NULL,
	[status] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[contractId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 5/21/2025 7:23:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[customerId] [int] NOT NULL,
	[fullName] [nvarchar](100) NULL,
	[phoneNumber] [nvarchar](20) NULL,
	[email] [nvarchar](100) NULL,
	[address] [nvarchar](255) NULL,
	[identityCard] [nvarchar](20) NULL,
	[dateOfBirth] [date] NULL,
	[gender] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[customerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 5/21/2025 7:23:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[employeeId] [int] NOT NULL,
	[name] [nvarchar](50) NULL,
	[role] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[identityNumber] [nvarchar](20) NULL,
	[salary] [int] NULL,
	[username] [nvarchar](20) NULL,
	[password] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[employeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 5/21/2025 7:23:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[roleId] [int] NOT NULL,
	[roleName] [nchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[roleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[roleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 5/21/2025 7:23:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[serviceId] [int] NOT NULL,
	[serviceName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[serviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slot]    Script Date: 5/21/2025 7:23:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slot](
	[slotId] [int] NOT NULL,
	[slotNumber] [nchar](10) NULL,
	[vehicle_typeId] [int] NULL,
	[is_occpied] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[slotId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 5/21/2025 7:23:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[vehicleId] [int] NOT NULL,
	[licensePlate] [nvarchar](50) NULL,
	[model] [nchar](15) NULL,
	[time_in] [datetime] NULL,
	[vehicle_typeId] [int] NULL,
	[img_plate_bike] [image] NULL,
	[img_owner_carModel] [image] NULL,
	[ownerName] [nvarchar](max) NULL,
	[ownerPhone] [text] NULL,
	[serviceId] [int] NULL,
	[slotId] [int] NULL,
	[parkingCard_code] [nvarchar](50) NULL,
	[problem_desc] [nvarchar](max) NULL,
	[parkingType] [nchar](5) NULL,
	[customerId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[vehicleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle Type]    Script Date: 5/21/2025 7:23:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle Type](
	[vehicle_typeId] [int] NOT NULL,
	[vehicle_typeName] [nvarchar](50) NULL,
	[parking_fee] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[vehicle_typeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkSession]    Script Date: 5/21/2025 7:23:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkSession](
	[sessionId] [int] IDENTITY(1,1) NOT NULL,
	[employeeId] [int] NULL,
	[startTime] [datetime] NULL,
	[endTime] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[sessionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_Role] FOREIGN KEY([roleId])
REFERENCES [dbo].[Role] ([roleId])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_Role]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Services] FOREIGN KEY([serviceId])
REFERENCES [dbo].[Services] ([serviceId])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Services]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Slot] FOREIGN KEY([slotId])
REFERENCES [dbo].[Slot] ([slotId])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Slot]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_VehicleType] FOREIGN KEY([vehicle_typeId])
REFERENCES [dbo].[Vehicle Type] ([vehicle_typeId])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_VehicleType]
GO
USE [master]
GO
ALTER DATABASE [CarParkingDB] SET  READ_WRITE 
GO
