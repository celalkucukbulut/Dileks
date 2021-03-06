USE [master]
GO
/****** Object:  Database [DilekDB]    Script Date: 16.05.2017 17:59:22 ******/
CREATE DATABASE [DilekDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DilekDB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DilekDB.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DilekDB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\DilekDB_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DilekDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DilekDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DilekDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DilekDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DilekDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DilekDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DilekDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [DilekDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DilekDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DilekDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DilekDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DilekDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DilekDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DilekDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DilekDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DilekDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DilekDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DilekDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DilekDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DilekDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DilekDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DilekDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DilekDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DilekDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DilekDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DilekDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DilekDB] SET  MULTI_USER 
GO
ALTER DATABASE [DilekDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DilekDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DilekDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DilekDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [DilekDB]
GO
/****** Object:  Table [dbo].[Contents]    Script Date: 16.05.2017 17:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Text] [nvarchar](1000) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifyDate] [datetime] NULL,
 CONSTRAINT [PK_Contents] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DBCodes]    Script Date: 16.05.2017 17:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DBCodes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [int] NOT NULL,
	[About] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime] NULL,
	[ModifyDate] [datetime] NULL,
 CONSTRAINT [PK_DBCodes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Images]    Script Date: 16.05.2017 17:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FilePath] [nvarchar](100) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[DBCode] [int] NOT NULL,
	[Text] [nvarchar](200) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifyDate] [datetime] NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Messages]    Script Date: 16.05.2017 17:59:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](50) NULL,
	[Phone] [nvarchar](20) NULL,
	[Text] [nvarchar](1000) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifyDate] [datetime] NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[DBCodes] ON 

INSERT [dbo].[DBCodes] ([Id], [Code], [About], [CreatedDate], [ModifyDate]) VALUES (1, 1, N'Anasayfa', CAST(0x0000A77300000000 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[DBCodes] OFF
SET IDENTITY_INSERT [dbo].[Images] ON 

INSERT [dbo].[Images] ([Id], [FilePath], [Code], [DBCode], [Text], [CreatedDate], [ModifyDate]) VALUES (1, N'~/Images/1.jpg', N'Anasayfa', 1, N'Deneme yazısı', CAST(0x0000A77300000000 AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Images] OFF
SET IDENTITY_INSERT [dbo].[Messages] ON 

INSERT [dbo].[Messages] ([Id], [Name], [Mail], [Phone], [Text], [CreatedDate], [ModifyDate]) VALUES (1, N'Celal', N'celal@celal', N'1233131323', N'Mesajı buraya mı yazıyoruz tam olarak', CAST(0x0000A77400DD6FDA AS DateTime), NULL)
INSERT [dbo].[Messages] ([Id], [Name], [Mail], [Phone], [Text], [CreatedDate], [ModifyDate]) VALUES (2, N'Celal', N'celal@celal', N'1233131323', N'MEsaj here', CAST(0x0000A77400DE404B AS DateTime), NULL)
INSERT [dbo].[Messages] ([Id], [Name], [Mail], [Phone], [Text], [CreatedDate], [ModifyDate]) VALUES (3, N'das', N'dsadsad@sd', N'sadasdsa', N'asd asd asd asdas dasd', CAST(0x0000A77400DF71B2 AS DateTime), NULL)
INSERT [dbo].[Messages] ([Id], [Name], [Mail], [Phone], [Text], [CreatedDate], [ModifyDate]) VALUES (4, N'adasd', N'sadasdas@sd', N'dasdas', N'dasdasdsad', CAST(0x0000A77400DFB54A AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[Messages] OFF
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Images] FOREIGN KEY([Id])
REFERENCES [dbo].[Images] ([Id])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Images]
GO
USE [master]
GO
ALTER DATABASE [DilekDB] SET  READ_WRITE 
GO
