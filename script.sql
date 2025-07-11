USE [BD]
GO
/****** Object:  User [alumno]    Script Date: 10/7/2025 09:03:25 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Integrante]    Script Date: 10/7/2025 09:03:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Integrante](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[dni] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[paisNacimiento] [varchar](50) NOT NULL,
	[colorFav] [varchar](50) NULL,
 CONSTRAINT [PK_Integrante] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Integrante] ON 

INSERT [dbo].[Integrante] ([id], [email], [nombre], [password], [fechaNacimiento], [dni], [telefono], [direccion], [paisNacimiento], [colorFav]) VALUES (1, N'victoriakriger@gmail.com', N'Victoria Kriger', N'clave123', CAST(N'2009-06-11' AS Date), N'49439065', N'1123456789', N'Av. Siempre Viva 123', N'Argentina', N'Azul')
INSERT [dbo].[Integrante] ([id], [email], [nombre], [password], [fechaNacimiento], [dni], [telefono], [direccion], [paisNacimiento], [colorFav]) VALUES (2, N'santische@gmail.com', N'Santi Sche', N'Contraseña123', CAST(N'2008-11-17' AS Date), N'49094257', N'1134567890', N'Calle Falsa 456', N'Argentina', N'Rojo')
INSERT [dbo].[Integrante] ([id], [email], [nombre], [password], [fechaNacimiento], [dni], [telefono], [direccion], [paisNacimiento], [colorFav]) VALUES (3, N'andresfishman@gmail.com', N'Andrés Fishman', N'ContraAndi', CAST(N'2009-06-15' AS Date), N'49435429', N'1157071714', N'Boulevard Central 789', N'Argentina', N'Verde')
SET IDENTITY_INSERT [dbo].[Integrante] OFF
GO
