USE [SellPoint]
GO

/****** Object:  Table [dbo].[GruposEntidades]    Script Date: 7/12/2021 5:12:38 p. m. ******/
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

ALTER TABLE [dbo].[GruposEntidades] ADD  CONSTRAINT [DF_GruposEntidades_Status]  DEFAULT (N'Activa') FOR [Status]
GO

ALTER TABLE [dbo].[GruposEntidades] ADD  CONSTRAINT [DF_GruposEntidades_NoEliminable]  DEFAULT ((0)) FOR [NoEliminable]
GO

ALTER TABLE [dbo].[GruposEntidades] ADD  CONSTRAINT [DF_GruposEntidades_FechaRegistro]  DEFAULT (getdate()) FOR [FechaRegistro]
GO


