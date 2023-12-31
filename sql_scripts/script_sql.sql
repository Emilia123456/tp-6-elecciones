USE [Elecciones2023]
GO
/****** Object:  Table [dbo].[Candidato]    Script Date: 9/8/2023 09:24:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidato](
	[IdCandidato] [int] IDENTITY(1,1) NOT NULL,
	[IdPartido] [int] NOT NULL,
	[Apellido] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[FechaNacimiento] [date] NULL,
	[Foto] [varchar](50) NULL,
	[Postulacion] [varchar](50) NULL,
 CONSTRAINT [PK_Candidato_1] PRIMARY KEY CLUSTERED 
(
	[IdCandidato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partido]    Script Date: 9/8/2023 09:24:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partido](
	[IdPartido] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Logo] [varchar](50) NULL,
	[SitioWeb] [varchar](255) NULL,
	[FechaFundacion] [date] NULL,
	[CantidadDiputados] [int] NULL,
	[CantidadSenadores] [int] NULL,
 CONSTRAINT [PK_Partido] PRIMARY KEY CLUSTERED 
(
	[IdPartido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Candidato] ON 

INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (1, 2, N'Larreta', N'Horacio Rodríguez', CAST(N'1965-10-29' AS Date), N'../Imagenes/Candidatos/larreta.jpg', N'Presidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (10, 2, N'Morales', N'Gerardo', CAST(N'1959-07-18' AS Date), N'../Imagenes/Candidatos/morales.jpg', N'Vicepresidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (11, 1, N'Bullrich', N'Patricia', CAST(N'1956-06-11' AS Date), N'../Imagenes/Candidatos/bullrich.jpg', N'Presidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (13, 1, N'Petri', N'Luis', CAST(N'1977-05-01' AS Date), N'../Imagenes/Candidatos/petri.jpg', N'Vicepresidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (14, 3, N'Milei', N'Javier', CAST(N'1970-10-20' AS Date), N'../Imagenes/Candidatos/milei.jpg', N'Presidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (15, 3, N'Villarruel', N'Victoria', CAST(N'1975-05-13' AS Date), N'../Imagenes/Candidatos/villarruel.jpg', N'Vicepresidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (16, 4, N'Del Caño', N'Nicolas', CAST(N'1980-02-06' AS Date), N'../Imagenes/Candidatos/caño.jpg', N'Vicepresidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (17, 4, N'Bregman', N'Myriam', CAST(N'1972-02-25' AS Date), N'../Imagenes/Candidatos/bregman.jpg', N'Presidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (18, 5, N'Ramal', N'Marcelo', CAST(N'1954-10-13' AS Date), N'../Imagenes/Candidatos/ramal.jpg', N'Presidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (19, 5, N'Urones', N'Patricia', CAST(N'1988-10-02' AS Date), N'../Imagenes/Candidatos/urones.jpg', N'Vicepresidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (20, 6, N'Massa', N'Sergio', CAST(N'1972-05-28' AS Date), N'../Imagenes/Candidatos/massa.jpg', N'Presidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (21, 6, N'Rossi', N'Agustin', CAST(N'1959-10-18' AS Date), N'../Imagenes/Candidatos/rossi.jpg', N'Vicepresidente')
INSERT [dbo].[Candidato] ([IdCandidato], [IdPartido], [Apellido], [Nombre], [FechaNacimiento], [Foto], [Postulacion]) VALUES (22, 2, N'Mile', N'dawi', CAST(N'2222-12-31' AS Date), N'hhhgh', N'diputado')
SET IDENTITY_INSERT [dbo].[Candidato] OFF
GO
SET IDENTITY_INSERT [dbo].[Partido] ON 

INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (1, N'La Fuerza del Cambio', N'/Imagenes/Lista La Fuerza del Cambio.JPG', N'https://jxc.com.ar/', CAST(N'2019-06-12' AS Date), 2, 17)
INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (2, N'Juntos por el Cambio', N'/Imagenes/Juntos por el Cambio.JPG', N'https://jxc.com.ar/', CAST(N'2019-06-12' AS Date), 2, 17)
INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (3, N'Libertad por Siempre', N'/Imagenes/Lista Libertad por Siempre.JPG', N'https://lalibertadavanza.com.ar/', CAST(N'2021-07-14' AS Date), 2, 2)
INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (4, N'Unir y Fortalecer la Izquierda', N'/Imagenes/Lista Unidad Obrera.JPG', N'https://izquierdasocialista.org.ar/2020/index.php/2014-05-02-03-07-21/frente-de-izquierda', CAST(N'2011-05-14' AS Date), 2, 20)
INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (5, N'Unidad Obrera', N'/Imagenes/Lista Unidad Obrera.JPG', N'https://pts.org.ar/Unidad-obrera-y-coordinacion', CAST(N'1964-04-16' AS Date), 2, 10)
INSERT [dbo].[Partido] ([IdPartido], [Nombre], [Logo], [SitioWeb], [FechaFundacion], [CantidadDiputados], [CantidadSenadores]) VALUES (6, N'Union por la Patria', N'/Imagenes/Union por la Patria.JPG', N'https://twitter.com/i/flow/login?redirect_after_login=%2Funionxlapatria%3Flang%3Des', CAST(N'2023-05-14' AS Date), 2, NULL)
SET IDENTITY_INSERT [dbo].[Partido] OFF
GO
ALTER TABLE [dbo].[Candidato]  WITH CHECK ADD  CONSTRAINT [FK_Candidato_Partido] FOREIGN KEY([IdPartido])
REFERENCES [dbo].[Partido] ([IdPartido])
GO
ALTER TABLE [dbo].[Candidato] CHECK CONSTRAINT [FK_Candidato_Partido]
GO
