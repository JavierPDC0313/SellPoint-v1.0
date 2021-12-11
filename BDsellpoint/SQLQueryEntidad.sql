USE [SellPoint]
GO

/****** Object:  Table [dbo].[Entidades]    Script Date: 7/12/2021 5:09:47 p. m. ******/
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

ALTER TABLE [dbo].[Entidades] ADD  CONSTRAINT [DF_Entidades_LimiteCreditoCK]  CHECK ( 0 <= LimiteCredito ) 
GO

