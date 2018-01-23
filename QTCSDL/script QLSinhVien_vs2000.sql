create database QLSinhVien
go

USE [QLSinhVien]
GO
/****** Object:  ForeignKey [FK_GiangKhoa_ChuongTrinh]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_GiangKhoa_ChuongTrinh]') AND type = 'F')
ALTER TABLE [dbo].[GiangKhoa] DROP CONSTRAINT [FK_GiangKhoa_ChuongTrinh]
GO
/****** Object:  ForeignKey [FK_GiangKhoa_Khoa]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_GiangKhoa_Khoa]') AND type = 'F')
ALTER TABLE [dbo].[GiangKhoa] DROP CONSTRAINT [FK_GiangKhoa_Khoa]
GO
/****** Object:  ForeignKey [FK_GiangKhoa_MonHoc]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_GiangKhoa_MonHoc]') AND type = 'F')
ALTER TABLE [dbo].[GiangKhoa] DROP CONSTRAINT [FK_GiangKhoa_MonHoc]
GO
/****** Object:  ForeignKey [FK_KetQua_GiangKhoa]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_KetQua_GiangKhoa]') AND type = 'F')
ALTER TABLE [dbo].[KetQua] DROP CONSTRAINT [FK_KetQua_GiangKhoa]
GO
/****** Object:  ForeignKey [FK_KetQua_SinhVien]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_KetQua_SinhVien]') AND type = 'F')
ALTER TABLE [dbo].[KetQua] DROP CONSTRAINT [FK_KetQua_SinhVien]
GO
/****** Object:  ForeignKey [FK_Lop_ChuongTrinh]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_Lop_ChuongTrinh]') AND type = 'F')
ALTER TABLE [dbo].[Lop] DROP CONSTRAINT [FK_Lop_ChuongTrinh]
GO
/****** Object:  ForeignKey [FK_Lop_Khoa]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_Lop_Khoa]') AND type = 'F')
ALTER TABLE [dbo].[Lop] DROP CONSTRAINT [FK_Lop_Khoa]
GO
/****** Object:  ForeignKey [FK_Lop_KhoaHoc]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_Lop_KhoaHoc]') AND type = 'F')
ALTER TABLE [dbo].[Lop] DROP CONSTRAINT [FK_Lop_KhoaHoc]
GO
/****** Object:  ForeignKey [FK_MonHoc_Khoa]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_MonHoc_Khoa]') AND type = 'F')
ALTER TABLE [dbo].[MonHoc] DROP CONSTRAINT [FK_MonHoc_Khoa]
GO
/****** Object:  ForeignKey [FK_SinhVien_Lop]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_SinhVien_Lop]') AND type = 'F')
ALTER TABLE [dbo].[SinhVien] DROP CONSTRAINT [FK_SinhVien_Lop]
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KetQua]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[KetQua]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Khoa]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[Khoa]
GO
/****** Object:  Table [dbo].[ChuongTrinh]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[ChuongTrinh]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[ChuongTrinh]
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KhoaHoc]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[KhoaHoc]
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Lop]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[Lop]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[MonHoc]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[MonHoc]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SinhVien]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[SinhVien]
GO
/****** Object:  Table [dbo].[GiangKhoa]    Script Date: 03/22/2011 18:09:09 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GiangKhoa]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
DROP TABLE [dbo].[GiangKhoa]
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 03/22/2011 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KhoaHoc]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[KhoaHoc](
	[maKhoahoc] [varchar](10) NOT NULL,
	[namBatDau] [int] NULL,
	[namKetThuc] [int] NULL,
 CONSTRAINT [PK_KhoaHoc] PRIMARY KEY CLUSTERED 
(
	[maKhoahoc] ASC
) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 03/22/2011 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Khoa]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[Khoa](
	[maKhoa] [varchar](10) NOT NULL,
	[tenKhoa] [nvarchar](100) NULL,
	[namThanhLap] [int] NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[maKhoa] ASC
) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ChuongTrinh]    Script Date: 03/22/2011 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[ChuongTrinh]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[ChuongTrinh](
	[maChuongTrinh] [varchar](10) NOT NULL,
	[tenChuongTrinh] [nvarchar](100) NULL,
 CONSTRAINT [PK_ChuongTrinh] PRIMARY KEY CLUSTERED 
(
	[maChuongTrinh] ASC
) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[GiangKhoa]    Script Date: 03/22/2011 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[GiangKhoa]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[GiangKhoa](
	[maGiangKhoa] [varchar](10) NOT NULL,
	[maChuongTrinh] [varchar](10) NULL,
	[maKhoa] [varchar](10) NULL,
	[maMonHoc] [varchar](10) NULL,
	[namHoc] [int] NULL,
	[hocKy] [int] NULL,
	[soTietLyThuyet] [int] NULL,
	[soTietThucHanh] [int] NULL,
	[soTinChi] [int] NULL,
 CONSTRAINT [PK_GiangKhoa] PRIMARY KEY CLUSTERED 
(
	[maGiangKhoa] ASC
) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 03/22/2011 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SinhVien]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[SinhVien](
	[maSinhVien] [varchar](10) NOT NULL,
	[hoTen] [nvarchar](100) NULL,
	[namSinh] [int] NULL,
	[danToc] [nvarchar](20) NULL,
	[maLop] [varchar](10) NULL,
 CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED 
(
	[maSinhVien] ASC
) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KetQua]    Script Date: 03/22/2011 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KetQua]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[KetQua](
	[maSinhVien] [varchar](10) NOT NULL,
	[maGiangKhoa] [varchar](10) NOT NULL,
	[diem] [float] NULL,
	[lanThi] [int] NULL,
 CONSTRAINT [PK_KetQua] PRIMARY KEY CLUSTERED 
(
	[maSinhVien] ASC,
	[maGiangKhoa] ASC
) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lop]    Script Date: 03/22/2011 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[Lop]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[Lop](
	[maLop] [varchar](10) NOT NULL,
	[maKhoaHoc] [varchar](10) NULL,
	[maKhoa] [varchar](10) NULL,
	[maChuongTrinh] [varchar](10) NULL,
	[soThuTu] [int] NULL,
 CONSTRAINT [PK_Lop] PRIMARY KEY CLUSTERED 
(
	[maLop] ASC
) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 03/22/2011 18:09:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[MonHoc]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
CREATE TABLE [dbo].[MonHoc](
	[maMonHoc] [varchar](10) NOT NULL,
	[tenMonHoc] [nvarchar](100) NULL,
	[maKhoa] [varchar](10) NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[maMonHoc] ASC
) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_GiangKhoa_ChuongTrinh]    Script Date: 03/22/2011 18:09:09 ******/
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_GiangKhoa_ChuongTrinh]') AND type = 'F')
ALTER TABLE [dbo].[GiangKhoa]  WITH CHECK ADD  CONSTRAINT [FK_GiangKhoa_ChuongTrinh] FOREIGN KEY([maChuongTrinh])
REFERENCES [dbo].[ChuongTrinh] ([maChuongTrinh])
GO
ALTER TABLE [dbo].[GiangKhoa] CHECK CONSTRAINT [FK_GiangKhoa_ChuongTrinh]
GO
/****** Object:  ForeignKey [FK_GiangKhoa_Khoa]    Script Date: 03/22/2011 18:09:09 ******/
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_GiangKhoa_Khoa]') AND type = 'F')
ALTER TABLE [dbo].[GiangKhoa]  WITH CHECK ADD  CONSTRAINT [FK_GiangKhoa_Khoa] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[GiangKhoa] CHECK CONSTRAINT [FK_GiangKhoa_Khoa]
GO
/****** Object:  ForeignKey [FK_GiangKhoa_MonHoc]    Script Date: 03/22/2011 18:09:09 ******/
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_GiangKhoa_MonHoc]') AND type = 'F')
ALTER TABLE [dbo].[GiangKhoa]  WITH CHECK ADD  CONSTRAINT [FK_GiangKhoa_MonHoc] FOREIGN KEY([maMonHoc])
REFERENCES [dbo].[MonHoc] ([maMonHoc])
GO
ALTER TABLE [dbo].[GiangKhoa] CHECK CONSTRAINT [FK_GiangKhoa_MonHoc]
GO
/****** Object:  ForeignKey [FK_KetQua_GiangKhoa]    Script Date: 03/22/2011 18:09:09 ******/
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_KetQua_GiangKhoa]') AND type = 'F')
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_GiangKhoa] FOREIGN KEY([maGiangKhoa])
REFERENCES [dbo].[GiangKhoa] ([maGiangKhoa])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_GiangKhoa]
GO
/****** Object:  ForeignKey [FK_KetQua_SinhVien]    Script Date: 03/22/2011 18:09:09 ******/
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_KetQua_SinhVien]') AND type = 'F')
ALTER TABLE [dbo].[KetQua]  WITH CHECK ADD  CONSTRAINT [FK_KetQua_SinhVien] FOREIGN KEY([maSinhVien])
REFERENCES [dbo].[SinhVien] ([maSinhVien])
GO
ALTER TABLE [dbo].[KetQua] CHECK CONSTRAINT [FK_KetQua_SinhVien]
GO
/****** Object:  ForeignKey [FK_Lop_ChuongTrinh]    Script Date: 03/22/2011 18:09:09 ******/
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_Lop_ChuongTrinh]') AND type = 'F')
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_ChuongTrinh] FOREIGN KEY([maChuongTrinh])
REFERENCES [dbo].[ChuongTrinh] ([maChuongTrinh])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_ChuongTrinh]
GO
/****** Object:  ForeignKey [FK_Lop_Khoa]    Script Date: 03/22/2011 18:09:09 ******/
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_Lop_Khoa]') AND type = 'F')
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_Khoa] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_Khoa]
GO
/****** Object:  ForeignKey [FK_Lop_KhoaHoc]    Script Date: 03/22/2011 18:09:09 ******/
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_Lop_KhoaHoc]') AND type = 'F')
ALTER TABLE [dbo].[Lop]  WITH CHECK ADD  CONSTRAINT [FK_Lop_KhoaHoc] FOREIGN KEY([maKhoaHoc])
REFERENCES [dbo].[KhoaHoc] ([maKhoahoc])
GO
ALTER TABLE [dbo].[Lop] CHECK CONSTRAINT [FK_Lop_KhoaHoc]
GO
/****** Object:  ForeignKey [FK_MonHoc_Khoa]    Script Date: 03/22/2011 18:09:09 ******/
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_MonHoc_Khoa]') AND type = 'F')
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_Khoa] FOREIGN KEY([maKhoa])
REFERENCES [dbo].[Khoa] ([maKhoa])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [FK_MonHoc_Khoa]
GO
/****** Object:  ForeignKey [FK_SinhVien_Lop]    Script Date: 03/22/2011 18:09:09 ******/
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[FK_SinhVien_Lop]') AND type = 'F')
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD  CONSTRAINT [FK_SinhVien_Lop] FOREIGN KEY([maLop])
REFERENCES [dbo].[Lop] ([maLop])
GO
ALTER TABLE [dbo].[SinhVien] CHECK CONSTRAINT [FK_SinhVien_Lop]
GO

