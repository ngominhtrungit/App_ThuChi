USE [master]
GO
/****** Object:  Database [BaoCaoThuChi]    Script Date: 6/26/2020 3:28:45 PM ******/
CREATE DATABASE [BaoCaoThuChi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BaoCaoThuChi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.TRUNGTHUY0805\MSSQL\DATA\BaoCaoThuChi.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BaoCaoThuChi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.TRUNGTHUY0805\MSSQL\DATA\BaoCaoThuChi_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BaoCaoThuChi] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BaoCaoThuChi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BaoCaoThuChi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET ARITHABORT OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BaoCaoThuChi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BaoCaoThuChi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BaoCaoThuChi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BaoCaoThuChi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET RECOVERY FULL 
GO
ALTER DATABASE [BaoCaoThuChi] SET  MULTI_USER 
GO
ALTER DATABASE [BaoCaoThuChi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BaoCaoThuChi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BaoCaoThuChi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BaoCaoThuChi] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BaoCaoThuChi] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BaoCaoThuChi', N'ON'
GO
ALTER DATABASE [BaoCaoThuChi] SET QUERY_STORE = OFF
GO
USE [BaoCaoThuChi]
GO
/****** Object:  Table [dbo].[ChiPhiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiPhiTheoCa](
	[chiphitcID] [int] IDENTITY(1,1) NOT NULL,
	[ngaytaocp] [date] NULL,
	[caID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[chiphitcID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuDauTu]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuDauTu](
	[cdtID] [int] IDENTITY(1,1) NOT NULL,
	[tenCDT] [nvarchar](50) NULL,
	[sdtCDT] [int] NULL,
	[diachiCDT] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[cdtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTChiPhiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTChiPhiTheoCa](
	[ctcptcID] [int] IDENTITY(1,1) NOT NULL,
	[chiphitcID] [int] NOT NULL,
	[mota] [nvarchar](300) NOT NULL,
	[donvitinh] [nvarchar](20) NULL,
	[soluong] [int] NOT NULL,
	[dongia] [float] NOT NULL,
	[thanhtien] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ctcptcID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTChuDauTu_ChiPhiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTChuDauTu_ChiPhiTheoCa](
	[ctcdtID] [int] IDENTITY(1,1) NOT NULL,
	[cdtID] [int] NOT NULL,
	[chiphitcID] [int] NOT NULL,
	[sotienlay] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[ctcdtID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoanhThu]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThu](
	[doanhthuID] [int] IDENTITY(1,1) NOT NULL,
	[ngaytaodt] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[doanhthuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoanhThuTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoanhThuTheoCa](
	[caID] [int] IDENTITY(1,1) NOT NULL,
	[tenCa] [nvarchar](50) NOT NULL,
	[doanhthuID] [int] NULL,
	[tiendelai] [float] NULL,
	[doanhthutheoca] [float] NULL,
	[doanhthukhac] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[caID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TienConLaiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TienConLaiTheoCa](
	[tlID] [int] IDENTITY(1,1) NOT NULL,
	[tienconlaitheoca] [float] NULL,
	[caID] [int] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiPhiTheoCa] ON 

INSERT [dbo].[ChiPhiTheoCa] ([chiphitcID], [ngaytaocp], [caID]) VALUES (2, CAST(N'2020-06-17' AS Date), 30)
INSERT [dbo].[ChiPhiTheoCa] ([chiphitcID], [ngaytaocp], [caID]) VALUES (3, CAST(N'2020-06-18' AS Date), 34)
INSERT [dbo].[ChiPhiTheoCa] ([chiphitcID], [ngaytaocp], [caID]) VALUES (6, CAST(N'2020-06-12' AS Date), 1)
INSERT [dbo].[ChiPhiTheoCa] ([chiphitcID], [ngaytaocp], [caID]) VALUES (12, CAST(N'2020-06-26' AS Date), 285)
SET IDENTITY_INSERT [dbo].[ChiPhiTheoCa] OFF
SET IDENTITY_INSERT [dbo].[ChuDauTu] ON 

INSERT [dbo].[ChuDauTu] ([cdtID], [tenCDT], [sdtCDT], [diachiCDT]) VALUES (31, N'anh trung', 902669115, N'quận 12, tp hcm')
INSERT [dbo].[ChuDauTu] ([cdtID], [tenCDT], [sdtCDT], [diachiCDT]) VALUES (32, N'anh thịnh', 90222666, N'quận 12')
SET IDENTITY_INSERT [dbo].[ChuDauTu] OFF
SET IDENTITY_INSERT [dbo].[CTChiPhiTheoCa] ON 

INSERT [dbo].[CTChiPhiTheoCa] ([ctcptcID], [chiphitcID], [mota], [donvitinh], [soluong], [dongia], [thanhtien]) VALUES (1, 2, N'bò húc', N'lon', 24, 8500, 204000)
INSERT [dbo].[CTChiPhiTheoCa] ([ctcptcID], [chiphitcID], [mota], [donvitinh], [soluong], [dongia], [thanhtien]) VALUES (5, 3, N'bò húc', N'lon', 1, 3, 3)
INSERT [dbo].[CTChiPhiTheoCa] ([ctcptcID], [chiphitcID], [mota], [donvitinh], [soluong], [dongia], [thanhtien]) VALUES (7, 3, N'củ cải', N'chai', 1, 10, 10)
INSERT [dbo].[CTChiPhiTheoCa] ([ctcptcID], [chiphitcID], [mota], [donvitinh], [soluong], [dongia], [thanhtien]) VALUES (8, 2, N'bò húc 2', N'lon', 10, 6500, 65000)
INSERT [dbo].[CTChiPhiTheoCa] ([ctcptcID], [chiphitcID], [mota], [donvitinh], [soluong], [dongia], [thanhtien]) VALUES (9, 2, N'demo', N'chai', 3, 3, 9)
INSERT [dbo].[CTChiPhiTheoCa] ([ctcptcID], [chiphitcID], [mota], [donvitinh], [soluong], [dongia], [thanhtien]) VALUES (14, 12, N'red bull', N'lon', 10, 10000, 100000)
INSERT [dbo].[CTChiPhiTheoCa] ([ctcptcID], [chiphitcID], [mota], [donvitinh], [soluong], [dongia], [thanhtien]) VALUES (15, 12, N'demo', N'kg', 2, 20000, 40000)
SET IDENTITY_INSERT [dbo].[CTChiPhiTheoCa] OFF
SET IDENTITY_INSERT [dbo].[CTChuDauTu_ChiPhiTheoCa] ON 

INSERT [dbo].[CTChuDauTu_ChiPhiTheoCa] ([ctcdtID], [cdtID], [chiphitcID], [sotienlay]) VALUES (2, 31, 3, 10000000)
INSERT [dbo].[CTChuDauTu_ChiPhiTheoCa] ([ctcdtID], [cdtID], [chiphitcID], [sotienlay]) VALUES (9, 31, 12, 1000000)
SET IDENTITY_INSERT [dbo].[CTChuDauTu_ChiPhiTheoCa] OFF
SET IDENTITY_INSERT [dbo].[DoanhThu] ON 

INSERT [dbo].[DoanhThu] ([doanhthuID], [ngaytaodt]) VALUES (19, CAST(N'2020-06-12' AS Date))
INSERT [dbo].[DoanhThu] ([doanhthuID], [ngaytaodt]) VALUES (20, CAST(N'2020-06-15' AS Date))
INSERT [dbo].[DoanhThu] ([doanhthuID], [ngaytaodt]) VALUES (21, CAST(N'2020-06-17' AS Date))
INSERT [dbo].[DoanhThu] ([doanhthuID], [ngaytaodt]) VALUES (22, CAST(N'2020-06-18' AS Date))
INSERT [dbo].[DoanhThu] ([doanhthuID], [ngaytaodt]) VALUES (24, CAST(N'2020-06-20' AS Date))
INSERT [dbo].[DoanhThu] ([doanhthuID], [ngaytaodt]) VALUES (25, CAST(N'2020-06-21' AS Date))
INSERT [dbo].[DoanhThu] ([doanhthuID], [ngaytaodt]) VALUES (26, CAST(N'2020-06-23' AS Date))
INSERT [dbo].[DoanhThu] ([doanhthuID], [ngaytaodt]) VALUES (27, CAST(N'2020-06-26' AS Date))
SET IDENTITY_INSERT [dbo].[DoanhThu] OFF
SET IDENTITY_INSERT [dbo].[DoanhThuTheoCa] ON 

INSERT [dbo].[DoanhThuTheoCa] ([caID], [tenCa], [doanhthuID], [tiendelai], [doanhthutheoca], [doanhthukhac]) VALUES (1, N'ca 1', 19, 1000000, 3500000, 0)
INSERT [dbo].[DoanhThuTheoCa] ([caID], [tenCa], [doanhthuID], [tiendelai], [doanhthutheoca], [doanhthukhac]) VALUES (11, N'ca 1', 20, 12, 12, 12)
INSERT [dbo].[DoanhThuTheoCa] ([caID], [tenCa], [doanhthuID], [tiendelai], [doanhthutheoca], [doanhthukhac]) VALUES (19, N'ca 2', 20, 122, 111, 111)
INSERT [dbo].[DoanhThuTheoCa] ([caID], [tenCa], [doanhthuID], [tiendelai], [doanhthutheoca], [doanhthukhac]) VALUES (30, N'ca 1', 21, 2, 2, 3)
INSERT [dbo].[DoanhThuTheoCa] ([caID], [tenCa], [doanhthuID], [tiendelai], [doanhthutheoca], [doanhthukhac]) VALUES (34, N'ca 1', 22, 12, 12, 12)
INSERT [dbo].[DoanhThuTheoCa] ([caID], [tenCa], [doanhthuID], [tiendelai], [doanhthutheoca], [doanhthukhac]) VALUES (35, N'ca 1', 24, 14, 12, 12)
INSERT [dbo].[DoanhThuTheoCa] ([caID], [tenCa], [doanhthuID], [tiendelai], [doanhthutheoca], [doanhthukhac]) VALUES (214, N'ca 2', 24, 2, 2, 2)
INSERT [dbo].[DoanhThuTheoCa] ([caID], [tenCa], [doanhthuID], [tiendelai], [doanhthutheoca], [doanhthukhac]) VALUES (216, N'ca 3', 24, 2, 2, 2)
INSERT [dbo].[DoanhThuTheoCa] ([caID], [tenCa], [doanhthuID], [tiendelai], [doanhthutheoca], [doanhthukhac]) VALUES (278, N'ca 2', 19, 12, 12, 12)
INSERT [dbo].[DoanhThuTheoCa] ([caID], [tenCa], [doanhthuID], [tiendelai], [doanhthutheoca], [doanhthukhac]) VALUES (285, N'ca 1', 27, 4000000, 5000000, 0)
SET IDENTITY_INSERT [dbo].[DoanhThuTheoCa] OFF
SET IDENTITY_INSERT [dbo].[TienConLaiTheoCa] ON 

INSERT [dbo].[TienConLaiTheoCa] ([tlID], [tienconlaitheoca], [caID]) VALUES (2, -269002, 30)
INSERT [dbo].[TienConLaiTheoCa] ([tlID], [tienconlaitheoca], [caID]) VALUES (4, -9999977, 34)
INSERT [dbo].[TienConLaiTheoCa] ([tlID], [tienconlaitheoca], [caID]) VALUES (6, 4500000, 1)
INSERT [dbo].[TienConLaiTheoCa] ([tlID], [tienconlaitheoca], [caID]) VALUES (7, 38, 35)
INSERT [dbo].[TienConLaiTheoCa] ([tlID], [tienconlaitheoca], [caID]) VALUES (12, 7860000, 285)
SET IDENTITY_INSERT [dbo].[TienConLaiTheoCa] OFF
/****** Object:  Index [UQ__ChiPhiTh__21BDC4FF143A77F3]    Script Date: 6/26/2020 3:28:45 PM ******/
ALTER TABLE [dbo].[ChiPhiTheoCa] ADD UNIQUE NONCLUSTERED 
(
	[caID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__ChiPhiTh__21BDC4FFF4BA3865]    Script Date: 6/26/2020 3:28:45 PM ******/
ALTER TABLE [dbo].[ChiPhiTheoCa] ADD UNIQUE NONCLUSTERED 
(
	[caID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__TienConL__21BDC4FF1768B4B2]    Script Date: 6/26/2020 3:28:45 PM ******/
ALTER TABLE [dbo].[TienConLaiTheoCa] ADD UNIQUE NONCLUSTERED 
(
	[caID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__TienConL__21BDC4FF1ACC11F7]    Script Date: 6/26/2020 3:28:45 PM ******/
ALTER TABLE [dbo].[TienConLaiTheoCa] ADD UNIQUE NONCLUSTERED 
(
	[caID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DoanhThuTheoCa] ADD  DEFAULT ((0)) FOR [tiendelai]
GO
ALTER TABLE [dbo].[DoanhThuTheoCa] ADD  DEFAULT ((0)) FOR [doanhthukhac]
GO
ALTER TABLE [dbo].[ChiPhiTheoCa]  WITH CHECK ADD FOREIGN KEY([caID])
REFERENCES [dbo].[DoanhThuTheoCa] ([caID])
GO
ALTER TABLE [dbo].[ChiPhiTheoCa]  WITH CHECK ADD FOREIGN KEY([caID])
REFERENCES [dbo].[DoanhThuTheoCa] ([caID])
GO
ALTER TABLE [dbo].[CTChiPhiTheoCa]  WITH CHECK ADD FOREIGN KEY([chiphitcID])
REFERENCES [dbo].[ChiPhiTheoCa] ([chiphitcID])
GO
ALTER TABLE [dbo].[CTChiPhiTheoCa]  WITH CHECK ADD FOREIGN KEY([chiphitcID])
REFERENCES [dbo].[ChiPhiTheoCa] ([chiphitcID])
GO
ALTER TABLE [dbo].[CTChuDauTu_ChiPhiTheoCa]  WITH CHECK ADD FOREIGN KEY([cdtID])
REFERENCES [dbo].[ChuDauTu] ([cdtID])
GO
ALTER TABLE [dbo].[CTChuDauTu_ChiPhiTheoCa]  WITH CHECK ADD FOREIGN KEY([cdtID])
REFERENCES [dbo].[ChuDauTu] ([cdtID])
GO
ALTER TABLE [dbo].[CTChuDauTu_ChiPhiTheoCa]  WITH CHECK ADD FOREIGN KEY([chiphitcID])
REFERENCES [dbo].[ChiPhiTheoCa] ([chiphitcID])
GO
ALTER TABLE [dbo].[CTChuDauTu_ChiPhiTheoCa]  WITH CHECK ADD FOREIGN KEY([chiphitcID])
REFERENCES [dbo].[ChiPhiTheoCa] ([chiphitcID])
GO
ALTER TABLE [dbo].[DoanhThuTheoCa]  WITH CHECK ADD FOREIGN KEY([doanhthuID])
REFERENCES [dbo].[DoanhThu] ([doanhthuID])
GO
ALTER TABLE [dbo].[DoanhThuTheoCa]  WITH CHECK ADD FOREIGN KEY([doanhthuID])
REFERENCES [dbo].[DoanhThu] ([doanhthuID])
GO
ALTER TABLE [dbo].[TienConLaiTheoCa]  WITH CHECK ADD FOREIGN KEY([caID])
REFERENCES [dbo].[DoanhThuTheoCa] ([caID])
GO
ALTER TABLE [dbo].[TienConLaiTheoCa]  WITH CHECK ADD FOREIGN KEY([caID])
REFERENCES [dbo].[DoanhThuTheoCa] ([caID])
GO
/****** Object:  StoredProcedure [dbo].[proc_ChoseTenCDTShowID]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[proc_ChoseTenCDTShowID]
	(
		@tenCDT nvarchar(50)
	)
	as
	begin
		select cdtID
		from ChuDauTu
		where tenCDT = @tenCDT
	end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteCDT]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_DeleteCDT]
(
	@cdtID int
)
as
begin
	delete from ChuDauTu where cdtID = @cdtID
end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteCDT_CPTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[proc_DeleteCDT_CPTheoCa]
(
	@ctcdtID int
)
as
begin
	-- khi xóa cdt lấy tiền, thì tiền còn lại sẽ tự cập nhật
	--đầu tiên lấy CaID 
	declare @caID int =(
							select cp.caID
							from CTChuDauTu_ChiPhiTheoCa cdt,ChiPhiTheoCa cp
							where cdt.ctcdtID = @ctcdtID and cdt.chiphitcID = cp.chiphitcID
							)

	--sau khi lấy được caID
	--khai báo số tiền chuẩn bị delete
	declare @sotienxoa float=(
		select sotienlay
		from CTChuDauTu_ChiPhiTheoCa
		where ctcdtID = @ctcdtID
	)

	--Tiền còn lại hiện tại
	declare @tienconlaiTruocDelete float=(
		select tienconlaitheoca
		from TienConLaiTheoCa
		where caID =@caID
	)

	--cộng số tiền chuẩn bị DElete vào tiền còn lại hiện tại
	declare @tienSauDelete float = @sotienxoa + @tienconlaiTruocDelete;

	delete from CTChuDauTu_ChiPhiTheoCa where ctcdtID = @ctcdtID

	UPDATE TienConLaiTheoCa SET tienconlaitheoca = @tienSauDelete WHERE caID = @caID

end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteChiPhiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[proc_DeleteChiPhiTheoCa]
(
	@chiphitcID int
)
as
begin
	delete from ChiPhiTheoCa where chiphitcID = @chiphitcID
end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteCTChiPhiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--sửa ngày 18/6
CREATE proc [dbo].[proc_DeleteCTChiPhiTheoCa]
(
	@ctcptcID int
)
as
begin
	-- khi xóa cdt lấy tiền, thì tiền còn lại sẽ tự cập nhật
	--đầu tiên lấy CaID 
	declare @caID int =(
							select cp.caID
							from CTChiPhiTheoCa ct,ChiPhiTheoCa cp
							where ct.ctcptcID = @ctcptcID and ct.chiphitcID = cp.chiphitcID
							)
	--sau khi lấy được caID
	--khai báo số tiền chuẩn bị delete
	declare @sotienxoa float=(
		select thanhtien
		from CTChiPhiTheoCa
		where ctcptcID = @ctcptcID
	)

	--Tiền còn lại hiện tại
	declare @tienconlaiTruocDelete float=(
		select tienconlaitheoca
		from TienConLaiTheoCa
		where caID =@caID
	)

	--cộng số tiền chuẩn bị DElete vào tiền còn lại hiện tại
	declare @tienSauDelete float = @sotienxoa + @tienconlaiTruocDelete;

	delete from CTChiPhiTheoCa where ctcptcID = @ctcptcID

	UPDATE TienConLaiTheoCa SET tienconlaitheoca = @tienSauDelete WHERE caID = @caID
end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteDoanhThu]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_DeleteDoanhThu]
(
	@doanhthuID int
)
as
begin
	delete from DoanhThu where doanhthuID = @doanhthuID
end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteDoanhThuTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[proc_DeleteDoanhThuTheoCa]
(
	@caID int
)
as
begin
	delete from DoanhThuTheoCa where caID = @caID
end
GO
/****** Object:  StoredProcedure [dbo].[proc_DeleteTienConLaiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[proc_DeleteTienConLaiTheoCa]
(
	@tlID int
)
as
begin
	delete from TienConLaiTheoCa where tlID = @tlID
end
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertCDT]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create proc [dbo].[proc_InsertCDT]
(
	
	@tenCDT nvarchar(50),
	@sdtCDT int,
	@diachiCDT nvarchar(200)
)
as
begin
	insert into ChuDauTu(tenCDT,sdtCDT,diachiCDT) values(@tenCDT,@sdtCDT,@diachiCDT);
end
GO
/****** Object:  StoredProcedure [dbo].[proc_insertCDTChiPhiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_insertCDTChiPhiTheoCa]
(
	@cdtID varchar(10),
	@chiphitcID varchar(10),
	@sotienlay float
)
as
begin
	-- khi insert cdt lấy tiền, thì tiền còn lại sẽ tự cập nhật
	--đầu tiên lấy 
	declare @caID int =(
							select cp.caID
							from ChiPhiTheoCa cp
							where cp.chiphitcID =@chiphitcID
							)
	--sau khi lấy được caID thì update lại tienconlaitheoca by caID
	--tổng doanhthu
	--declare @dttc float = 
	--					(
	--						select sum(ca.tiendelai+ca.doanhthutheoca+ca.doanhthukhac)
	--						from DoanhThuTheoCa ca, DoanhThu dt
	--						where ca.caID =@caID and ca.doanhthuID = dt.doanhthuID
	--						group by tiendelai,doanhthutheoca,doanhthukhac
	--					)

	declare @tienconlainoUpdate  float= (
											select tienconlaitheoca
											from TienConLaiTheoCa 
											where caID = @caID
										)
	declare @tienconlaiUpdate float= @tienconlainoUpdate - @sotienlay

	--insert into CTChuDauTu_ChiPhiTheoCa(cdtID,chiphitcID,sotienlay) values(@cdtID,@chiphitcID,@sotienlay)
	insert into CTChuDauTu_ChiPhiTheoCa(cdtID,chiphitcID,sotienlay) values(@cdtID,@chiphitcID,@sotienlay)

	UPDATE TienConLaiTheoCa SET tienconlaitheoca = @tienconlaiUpdate WHERE caID = @caID
end
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertChiPhiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_InsertChiPhiTheoCa]
(
	@ngaytaocp datetime,
	@caID int
)
as
begin
	insert into ChiPhiTheoCa(ngaytaocp,caID) 
						values(@ngaytaocp,@caID)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertCTChiPhiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

	--sửa ngày 18/6
	CREATE proc [dbo].[proc_InsertCTChiPhiTheoCa]
(
	@chiphitcID int,
	@mota Nvarchar(300),
	@donvitinh Nvarchar(20),

	@soluong int,
	@dongia float
)
as
begin
	DECLARE @thanhtien float; 
	set @thanhtien = @soluong * @dongia;

	-- khi insert cdt lấy tiền, thì tiền còn lại sẽ tự cập nhật
	--đầu tiên lấy 
	declare @caID int =(
							select cp.caID
							from ChiPhiTheoCa cp
							where cp.chiphitcID =@chiphitcID
							)
	--sau khi lấy được caID thì insert lại tienconlaitheoca by caID
	declare @tienconlainoInsert  float= (
											select tienconlaitheoca
											from TienConLaiTheoCa 
											where caID = @caID
										)
	declare @tienconlaiInsert float= @tienconlainoInsert - @thanhtien;

	insert into CTChiPhiTheoCa(chiphitcID,mota,donvitinh,soluong,dongia,thanhtien) 
						values(@chiphitcID,@mota,@donvitinh,@soluong,@dongia,@thanhtien)
	
	UPDATE TienConLaiTheoCa SET tienconlaitheoca = @tienconlaiInsert WHERE caID = @caID
end
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertDoanhThu]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_InsertDoanhThu]
(
	@ngaytaodt datetime
)
as
begin 
	insert into DoanhThu(ngaytaodt) values(@ngaytaodt);
end
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertDoanhThuTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[proc_InsertDoanhThuTheoCa]
(
	@tenCa Nvarchar(50),
	@doanhthuID int,
	@tiendelai float,--tiền này là tiền của ngày hôm trước để lại
	@doanhthutheoca float,--này là doanh thu của ngày hiện tại
	@doanhthukhac float
)
as
begin
	insert into DoanhThuTheoCa(tenCa,doanhthuID,tiendelai,doanhthutheoca,doanhthukhac) 
						values(@tenCa,@doanhthuID,@tiendelai,@doanhthutheoca,@doanhthukhac)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_InsertTienConLaiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_InsertTienConLaiTheoCa]
(
	@caID int
)
as
begin 
	declare @dttc float;-- tổng doanhthu chua trừ chi phí
	declare @cptc float; --tổng chi phí theo doanhthuIproc_DeleteTienLoiCND
	declare @CDT float; -- tổng tiền chủ đầu tư lấy theo doanhthuID
	declare @tienconlaitheoca float; --tiền lời được tính dựa trên các tham số trên
	
	--tổng doanh thu
	begin
		set @dttc = (SELECT sum(ca.tiendelai+ca.doanhthutheoca+ca.doanhthukhac)
		FROM DoanhThuTheoCa as ca
		WHERE ca.caID = @caID
		group by ca.tiendelai,ca.doanhthutheoca,ca.doanhthukhac);
	end
	--end tổng doanh thu

		--tổng thành tiền chi phí thuộc mã doanhthuID
		begin
			set @cptc = (
				Select sum(ctcp.thanhtien)
				from DoanhThuTheoCa ca, ChiPhiTheoCa cp, CTChiPhiTheoCa ctcp
				where ca.caID = @caID and ca.caID= cp.caID and ctcp.chiphitcID=cp.chiphitcID
			);
		end
		--tổng thành tiền chi phí thuộc mã doanhthuID

		--chủ đầu tư lấy tiền
		begin
			set @CDT=(
						SELECT sum(cdtcp.sotienlay)
						FROM DoanhThuTheoCa as ca,ChiPhiTheoCa as cp,CTChuDauTu_ChiPhiTheoCa as cdtcp
						WHERE ca.caID = @caID and ca.caID=cp.caID and cp.chiphitcID = cdtcp.chiphitcID
						group by cdtcp.sotienlay
						);
		end
		--end chủ đầu tư lấy tiền

		if(@cptc IS NOT NULL and @CDT IS NOT NULL)
		BEGIN
			set @tienconlaitheoca=@dttc-@cptc-@CDT;
		END
		else 
			begin 
				--print N'rỗng(tổng chi phí rỗng or cdt rỗng)';
				--nếu ngày đó không có chi phí mua này nọ(trái cây, bla bla..) nhưng có chủ đầu tư vẫn lấy tiền thì ta
				--(sẽ lấy tổng doanh thu chưa trừ chi phí) - (tiền mà chủ đầu tư lấy)
				IF(@cptc IS NULL AND @CDT IS NULL)
					SET @tienconlaitheoca =@dttc;
				ELSE
					if(@CDT IS NULL)--NẾU 
						begin
							print N'Tổng chi phí có và chủ đầu tư không lấy tiền';
							set @tienconlaitheoca = @dttc-@cptc;
						end
					else
						begin
							print N'Tổng chi phí rỗng và chủ đầu tư lấy tiền';
							set @tienconlaitheoca = @dttc-@CDT;
						end

			end

		insert into TienConLaiTheoCa values(@tienconlaitheoca,@caID);
end
GO
/****** Object:  StoredProcedure [dbo].[proc_RetrieveCDTID_by_TenCDT]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_RetrieveCDTID_by_TenCDT]
(
	@tenCDT nvarchar(50)
)
as
begin
	select cdtID
	from ChuDauTu
	where tenCDT=@tenCDT
end
GO
/****** Object:  StoredProcedure [dbo].[proc_RetrieveDoanhThuID]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_RetrieveDoanhThuID]
(
	@ngay date
)
as
begin
	select doanhthuID from dbo.DoanhThu where ngaytaodt =@ngay
end
GO
/****** Object:  StoredProcedure [dbo].[proc_RetrieveDoanhThuIDbyDay]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_RetrieveDoanhThuIDbyDay]
	(
		@ngay datetime,
		@doanhthuID int output
	)
AS
Begin
	--declare @_tiendelai float;
	set @doanhthuID=
	(
		select doanhthuID
		from DoanhThu dt
		where dt.ngaytaodt=@ngay
	);
end
GO
/****** Object:  StoredProcedure [dbo].[proc_RetrieveTenCabyNgay]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[proc_RetrieveTenCabyNgay]
	(
		@ngay datetime,
		@tenCa nvarchar(50) output
	)
AS
Begin
	SET NOCOUNT ON; 
	--declare @_tiendelai float;
	set @tenCa=
	(
		select tc.tenCa
		from DoanhThu dt, DoanhThuTheoCa tc
		where dt.ngaytaodt = @ngay
	);
end
GO
/****** Object:  StoredProcedure [dbo].[proc_RetrieveTenCabyNgayTaoDT]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_RetrieveTenCabyNgayTaoDT]
(
	@ngay date
)
as
begin
	select ca.tenCa from DoanhThu dt, DoanhThuTheoCa ca where ngaytaodt =@ngay and ca.doanhthuID = dt.doanhthuID
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowCaIDbyTenCa_NgaytaoDT]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_ShowCaIDbyTenCa_NgaytaoDT]
(
	@tenCa nvarchar(50)
	,@ngay date
)
as
begin
	select ca.caID from DoanhThuTheoCa ca, DoanhThu dt
	where ca.doanhthuID = dt.doanhthuID and dt.ngaytaodt = @ngay and ca.tenCa = @tenCa
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowCDT]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_ShowCDT]
as
begin
	select * from ChuDauTu
	order by cdtID DESC
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowCDT_CPTC]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_ShowCDT_CPTC]
as
begin
	select cdttc.ctcdtID,cdttc.cdtID,cdttc.chiphitcID,cp.ngaytaocp,ca.tenCa,cdt.tenCDT,cdttc.sotienlay 
	from ChuDauTu cdt ,CTChuDauTu_ChiPhiTheoCa cdttc , ChiPhiTheoCa cp, DoanhThuTheoCa ca
	where cdt.cdtID = cdttc.cdtID and cdttc.chiphitcID = cp.chiphitcID and ca.caID = cp.caID
	order by cdttc.ctcdtID DESC
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowCDTIDbyTenCDT]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_ShowCDTIDbyTenCDT]
(
	@tenCDT Nvarchar(50)
)
as
begin
	select cdtID
	from ChuDauTu
	where tenCDT = @tenCDT
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowChiPhi]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_ShowChiPhi]
as
begin
	select cp.chiphitcID,cp.caID,cp.ngaytaocp,ca.tenCa 
	from ChiPhiTheoCa cp, DoanhThuTheoCa ca 
	where cp.caID = ca.caID
	order by ngaytaocp DESC
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowChiPhiIDbyTenCaAndNgayTaoCP]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_ShowChiPhiIDbyTenCaAndNgayTaoCP]
(
	@tenCa Nvarchar(50),
	@ngay date
)
as
begin
	select cp.chiphitcID
	from DoanhThuTheoCa ca, ChiPhiTheoCa cp
	where ca.caID = cp.caID and ca.tenCa = @tenCa and ngaytaocp = @ngay
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowCTCP_by_cdtID]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_ShowCTCP_by_cdtID]
(
	@cdtID int
)
as
begin
	select ca.ctcdtID,ca.cdtID, cp.chiphitcID, cp.ngaytaocp, dt.tenCa, cdt.tenCDT, ca.sotienlay 
	from DoanhThuTheoCa dt, ChiPhiTheoCa cp, CTChuDauTu_ChiPhiTheoCa ca, ChuDauTu cdt 
	where ca.cdtID=@cdtID and dt.caID = cp.caID and cdt.cdtID = ca.cdtID and cp.chiphitcID = ca.chiphitcID
	order by cp.ngaytaocp DESC
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowCTCP_by_chiphiID]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_ShowCTCP_by_chiphiID]
(
	@chiphitcID int
)
as
begin
	select ct.ctcptcID,ct.chiphitcID,cp.ngaytaocp,ca.tenCa,ct.mota,ct.donvitinh,ct.soluong,ct.dongia,ct.thanhtien
	from CTChiPhiTheoCa ct, ChiPhiTheoCa cp, DoanhThuTheoCa ca
	where ct.chiphitcID=@chiphitcID and ct.chiphitcID = cp.chiphitcID and cp.caID = ca.caID
	order by ngaytaocp,ctcptcID desc
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowCTCPTC]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_ShowCTCPTC]
as
begin 
	select ctcp.ctcptcID,ctcp.chiphitcID,cp.ngaytaocp,ca.tenCa, ctcp.mota,ctcp.donvitinh,ctcp.soluong,ctcp.dongia,ctcp.thanhtien
	from ChiPhiTheoCa cp, DoanhThuTheoCa ca, CTChiPhiTheoCa ctcp
	where ca.caID = cp.caID and cp.chiphitcID = ctcp.chiphitcID
	ORDER BY cp.ngaytaocp DESC
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowDoanhThu]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_ShowDoanhThu]
as
begin
	select * from DoanhThu
	order by ngaytaodt DESC
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowDoanhThuTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_ShowDoanhThuTheoCa]
as
begin
	select ca.caID,ca.doanhthuID,dt.ngaytaodt,ca.tenCa,ca.tiendelai,ca.doanhthutheoca,ca.doanhthukhac 
	from DoanhThuTheoCa ca, DoanhThu dt
	where dt.doanhthuID = ca.doanhthuID
	order by dt.ngaytaodt Desc
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowDoanhThuTheoCa_by_doanhthuID]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_ShowDoanhThuTheoCa_by_doanhthuID]
(
	@doanhthuID int
)
as
begin 
	select caID,ca.doanhthuID,dt.ngaytaodt,tenCa,tiendelai,doanhthutheoca,doanhthukhac from DoanhThuTheoCa ca, DoanhThu dt where ca.doanhthuID = @doanhthuID and ca.doanhthuID = dt.doanhthuID
	order by caID DESC
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowTenCabyNgaytaocp]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_ShowTenCabyNgaytaocp]
(
	@ngay date
)
as
begin
select ca.tenCa
from DoanhThuTheoCa ca, ChiPhiTheoCa cp
where ca.caID = cp.caID and cp.ngaytaocp = @ngay
end
GO
/****** Object:  StoredProcedure [dbo].[proc_ShowTienConLaiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_ShowTienConLaiTheoCa]
as
begin
	select tcl.tlID,tcl.caID,dt.ngaytaodt,ca.tenCa,tcl.tienconlaitheoca 
	from TienConLaiTheoCa tcl, DoanhThuTheoCa ca, DoanhThu dt
	where tcl.caID = ca.caID and ca.doanhthuID = dt.doanhthuID
 	order by dt.ngaytaodt DESC
end
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateCDT]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateCDT]
(
	@cdtID int,
	@tenCDT nvarchar(50),
	@sdtCDT int,
	@diachiCDT nvarchar(200)
)
as
begin
	UPDATE ChuDauTu
	SET tenCDT = @tenCDT, sdtCDT = @sdtCDT, diachiCDT = @diachiCDT
	WHERE cdtID = @cdtID;
end
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateCDT_CPTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateCDT_CPTheoCa]
(
	@ctcdtID int,
	@cdtID int,
	@chiphitcID int,
	@sotienlay float
)
as
begin
	begin
		UPDATE CTChuDauTu_ChiPhiTheoCa
		SET cdtID =@cdtID,chiphitcID = @chiphitcID,sotienlay = @sotienlay
		WHERE ctcdtID = @ctcdtID;
	end

	--khi update số tiền chủ đầu tư lấy thì tự động tienconlaitheoca tương ứng sẽ update theo
	begin
		--lấy được caID theo @chiphitcID nhập vào
		declare @caID int =(
							select ca.caID
							from DoanhThuTheoCa ca
							where ca.caID in (
												select ca.caID
												from DoanhThuTheoCa ca, ChiPhiTheoCa cp,CTChuDauTu_ChiPhiTheoCa cdttc
												where ca.caID = cp.caID and cp.chiphitcID = cdttc.chiphitcID and cdttc.chiphitcID = @chiphitcID
												group by ca.caID
												having Count(*)>0
											  )
							)

	--sau khi lấy được caID thì update lại tienconlaitheoca by caID
	--tổng doanhthu
	declare @dttc float = 
						(
							select sum(ca.tiendelai+ca.doanhthutheoca+ca.doanhthukhac)
							from DoanhThuTheoCa ca, DoanhThu dt
							where ca.caID =@caID and ca.doanhthuID = dt.doanhthuID
							group by tiendelai,doanhthutheoca,doanhthukhac
						)
	--tổng chi phi
	declare @cptc float=
						(
							select sum(ctcp.thanhtien)--,cp.ngaytaocp,ca.tenCa
							from DoanhThuTheoCa ca,ChiPhiTheoCa cp, CTChiPhiTheoCa ctcp
							where ca.caID=@caID and ca.caID=cp.caID and cp.chiphitcID=ctcp.chiphitcID
							--group by ngaytaocp,tenCa
						)

	--tông cdt lấy
		declare @cdt float=
						(
							select sum(cdtcp.sotienlay)--,cdt.tenCDT
							from DoanhThuTheoCa ca,ChiPhiTheoCa cp, CTChuDauTu_ChiPhiTheoCa cdtcp,ChuDauTu cdt
							where ca.caID=@caID and ca.caID=cp.caID and cp.chiphitcID = cdtcp.chiphitcID and cdtcp.cdtID = cdt.cdtID
							--group by sotienlay,tenCDT
						)
		declare @tienconlaitheoca float;
	
		set @tienconlaitheoca = @dttc-@cptc-@cdt;
		
		UPDATE TienConLaiTheoCa SET tienconlaitheoca = @tienconlaitheoca WHERE caID = @caID

	end
end
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateCTChiPhiTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateCTChiPhiTheoCa]
(
	@ctcptcID int,
	@chiphitcID int,
	@mota Nvarchar(300),
	@donvitinh Nvarchar(20),

	@soluong int,
	@dongia float
)
as
begin
	--update thành tiền by change số lượng or dongia
	begin
		UPDATE CTChiPhiTheoCa
		SET chiphitcID = @chiphitcID, mota = @mota,donvitinh = @donvitinh, soluong= @soluong, dongia =@dongia
		WHERE ctcptcID = @ctcptcID;
	end

	--update TienConLaiTheoCa by thanh tien change
	begin

	--lấy được caID theo @chiphitcID nhập vào
		declare @caID int =(
							select ca.caID
							from DoanhThuTheoCa ca
							where ca.caID in (
												select ca.caID
												from DoanhThuTheoCa ca, ChiPhiTheoCa cp,CTChiPhiTheoCa ctcp
												where ca.caID = cp.caID and cp.chiphitcID = ctcp.chiphitcID and ctcp.chiphitcID = @chiphitcID
												group by ca.caID
												having Count(*)>0
											  )
							)

	--sau khi lấy được caID thì update lại tienconlaitheoca by caID
	--tổng doanhthu
	declare @dttc float = 
						(
							select sum(ca.tiendelai+ca.doanhthutheoca+ca.doanhthukhac)
							from DoanhThuTheoCa ca, DoanhThu dt
							where ca.caID =@caID and ca.doanhthuID = dt.doanhthuID
							group by tiendelai,doanhthutheoca,doanhthukhac
						)
	--tổng chi phi
	declare @cptc float=
						(
							select sum(ctcp.thanhtien)--,cp.ngaytaocp,ca.tenCa
							from DoanhThuTheoCa ca,ChiPhiTheoCa cp, CTChiPhiTheoCa ctcp
							where ca.caID=@caID and ca.caID=cp.caID and cp.chiphitcID=ctcp.chiphitcID
							--group by ngaytaocp,tenCa
						)

	--tông cdt lấy
		declare @cdt float=
						(
							select sum(cdtcp.sotienlay)--,cdt.tenCDT
							from DoanhThuTheoCa ca,ChiPhiTheoCa cp, CTChuDauTu_ChiPhiTheoCa cdtcp,ChuDauTu cdt
							where ca.caID=@caID and ca.caID=cp.caID and cp.chiphitcID = cdtcp.chiphitcID and cdtcp.cdtID = cdt.cdtID
							--group by sotienlay,tenCDT
						)
		declare @tienconlaitheoca float;
	
		set @tienconlaitheoca = @dttc-@cptc-@cdt;
		
		UPDATE TienConLaiTheoCa SET tienconlaitheoca = @tienconlaitheoca WHERE caID = @caID
	end

end
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateDoanhThu]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateDoanhThu] 
(
	@doanhthuID int,
	@ngaytaodt datetime
)
as
begin
	UPDATE DoanhThu
	SET ngaytaodt = @ngaytaodt
	WHERE @doanhthuID = doanhthuID;
end
GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateDoanhThuTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_UpdateDoanhThuTheoCa]
(
	@caID int,
	@tenCa Nvarchar(50),
	@doanhthuID int,
	@tiendelai float,
	@doanhthutheoca float,--này là doanh thu của ngày hiện tại
	@doanhthukhac float
)
as
begin
	UPDATE DoanhThuTheoCa
	SET tenCa = @tenCa, doanhthuID = @doanhthuID,tiendelai =@tiendelai, doanhthutheoca = @doanhthutheoca, doanhthukhac = @doanhthukhac
	WHERE caID = @caID;
end
GO
/****** Object:  Trigger [dbo].[tg_NgayChiPhi_NgayDoanhThu]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create TRIGGER [dbo].[tg_NgayChiPhi_NgayDoanhThu] ON [dbo].[ChiPhiTheoCa]
FOR UPDATE, INSERT
AS 
BEGIN
SET XACT_ABORT ON
IF (UPDATE(ngaytaocp)) AND EXISTS(SELECT 1 FROM DoanhThu dt,DoanhThuTheoCa ca, inserted i WHERE dt.doanhthuID=ca.doanhthuID and dt.ngaytaodt = i.ngaytaocp )
    --Do something (I'd suggest RAISERROR)
	 begin
        print('insert thành công');
     end
	 else
	 begin
		 --RAISERROR(@ErrorMessage, 16, 1);rollback;
		rollback transaction
		DECLARE @ErrorMessage nVARCHAR(2000)
		--print ;
		SELECT @ErrorMessage = N'Lỗi thêm, ngày tạo chi phí (ngaytaocp) phải trùng với ngày (ngaytaodt) trên mã doanhthuID!' --+ ERROR_MESSAGE()
		RAISERROR(@ErrorMessage, 16, 1)
	 end
END
GO
ALTER TABLE [dbo].[ChiPhiTheoCa] ENABLE TRIGGER [tg_NgayChiPhi_NgayDoanhThu]
GO
/****** Object:  Trigger [dbo].[tb_CheckOnlyTenCDT]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tb_CheckOnlyTenCDT]
ON [dbo].[ChuDauTu]
for INSERT
AS
    IF EXISTS(
         SELECT * FROM ChuDauTu cdt WHERE
            tenCDT  IN (SELECT tenCDT FROM inserted)
         GROUP BY tenCDT
		 having count(*)>1
         )
    BEGIN
      RAISERROR('THIS RECORD IS ALREADY EXISTS', 10, 1)
      rollback transaction 
    END
GO
ALTER TABLE [dbo].[ChuDauTu] ENABLE TRIGGER [tb_CheckOnlyTenCDT]
GO
/****** Object:  Trigger [dbo].[tg_SL_DonGia_CTCPTheoCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_SL_DonGia_CTCPTheoCa] on [dbo].[CTChiPhiTheoCa]
for update, insert
as
begin
	set XACT_ABORT ON
	--KHI BÁO BIẾN
	DECLARE @ctcptcID VARchar(10) = (SELECT ctcptcID FROM inserted)

	--khai báo biến
	declare @SL int=(
		select soluong
		from CTChiPhiTheoCa
		where ctcptcID = @ctcptcID
	);

	declare @dongia int=(
		select dongia
		from CTChiPhiTheoCa
		where ctcptcID = @ctcptcID
	);

	declare @thanhtien float;
	set @thanhtien = @sl*@dongia;
	update CTChiPhiTheoCa set thanhtien = @thanhtien
	where ctcptcID = @ctcptcID
end
GO
ALTER TABLE [dbo].[CTChiPhiTheoCa] ENABLE TRIGGER [tg_SL_DonGia_CTCPTheoCa]
GO
/****** Object:  Trigger [dbo].[tb_CheckOnlyTenCa]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tb_CheckOnlyTenCa]
ON [dbo].[DoanhThuTheoCa] 
for INSERT
AS
    IF EXISTS(
         SELECT * FROM DoanhThuTheoCa ca WHERE
             tenCa IN (SELECT tenCa FROM inserted i where i.doanhthuID = ca.doanhthuID)
         GROUP BY tenCa
		 having count(*)>1
         )
    BEGIN
      RAISERROR('THIS RECORD IS ALREADY EXISTS', 10, 1)
      rollback transaction 
    END
GO
ALTER TABLE [dbo].[DoanhThuTheoCa] ENABLE TRIGGER [tb_CheckOnlyTenCa]
GO
/****** Object:  Trigger [dbo].[tg_updateDTTC]    Script Date: 6/26/2020 3:28:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[tg_updateDTTC] ON [dbo].[DoanhThuTheoCa]
FOR UPDATE, DELETE
AS 
BEGIN
    SET NOCOUNT ON 
    -- Lấy MÃ DOANHTHUID
    DECLARE @caID VARchar(10) = (SELECT caID FROM inserted)
    -- inserted là bảng table khi insert vào tbl_monhoc, nói cách khác inserted chính là tbl_monhoc
    -- Tính tiền lãi sau khi có tự thây đổi data của doanhthuKhac và doanhthutrongngay
	--tổng doanhthu
	declare @dttc float = 
						(
							select sum(ca.tiendelai+ca.doanhthutheoca+ca.doanhthukhac)
							from DoanhThuTheoCa ca, DoanhThu dt
							where ca.caID =@caID and ca.doanhthuID = dt.doanhthuID
							group by tiendelai,doanhthutheoca,doanhthukhac
						)
	--tổng chi phi
	declare @cptc float=
						(
							select sum(ctcp.thanhtien)--,cp.ngaytaocp,ca.tenCa
							from DoanhThuTheoCa ca,ChiPhiTheoCa cp, CTChiPhiTheoCa ctcp
							where ca.caID=@caID and ca.caID=cp.caID and cp.chiphitcID=ctcp.chiphitcID
							--group by ngaytaocp,tenCa
						)

	--tông cdt lấy
		declare @cdt float=
						(
							select sum(cdtcp.sotienlay)--,cdt.tenCDT
							from DoanhThuTheoCa ca,ChiPhiTheoCa cp, CTChuDauTu_ChiPhiTheoCa cdtcp,ChuDauTu cdt
							where ca.caID=@caID and ca.caID=cp.caID and cp.chiphitcID = cdtcp.chiphitcID and cdtcp.cdtID = cdt.cdtID
							--group by sotienlay,tenCDT
						)
	
	declare @tienconlaitheoca float;
	--nếu @cp và @cdt is not null
	if(@cptc is not null and @cdt is not null)
	begin 
		set @tienconlaitheoca = @dttc-@cptc-@cdt;
	end
	else
	begin
		if(@cptc is null and @cdt is null)
		begin
			set @tienconlaitheoca = @dttc;
		end
		else
		begin
			if(@cptc is null)
			begin 
				set @tienconlaitheoca = @dttc-@cdt;	
			end
			else
			begin 
				set @tienconlaitheoca =@dttc-@cptc;
			end
		end
	end

    UPDATE TienConLaiTheoCa SET tienconlaitheoca = @tienconlaitheoca WHERE caID = @caID
END
GO
ALTER TABLE [dbo].[DoanhThuTheoCa] ENABLE TRIGGER [tg_updateDTTC]
GO
USE [master]
GO
ALTER DATABASE [BaoCaoThuChi] SET  READ_WRITE 
GO
