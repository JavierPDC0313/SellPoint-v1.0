USE [master]
GO
/****** Object:  Database [SellPoint]    Script Date: 7/12/2021 5:19:35 p. m. ******/
CREATE DATABASE [SellPoint]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SellPoint', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SellPoint.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SellPoint_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SellPoint_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SellPoint] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SellPoint].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SellPoint] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SellPoint] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SellPoint] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SellPoint] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SellPoint] SET ARITHABORT OFF 
GO
ALTER DATABASE [SellPoint] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SellPoint] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SellPoint] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SellPoint] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SellPoint] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SellPoint] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SellPoint] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SellPoint] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SellPoint] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SellPoint] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SellPoint] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SellPoint] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SellPoint] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SellPoint] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SellPoint] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SellPoint] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SellPoint] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SellPoint] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SellPoint] SET  MULTI_USER 
GO
ALTER DATABASE [SellPoint] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SellPoint] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SellPoint] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SellPoint] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SellPoint] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SellPoint] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SellPoint] SET QUERY_STORE = OFF
GO
USE [SellPoint]
GO
/****** Object:  Table [dbo].[Entidades]    Script Date: 7/12/2021 5:19:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entidades](
	[IdEntidad] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Direccion] [text] NOT NULL,
	[Localidad] [nvarchar](max) NOT NULL,
	[TipoEntidad] [text] NOT NULL,
	[TipoDocumento] [text] NOT NULL,
	[NumeroDocumento] [numeric](18, 0) NOT NULL,
	[Teléfonos] [nvarchar](max) NOT NULL,
	[URLPaginaWeb] [nvarchar](max) NULL,
	[URLFacebook] [nvarchar](max) NULL,
	[URLInstagram] [nvarchar](max) NULL,
	[URLTwitter] [nvarchar](max) NULL,
	[URLTikTok] [nvarchar](max) NULL,
	[IdGrupoEntidad] [numeric](18, 0) NULL,
	[IdTipoEntidad] [numeric](18, 0) NULL,
	[LimiteCredito] [numeric](18, 0) NULL,
	[UserNameEntidad] [nvarchar](50) NOT NULL,
	[PassworEntidad] [nvarchar](30) NOT NULL,
	[RolUserEntidad] [nchar](10) NOT NULL,
	[Comentario] [text] NULL,
	[Status] [nchar](10) NOT NULL,
	[NoEliminable] [bit] NOT NULL,
	[FechaRegistro] [date] NULL,
 CONSTRAINT [PK_Entidades] PRIMARY KEY CLUSTERED 
(
	[IdEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GruposEntidades]    Script Date: 7/12/2021 5:19:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GruposEntidades](
	[IdGrupoEntidad] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Comentario] [text] NULL,
	[Status] [nchar](10) NULL,
	[NoEliminable] [bit] NULL,
	[FechaRegistro] [date] NULL,
 CONSTRAINT [PK_GruposEntidades] PRIMARY KEY CLUSTERED 
(
	[IdGrupoEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposEntidades]    Script Date: 7/12/2021 5:19:35 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposEntidades](
	[IdTipoEntidad] [int] NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[IdGrupoEntidad] [int] NOT NULL,
	[Comentario] [text] NULL,
	[Status] [nchar](10) NULL,
	[NoEliminable] [bit] NULL,
	[FechaRegistro] [date] NULL,
 CONSTRAINT [PK_TiposEntidades] PRIMARY KEY CLUSTERED 
(
	[IdTipoEntidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_Direccion]  DEFAULT ('0') FOR [Direccion]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_TipoEntidad]  DEFAULT ('Jurídica') FOR [TipoEntidad]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_TipoDocumento]  DEFAULT ('RNC') FOR [TipoDocumento]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_LimiteCredito]  DEFAULT ((0)) FOR [LimiteCredito]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_RolUserEntidad]  DEFAULT (N'Usuario') FOR [RolUserEntidad]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_Status]  DEFAULT (N'Activa') FOR [Status]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_NoEliminable]  DEFAULT ((0)) FOR [NoEliminable]
GO
ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[GruposEntidades] ADD  CONSTRAINT [DF_GruposEntidades_Status]  DEFAULT (N'Activa') FOR [Status]
GO
ALTER TABLE [dbo].[GruposEntidades] ADD  CONSTRAINT [DF_GruposEntidades_NoEliminable]  DEFAULT ((0)) FOR [NoEliminable]
GO
ALTER TABLE [dbo].[GruposEntidades] ADD  CONSTRAINT [DF_GruposEntidades_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[TiposEntidades] ADD  CONSTRAINT [DF_TiposEntidades_Status]  DEFAULT (N'Activa') FOR [Status]
GO
ALTER TABLE [dbo].[TiposEntidades] ADD  CONSTRAINT [DF_TiposEntidades_NoEliminable]  DEFAULT ((0)) FOR [NoEliminable]
GO
ALTER TABLE [dbo].[TiposEntidades] ADD  CONSTRAINT [DF_TiposEntidades_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO
ALTER TABLE [dbo].[Entidades]  WITH CHECK ADD  CONSTRAINT [DF_Entidades_LimiteCreditoCK] CHECK  (((0)<=[LimiteCredito]))
GO
ALTER TABLE [dbo].[Entidades] CHECK CONSTRAINT [DF_Entidades_LimiteCreditoCK]
GO
USE [master]
GO
ALTER DATABASE [SellPoint] SET  READ_WRITE 
GO
