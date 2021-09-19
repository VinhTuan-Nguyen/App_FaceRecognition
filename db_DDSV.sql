USE [master]
GO
/****** Object:  Database [db_DDSV]    Script Date: 09/19/2021 21:21:21 ******/
CREATE DATABASE [db_DDSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_DDSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_DDSV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_DDSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\db_DDSV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_DDSV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_DDSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_DDSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_DDSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_DDSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_DDSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_DDSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_DDSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_DDSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_DDSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_DDSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_DDSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_DDSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_DDSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_DDSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_DDSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_DDSV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_DDSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_DDSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_DDSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_DDSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_DDSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_DDSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_DDSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_DDSV] SET RECOVERY FULL 
GO
ALTER DATABASE [db_DDSV] SET  MULTI_USER 
GO
ALTER DATABASE [db_DDSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_DDSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_DDSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_DDSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_DDSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_DDSV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_DDSV', N'ON'
GO
ALTER DATABASE [db_DDSV] SET QUERY_STORE = OFF
GO
USE [db_DDSV]
GO
/****** Object:  Table [dbo].[tab_DiemDanh]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_DiemDanh](
	[col_NgayDD] [smalldatetime] NOT NULL,
	[col_MaHP] [varchar](10) NOT NULL,
	[col_MaSV] [varchar](10) NOT NULL,
	[col_GhiChu] [nvarchar](150) NOT NULL,
	[col_GioDD] [time](0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tab_DKHP]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_DKHP](
	[col_MaHP] [varchar](10) NOT NULL,
	[col_MaSV] [varchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tab_GiangVien]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_GiangVien](
	[col_MaGV] [varchar](10) NOT NULL,
	[col_HoLot] [nvarchar](20) NOT NULL,
	[col_Ten] [nvarchar](10) NOT NULL,
	[col_Khoa] [nvarchar](50) NOT NULL,
	[col_Email] [varchar](100) NOT NULL,
	[col_GioiTinh] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[col_MaGV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tab_Login]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_Login](
	[col_User] [varchar](10) NOT NULL,
	[col_Password] [varchar](max) NOT NULL,
	[col_Role] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[col_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tab_LopHP]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_LopHP](
	[col_MaHP] [varchar](10) NOT NULL,
	[col_TenHP] [nvarchar](100) NOT NULL,
	[col_NgayBD] [date] NOT NULL,
	[col_NgayKT] [date] NOT NULL,
	[col_Thu] [varchar](2) NOT NULL,
	[col_MaGV] [varchar](10) NOT NULL,
	[col_TrangThai] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[col_MaHP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tab_SinhVien]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tab_SinhVien](
	[col_MaSV] [varchar](10) NOT NULL,
	[col_HoLot] [nvarchar](20) NOT NULL,
	[col_Ten] [nvarchar](10) NOT NULL,
	[col_Lop] [nvarchar](50) NOT NULL,
	[col_Email] [varchar](100) NOT NULL,
	[col_GioiTinh] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[col_MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-05-23T00:00:00' AS SmallDateTime), N'12345abcde', N'SV12345678', N'Có Phép', NULL)
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-07T00:00:00' AS SmallDateTime), N'sdfsd', N'sdfgsd', N'Có Mặt', NULL)
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-07T00:00:00' AS SmallDateTime), N'gdfsgjj', N'FAD', N'Có Mặt', NULL)
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-07T00:00:00' AS SmallDateTime), N'gdfsgjj', N'', N'Có Mặt', NULL)
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-07T00:00:00' AS SmallDateTime), N'gdfsgjj', N'sadfjsa', N'Có Mặt', NULL)
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-07T00:00:00' AS SmallDateTime), N'sfdgvd', N'fsdf', N'Có Mặt', NULL)
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-12T00:00:00' AS SmallDateTime), N'abcde12345', N'SV15335665', N'Có Mặt', CAST(N'19:05:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-12T00:00:00' AS SmallDateTime), N'abcde12345', N'SV15335665', N'Có Mặt', CAST(N'19:30:44' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-13T00:00:00' AS SmallDateTime), N'abcde12345', N'SV15335665', N'Có Mặt', CAST(N'18:40:25' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-15T19:25:00' AS SmallDateTime), N'abcde12345', N'SV15335665', N'Có Mặt', CAST(N'19:24:41' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-15T19:58:00' AS SmallDateTime), N'abcde12345', N'SV15335665', N'Có Mặt', CAST(N'19:58:05' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-17T19:05:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'19:05:25' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T12:40:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'12:39:50' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T12:40:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T12:40:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'12:43:29' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T14:09:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'14:09:37' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T14:09:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T14:22:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'14:23:40' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T14:22:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T15:40:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'15:40:50' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T15:40:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T16:29:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'16:29:37' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T16:29:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:06:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'17:06:37' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:06:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:11:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'17:11:44' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:11:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-19T15:53:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'15:53:17' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-19T15:53:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-19T15:53:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'15:54:04' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-19T19:51:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'19:52:34' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-19T19:51:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T12:40:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'13:52:54' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T12:40:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'13:53:31' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T11:25:00' AS SmallDateTime), N'abcde12345', N'SV12345678', N'Có M?t', CAST(N'15:53:45' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T11:25:00' AS SmallDateTime), N'abcde12345', N'SV12345678', N'Có Mặt', CAST(N'15:53:45' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T11:24:00' AS SmallDateTime), N'abcde12345', N'SV12345678', N'Có Mặt', CAST(N'15:53:45' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T14:18:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'14:18:53' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T14:18:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T11:25:00' AS SmallDateTime), N'abcde12345', N'SV12345678', N'Có Mặt', NULL)
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T15:47:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'15:47:53' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T15:47:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:08:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'17:08:34' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:08:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:20:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'17:20:16' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:20:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T14:56:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'14:56:39' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T14:56:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:22:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'17:22:34' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:22:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:24:00' AS SmallDateTime), N'gsdfg56668', N'SV15335665', N'Có Mặt', CAST(N'17:24:51' AS Time))
INSERT [dbo].[tab_DiemDanh] ([col_NgayDD], [col_MaHP], [col_MaSV], [col_GhiChu], [col_GioDD]) VALUES (CAST(N'2021-09-18T17:24:00' AS SmallDateTime), N'gsdfg56668', N'SV12345678', N'Vắng', CAST(N'00:00:00' AS Time))
GO
INSERT [dbo].[tab_DKHP] ([col_MaHP], [col_MaSV]) VALUES (N'gsdfg56668', N'SV12345678')
INSERT [dbo].[tab_DKHP] ([col_MaHP], [col_MaSV]) VALUES (N'abcde12345', N'SV15335665')
INSERT [dbo].[tab_DKHP] ([col_MaHP], [col_MaSV]) VALUES (N'gsdfg56668', N'SV15335665')
INSERT [dbo].[tab_DKHP] ([col_MaHP], [col_MaSV]) VALUES (N'1a2b3c4d5e', N'SV15335665')
INSERT [dbo].[tab_DKHP] ([col_MaHP], [col_MaSV]) VALUES (N'xczfzgadf', N'SV12345678')
INSERT [dbo].[tab_DKHP] ([col_MaHP], [col_MaSV]) VALUES (N'12345abcde', N'SV12345678')
GO
INSERT [dbo].[tab_GiangVien] ([col_MaGV], [col_HoLot], [col_Ten], [col_Khoa], [col_Email], [col_GioiTinh]) VALUES (N'GV00000001', N'Huỳnh Văn', N'Thanh', N'Khoa Học Cơ Bản', N'fsdasd@gmail.com', 1)
INSERT [dbo].[tab_GiangVien] ([col_MaGV], [col_HoLot], [col_Ten], [col_Khoa], [col_Email], [col_GioiTinh]) VALUES (N'GV12345678', N'Nguyễn Phi', N'Hùng', N'Công Nghệ Thông Tin', N'phihung@gmail.com', 1)
GO
INSERT [dbo].[tab_Login] ([col_User], [col_Password], [col_Role]) VALUES (N'AD12345678', N'781e5e245d69b566979b86e28d23f2c7', N'admin')
INSERT [dbo].[tab_Login] ([col_User], [col_Password], [col_Role]) VALUES (N'GV00000000', N'781e5e245d69b566979b86e28d23f2c7', N'user')
INSERT [dbo].[tab_Login] ([col_User], [col_Password], [col_Role]) VALUES (N'GV00000001', N'781e5e245d69b566979b86e28d23f2c7', N'user')
INSERT [dbo].[tab_Login] ([col_User], [col_Password], [col_Role]) VALUES (N'GV12345678', N'781e5e245d69b566979b86e28d23f2c7', N'user')
INSERT [dbo].[tab_Login] ([col_User], [col_Password], [col_Role]) VALUES (N'root', N'781e5e245d69b566979b86e28d23f2c7', N'admin')
GO
INSERT [dbo].[tab_LopHP] ([col_MaHP], [col_TenHP], [col_NgayBD], [col_NgayKT], [col_Thu], [col_MaGV], [col_TrangThai]) VALUES (N'12345abcde', N'Mạng Máy Tính', CAST(N'2021-06-16' AS Date), CAST(N'2021-09-15' AS Date), N'T4', N'GV12345678', 1)
INSERT [dbo].[tab_LopHP] ([col_MaHP], [col_TenHP], [col_NgayBD], [col_NgayKT], [col_Thu], [col_MaGV], [col_TrangThai]) VALUES (N'1a2b3c4d5e', N'Công Nghệ .Net', CAST(N'2021-08-19' AS Date), CAST(N'2021-09-23' AS Date), N'T6', N'GV98765432', 0)
INSERT [dbo].[tab_LopHP] ([col_MaHP], [col_TenHP], [col_NgayBD], [col_NgayKT], [col_Thu], [col_MaGV], [col_TrangThai]) VALUES (N'4asd56ga', N'Trí Tuệ Nhân Tạo', CAST(N'2021-05-22' AS Date), CAST(N'2021-08-07' AS Date), N'T7', N'GV18531533', 0)
INSERT [dbo].[tab_LopHP] ([col_MaHP], [col_TenHP], [col_NgayBD], [col_NgayKT], [col_Thu], [col_MaGV], [col_TrangThai]) VALUES (N'abcde12345', N'Thương Mại Điện Tử', CAST(N'2021-12-01' AS Date), CAST(N'2022-06-01' AS Date), N'T4', N'GV12345678', 1)
INSERT [dbo].[tab_LopHP] ([col_MaHP], [col_TenHP], [col_NgayBD], [col_NgayKT], [col_Thu], [col_MaGV], [col_TrangThai]) VALUES (N'gsdfg56668', N'Toán Rời Rạc', CAST(N'2021-01-13' AS Date), CAST(N'2021-02-18' AS Date), N'T4', N'GV00000001', 1)
INSERT [dbo].[tab_LopHP] ([col_MaHP], [col_TenHP], [col_NgayBD], [col_NgayKT], [col_Thu], [col_MaGV], [col_TrangThai]) VALUES (N'jhfg51566d', N'Toán Rời Rạc', CAST(N'2021-10-12' AS Date), CAST(N'2022-03-25' AS Date), N'T6', N'GV00000001', 0)
INSERT [dbo].[tab_LopHP] ([col_MaHP], [col_TenHP], [col_NgayBD], [col_NgayKT], [col_Thu], [col_MaGV], [col_TrangThai]) VALUES (N'ssdfg8s6f8', N'Hệ Quản Trị Cơ Sở Dữ Liệu', CAST(N'2021-04-23' AS Date), CAST(N'2021-07-23' AS Date), N'T6', N'GV00000001', 1)
GO
INSERT [dbo].[tab_SinhVien] ([col_MaSV], [col_HoLot], [col_Ten], [col_Lop], [col_Email], [col_GioiTinh]) VALUES (N'SV12345678', N'Nguyễn Vĩnh', N'Tuân', N'KHMT0118', N'fsdagfsa@gmail.com', 1)
INSERT [dbo].[tab_SinhVien] ([col_MaSV], [col_HoLot], [col_Ten], [col_Lop], [col_Email], [col_GioiTinh]) VALUES (N'SV15335665', N'Võ Nguyễn Thái', N'Nhi', N'KHDL0119', N'sdfgsfa@gmail.com', 0)
INSERT [dbo].[tab_SinhVien] ([col_MaSV], [col_HoLot], [col_Ten], [col_Lop], [col_Email], [col_GioiTinh]) VALUES (N'SV1800097', N'Nguyễn Bảo', N'Ân', N'KHMT0118', N'zcdsfa@gmai.com', 1)
GO
/****** Object:  StoredProcedure [dbo].[asp_AddLhp]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[asp_AddLhp]
	@maHP varchar(10),
	@tenHP nvarchar(20),
	@ngayBD date,
	@ngayKT date,
	@thu varchar(2),
	@maGV varchar(10),
	@tt bit
AS
	INSERT INTO tab_LopHP
	VALUES (
		@maHP,
		@tenHP,
		@ngayBD,
		@ngayKT,
		@thu,
		@maGV,
		@tt
	)
GO
/****** Object:  StoredProcedure [dbo].[asp_AddUser]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[asp_AddUser]
	@user varchar(10),
	@role varchar(10)
AS
	INSERT INTO tab_Login
	VALUES (
		@user,
		'1203094369310518110215115513422614135242199',
		@role
	)
GO
/****** Object:  StoredProcedure [dbo].[asp_AllUser]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[asp_AllUser]
	@user varchar(10),
	@pass varchar(100)
AS
	SELECT *
	FROM tab_Login
	WHERE
		col_User = @user  COLLATE SQL_Latin1_General_CP1_CS_AS and
		col_Password = @pass COLLATE SQL_Latin1_General_CP1_CS_AS
GO
/****** Object:  StoredProcedure [dbo].[asp_AllUserVal]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[asp_AllUserVal]
	@user varchar(10),
	@role varchar(10)
AS
	SELECT *
	FROM tab_Login
	WHERE
		col_User like @user or
		col_Role like @role
GO
/****** Object:  StoredProcedure [dbo].[asp_DKHP_AllData]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[asp_DKHP_AllData]
AS
	SELECT DISTINCT hp.*
	FROM tab_LopHP hp, tab_SinhVien sv, tab_DKHP dk
	WHERE
		hp.col_MaHP = dk.col_MaHP and
		sv.col_MaSV = dk.col_MaSV

	SELECT DISTINCT sv.*
	FROM tab_LopHP hp, tab_SinhVien sv, tab_DKHP dk
	WHERE
		hp.col_MaHP = dk.col_MaHP and
		sv.col_MaSV = dk.col_MaSV
GO
/****** Object:  StoredProcedure [dbo].[asp_GV_Data]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[asp_GV_Data]
	@mahp varchar(10)
AS
	SELECT sv.*
	FROM tab_LopHP hp, tab_SinhVien sv, tab_DKHP dk
	WHERE
		hp.col_MaHP = dk.col_MaHP and
		sv.col_MaSV = dk.col_MaSV and
		hp.col_MaHP = @mahp

	SELECT *
	FROM tab_LopHP
	WHERE
		col_MaHP = @mahp

	SELECT *
	FROM tab_DiemDanh
	WHERE
		col_MaHP = @mahp
GO
/****** Object:  StoredProcedure [dbo].[asp_LHP_LoadSV]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[asp_LHP_LoadSV]
	@mahp varchar(10)
AS
	SELECT sv.col_MaSV, sv.col_HoLot, sv.col_Ten, sv.col_Email, sv.col_GioiTinh 
	FROM tab_DKHP dk, tab_LopHP hp, tab_SinhVien sv
	WHERE
		dk.col_MaHP = hp.col_MaHP and
		sv.col_MaSV = hp.col_MaHP and
		hp.col_MaHP = @mahp
GO
/****** Object:  StoredProcedure [dbo].[asp_LHP_LoadVal1]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[asp_LHP_LoadVal1]
	@maHP varchar(10),
	@tenHP nvarchar(100),
	@maGV varchar(10),
	@thu varchar(2)
AS
	SELECT *
	FROM tab_LopHP
	WHERE
		col_MaHP = @maHP or
		col_TenHP = @tenHP or
		col_MaGV = @maGV or
		col_Thu = @thu
GO
/****** Object:  StoredProcedure [dbo].[asp_LHP_LoadVal2]    Script Date: 09/19/2021 21:21:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[asp_LHP_LoadVal2]
	@tungay date,
	@denngay date
AS
	SELECT *
	FROM tab_LopHP
	WHERE
		col_NgayBD BETWEEN @tungay and @denngay and
		col_NgayKT BETWEEN @tungay and @denngay
GO
USE [master]
GO
ALTER DATABASE [db_DDSV] SET  READ_WRITE 
GO
