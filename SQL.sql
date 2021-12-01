USE [master]
GO
/****** Object:  Database [QL_BANHANG]    Script Date: 12/01/2021 14:04:10 ******/
CREATE DATABASE [QL_BANHANG] ON  PRIMARY 
( NAME = N'QL_BANHANG', FILENAME = N'e:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QL_BANHANG.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_BANHANG_log', FILENAME = N'e:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\QL_BANHANG_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QL_BANHANG] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_BANHANG].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_BANHANG] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [QL_BANHANG] SET ANSI_NULLS OFF
GO
ALTER DATABASE [QL_BANHANG] SET ANSI_PADDING OFF
GO
ALTER DATABASE [QL_BANHANG] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [QL_BANHANG] SET ARITHABORT OFF
GO
ALTER DATABASE [QL_BANHANG] SET AUTO_CLOSE ON
GO
ALTER DATABASE [QL_BANHANG] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [QL_BANHANG] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [QL_BANHANG] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [QL_BANHANG] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [QL_BANHANG] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [QL_BANHANG] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [QL_BANHANG] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [QL_BANHANG] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [QL_BANHANG] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [QL_BANHANG] SET  ENABLE_BROKER
GO
ALTER DATABASE [QL_BANHANG] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [QL_BANHANG] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [QL_BANHANG] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [QL_BANHANG] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [QL_BANHANG] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [QL_BANHANG] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [QL_BANHANG] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [QL_BANHANG] SET  READ_WRITE
GO
ALTER DATABASE [QL_BANHANG] SET RECOVERY SIMPLE
GO
ALTER DATABASE [QL_BANHANG] SET  MULTI_USER
GO
ALTER DATABASE [QL_BANHANG] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [QL_BANHANG] SET DB_CHAINING OFF
GO
USE [QL_BANHANG]
GO
/****** Object:  Table [dbo].[tbl_PhieuNhapChiTiet]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuNhapChiTiet](
	[ID_PN] [nvarchar](50) NOT NULL,
	[HANG] [nvarchar](50) NOT NULL,
	[SL] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_tbl_PhieuNhapChiTiet] PRIMARY KEY CLUSTERED 
(
	[ID_PN] ASC,
	[HANG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN110BA', N'H02', 14, 200000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN110BA', N'H04', 6, 400000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN110BA', N'H09', 9, 3333)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN12648YW', N'H09', 2, 3333)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN1614AY', N'H00', 6, 29000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN1614AY', N'H01', 7, 1000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN1614AY', N'H02', 4, 200000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN1614AY', N'H03', 6, 10000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN1614AY', N'H04', 77, 400000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN1614AY', N'H06', 6, 344000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN1614AY', N'H09', 5, 3333)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN1645AW', N'H01', 10, 33333)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN1645AW', N'H03', 21, 10000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN1645AW', N'H06', 666, 344000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN2610DV', N'H02', 16, 200000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN3129FD', N'H01', 666, 1000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN3235FG', N'H01', 44, 1000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN3235FG', N'H04', 97, 400000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN3243FF', N'H00', 7, 29000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN724MF', N'H01', 66, 1000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN724MF', N'H02', 7, 200000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN724MF', N'H03', 5, 10000)
INSERT [dbo].[tbl_PhieuNhapChiTiet] ([ID_PN], [HANG], [SL], [DonGia]) VALUES (N'PN7551NT', N'H02', 7, 200000)
/****** Object:  Table [dbo].[tbl_PhieuNhap]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuNhap](
	[IDPN] [nvarchar](50) NOT NULL,
	[TONGTIEN] [float] NULL,
	[NGAY] [date] NULL,
	[TrangThai] [int] NULL,
	[NguoiGiao] [nvarchar](50) NULL,
	[Sdt] [nvarchar](20) NULL,
	[MANCC] [nvarchar](50) NULL,
	[MANV] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[IDPN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt], [MANCC], [MANV]) VALUES (N'PN110BA', 5229997, CAST(0x43430B00 AS Date), 1, N'hehe', N'4', N'NCC001', N'NV001')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt], [MANCC], [MANV]) VALUES (N'PN12648YW', 6666, CAST(0x48430B00 AS Date), 0, N'Nhập hàng', N'Ko', N'NCC003', N'NV001')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt], [MANCC], [MANV]) VALUES (N'PN1614AY', 33921665, CAST(0x43430B00 AS Date), 0, N'THEANH9999', N'0000', N'NCC001', N'NV002')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt], [MANCC], [MANV]) VALUES (N'PN1645AW', 229647330, CAST(0x3C430B00 AS Date), 1, N'hehehe', N'69696969', N'NCC002', N'NV001')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt], [MANCC], [MANV]) VALUES (N'PN2610DV', 3200000, CAST(0x42430B00 AS Date), 0, N'dddd', N'0000000', N'NCC004', N'NV1244')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt], [MANCC], [MANV]) VALUES (N'PN3129FD', 666000, CAST(0x42430B00 AS Date), 1, N'888', N'8888888888', N'NCC001', N'NV001')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt], [MANCC], [MANV]) VALUES (N'PN3235FG', 38844000, CAST(0x39430B00 AS Date), 1, N'TheAnh28', N'45645', N'NCC001', N'NV002')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt], [MANCC], [MANV]) VALUES (N'PN3243FF', 203000, CAST(0x3D430B00 AS Date), 0, N'theeee', N'546456456', N'NCC003', N'NV001')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt], [MANCC], [MANV]) VALUES (N'PN724MF', 1516000, CAST(0x42430B00 AS Date), 1, N'9', N'0000000000', N'NCC003', N'NV1244')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt], [MANCC], [MANV]) VALUES (N'PN7551NT', 1400000, CAST(0x39430B00 AS Date), 0, N'NhanVien123', N'0000', N'NCC002', N'NV002')
/****** Object:  Table [dbo].[tbl_PhieuBanHang]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuBanHang](
	[IDPHIEU] [nvarchar](50) NOT NULL,
	[MAKH] [nvarchar](50) NULL,
	[NGAYLAP] [date] NULL,
	[MANV] [nvarchar](50) NULL,
	[TongTien] [float] NULL,
	[TrangThai] [int] NULL,
	[NGAYGIAO] [date] NULL,
 CONSTRAINT [PK_tbl_PhieuBanHang] PRIMARY KEY CLUSTERED 
(
	[IDPHIEU] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH11649VV', N'KH002', CAST(0x3E430B00 AS Date), N'NV002', 6944000, 1, CAST(0x41430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH12532XR', N'KH002', CAST(0x34430B00 AS Date), N'NV002', 3180000, 1, CAST(0x3E430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH1622BY', N'KH002', CAST(0x2F430B00 AS Date), N'NV001', 28400000, 1, CAST(0x3D430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH2134CA', N'KH001', CAST(0x2C420B00 AS Date), N'NV001', 11000000, 1, CAST(0x3D430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH2141CD', N'KH002', CAST(0x36430B00 AS Date), N'NV001', 0, 0, CAST(0x43430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH2443DO', N'KH002', CAST(0x3E430B00 AS Date), N'NV1244', 4000000, 1, CAST(0x46430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH3126FA', N'KH001', CAST(0x0E420B00 AS Date), N'NV1244', 13248000, 1, CAST(0x3E430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH5149JB', N'KH001', CAST(0x3D420B00 AS Date), N'NV001', 15262000, 1, CAST(0x3E430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH6319MI', N'KH002', CAST(0x2D420B00 AS Date), N'NV002', 6000, 1, CAST(0x3E430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH9124RA', N'KH002', CAST(0x3E430B00 AS Date), N'NV002', 1000000, 1, CAST(0x47430B00 AS Date))
/****** Object:  Table [dbo].[tbl_PhieuBanChiTiet]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuBanChiTiet](
	[ID_PB] [nvarchar](50) NOT NULL,
	[HANG] [nvarchar](50) NOT NULL,
	[SL] [int] NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_tbl_PhieuBanChiTiet_1] PRIMARY KEY CLUSTERED 
(
	[ID_PB] ASC,
	[HANG] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH11649VV', N'H00', 6, 29000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH11649VV', N'H01', 10, 1000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH11649VV', N'H02', 13, 200000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH11649VV', N'H03', 16, 10000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH11649VV', N'H04', 10, 400000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH12532XR', N'H00', 5, 29000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH12532XR', N'H01', 35, 1000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH12532XR', N'H02', 5, 200000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH12532XR', N'H04', 5, 400000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH1622BY', N'H02', 10, 200000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH1622BY', N'H04', 66, 400000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH2134CA', N'H02', 55, 200000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH2443DO', N'H04', 10, 400000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH3126FA', N'H01', 48, 1000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH3126FA', N'H02', 66, 200000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH5149JB', N'H01', 24, 1000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH5149JB', N'H03', 79, 10000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH5149JB', N'H06', 42, 344000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH6319MI', N'H01', 6, 1000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH9124RA', N'H02', 5, 200000)
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhanVien](
	[manv] [nvarchar](50) NOT NULL,
	[tennv] [nvarchar](50) NULL,
	[diachi] [nvarchar](500) NULL,
	[sdt] [nvarchar](11) NULL,
	[CMND] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_NhanVien] PRIMARY KEY CLUSTERED 
(
	[manv] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV001', N'Nhân viên q', N'BG', N'1234', N'22222')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV002', N'Nam', N'BN', N'095645', N'345453')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV003', N'Trần Bình Trọng', NULL, N'0973888536 ', N'9484739920          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV004', N'Nguyễn Thị Nga', NULL, N'0981231236 ', N'8482930284          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV005', N'Trần Minh Nghĩa', NULL, N'0859406784 ', N'4989380380          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV006', N'Vũ Thị Thanh Hương', NULL, N'0913213210 ', N'8937920028          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV007', N'Lê Thị Cúc', NULL, N'03772235772', N'4989303048          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV008', N'Nguyễn Hữu An', NULL, N'0377981234 ', N'8349497590          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV009', N'Mai Minh Mẫn', NULL, N'0762550679 ', N'9937589300          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV010', N'Lưu Vũ Thu Hà', NULL, N'0874469932 ', N'8759030394          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV011', N'Trương Minh Xuân', NULL, N'0938799745 ', N'8493838003          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV012', N'Nguyễn Thu Hương', NULL, N'0377932832 ', N'9497573890          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV013', N'Nguyễn Qui Khanh ', NULL, N'03779888872', N'5975930003          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV014', N'Nguyễn Hương Huy ', NULL, N'0377928803 ', N'4983803383          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV015', N'Nguyễn  Thanh ', N'218 Long Thành, Xuân Phú, tỉnh Bến Tre', N'0377985772 ', N'9893830320          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV016', N'Đỗ Huỳnh Nga', N'160 Lê Văn Sỹ, phường 10, quận Phú Nhuận, TP.HCM', N'0979816989 ', N'8493989303          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV017', N'Phạm Nguyên Phú', N'287 Hàng Gòn, TP.Long Khánh, tỉnh Đồng Nai', N'0938935096 ', N'9497593022          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV018', N'Võ Minh', N'223 Nguyễn Huệ, phường Mỹ Tây, quận 12, TP.HCM', N'098789789  ', N'8484930202          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV019', N'Nguyễn Thụy ', N'119 Lương Thế Vinh, Nam Từ Liêm, Hà Nội', N'0948928291 ', N'4937898290          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV020', N'Đinh  Thanh Vinh ', N'289 Trần Phú, quận Hà Đông, TP. Hà Nội', N'092987987  ', N'7349394030          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV021', N'Trần Anh Tuấn', N'270 Nguyễn Thị Định, Phường Nguyễn Văn Cừ, TP.Quy Nhơn, Tỉnh Bình Định', N'0377985772 ', N'2930891003          ')
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV022', N'Thái Bá Đông', N'120 Nguyễn Hồng Đào, phường 14, quận Tân Bình, TP.HCM ', N'0385892239 ', NULL)
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'NV1244', N'TheAnh', N'HN', N'23423', N'1233333')
/****** Object:  Table [dbo].[tbl_NhaCungCap]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhaCungCap](
	[mancc] [nvarchar](50) NOT NULL,
	[TENNCC] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](500) NULL,
	[SDT] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[mancc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_NhaCungCap] ([mancc], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC001', N'Not', N'HN', N'123')
INSERT [dbo].[tbl_NhaCungCap] ([mancc], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC002', N'NC002', N'A', N'333')
INSERT [dbo].[tbl_NhaCungCap] ([mancc], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC003', N'Abc', N'LA', N'444444')
INSERT [dbo].[tbl_NhaCungCap] ([mancc], [TENNCC], [DIACHI], [SDT]) VALUES (N'NCC004', N'AAA', N'BG', N'34535')
/****** Object:  Table [dbo].[tbl_nguoidung]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_nguoidung](
	[MANV] [nvarchar](50) NOT NULL,
	[TENDANGNHAP] [nvarchar](50) NOT NULL,
	[MATKHAU] [nvarchar](50) NULL,
	[PHANQUYEN] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_nguoidung_1] PRIMARY KEY CLUSTERED 
(
	[TENDANGNHAP] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_nguoidung] ([MANV], [TENDANGNHAP], [MATKHAU], [PHANQUYEN]) VALUES (N'NV001', N'admin', N'admin', N'ADMIN')
/****** Object:  Table [dbo].[tbl_Loai]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Loai](
	[Ma] [nvarchar](50) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_LoaiThe] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_Loai] ([Ma], [TenLoai]) VALUES (N'L1', N'Loại 1')
INSERT [dbo].[tbl_Loai] ([Ma], [TenLoai]) VALUES (N'L2', N'Loai 2')
INSERT [dbo].[tbl_Loai] ([Ma], [TenLoai]) VALUES (N'LH001', N'Điện Thoại')
INSERT [dbo].[tbl_Loai] ([Ma], [TenLoai]) VALUES (N'LH002', N'LapTop')
INSERT [dbo].[tbl_Loai] ([Ma], [TenLoai]) VALUES (N'LH003', N'PC')
INSERT [dbo].[tbl_Loai] ([Ma], [TenLoai]) VALUES (N'LH004', N'Linh kiện')
INSERT [dbo].[tbl_Loai] ([Ma], [TenLoai]) VALUES (N'LH005', N'Phụ kiện')
/****** Object:  Table [dbo].[tbl_KhachHang]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KhachHang](
	[makh] [nvarchar](50) NOT NULL,
	[tenkh] [nvarchar](50) NULL,
	[gioitinh] [int] NULL,
	[ngaysinh] [date] NULL,
	[diachi] [nvarchar](500) NULL,
	[sdt] [nvarchar](50) NULL,
	[stk] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbl_KhachHang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH001', N'Khách hàng 1', 0, CAST(0xB9330B00 AS Date), N'477/85A Nguyễn Thái Học, Phường Nguyễn Văn Cừ, TP.Quy Nhơn, Tỉnh Bình Định', N'0973675899          ', N'1234444')
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH002', N'Khách 2', 1, CAST(0xFE410B00 AS Date), N'66 Phạm Hùng, Phường Lý Thường Kiệt, TP. Quy Nhơn, Tỉnh Bình Định', N'0938286493          ', N'2334234')
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH003', N'Hà Thị Thu', NULL, CAST(0x0D240B00 AS Date), N'46/3 đường số 17, phường Hiệp Bình Chánh, Quận Thủ Đức, Tp.HCM', N'0123789789          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH004', N'Trần Văn Sang', NULL, CAST(0x69210B00 AS Date), N'21 Lý Thái tổ, Phường EATam, Thành phố Buôn Ma Thuột, Đăk Lăk  ', N'0949345988          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH005', N'Đàm Thị Hằng', NULL, CAST(0x56230B00 AS Date), N'455 Kha Vạn Cân, phường Bình Thọ, thành phố Thủ Đức', N'0948377389          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH006', N'Trần Trọng Nghĩa', NULL, CAST(0xDF870A00 AS Date), N'344 Trần Chiêu, Quận 1, TP.HCM', N'0830329321          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH007', N'Nguyễn Bá Lộc', NULL, CAST(0x76240B00 AS Date), N'998 Phạm Ngũ Lão, phường 8, quận 5, TP.HCM', N'0947922903          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH008', N'Phạm Thị Ngừng', NULL, CAST(0xD9290B00 AS Date), N'160 Lê Văn Sỹ, phường 10, quận Phú Nhuận, TP.HCM', N'0937927298          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH009', N'Đinh Xuân Thọ', NULL, CAST(0x6A1D0B00 AS Date), N'223 Nguyễn Huệ, phường Mỹ Tây, quận 12, TP.HCM', N'0972893928          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH010', N'Nguyễn Viết Xuân', NULL, CAST(0xD7110B00 AS Date), N'120 Nguyễn Hồng Đào, phường 14, quận Tân Bình, TP.HCM ', N'0948933022          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH011', N'Trần Đình Trọng', NULL, CAST(0x03200B00 AS Date), N'119 Lương Thế Vinh, Nam Từ Liêm, Hà Nội', N'0932099320          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH012', N'Đào Thúy Hạnh', NULL, CAST(0x51260B00 AS Date), N'289 Trần Phú, quận Hà Đông, TP. Hà Nội', N'0893220911          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH013', N'Lê Thanh Hoài', NULL, CAST(0x321A0B00 AS Date), N'Xã Mỹ Yên, huyện Bến Lức, tỉnh Long An', N'0830229033          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH014', N'Lê Thái An', NULL, CAST(0x961E0B00 AS Date), N'218 Long Trạch, Cần Giờ, tỉnh Bến Tre', N'0928939207          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH015', N'Trần Triệu Vy', NULL, CAST(0x431C0B00 AS Date), N'28 Thạch Hà, huyện Thạch Trị, tỉnh Hà Tĩnh', N'0830922093          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH016', N'Hồ Huyền Thoại', NULL, CAST(0x70210B00 AS Date), N'189 Bắc Sơn, quận Cẩm Lệ, TP.Đà Nẵng ', N'0930392034          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH017', N'Đào Xuân Hiếu', NULL, CAST(0x431C0B00 AS Date), N'327 Trần Cao Vân, quận Thạch Khê, TP.Đà Nẵng', N'0930200390          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH018', N'Đinh Trí An ', NULL, CAST(0x5E210B00 AS Date), N'34 Quỳnh Hồng, huyện Quỳnh Phụ, tỉnh Thái Bình', N'0392090930          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH019', N'Lê Trí Dũng', NULL, CAST(0xE91F0B00 AS Date), N'287 Hàng Gòn, TP.Long Khánh, tỉnh Đồng Nai', N'0938291799          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH020', N'Cao Anh Minh', NULL, CAST(0xB3250B00 AS Date), N'378 Điện Biên Phủ, phường Long Khánh, thị xã Buôn Hồ, tỉnh Đăk Lăk', N'0920339029          ', NULL)
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [gioitinh], [ngaysinh], [diachi], [sdt], [stk]) VALUES (N'KH021', N'Trần Trí Cường', NULL, CAST(0x4A240B00 AS Date), N'477/85A Nguyễn Thái Học, Phường Nguyễn Văn Cừ, TP.Quy Nhơn, Tỉnh Bình Định', N'0948292891', NULL)
/****** Object:  Table [dbo].[tbl_HoaDonNhap]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HoaDonNhap](
	[Id] [nvarchar](50) NOT NULL,
	[Ngay] [date] NULL,
	[mancc] [nvarchar](50) NULL,
	[manv] [nvarchar](50) NOT NULL,
	[chungtu] [nvarchar](50) NULL,
	[nguoigiao] [nvarchar](50) NULL,
	[sdt] [nvarchar](20) NULL,
	[tongtien] [float] NULL,
	[trangthai] [int] NOT NULL,
	[loai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_HoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_HoaDonNhap] ([Id], [Ngay], [mancc], [manv], [chungtu], [nguoigiao], [sdt], [tongtien], [trangthai], [loai]) VALUES (N'dfdf', CAST(0x1E420B00 AS Date), N'NCC002', N'NV002', N' ', N'7ffg', N'00', 160000, 1, N'Thu')
INSERT [dbo].[tbl_HoaDonNhap] ([Id], [Ngay], [mancc], [manv], [chungtu], [nguoigiao], [sdt], [tongtien], [trangthai], [loai]) VALUES (N'hd3rws', CAST(0x1D420B00 AS Date), N'NCC001', N'NV001', N' ', N'5555', N'000', 0, 1, N'Thu')
INSERT [dbo].[tbl_HoaDonNhap] ([Id], [Ngay], [mancc], [manv], [chungtu], [nguoigiao], [sdt], [tongtien], [trangthai], [loai]) VALUES (N'HDN1050TS', CAST(0x39430B00 AS Date), N'NCC001', N'NV002', N'PN3235FG', N'TheAnh28', N'45645', 38844000, 1, N'Thu')
INSERT [dbo].[tbl_HoaDonNhap] ([Id], [Ngay], [mancc], [manv], [chungtu], [nguoigiao], [sdt], [tongtien], [trangthai], [loai]) VALUES (N'HDN2239CG', CAST(0x43430B00 AS Date), N'NCC002', N'NV001', N'PN110BA', NULL, NULL, 5229997, 1, N'Thu')
INSERT [dbo].[tbl_HoaDonNhap] ([Id], [Ngay], [mancc], [manv], [chungtu], [nguoigiao], [sdt], [tongtien], [trangthai], [loai]) VALUES (N'HDN4324GL', CAST(0x42430B00 AS Date), N'NCC001', N'NV001', N'PN3129FD', N'888', N'8888888888', 666000, 1, N'Thu')
INSERT [dbo].[tbl_HoaDonNhap] ([Id], [Ngay], [mancc], [manv], [chungtu], [nguoigiao], [sdt], [tongtien], [trangthai], [loai]) VALUES (N'HDN4512HS', CAST(0x44430B00 AS Date), N'NCC003', N'NV1244', N'', N'theaaaaaaaaaaaaaaa', N'0000000000000', 16000, 0, N'Thu')
INSERT [dbo].[tbl_HoaDonNhap] ([Id], [Ngay], [mancc], [manv], [chungtu], [nguoigiao], [sdt], [tongtien], [trangthai], [loai]) VALUES (N'HDN5116KB', CAST(0x42430B00 AS Date), N'NCC003', N'NV1244', N'PN724MF', N'9', N'0000000000', 1516000, 1, N'Thu')
INSERT [dbo].[tbl_HoaDonNhap] ([Id], [Ngay], [mancc], [manv], [chungtu], [nguoigiao], [sdt], [tongtien], [trangthai], [loai]) VALUES (N'HDN738MJ', CAST(0x3C430B00 AS Date), N'NCC002', N'NV001', N'PN1645AW', NULL, NULL, 229647328, 1, N'Thu')
INSERT [dbo].[tbl_HoaDonNhap] ([Id], [Ngay], [mancc], [manv], [chungtu], [nguoigiao], [sdt], [tongtien], [trangthai], [loai]) VALUES (N'HDN8421PO', CAST(0x44430B00 AS Date), N'NCC003', N'NV001', N'', N'xxxx', N'555', 10000, 1, N'Thu')
/****** Object:  Table [dbo].[tbl_HoaDonBan]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HoaDonBan](
	[Id] [nvarchar](50) NOT NULL,
	[Ngay] [date] NULL,
	[makh] [nvarchar](50) NOT NULL,
	[manv] [nvarchar](50) NOT NULL,
	[phuongthuc] [nvarchar](50) NULL,
	[stk] [nvarchar](20) NULL,
	[chungtu] [nvarchar](50) NULL,
	[tongtien] [float] NULL,
	[danhan] [float] NULL,
	[trangthai] [int] NOT NULL,
	[loai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_HoaDon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_HoaDonBan] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai], [loai]) VALUES (N'HD1037UK', CAST(0x42430B00 AS Date), N'KH001', N'NV001', N'Tiền mặt', N'', N'DH5149JB', 15262000, 666666880, 0, N'Chi')
INSERT [dbo].[tbl_HoaDonBan] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai], [loai]) VALUES (N'HD11249WH', CAST(0x3E430B00 AS Date), N'KH001', N'nv1244', N'Tiền mặt', N'', N'DH1622BY', 28400000, 345345344, 1, N'Chi')
INSERT [dbo].[tbl_HoaDonBan] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai], [loai]) VALUES (N'HD12626YX', CAST(0x41430B00 AS Date), N'KH001', N'NV002', N'Thẻ', N'1234444', N'DH12532XR', 3180000, 0, 1, N'Chi')
INSERT [dbo].[tbl_HoaDonBan] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai], [loai]) VALUES (N'HD12639YV', CAST(0x41430B00 AS Date), N'KH002', N'NV002', N'Tiền mặt', N'2334234', N'DH6319MI', 6000, 0, 1, N'Chi')
INSERT [dbo].[tbl_HoaDonBan] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai], [loai]) VALUES (N'HD2521DT', CAST(0x41430B00 AS Date), N'KH002', N'nv1244', N'Tiền mặt', N'2334234', N'DH2443DO', 4000000, 0, 1, N'Chi')
INSERT [dbo].[tbl_HoaDonBan] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai], [loai]) VALUES (N'HD3127EA', CAST(0x3F430B00 AS Date), N'KH001', N'NV001', N'Tiền mặt', N'', N'', 22000000, 77777, 1, N'Chi')
INSERT [dbo].[tbl_HoaDonBan] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai], [loai]) VALUES (N'HD5338KJ', CAST(0x40430B00 AS Date), N'KH002', N'NV002', N'Tiền mặt', N'2334234', N'DH11649VV', 6944000, 666, 1, N'Chi')
INSERT [dbo].[tbl_HoaDonBan] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai], [loai]) VALUES (N'HD5447IO', CAST(0x40430B00 AS Date), N'KH001', N'nv1244', N'Thẻ', N'1234444', N'', 4010000, 0, 1, N'Chi')
INSERT [dbo].[tbl_HoaDonBan] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai], [loai]) VALUES (N'HD8435OQ', CAST(0x40430B00 AS Date), N'KH002', N'nv1244', N'Tiền mặt', N'', N'', 775000, 666, 0, N'Chi')
INSERT [dbo].[tbl_HoaDonBan] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai], [loai]) VALUES (N'HD9215SG', CAST(0x41430B00 AS Date), N'KH002', N'nv1244', N'Tiền mặt', N'2334234', N'DH2443DO', 4000000, 0, 0, N'Chi')
INSERT [dbo].[tbl_HoaDonBan] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai], [loai]) VALUES (N'HDB1249XM', CAST(0x43430B00 AS Date), N'KH002', N'NV002', N'Tiền mặt', N'', N'DH9124RA', 1000000, 456456448, 1, N'Chi')
/****** Object:  Table [dbo].[tbl_HANG]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HANG](
	[Ma] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[DVT] [nvarchar](50) NULL,
	[LOAI] [nvarchar](50) NULL,
	[DONGIANHAP] [float] NOT NULL,
	[Soluong] [int] NOT NULL,
	[DONGIABAN] [float] NOT NULL,
	[Mausac] [nvarchar](50) NULL,
	[Mota] [nvarchar](50) NULL,
	[Chietkhau] [float] NOT NULL,
	[Thue] [float] NOT NULL,
	[Anh] [nvarchar](50) NULL,
	[Trangthai] [int] NOT NULL,
 CONSTRAINT [PK_tbl_The] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'Acer515', N'Acer Nitro Gaming AN515-57-74NU/i7-11800H', N'1', N'L1', 1999, 100, 99999, N'no', N'no', 0, 5, N'', 0)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'AsusA515', N'Asus Vivobook A515EA-L11970T/i5-1135G7
', N'1', N'LH002', 19997, 100, 99999, N'no', N'no', 69, 5, NULL, 0)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'CardPH', N'Card đồ họa Asus PH GT 1030 O2G
', N'1', N'LH001', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'CPUAR3', N'CPU Desktop AMD Ryzen 3 3200G
', N'1', N'LH001', 1999, 100, 99999, N'no', N'Hehee', 0, 5, NULL, 0)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'CPUAR56', N'CPU Desktop AMD Ryzen 5 5600X
', N'1', N'LH001', 1999, 100, 99999, N'no', N'no', 0, 5, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'DellN35', N'Dell Inspiron N3511 i3 1115G4', N'1', N'LH002', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'DellV35', N'Dell Vostro V3500 i3 1115G4', N'1', N'LH002', 1999, 100, 99999, N'no', N'no', 0, 10, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'H00', N'Sản phẩm 222', N'1', N'L1', 1999, 100, 99999, N'no', N'no', 0, 10, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'H01', N'ABC', N'1', N'L1', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'H02', N'Asus TP500LN-DN126H Silver', N'1', N'L1', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'H03', N'Vải lụa', N'2', N'L1', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'H04', N'Máy Tính', N'3', N'L1', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'H06', N'Tủ', N'2', N'L2', 1999, 100, 99999, N'no', N'no', 0, 10, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'H09', N'Máy', N'3', N'L2', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'HPE13', N'HP Envy 13 ba1535TU i7 1165G7/4U6M4PA
', N'2', N'LH002', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'HPTP01', N'Máy tính để bàn HP Pavilion TP01 2003d i5 ', N'1', N'LH003', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'iMac27', N'iMac 272020 Retina 5K 3.1GHz Core i5 256GB ', N'2', N'LH003', 1999, 100, 99999, N'no', N'no', 0, 10, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'iphone11', N'iPhone 11 64GB
', N'1', N'LH001', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'iphone13', N'iPhone 13 Pro Max 128GB
', N'1', N'LH001', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'LeIC', N'Máy tính All in one Lenovo IdeaCentre AIO 3 24IIL5', N'3', N'LH003', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'LeThink14', N'Lenovo ThinkBook 14 G3 ACL R7 5700U/21A2004BVN
', N'1', N'LH002', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'OppoA95', N'OPPO A95 8GB-128GB
', N'1', N'LH001', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'RAMD24', N'RAM Corsair cho laptop 8GB DDR4 2400MHz 1x260 ', N'1', N'LH001', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'SGZF3', N'Samsung Galaxy Z Fold3 5G 256GB', N'1', N'LH001', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'SP4647HV', N'Sản ph123', N'0', N'L1', 234, 0, 4234234, N'Đen', N'', 0, 0, NULL, 0)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'SP932QK', N'Hehehe', N'1', N'LH001', 0, 0, 0, N'', N'', 0, 5, NULL, 0)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'vivoV23', N'Vivo V23e 8GB - 128GB
', N'1', N'LH001', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'WDSSD', N'Ổ cứng WD SSD 240GB SN350 NVME Green
', N'1', N'LH001', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIANHAP], [Soluong], [DONGIABAN], [Mausac], [Mota], [Chietkhau], [Thue], [Anh], [Trangthai]) VALUES (N'XiaomiX3', N'Xiaomi POCO X3 Pro NFC 8GB-256GB', N'1', N'LH001', 1999, 100, 99999, N'no', N'no', 0, 0, N'', 1)
/****** Object:  Table [dbo].[tbl_DVT]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DVT](
	[ID] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_MenhGia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_DVT] ([ID], [Ten]) VALUES (N'0', N'Bộ')
INSERT [dbo].[tbl_DVT] ([ID], [Ten]) VALUES (N'1', N'Cái')
INSERT [dbo].[tbl_DVT] ([ID], [Ten]) VALUES (N'2', N'Cân')
INSERT [dbo].[tbl_DVT] ([ID], [Ten]) VALUES (N'3', N'Chiếc')
INSERT [dbo].[tbl_DVT] ([ID], [Ten]) VALUES (N'4', N'Mét')
/****** Object:  Table [dbo].[tbl_ChiTietHoaDonNhap]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiTietHoaDonNhap](
	[Id_hd] [nvarchar](50) NOT NULL,
	[masp] [nvarchar](50) NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_tbl_ChiTietHoaDonNhap] PRIMARY KEY CLUSTERED 
(
	[Id_hd] ASC,
	[masp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_ChiTietHoaDonNhap] ([Id_hd], [masp], [soluong]) VALUES (N'dfdf', N'H03', 16)
INSERT [dbo].[tbl_ChiTietHoaDonNhap] ([Id_hd], [masp], [soluong]) VALUES (N'HDN4512HS', N'H01', 16)
INSERT [dbo].[tbl_ChiTietHoaDonNhap] ([Id_hd], [masp], [soluong]) VALUES (N'HDN8421PO', N'H01', 10)
/****** Object:  Table [dbo].[tbl_ChiTietHoaDonBan]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiTietHoaDonBan](
	[Id_hd] [nvarchar](50) NOT NULL,
	[masp] [nvarchar](50) NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [PK_tbl_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[Id_hd] ASC,
	[masp] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_ChiTietHoaDonBan] ([Id_hd], [masp], [soluong]) VALUES (N'HD3127EA', N'H02', 110)
INSERT [dbo].[tbl_ChiTietHoaDonBan] ([Id_hd], [masp], [soluong]) VALUES (N'HD3127EA', N'H03', 5)
INSERT [dbo].[tbl_ChiTietHoaDonBan] ([Id_hd], [masp], [soluong]) VALUES (N'HD5447IO', N'H01', 10)
INSERT [dbo].[tbl_ChiTietHoaDonBan] ([Id_hd], [masp], [soluong]) VALUES (N'HD5447IO', N'H02', 8)
INSERT [dbo].[tbl_ChiTietHoaDonBan] ([Id_hd], [masp], [soluong]) VALUES (N'HD5447IO', N'H04', 10)
INSERT [dbo].[tbl_ChiTietHoaDonBan] ([Id_hd], [masp], [soluong]) VALUES (N'HD8435OQ', N'H00', 25)
INSERT [dbo].[tbl_ChiTietHoaDonBan] ([Id_hd], [masp], [soluong]) VALUES (N'HD8435OQ', N'H03', 5)
/****** Object:  Table [dbo].[tbl_ChiTietBaoGia]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiTietBaoGia](
	[mabaogia] [nvarchar](50) NOT NULL,
	[masp] [nvarchar](50) NOT NULL,
	[soluong] [int] NULL,
	[dongia] [float] NULL,
	[thanhtien] [float] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG002', N'H01', 10, 1000, 10000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG004', N'H02', 55, 200000, 11000000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG003', N'H03', 54, 10000, 540000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG003', N'H01', 60, 1000, 60000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG11427UN', N'H04', 444, 400000, 17600000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG004', N'H03', 4011, 10000, 330000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG004', N'H00', 300, 29000, 8700000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG005', N'H02', 777, 200000, 155400000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG005', N'H04', 8, 400000, 3200000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG1329BI', N'H01', 16, 1000, 8000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG002', N'H01', 10, 1000, 10000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG004', N'H02', 55, 200000, 11000000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG003', N'H03', 54, 10000, 540000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG003', N'H01', 60, 1000, 60000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG11427UN', N'H04', 444, 400000, 17600000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG004', N'H03', 4011, 10000, 330000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG004', N'H00', 300, 29000, 8700000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG005', N'H02', 777, 200000, 155400000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG005', N'H04', 8, 400000, 3200000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG1329BI', N'H01', 16, 1000, 8000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG002', N'H01', 10, 1000, 10000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG004', N'H02', 55, 200000, 11000000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG003', N'H03', 54, 10000, 540000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG003', N'H01', 60, 1000, 60000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG11427UN', N'H04', 444, 400000, 17600000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG004', N'H03', 4011, 10000, 330000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG004', N'H00', 300, 29000, 8700000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG005', N'H02', 777, 200000, 155400000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG005', N'H04', 8, 400000, 3200000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG1329BI', N'H01', 16, 1000, 8000)
/****** Object:  Table [dbo].[tbl_BaoGia]    Script Date: 12/01/2021 14:04:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_BaoGia](
	[mabaogia] [nvarchar](50) NOT NULL,
	[ngay] [date] NULL,
	[hieuluc] [date] NULL,
	[manv] [nvarchar](50) NOT NULL,
	[makh] [nvarchar](50) NOT NULL,
	[ghichu] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbl_BaoGia] PRIMARY KEY CLUSTERED 
(
	[mabaogia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_BaoGia] ([mabaogia], [ngay], [hieuluc], [manv], [makh], [ghichu]) VALUES (N'BG004', CAST(0x3C430B00 AS Date), CAST(0x6A430B00 AS Date), N'NV001', N'KH002', N'ghi chú')
INSERT [dbo].[tbl_BaoGia] ([mabaogia], [ngay], [hieuluc], [manv], [makh], [ghichu]) VALUES (N'BG005', CAST(0x02430B00 AS Date), CAST(0x37430B00 AS Date), N'NV001', N'KH001', N'ghi chú')
INSERT [dbo].[tbl_BaoGia] ([mabaogia], [ngay], [hieuluc], [manv], [makh], [ghichu]) VALUES (N'BG11427UN', CAST(0xF9160B00 AS Date), CAST(0x3D430B00 AS Date), N'NV001', N'KH002', N'theanh18')
INSERT [dbo].[tbl_BaoGia] ([mabaogia], [ngay], [hieuluc], [manv], [makh], [ghichu]) VALUES (N'BG1329BI', CAST(0x56140B00 AS Date), CAST(0x3D430B00 AS Date), N'NV001', N'KH002', N'Hihihihih')
INSERT [dbo].[tbl_BaoGia] ([mabaogia], [ngay], [hieuluc], [manv], [makh], [ghichu]) VALUES (N'BG7633OY', CAST(0x3D430B00 AS Date), CAST(0x3D430B00 AS Date), N'NV001', N'KH002', N'')
INSERT [dbo].[tbl_BaoGia] ([mabaogia], [ngay], [hieuluc], [manv], [makh], [ghichu]) VALUES (N'BG8132PA', CAST(0xFE410B00 AS Date), CAST(0x7A430B00 AS Date), N'NV001', N'KH002', N'')
INSERT [dbo].[tbl_BaoGia] ([mabaogia], [ngay], [hieuluc], [manv], [makh], [ghichu]) VALUES (N'PB11610VW', CAST(0x3C430B00 AS Date), CAST(0x3C430B00 AS Date), N'nv1244', N'KH001', N'hihihihi')
/****** Object:  Default [DF_tbl_HoaDonNhap_loai]    Script Date: 12/01/2021 14:04:11 ******/
ALTER TABLE [dbo].[tbl_HoaDonNhap] ADD  CONSTRAINT [DF_tbl_HoaDonNhap_loai]  DEFAULT (N'Thu') FOR [loai]
GO
/****** Object:  Default [DF_tbl_HoaDonBan_loai]    Script Date: 12/01/2021 14:04:11 ******/
ALTER TABLE [dbo].[tbl_HoaDonBan] ADD  CONSTRAINT [DF_tbl_HoaDonBan_loai]  DEFAULT (N'Chi') FOR [loai]
GO
/****** Object:  Default [DF_tbl_HANG_DONGIANHAP]    Script Date: 12/01/2021 14:04:11 ******/
ALTER TABLE [dbo].[tbl_HANG] ADD  CONSTRAINT [DF_tbl_HANG_DONGIANHAP]  DEFAULT ((0)) FOR [DONGIANHAP]
GO
/****** Object:  Default [DF_tbl_HANG_Soluong]    Script Date: 12/01/2021 14:04:11 ******/
ALTER TABLE [dbo].[tbl_HANG] ADD  CONSTRAINT [DF_tbl_HANG_Soluong]  DEFAULT ((0)) FOR [Soluong]
GO
/****** Object:  Default [DF_tbl_HANG_DONGIABAN]    Script Date: 12/01/2021 14:04:11 ******/
ALTER TABLE [dbo].[tbl_HANG] ADD  CONSTRAINT [DF_tbl_HANG_DONGIABAN]  DEFAULT ((0)) FOR [DONGIABAN]
GO
/****** Object:  Default [DF_tbl_HANG_Chietkhau]    Script Date: 12/01/2021 14:04:11 ******/
ALTER TABLE [dbo].[tbl_HANG] ADD  CONSTRAINT [DF_tbl_HANG_Chietkhau]  DEFAULT ((0)) FOR [Chietkhau]
GO
/****** Object:  Default [DF_tbl_HANG_Thue]    Script Date: 12/01/2021 14:04:11 ******/
ALTER TABLE [dbo].[tbl_HANG] ADD  CONSTRAINT [DF_tbl_HANG_Thue]  DEFAULT ((0)) FOR [Thue]
GO
/****** Object:  Default [DF_tbl_HANG_Trangthai]    Script Date: 12/01/2021 14:04:11 ******/
ALTER TABLE [dbo].[tbl_HANG] ADD  CONSTRAINT [DF_tbl_HANG_Trangthai]  DEFAULT ((1)) FOR [Trangthai]
GO
