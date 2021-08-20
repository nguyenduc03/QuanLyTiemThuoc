USE [master]
GO
/****** Object:  Database [QuanLyTiemThuoc]    Script Date: 8/20/2021 10:22:46 AM ******/
CREATE DATABASE [QuanLyTiemThuoc]
 CONTAINMENT = NONE
 ON  PRIMARY 

 LOG ON 

 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyTiemThuoc] SET COMPATIBILITY_LEVEL = 150
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
ALTER DATABASE [QuanLyTiemThuoc] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyTiemThuoc] SET QUERY_STORE = OFF
GO
USE [QuanLyTiemThuoc]
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 8/20/2021 10:22:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD](
	[MaThuoc] [varchar](50) NOT NULL,
	[MaHD] [varchar](50) NOT NULL,
	[SoLuongMua] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 8/20/2021 10:22:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [varchar](50) NOT NULL,
	[NgayLap] [date] NULL,
	[TongTien] [bigint] NULL,
	[MaNV] [varchar](50) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiThuoc]    Script Date: 8/20/2021 10:22:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiThuoc](
	[MaLoai] [varchar](50) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
	[MoTa] [nvarchar](500) NULL,
 CONSTRAINT [PK_LoaiThuoc] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 8/20/2021 10:22:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[SDT] [int] NULL,
	[Email] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[Role] [bit] NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Thuoc]    Script Date: 8/20/2021 10:22:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuoc](
	[MaThuoc] [varchar](50) NOT NULL,
	[MaLoai] [varchar](50) NULL,
	[TenThuoc] [nvarchar](50) NULL,
	[DonGia] [int] NULL,
	[SoLuong] [int] NULL,
	[MoTa] [nvarchar](500) NULL,
 CONSTRAINT [PK_Thuoc] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [MoTa]) VALUES (N'DB', N'Đau Bụng', N'Thuốc đau bụng ')
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [MoTa]) VALUES (N'GD', N'Giảm Đau', N'Thuốc giảm đau')
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [MoTa]) VALUES (N'ND', N'Nhức Đầu', N'Thuốc nhức đầu')
INSERT [dbo].[LoaiThuoc] ([MaLoai], [TenLoai], [MoTa]) VALUES (N'TN', N'Thuốc Ngủ', N'Thuốc Ngủ')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [SDT], [Email], [MatKhau], [Role]) VALUES (N'1', N'Nguyễn Đức Tri', CAST(N'2001-03-07' AS Date), 835866056, N'nguyenductri@gmail.com', N'1', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [SDT], [Email], [MatKhau], [Role]) VALUES (N'2', N'Nguyễn Đức Tri1', CAST(N'2001-03-07' AS Date), 835866056, N'nguyenductri@gmail.com', N'1', 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [SDT], [Email], [MatKhau], [Role]) VALUES (N'3', N'Nguyễn Đức ', CAST(N'2001-03-07' AS Date), 835866056, N'nguyenductri@gmail.com', N'1', 0)
GO
INSERT [dbo].[Thuoc] ([MaThuoc], [MaLoai], [TenThuoc], [DonGia], [SoLuong], [MoTa]) VALUES (N'T1', N'GD', N'ThuocGiamDau1', 10000, 1000, N'ThuocGiamDau ')
INSERT [dbo].[Thuoc] ([MaThuoc], [MaLoai], [TenThuoc], [DonGia], [SoLuong], [MoTa]) VALUES (N'T2', N'GD', N'ThuocGiamDau2', 12000, 150, N'ThuocGiamDau ')
INSERT [dbo].[Thuoc] ([MaThuoc], [MaLoai], [TenThuoc], [DonGia], [SoLuong], [MoTa]) VALUES (N'T3', N'DB', N'Thuoc Đau bụng', 20000, 500, N'thuốc đau bụng')
INSERT [dbo].[Thuoc] ([MaThuoc], [MaLoai], [TenThuoc], [DonGia], [SoLuong], [MoTa]) VALUES (N'T4', N'TN', N'Thuốc Ngủ 1', 30000, 1000, N'Thuốc ngủ')
GO
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
ALTER TABLE [dbo].[Thuoc]  WITH CHECK ADD  CONSTRAINT [FK_Thuoc_LoaiThuoc] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiThuoc] ([MaLoai])
GO
ALTER TABLE [dbo].[Thuoc] CHECK CONSTRAINT [FK_Thuoc_LoaiThuoc]
GO
USE [master]
GO
ALTER DATABASE [QuanLyTiemThuoc] SET  READ_WRITE 
GO
