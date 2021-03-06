USE [master]
GO
/****** Object:  Database [DuLichViet]    Script Date: 12/24/2016 12:28:40 AM ******/
CREATE DATABASE [DuLichViet]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DuLichViet', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DuLichViet.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DuLichViet_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DuLichViet_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DuLichViet] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DuLichViet].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DuLichViet] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DuLichViet] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DuLichViet] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DuLichViet] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DuLichViet] SET ARITHABORT OFF 
GO
ALTER DATABASE [DuLichViet] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DuLichViet] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DuLichViet] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DuLichViet] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DuLichViet] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DuLichViet] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DuLichViet] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DuLichViet] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DuLichViet] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DuLichViet] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DuLichViet] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DuLichViet] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DuLichViet] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DuLichViet] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DuLichViet] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DuLichViet] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DuLichViet] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DuLichViet] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DuLichViet] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DuLichViet] SET  MULTI_USER 
GO
ALTER DATABASE [DuLichViet] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DuLichViet] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DuLichViet] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DuLichViet] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DuLichViet]
GO
/****** Object:  StoredProcedure [dbo].[Check_ID]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Check_ID]
@Madiadiem int,
@Matour varchar(10)
as
begin
select Madiadiem from Place_Tour pt
where pt.Matour=@Matour And pt.Madiadiem =@Madiadiem
end
GO
/****** Object:  StoredProcedure [dbo].[CTM_Delete_CusTour]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CTM_Delete_CusTour]
@Makhachhang int,
@Madoan varchar(10)
as
begin
delete from TouristGroup_Customer
where Madoan=@Madoan And Makhachhang=@Makhachhang
update Tour set Tour.Dadangky= (select COUNT(*) from TouristGroup_Customer tg where tg.Madoan=@Madoan) where Matour=(select Matour from Tourist_Group where Madoan=@Madoan)
end
GO
/****** Object:  StoredProcedure [dbo].[CTM_Insert_CusTour]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CTM_Insert_CusTour]
@Makhachhang int,
@Madoan varchar(10)
as
begin
begin transaction
if not exists (select * from TouristGroup_Customer where Madoan=@Madoan And Makhachhang=@Makhachhang)
	begin 
		insert into TouristGroup_Customer(Madoan,Makhachhang) values (@Madoan,@Makhachhang);		
		update Tour set Tour.Dadangky= (select COUNT(*) from TouristGroup_Customer tg where tg.Madoan=@Madoan) where Matour=(select Matour from Tourist_Group where Madoan=@Madoan)
	end
else
	rollback tran
commit
end
GO
/****** Object:  StoredProcedure [dbo].[CTM_ListAll]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CTM_ListAll]
as
begin
select * from Customer
end
GO
/****** Object:  StoredProcedure [dbo].[CTM_TK]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CTM_TK]
@Makhachhang int,
@Ngaybatdau datetime,
@Ngayketthuc datetime
as
begin
select *
from Customer ctm
join TouristGroup_Customer tgctm
on ctm.Makhachhang = tgctm.Makhachhang
join Tourist_Group tg
on tgctm.Madoan=tg.Madoan
join Tour t
on tg.Matour = t.Matour
where @Ngaybatdau<=t.Ngaykhoihanh And @Ngayketthuc>=t.Ngaykhoihanh And @Makhachhang =ctm.Makhachhang
end
GO
/****** Object:  StoredProcedure [dbo].[CTM_TK_All]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CTM_TK_All]
@Makhachhang int
as
begin
select * 
from Customer ctm
join TouristGroup_Customer tgctm
on ctm.Makhachhang = tgctm.Makhachhang
join Tourist_Group tg
on tgctm.Madoan=tg.Madoan
join Tour t
on tg.Matour = t.Matour
where @Makhachhang=ctm.Makhachhang
end
GO
/****** Object:  StoredProcedure [dbo].[Dang_nhap]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Dang_nhap]
@Username varchar(10),
@Password varchar(10)
as
begin
declare @count int
declare @res bit
select @count=count(*) from Account where Tendangnhap=@Username and Matkhau=@Password
if @count>0
	set @res=1
else
	set @res=0
select @res
end
GO
/****** Object:  StoredProcedure [dbo].[DLV_CTM_ListAll]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DLV_CTM_ListAll]
@Madoan varchar(10)
as
begin
select * from Customer ctm
join TouristGroup_Customer tgctm
on ctm.Makhachhang = tgctm.Makhachhang
join Tourist_Group tg
on tgctm.Madoan=tg.Madoan
where tg.Madoan=@Madoan
end
GO
/****** Object:  StoredProcedure [dbo].[DLV_TG_Delete]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DLV_TG_Delete]
@Madoan varchar(10)
as
begin
delete from Tourist_Group where Madoan=@Madoan
end
GO
/****** Object:  StoredProcedure [dbo].[DLV_TG_Edit]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DLV_TG_Edit]
@Madoan varchar(10),
@Matour varchar(10),
@Tendoan nvarchar(500),
@Chuongtrinhthamquan nvarchar(4000),
@Ngaykhoihanh date,
@Ngayketthuc date,
@Phuongtien nvarchar(50)
as
begin
update Tourist_Group set  Matour=@Matour ,Tendoan=@Tendoan, Chuongtrinhthamquan=@Chuongtrinhthamquan, Ngaykhoihanh=@Ngaykhoihanh, Ngayketthuc=@Ngayketthuc, Phuongtien=@Phuongtien
where Madoan=@Madoan
end
GO
/****** Object:  StoredProcedure [dbo].[DLV_TG_ListAll]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DLV_TG_ListAll]
as
begin
select * from Tourist_Group
end
GO
/****** Object:  StoredProcedure [dbo].[Place_Edit]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Place_Edit]
@Stt int,
@Madiadiem int,
@Matour varchar(10)
as
begin
update Place_Tour set STT=@Stt,Madiadiem=@Madiadiem,Matour=@Matour
end
GO
/****** Object:  StoredProcedure [dbo].[Place_Insert]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Place_Insert]
@Stt int,
@Madiadiem int,
@Matour varchar(10)
as
begin
insert into Place_Tour(STT,Madiadiem,Matour) values (@Stt,@Madiadiem,@Matour)
end
GO
/****** Object:  StoredProcedure [dbo].[Place_ListAll]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Place_ListAll]
@Matour varchar(10)
as
begin
select * from Place p
join Place_Tour pt
on p.Madiadiem=pt.Madiadiem
join Tour t
on t.Matour=pt.Matour
where pt.Matour=@Matour
end
GO
/****** Object:  StoredProcedure [dbo].[Place_ListAllDD]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Place_ListAllDD]
as
begin
select * from Place p
end
GO
/****** Object:  StoredProcedure [dbo].[PT_Delete]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PT_Delete]
@Madiadiem int,
@Matour varchar(10)
as
begin
delete from Place_Tour
where Matour=@Matour And Madiadiem =@Madiadiem
end
GO
/****** Object:  StoredProcedure [dbo].[T_ListAll]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[T_ListAll]
as
begin
select * from Tour
end
GO
/****** Object:  StoredProcedure [dbo].[T_ListAllID]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[T_ListAllID]
@Matour varchar(10)
as
begin
select * from Tour
where Matour=@Matour
end
GO
/****** Object:  StoredProcedure [dbo].[TG_Insert]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TG_Insert]
@Madoan varchar(10),
@Matour varchar(10),
@Tendoan nvarchar(500),
@Chuongtrinhthamquan nvarchar(4000),
@Ngaykhoihanh date,
@Ngayketthuc date,
@Phuongtien nvarchar(50)
as
begin
insert into Tourist_Group(Madoan,Matour,Tendoan,Chuongtrinhthamquan,Ngaykhoihanh,Ngayketthuc,Phuongtien) 
values (@Madoan,@Matour,@Tendoan,@Chuongtrinhthamquan,@Ngaykhoihanh,@Ngayketthuc,@Phuongtien)
end
GO
/****** Object:  StoredProcedure [dbo].[TG_ListAll]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TG_ListAll]
as
begin
select * from TouristGroup
end
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Account](
	[Tendangnhap] [varchar](10) NULL,
	[Matkhau] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/24/2016 12:28:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bill](
	[Mahoadon] [int] IDENTITY(1,1) NOT NULL,
	[Makhachhang] [int] NULL,
	[Tenkhachhang] [nvarchar](50) NULL,
	[Diachi] [nvarchar](50) NULL,
	[Sodienthoai] [nvarchar](50) NULL,
	[Madoan] [varchar](10) NULL,
	[Tendoan] [nvarchar](50) NULL,
	[Soluongnguoidangki] [int] NULL,
	[Ngayxuat] [date] NULL,
	[Tinhtrang] [nvarchar](50) NULL,
	[Tongtien] [int] NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[Mahoadon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/24/2016 12:28:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[Makhachhang] [int] IDENTITY(1,1) NOT NULL,
	[Tenkhachhang] [nvarchar](100) NULL,
	[Cmnd] [varchar](15) NULL,
	[Diachi] [nvarchar](4000) NULL,
	[Gioitinh] [nvarchar](10) NULL,
	[Sodienthoai] [nvarchar](15) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Makhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Place]    Script Date: 12/24/2016 12:28:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Place](
	[Madiadiem] [int] IDENTITY(1,1) NOT NULL,
	[Matinh] [int] NOT NULL,
	[Tendiadiem] [nvarchar](4000) NULL,
	[Chitiet] [nvarchar](4000) NULL,
 CONSTRAINT [PK_Place] PRIMARY KEY CLUSTERED 
(
	[Madiadiem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Place_Tour]    Script Date: 12/24/2016 12:28:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Place_Tour](
	[STT] [int] NULL,
	[Madiadiem] [int] NULL,
	[Matour] [varchar](10) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Province]    Script Date: 12/24/2016 12:28:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Province](
	[Matinh] [int] IDENTITY(1,1) NOT NULL,
	[Tentinh] [nvarchar](50) NULL,
 CONSTRAINT [PK_Province] PRIMARY KEY CLUSTERED 
(
	[Matinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tour]    Script Date: 12/24/2016 12:28:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tour](
	[Matour] [varchar](10) NOT NULL,
	[Tentour] [nvarchar](50) NOT NULL,
	[Dacdiem] [nvarchar](4000) NOT NULL,
	[Giatour] [int] NULL,
	[Loaihinh] [nvarchar](50) NULL,
	[Thoigian] [nvarchar](50) NULL,
	[Ngaykhoihanh] [date] NULL,
	[Phuongtien] [nvarchar](50) NULL,
	[Tonghanhkhachtour] [int] NULL,
	[Dadangky] [int] NULL,
	[Trangthai] [int] NULL,
 CONSTRAINT [PK_Tour] PRIMARY KEY CLUSTERED 
(
	[Matour] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tourist_Group]    Script Date: 12/24/2016 12:28:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tourist_Group](
	[Madoan] [varchar](10) NOT NULL,
	[Matour] [varchar](10) NULL,
	[Tendoan] [nvarchar](500) NULL,
	[Chuongtrinhthamquan] [nvarchar](4000) NULL,
	[Ngaykhoihanh] [date] NULL,
	[Ngayketthuc] [date] NULL,
	[Phuongtien] [nvarchar](50) NULL,
	[Tonghanhkhachdoan] [int] NULL,
 CONSTRAINT [PK_Tourist_Group] PRIMARY KEY CLUSTERED 
(
	[Madoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TouristGroup_Customer]    Script Date: 12/24/2016 12:28:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TouristGroup_Customer](
	[Madoan] [varchar](10) NULL,
	[Makhachhang] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Customer] FOREIGN KEY([Makhachhang])
REFERENCES [dbo].[Customer] ([Makhachhang])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Customer]
GO
ALTER TABLE [dbo].[Place]  WITH CHECK ADD  CONSTRAINT [FK_Place_Province] FOREIGN KEY([Matinh])
REFERENCES [dbo].[Province] ([Matinh])
GO
ALTER TABLE [dbo].[Place] CHECK CONSTRAINT [FK_Place_Province]
GO
ALTER TABLE [dbo].[Place_Tour]  WITH CHECK ADD  CONSTRAINT [FK_Place_Tour_Place] FOREIGN KEY([Madiadiem])
REFERENCES [dbo].[Place] ([Madiadiem])
GO
ALTER TABLE [dbo].[Place_Tour] CHECK CONSTRAINT [FK_Place_Tour_Place]
GO
ALTER TABLE [dbo].[Place_Tour]  WITH CHECK ADD  CONSTRAINT [FK_Place_Tour_Tour] FOREIGN KEY([Matour])
REFERENCES [dbo].[Tour] ([Matour])
GO
ALTER TABLE [dbo].[Place_Tour] CHECK CONSTRAINT [FK_Place_Tour_Tour]
GO
ALTER TABLE [dbo].[Tourist_Group]  WITH CHECK ADD  CONSTRAINT [FK_Tourist_Group_Tour] FOREIGN KEY([Matour])
REFERENCES [dbo].[Tour] ([Matour])
GO
ALTER TABLE [dbo].[Tourist_Group] CHECK CONSTRAINT [FK_Tourist_Group_Tour]
GO
ALTER TABLE [dbo].[TouristGroup_Customer]  WITH CHECK ADD  CONSTRAINT [FK_TouristGroup_Customer_Customer] FOREIGN KEY([Makhachhang])
REFERENCES [dbo].[Customer] ([Makhachhang])
GO
ALTER TABLE [dbo].[TouristGroup_Customer] CHECK CONSTRAINT [FK_TouristGroup_Customer_Customer]
GO
ALTER TABLE [dbo].[TouristGroup_Customer]  WITH CHECK ADD  CONSTRAINT [FK_TouristGroup_Customer_Tourist_Group] FOREIGN KEY([Madoan])
REFERENCES [dbo].[Tourist_Group] ([Madoan])
GO
ALTER TABLE [dbo].[TouristGroup_Customer] CHECK CONSTRAINT [FK_TouristGroup_Customer_Tourist_Group]
GO
USE [master]
GO
ALTER DATABASE [DuLichViet] SET  READ_WRITE 
GO
