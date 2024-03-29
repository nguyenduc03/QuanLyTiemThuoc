USE [master]
GO
/****** Object:  Database [QuanLyTiemThuoc]    Script Date: 8/28/2021 10:31:23 AM ******/
CREATE DATABASE [QuanLyTiemThuoc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyTiemThuoc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.PHANTUAN\MSSQL\DATA\QuanLyTiemThuoc.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyTiemThuoc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.PHANTUAN\MSSQL\DATA\QuanLyTiemThuoc_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyTiemThuoc] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyTiemThuoc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyTiemThuoc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyTiemThuoc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyTiemThuoc] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyTiemThuoc', N'ON'
GO
USE [QuanLyTiemThuoc]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 8/28/2021 10:31:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHD](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MaHD] [int] NOT NULL,
	[MaThuoc] [varchar](50) NOT NULL,
	[SoLuongMua] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_CTHD_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 8/28/2021 10:31:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayLap] [date] NULL,
	[TongTien] [bigint] NULL,
	[MaNV] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 8/28/2021 10:31:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1900,1) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[SDT] [int] NULL,
	[Email] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[Role] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 8/28/2021 10:31:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [varchar](50) NOT NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
	[MoTa] [nvarchar](500) NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CTHD] ON 

INSERT [dbo].[CTHD] ([Id], [MaHD], [MaThuoc], [SoLuongMua], [DonGia]) VALUES (4, 3, N'T1', 1, 1000)
INSERT [dbo].[CTHD] ([Id], [MaHD], [MaThuoc], [SoLuongMua], [DonGia]) VALUES (5, 3, N'T3', 1, 20000)
INSERT [dbo].[CTHD] ([Id], [MaHD], [MaThuoc], [SoLuongMua], [DonGia]) VALUES (6, 4, N'T3', 4, 1000021)
INSERT [dbo].[CTHD] ([Id], [MaHD], [MaThuoc], [SoLuongMua], [DonGia]) VALUES (8, 4, N'T3', 6, 60001)
INSERT [dbo].[CTHD] ([Id], [MaHD], [MaThuoc], [SoLuongMua], [DonGia]) VALUES (10, 7, N'T4', 1, 30000)
INSERT [dbo].[CTHD] ([Id], [MaHD], [MaThuoc], [SoLuongMua], [DonGia]) VALUES (11, 7, N'T2', 1, 12000)
INSERT [dbo].[CTHD] ([Id], [MaHD], [MaThuoc], [SoLuongMua], [DonGia]) VALUES (14, 3, N'T1', 1, 10000)
SET IDENTITY_INSERT [dbo].[CTHD] OFF
SET IDENTITY_INSERT [dbo].[HoaDon] ON 

INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [MaNV]) VALUES (3, CAST(N'2021-08-08' AS Date), 151000, 4)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [MaNV]) VALUES (4, CAST(N'2021-08-08' AS Date), 4360090, 6)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [MaNV]) VALUES (6, CAST(N'2021-01-03' AS Date), 0, 6)
INSERT [dbo].[HoaDon] ([MaHD], [NgayLap], [TongTien], [MaNV]) VALUES (7, CAST(N'2021-01-03' AS Date), 54000, 6)
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [SDT], [Email], [MatKhau], [Role]) VALUES (4, N'Phan Tuấn', CAST(N'1999-06-12 00:00:00.000' AS DateTime), 902343263, N'tuan1@gmail.com', N'c4ca4238a0b923820dcc509a6f75849b', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [SDT], [Email], [MatKhau], [Role]) VALUES (5, N'Phan Tuấn 2', CAST(N'1999-06-12 00:00:00.000' AS DateTime), 123545, N'tuan2@gmail.com', N'202cb962ac59075b964b07152d234b70', 0)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [SDT], [Email], [MatKhau], [Role]) VALUES (6, N'ABC', CAST(N'2000-01-01 00:00:00.000' AS DateTime), 123, N'test', N'202cb962ac59075b964b07152d234b70', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [SDT], [Email], [MatKhau], [Role]) VALUES (15, N'abc1', CAST(N'2021-08-26 00:58:02.000' AS DateTime), 123, N'abc2@gmail.com', N'd41d8cd98f00b204e9800998ecf8427e', 0)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuong], [MoTa]) VALUES (N'T1', N'ThuocGiamDau1', 10000, 1000, N'ThuocGiamDau ')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuong], [MoTa]) VALUES (N'T2', N'ThuocGiamDau2', 12000, 150, N'ThuocGiamDau ')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuong], [MoTa]) VALUES (N'T3', N'Thuoc Đau bụng', 20000, 500, N'thuốc đau bụng')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuong], [MoTa]) VALUES (N'T4', N'Thuốc Ngủ 1', 30000, 1000, N'Thuốc ngủ')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuong], [MoTa]) VALUES (N'T5', N'ABC', 10000, 5, N'ABC')
INSERT [dbo].[Thuoc] ([MaThuoc], [TenThuoc], [DonGia], [SoLuong], [MoTa]) VALUES (N'T6', N'123', 123, 1, N'123')
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_HoaDon]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [FK_CTHD_Thuoc] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[Thuoc] ([MaThuoc])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [FK_CTHD_Thuoc]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
USE [master]
GO
ALTER DATABASE [QuanLyTiemThuoc] SET  READ_WRITE 
GO
