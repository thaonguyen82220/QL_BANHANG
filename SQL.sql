USE [master]
GO
/****** Object:  Database [QL_BANHANG]    Script Date: 11/19/2021 23:54:38 ******/
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
/****** Object:  Table [dbo].[tbl_Loai]    Script Date: 11/19/2021 23:54:39 ******/
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
/****** Object:  Table [dbo].[tbl_KhachHang]    Script Date: 11/19/2021 23:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KhachHang](
	[makh] [nvarchar](50) NOT NULL,
	[tenkh] [nvarchar](50) NULL,
	[diachi] [nvarchar](500) NULL,
	[sdt] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [int] NULL,
	[stk] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbl_KhachHang] PRIMARY KEY CLUSTERED 
(
	[makh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh], [stk]) VALUES (N'KH001', N'Khách hàng 1', N'HN', N'012345', CAST(0xB9330B00 AS Date), 0, N'1234444')
INSERT [dbo].[tbl_KhachHang] ([makh], [tenkh], [diachi], [sdt], [ngaysinh], [gioitinh], [stk]) VALUES (N'KH002', N'Khách 2', N'BG', N'22222', CAST(0xFE410B00 AS Date), 1, N'2334234')
/****** Object:  Table [dbo].[tbl_HoaDon]    Script Date: 11/19/2021 23:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HoaDon](
	[Id] [nvarchar](50) NOT NULL,
	[Ngay] [date] NULL,
	[makh] [nvarchar](50) NOT NULL,
	[manv] [nvarchar](50) NOT NULL,
	[phuongthuc] [nvarchar](50) NULL,
	[stk] [nvarchar](20) NULL,
	[chungtu] [nvarchar](50) NULL,
	[tongtien] [float] NULL,
	[danhan] [float] NULL,
	[trangthai] [int] NULL,
 CONSTRAINT [PK_tbl_HoaDon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_HoaDon] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai]) VALUES (N'HD1037UK', CAST(0x3E430B00 AS Date), N'KH001', N'NV001', N'Thẻ', N'1234444', N'DH5149JB', 40000, 30000, 0)
INSERT [dbo].[tbl_HoaDon] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai]) VALUES (N'HD11249WH', CAST(0x3E430B00 AS Date), N'KH001', N'nv1244', N'Tiền mặt', N'', N'DH1622BY', 28400000, 7777, 1)
INSERT [dbo].[tbl_HoaDon] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai]) VALUES (N'HD3127EA', CAST(0x3F430B00 AS Date), N'KH001', N'NV001', N'Tiền mặt', N'', N'', 22000000, 77777, 0)
INSERT [dbo].[tbl_HoaDon] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai]) VALUES (N'HD5338KJ', CAST(0x40430B00 AS Date), N'KH002', N'NV002', N'Tiền mặt', N'2334234', N'DH11649VV', 6844000, 666, 1)
INSERT [dbo].[tbl_HoaDon] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai]) VALUES (N'HD5447IO', CAST(0x40430B00 AS Date), N'KH001', N'nv1244', N'Thẻ', N'1234444', N'', 4010000, 0, 1)
INSERT [dbo].[tbl_HoaDon] ([Id], [Ngay], [makh], [manv], [phuongthuc], [stk], [chungtu], [tongtien], [danhan], [trangthai]) VALUES (N'HD8435OQ', CAST(0x40430B00 AS Date), N'KH002', N'nv1244', N'Tiền mặt', N'', N'', 775000, 666, 0)
/****** Object:  Table [dbo].[tbl_ChiTietBaoGia]    Script Date: 11/19/2021 23:54:39 ******/
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
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG004', N'H03', 3999, 10000, 330000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG004', N'H00', 300, 29000, 8700000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG005', N'H02', 777, 200000, 155400000)
INSERT [dbo].[tbl_ChiTietBaoGia] ([mabaogia], [masp], [soluong], [dongia], [thanhtien]) VALUES (N'BG005', N'H04', 8, 400000, 3200000)
/****** Object:  Table [dbo].[tbl_BaoGia]    Script Date: 11/19/2021 23:54:39 ******/
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
INSERT [dbo].[tbl_BaoGia] ([mabaogia], [ngay], [hieuluc], [manv], [makh], [ghichu]) VALUES (N'BG165AY', CAST(0x3D430B00 AS Date), CAST(0x3D430B00 AS Date), N'NV001', N'KH002', N'')
INSERT [dbo].[tbl_BaoGia] ([mabaogia], [ngay], [hieuluc], [manv], [makh], [ghichu]) VALUES (N'BG7633OY', CAST(0x3D430B00 AS Date), CAST(0x3D430B00 AS Date), N'NV001', N'KH002', N'')
INSERT [dbo].[tbl_BaoGia] ([mabaogia], [ngay], [hieuluc], [manv], [makh], [ghichu]) VALUES (N'BG8132PA', CAST(0xFE410B00 AS Date), CAST(0x7A430B00 AS Date), N'NV001', N'KH002', N'')
INSERT [dbo].[tbl_BaoGia] ([mabaogia], [ngay], [hieuluc], [manv], [makh], [ghichu]) VALUES (N'PB11610VW', CAST(0x3C430B00 AS Date), CAST(0x3C430B00 AS Date), N'nv1244', N'KH001', N'hihihihi')
/****** Object:  Table [dbo].[tbl_DVT]    Script Date: 11/19/2021 23:54:39 ******/
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
INSERT [dbo].[tbl_DVT] ([ID], [Ten]) VALUES (N'C', N'Cái')
INSERT [dbo].[tbl_DVT] ([ID], [Ten]) VALUES (N'CH', N'Chiếc')
INSERT [dbo].[tbl_DVT] ([ID], [Ten]) VALUES (N'KG', N'Cân')
INSERT [dbo].[tbl_DVT] ([ID], [Ten]) VALUES (N'M', N'Mét')
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 11/19/2021 23:54:39 ******/
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
INSERT [dbo].[tbl_NhanVien] ([manv], [tennv], [diachi], [sdt], [CMND]) VALUES (N'nv1244', N'TheAnh', N'HN', N'23423', N'1233333')
/****** Object:  Table [dbo].[tbl_NhaCungCap]    Script Date: 11/19/2021 23:54:39 ******/
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
INSERT [dbo].[tbl_NhaCungCap] ([mancc], [TENNCC], [DIACHI], [SDT]) VALUES (N'0', N'Not', N'HN', N'123')
INSERT [dbo].[tbl_NhaCungCap] ([mancc], [TENNCC], [DIACHI], [SDT]) VALUES (N'NC002', N'NC002', N'', N'')
/****** Object:  Table [dbo].[tbl_nguoidung]    Script Date: 11/19/2021 23:54:39 ******/
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
/****** Object:  Table [dbo].[tbl_ChiTietHoaDon]    Script Date: 11/19/2021 23:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiTietHoaDon](
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
INSERT [dbo].[tbl_ChiTietHoaDon] ([Id_hd], [masp], [soluong]) VALUES (N'HD3127EA', N'H02', 110)
INSERT [dbo].[tbl_ChiTietHoaDon] ([Id_hd], [masp], [soluong]) VALUES (N'HD3127EA', N'H03', 5)
INSERT [dbo].[tbl_ChiTietHoaDon] ([Id_hd], [masp], [soluong]) VALUES (N'HD5447IO', N'H01', 10)
INSERT [dbo].[tbl_ChiTietHoaDon] ([Id_hd], [masp], [soluong]) VALUES (N'HD5447IO', N'H02', 8)
INSERT [dbo].[tbl_ChiTietHoaDon] ([Id_hd], [masp], [soluong]) VALUES (N'HD5447IO', N'H04', 10)
INSERT [dbo].[tbl_ChiTietHoaDon] ([Id_hd], [masp], [soluong]) VALUES (N'HD8435OQ', N'H00', 25)
INSERT [dbo].[tbl_ChiTietHoaDon] ([Id_hd], [masp], [soluong]) VALUES (N'HD8435OQ', N'H03', 5)
/****** Object:  Table [dbo].[tbl_HANG]    Script Date: 11/19/2021 23:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HANG](
	[Ma] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[DVT] [nvarchar](50) NULL,
	[LOAI] [nvarchar](50) NULL,
	[DONGIA] [float] NULL,
	[Soluong] [int] NULL,
 CONSTRAINT [PK_tbl_The] PRIMARY KEY CLUSTERED 
(
	[Ma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIA], [Soluong]) VALUES (N'H00', N'Sản phẩm 222', N'C', N'L1', 29000, 112)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIA], [Soluong]) VALUES (N'H01', N'ABC', N'C', N'L1', 1000, 636)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIA], [Soluong]) VALUES (N'H02', N'Asus TP500LN-DN126H Silver', N'C', N'L1', 200000, 271)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIA], [Soluong]) VALUES (N'H03', N'Vải lụa', N'M', N'L2', 10000, 0)
INSERT [dbo].[tbl_HANG] ([Ma], [Ten], [DVT], [LOAI], [DONGIA], [Soluong]) VALUES (N'H04', N'Máy Tính', N'CH', N'L1', 400000, 213)
/****** Object:  Table [dbo].[tbl_PhieuNhap]    Script Date: 11/19/2021 23:54:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PhieuNhap](
	[IDPN] [nvarchar](50) NOT NULL,
	[NCC] [nvarchar](50) NULL,
	[TONGTIEN] [float] NULL,
	[NGAY] [date] NULL,
	[TrangThai] [int] NULL,
	[NguoiGiao] [nvarchar](50) NULL,
	[Sdt] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbl_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[IDPN] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [NCC], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt]) VALUES (N'PN1645AW', NULL, 0, CAST(0x3C430B00 AS Date), 0, N'dfgdfg', N'000000')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [NCC], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt]) VALUES (N'PN3235FG', NULL, 0, CAST(0x39430B00 AS Date), 0, N'TheAnh28', N'45645')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [NCC], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt]) VALUES (N'PN3243FF', NULL, 0, CAST(0x3D430B00 AS Date), 0, N'theeee', N'546456456')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [NCC], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt]) VALUES (N'PN7551NT', NULL, 0, CAST(0x39430B00 AS Date), 0, N'NhanVien123', N'0000')
INSERT [dbo].[tbl_PhieuNhap] ([IDPN], [NCC], [TONGTIEN], [NGAY], [TrangThai], [NguoiGiao], [Sdt]) VALUES (N'PN8527PU', NULL, 0, CAST(0x39430B00 AS Date), 0, N'TheAnh', N'45645')
/****** Object:  Table [dbo].[tbl_PhieuBanHang]    Script Date: 11/19/2021 23:54:39 ******/
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
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH12532XR', N'KH002', CAST(0x34430B00 AS Date), N'NV002', 1151000, 0, CAST(0x3E430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH1622BY', N'KH002', CAST(0x2F430B00 AS Date), N'NV001', 28400000, 1, CAST(0x3D430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH2134CA', N'KH001', CAST(0x2C420B00 AS Date), N'NV001', 11000000, 1, CAST(0x3D430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH2443DO', N'KH002', CAST(0x3E430B00 AS Date), N'nv1244', 0, 0, CAST(0x46430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH3126FA', N'KH001', CAST(0x0E420B00 AS Date), N'nv1244', 13248000, 1, CAST(0x3E430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH5149JB', N'KH001', CAST(0x3D420B00 AS Date), N'NV001', 40000, 1, CAST(0x3E430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH6319MI', N'KH002', CAST(0x2D420B00 AS Date), N'NV002', 0, 0, CAST(0x3E430B00 AS Date))
INSERT [dbo].[tbl_PhieuBanHang] ([IDPHIEU], [MAKH], [NGAYLAP], [MANV], [TongTien], [TrangThai], [NGAYGIAO]) VALUES (N'DH9124RA', N'KH002', CAST(0x3E430B00 AS Date), N'NV002', 0, 0, CAST(0x47430B00 AS Date))
/****** Object:  Table [dbo].[tbl_PhieuNhapChiTiet]    Script Date: 11/19/2021 23:54:39 ******/
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
/****** Object:  Table [dbo].[tbl_PhieuBanChiTiet]    Script Date: 11/19/2021 23:54:39 ******/
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
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH12532XR', N'H01', 6, 1000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH12532XR', N'H02', 5, 200000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH12532XR', N'H04', 5, 400000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH1622BY', N'H02', 10, 200000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH1622BY', N'H04', 66, 400000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH2134CA', N'H02', 55, 200000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH3126FA', N'H01', 48, 1000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH3126FA', N'H02', 66, 200000)
INSERT [dbo].[tbl_PhieuBanChiTiet] ([ID_PB], [HANG], [SL], [DonGia]) VALUES (N'DH5149JB', N'H03', 4, 10000)
/****** Object:  ForeignKey [FK_tbl_nguoidung_tbl_NhanVien]    Script Date: 11/19/2021 23:54:39 ******/
ALTER TABLE [dbo].[tbl_nguoidung]  WITH CHECK ADD  CONSTRAINT [FK_tbl_nguoidung_tbl_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[tbl_NhanVien] ([manv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_nguoidung] CHECK CONSTRAINT [FK_tbl_nguoidung_tbl_NhanVien]
GO
/****** Object:  ForeignKey [FK_tbl_ChiTietHoaDon_tbl_HoaDon]    Script Date: 11/19/2021 23:54:39 ******/
ALTER TABLE [dbo].[tbl_ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTietHoaDon_tbl_HoaDon] FOREIGN KEY([Id_hd])
REFERENCES [dbo].[tbl_HoaDon] ([Id])
GO
ALTER TABLE [dbo].[tbl_ChiTietHoaDon] CHECK CONSTRAINT [FK_tbl_ChiTietHoaDon_tbl_HoaDon]
GO
/****** Object:  ForeignKey [FK_tbl_The_tbl_LoaiThe]    Script Date: 11/19/2021 23:54:39 ******/
ALTER TABLE [dbo].[tbl_HANG]  WITH CHECK ADD  CONSTRAINT [FK_tbl_The_tbl_LoaiThe] FOREIGN KEY([LOAI])
REFERENCES [dbo].[tbl_Loai] ([Ma])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_HANG] CHECK CONSTRAINT [FK_tbl_The_tbl_LoaiThe]
GO
/****** Object:  ForeignKey [FK_tbl_The_tbl_MenhGia]    Script Date: 11/19/2021 23:54:39 ******/
ALTER TABLE [dbo].[tbl_HANG]  WITH CHECK ADD  CONSTRAINT [FK_tbl_The_tbl_MenhGia] FOREIGN KEY([DVT])
REFERENCES [dbo].[tbl_DVT] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_HANG] CHECK CONSTRAINT [FK_tbl_The_tbl_MenhGia]
GO
/****** Object:  ForeignKey [FK_tbl_PhieuNhap_tbl_NhaCungCap]    Script Date: 11/19/2021 23:54:39 ******/
ALTER TABLE [dbo].[tbl_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuNhap_tbl_NhaCungCap] FOREIGN KEY([NCC])
REFERENCES [dbo].[tbl_NhaCungCap] ([mancc])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_PhieuNhap] CHECK CONSTRAINT [FK_tbl_PhieuNhap_tbl_NhaCungCap]
GO
/****** Object:  ForeignKey [FK_tbl_PhieuBanHang_tbl_KhachHang]    Script Date: 11/19/2021 23:54:39 ******/
ALTER TABLE [dbo].[tbl_PhieuBanHang]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuBanHang_tbl_KhachHang] FOREIGN KEY([MAKH])
REFERENCES [dbo].[tbl_KhachHang] ([makh])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_PhieuBanHang] CHECK CONSTRAINT [FK_tbl_PhieuBanHang_tbl_KhachHang]
GO
/****** Object:  ForeignKey [FK_tbl_PhieuBanHang_tbl_NhanVien]    Script Date: 11/19/2021 23:54:39 ******/
ALTER TABLE [dbo].[tbl_PhieuBanHang]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuBanHang_tbl_NhanVien] FOREIGN KEY([MANV])
REFERENCES [dbo].[tbl_NhanVien] ([manv])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_PhieuBanHang] CHECK CONSTRAINT [FK_tbl_PhieuBanHang_tbl_NhanVien]
GO
/****** Object:  ForeignKey [FK_tbl_PhieuNhapChiTiet_tbl_PhieuNhap]    Script Date: 11/19/2021 23:54:39 ******/
ALTER TABLE [dbo].[tbl_PhieuNhapChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuNhapChiTiet_tbl_PhieuNhap] FOREIGN KEY([ID_PN])
REFERENCES [dbo].[tbl_PhieuNhap] ([IDPN])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_PhieuNhapChiTiet] CHECK CONSTRAINT [FK_tbl_PhieuNhapChiTiet_tbl_PhieuNhap]
GO
/****** Object:  ForeignKey [FK_tbl_PhieuBanChiTiet_tbl_PhieuBanHang]    Script Date: 11/19/2021 23:54:39 ******/
ALTER TABLE [dbo].[tbl_PhieuBanChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuBanChiTiet_tbl_PhieuBanHang] FOREIGN KEY([ID_PB])
REFERENCES [dbo].[tbl_PhieuBanHang] ([IDPHIEU])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_PhieuBanChiTiet] CHECK CONSTRAINT [FK_tbl_PhieuBanChiTiet_tbl_PhieuBanHang]
GO
/****** Object:  ForeignKey [FK_tbl_PhieuBanChiTiet_tbl_The]    Script Date: 11/19/2021 23:54:39 ******/
ALTER TABLE [dbo].[tbl_PhieuBanChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PhieuBanChiTiet_tbl_The] FOREIGN KEY([HANG])
REFERENCES [dbo].[tbl_HANG] ([Ma])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tbl_PhieuBanChiTiet] CHECK CONSTRAINT [FK_tbl_PhieuBanChiTiet_tbl_The]
GO