/*
	SQL Server Dumper - version 2.1.3
	Ruizata Project

	Creation Date: 29/3/2011 5:28:41 PM
	Database : `QLSinhVien` 
*/


-- `dbo.ChuongTrinh`
INSERT dbo.ChuongTrinh VALUES ('CNTN', N'Cử nhân tài năng')
INSERT dbo.ChuongTrinh VALUES ('CQ', N'Chính qui')
INSERT dbo.ChuongTrinh VALUES ('CÐ	', N'Cao đẳng')
GO

-- `dbo.GiangKhoa`
GO

-- `dbo.KetQua`
GO

-- `dbo.Khoa`
INSERT dbo.Khoa VALUES ('CNSH', N'Công nghệ sinh học', 1990)
INSERT dbo.Khoa VALUES ('CNTT', N'Công nghệ thông tin', 1995)
INSERT dbo.Khoa VALUES ('DC', N'Địa chất', 2000)
INSERT dbo.Khoa VALUES ('DTVT', N'Điện tử viễn thông', 2003)
INSERT dbo.Khoa VALUES ('TT', N'Toán-Tin', 1996)
INSERT dbo.Khoa VALUES ('VL', N'Vật lý', 1970)
GO

-- `dbo.KhoaHoc`
INSERT dbo.KhoaHoc VALUES ('K2002', 2002, 2006)
INSERT dbo.KhoaHoc VALUES ('K2003', 2003, 2007)
INSERT dbo.KhoaHoc VALUES ('K2004', 2004, 2008)
INSERT dbo.KhoaHoc VALUES ('K2005', 2005, 2009)
INSERT dbo.KhoaHoc VALUES ('K2006', 2006, 2010)
INSERT dbo.KhoaHoc VALUES ('K2007', 2007, 2011)
GO

-- `dbo.Lop`
INSERT dbo.Lop VALUES ('TH2002/01', 'K2002', 'CNTT', 'CQ', 1)
INSERT dbo.Lop VALUES ('TH2002/02', 'K2002', 'CNTT', 'CQ', 2)
INSERT dbo.Lop VALUES ('VL2003/01', 'K2003', 'VL', 'CQ', 1)
GO

-- `dbo.MonHoc`
INSERT dbo.MonHoc VALUES ('THCS01', N'Cấu trúc dữ liệu 1', 'CNTT')
INSERT dbo.MonHoc VALUES ('THCS02', N'Hệ điều hành', 'CNTT')
INSERT dbo.MonHoc VALUES ('THT01', N'Toán Cao cấp A1', 'CNTT')
INSERT dbo.MonHoc VALUES ('THT02', N'Toán rời rạc', 'CNTT')
INSERT dbo.MonHoc VALUES ('VLT01', N'Vật lý Cao cấp A1', 'VL')
GO

-- `dbo.SinhVien`
INSERT dbo.SinhVien VALUES ('0212001', N'Nguyễn Vĩnh An', 1984, N'Kinh', 'TH2002/01')
INSERT dbo.SinhVien VALUES ('0212002', N'Nguyễn Thanh Bình', 1985, N'Kinh', 'TH2002/01')
INSERT dbo.SinhVien VALUES ('0212003', N'Nguyễn Thanh Cường', 1984, N'Kinh', 'TH2002/02')
INSERT dbo.SinhVien VALUES ('0212004', N'Nguyễn Quốc Duy', 1983, N'Kinh', 'TH2002/02')
INSERT dbo.SinhVien VALUES ('0312001', N'Phan Tuấn Anh', 1985, N'Kinh', 'VL2003/01')
INSERT dbo.SinhVien VALUES ('0312002', N'Huỳnh Thanh Sang', 1984, N'Kinh', 'VL2003/01')
GO
