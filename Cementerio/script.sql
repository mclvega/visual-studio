USE [master]
GO
/****** Object:  Database [mbbCementerio]    Script Date: 26/11/2019 10:07:42 ******/
CREATE DATABASE [mbbCementerio]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mbbCementerio_Data', FILENAME = N'c:\dzsqls\mbbCementerio.mdf' , SIZE = 3264KB , MAXSIZE = 15360KB , FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'mbbCementerio_Logs', FILENAME = N'c:\dzsqls\mbbCementerio.ldf' , SIZE = 1024KB , MAXSIZE = 20480KB , FILEGROWTH = 10%)
GO
ALTER DATABASE [mbbCementerio] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [mbbCementerio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [mbbCementerio] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [mbbCementerio] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [mbbCementerio] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [mbbCementerio] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [mbbCementerio] SET ARITHABORT OFF 
GO
ALTER DATABASE [mbbCementerio] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [mbbCementerio] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [mbbCementerio] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [mbbCementerio] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [mbbCementerio] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [mbbCementerio] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [mbbCementerio] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [mbbCementerio] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [mbbCementerio] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [mbbCementerio] SET  DISABLE_BROKER 
GO
ALTER DATABASE [mbbCementerio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [mbbCementerio] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [mbbCementerio] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [mbbCementerio] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [mbbCementerio] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [mbbCementerio] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [mbbCementerio] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [mbbCementerio] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [mbbCementerio] SET  MULTI_USER 
GO
ALTER DATABASE [mbbCementerio] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [mbbCementerio] SET DB_CHAINING OFF 
GO
ALTER DATABASE [mbbCementerio] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [mbbCementerio] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [mbbCementerio] SET DELAYED_DURABILITY = DISABLED 
GO
USE [mbbCementerio]
GO
/****** Object:  User [MclVega_SQLLogin_1]    Script Date: 26/11/2019 10:07:46 ******/
CREATE USER [MclVega_SQLLogin_1] FOR LOGIN [MclVega_SQLLogin_1] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [MclVega_SQLLogin_1]
GO
/****** Object:  Schema [MclVega_SQLLogin_1]    Script Date: 26/11/2019 10:07:48 ******/
CREATE SCHEMA [MclVega_SQLLogin_1]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 26/11/2019 10:07:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK__categori__3213E83F108B795B] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[dato_interes]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[dato_interes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK__dato_int__3213E83F1B0907CE] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Detalle]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_fallecido] [int] NOT NULL,
	[id_factura] [int] NOT NULL,
	[descuento] [int] NOT NULL,
	[total] [int] NOT NULL,
 CONSTRAINT [PK_Detalle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalle_dato_interes]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_dato_interes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[familiar_id] [int] NOT NULL,
	[dato_interes_id] [int] NOT NULL,
 CONSTRAINT [PK__detalle___3213E83F1ED998B2] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalle_factura]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tumba_id] [int] NOT NULL,
	[sector_id] [int] NOT NULL,
	[familiar_id] [int] NOT NULL,
	[fallecido_id] [int] NOT NULL,
 CONSTRAINT [PK__detalle___3213E83F36B12243] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[empleado]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[salario] [int] NOT NULL,
	[antiguedad] [date] NOT NULL,
	[persona_id] [int] NOT NULL,
	[categoria_id] [int] NOT NULL,
	[jornada_laboral_id] [int] NOT NULL,
 CONSTRAINT [PK__empleado__3213E83F145C0A3F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[factura]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[factura](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[total] [int] NOT NULL,
	[fecha_emision] [date] NOT NULL,
	[detalle_factura_id] [int] NOT NULL,
 CONSTRAINT [PK__factura__3213E83F3E52440B] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[fallecido]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fallecido](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[persona_id] [int] NOT NULL,
 CONSTRAINT [PK__fallecid__3213E83F03317E3D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[familiar]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[familiar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[persona_id] [int] NOT NULL,
 CONSTRAINT [PK__familiar__3213E83F07F6335A] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[jornada_laboral]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[jornada_laboral](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK__jornada___3213E83F0CBAE877] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[material]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[material](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK__material__3213E83F286302EC] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[persona]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[persona](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[rut] [varchar](10) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellidoPaterno] [varchar](20) NOT NULL,
	[apellidoMaterno] [varchar](20) NOT NULL,
	[edad] [int] NOT NULL,
	[telefono] [int] NOT NULL,
 CONSTRAINT [PK__persona__3213E83F7F60ED59] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[sector]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sector](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[capacidad] [int] NOT NULL,
	[extension_variable] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK__sector__3213E83F24927208] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_tumba]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipo_tumba](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK__tipo_tum__3213E83F2C3393D0] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tumba]    Script Date: 26/11/2019 10:07:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tumba](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo_tumba_id] [int] NOT NULL,
	[material_id] [int] NOT NULL,
	[fallecido_id] [int] NOT NULL,
 CONSTRAINT [PK__tumba__3213E83F300424B4] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[categoria] ON 

INSERT [dbo].[categoria] ([id], [nombre], [descripcion]) VALUES (1, N'Enterradores', N'Entierra al muerto')
INSERT [dbo].[categoria] ([id], [nombre], [descripcion]) VALUES (2, N'Jardineros', N'Tareas de jardin')
INSERT [dbo].[categoria] ([id], [nombre], [descripcion]) VALUES (3, N'Administrativos', N'Gestiones administrativas')
SET IDENTITY_INSERT [dbo].[categoria] OFF
SET IDENTITY_INSERT [dbo].[dato_interes] ON 

INSERT [dbo].[dato_interes] ([id], [nombre], [descripcion]) VALUES (1, N'tio/a', N'Esta es una descripción')
INSERT [dbo].[dato_interes] ([id], [nombre], [descripcion]) VALUES (2, N'sobrino/a', N'Esta es una descripción')
INSERT [dbo].[dato_interes] ([id], [nombre], [descripcion]) VALUES (3, N'hermano/a', N'Esta es una descripción')
SET IDENTITY_INSERT [dbo].[dato_interes] OFF
SET IDENTITY_INSERT [dbo].[Detalle] ON 

INSERT [dbo].[Detalle] ([id], [id_fallecido], [id_factura], [descuento], [total]) VALUES (622, 2, 1, 2598, 12990)
INSERT [dbo].[Detalle] ([id], [id_fallecido], [id_factura], [descuento], [total]) VALUES (623, 3, 2, 2598, 12990)
INSERT [dbo].[Detalle] ([id], [id_fallecido], [id_factura], [descuento], [total]) VALUES (624, 19, 4, 3000, 15000)
INSERT [dbo].[Detalle] ([id], [id_fallecido], [id_factura], [descuento], [total]) VALUES (625, 21, 5, 5000000, 25000000)
INSERT [dbo].[Detalle] ([id], [id_fallecido], [id_factura], [descuento], [total]) VALUES (626, 22, 6, 5000000, 25000000)
INSERT [dbo].[Detalle] ([id], [id_fallecido], [id_factura], [descuento], [total]) VALUES (627, 23, 7, 22400, 112000)
INSERT [dbo].[Detalle] ([id], [id_fallecido], [id_factura], [descuento], [total]) VALUES (628, 24, 8, 5000000, 25000000)
INSERT [dbo].[Detalle] ([id], [id_fallecido], [id_factura], [descuento], [total]) VALUES (629, 25, 9, 5000000, 25000000)
INSERT [dbo].[Detalle] ([id], [id_fallecido], [id_factura], [descuento], [total]) VALUES (630, 26, 10, 2500000, 12500000)
SET IDENTITY_INSERT [dbo].[Detalle] OFF
SET IDENTITY_INSERT [dbo].[detalle_dato_interes] ON 

INSERT [dbo].[detalle_dato_interes] ([id], [familiar_id], [dato_interes_id]) VALUES (1, 1, 1)
INSERT [dbo].[detalle_dato_interes] ([id], [familiar_id], [dato_interes_id]) VALUES (2, 2, 1)
INSERT [dbo].[detalle_dato_interes] ([id], [familiar_id], [dato_interes_id]) VALUES (3, 3, 1)
INSERT [dbo].[detalle_dato_interes] ([id], [familiar_id], [dato_interes_id]) VALUES (4, 4, 2)
INSERT [dbo].[detalle_dato_interes] ([id], [familiar_id], [dato_interes_id]) VALUES (5, 5, 2)
INSERT [dbo].[detalle_dato_interes] ([id], [familiar_id], [dato_interes_id]) VALUES (6, 6, 2)
INSERT [dbo].[detalle_dato_interes] ([id], [familiar_id], [dato_interes_id]) VALUES (7, 7, 3)
INSERT [dbo].[detalle_dato_interes] ([id], [familiar_id], [dato_interes_id]) VALUES (8, 8, 3)
INSERT [dbo].[detalle_dato_interes] ([id], [familiar_id], [dato_interes_id]) VALUES (9, 9, 3)
INSERT [dbo].[detalle_dato_interes] ([id], [familiar_id], [dato_interes_id]) VALUES (10, 10, 1)
SET IDENTITY_INSERT [dbo].[detalle_dato_interes] OFF
SET IDENTITY_INSERT [dbo].[detalle_factura] ON 

INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (1, 1, 1, 1, 2)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (2, 2, 2, 2, 3)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (6, 14, 3, 18, 19)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (7, 14, 3, 18, 19)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (8, 10, 3, 20, 10)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (9, 14, 3, 21, 19)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (10, 14, 3, 22, 19)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (11, 8, 3, 23, 8)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (12, 14, 3, 24, 19)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (13, 15, 3, 25, 20)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (14, 16, 3, 26, 21)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (15, 8, 3, 27, 8)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (16, 8, 3, 27, 8)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (17, 16, 3, 29, 21)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (18, 17, 7, 30, 22)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (19, 18, 1, 31, 23)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (20, 19, 5, 32, 24)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (21, 20, 3, 33, 25)
INSERT [dbo].[detalle_factura] ([id], [tumba_id], [sector_id], [familiar_id], [fallecido_id]) VALUES (22, 21, 3, 34, 26)
SET IDENTITY_INSERT [dbo].[detalle_factura] OFF
SET IDENTITY_INSERT [dbo].[empleado] ON 

INSERT [dbo].[empleado] ([id], [salario], [antiguedad], [persona_id], [categoria_id], [jornada_laboral_id]) VALUES (1, 300000, CAST(N'2012-12-12' AS Date), 1, 1, 1)
INSERT [dbo].[empleado] ([id], [salario], [antiguedad], [persona_id], [categoria_id], [jornada_laboral_id]) VALUES (2, 300000, CAST(N'2012-12-12' AS Date), 2, 1, 3)
INSERT [dbo].[empleado] ([id], [salario], [antiguedad], [persona_id], [categoria_id], [jornada_laboral_id]) VALUES (3, 400000, CAST(N'2012-12-12' AS Date), 3, 2, 1)
INSERT [dbo].[empleado] ([id], [salario], [antiguedad], [persona_id], [categoria_id], [jornada_laboral_id]) VALUES (4, 400000, CAST(N'2012-12-12' AS Date), 4, 2, 2)
INSERT [dbo].[empleado] ([id], [salario], [antiguedad], [persona_id], [categoria_id], [jornada_laboral_id]) VALUES (5, 500000, CAST(N'2012-12-12' AS Date), 5, 3, 1)
INSERT [dbo].[empleado] ([id], [salario], [antiguedad], [persona_id], [categoria_id], [jornada_laboral_id]) VALUES (6, 500000, CAST(N'2012-12-12' AS Date), 6, 3, 2)
SET IDENTITY_INSERT [dbo].[empleado] OFF
SET IDENTITY_INSERT [dbo].[factura] ON 

INSERT [dbo].[factura] ([id], [total], [fecha_emision], [detalle_factura_id]) VALUES (1, 12990, CAST(N'2012-11-12' AS Date), 1)
INSERT [dbo].[factura] ([id], [total], [fecha_emision], [detalle_factura_id]) VALUES (2, 12990, CAST(N'2012-11-12' AS Date), 2)
INSERT [dbo].[factura] ([id], [total], [fecha_emision], [detalle_factura_id]) VALUES (4, 15000, CAST(N'2015-12-15' AS Date), 6)
INSERT [dbo].[factura] ([id], [total], [fecha_emision], [detalle_factura_id]) VALUES (5, 25000000, CAST(N'2019-10-14' AS Date), 14)
INSERT [dbo].[factura] ([id], [total], [fecha_emision], [detalle_factura_id]) VALUES (6, 25000000, CAST(N'2019-10-14' AS Date), 18)
INSERT [dbo].[factura] ([id], [total], [fecha_emision], [detalle_factura_id]) VALUES (7, 112000, CAST(N'2019-10-15' AS Date), 19)
INSERT [dbo].[factura] ([id], [total], [fecha_emision], [detalle_factura_id]) VALUES (8, 25000000, CAST(N'2019-10-15' AS Date), 20)
INSERT [dbo].[factura] ([id], [total], [fecha_emision], [detalle_factura_id]) VALUES (9, 25000000, CAST(N'2019-10-15' AS Date), 21)
INSERT [dbo].[factura] ([id], [total], [fecha_emision], [detalle_factura_id]) VALUES (10, 12500000, CAST(N'2019-10-15' AS Date), 22)
SET IDENTITY_INSERT [dbo].[factura] OFF
SET IDENTITY_INSERT [dbo].[fallecido] ON 

INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (1, 11)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (2, 12)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (3, 13)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (4, 14)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (5, 15)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (6, 16)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (7, 17)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (8, 18)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (9, 19)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (10, 20)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (17, 28)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (18, 32)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (19, 33)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (20, 44)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (21, 46)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (22, 51)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (23, 53)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (24, 55)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (25, 57)
INSERT [dbo].[fallecido] ([id], [persona_id]) VALUES (26, 59)
SET IDENTITY_INSERT [dbo].[fallecido] OFF
SET IDENTITY_INSERT [dbo].[familiar] ON 

INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (1, 1)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (2, 2)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (3, 3)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (4, 4)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (5, 5)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (6, 6)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (7, 7)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (8, 8)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (9, 9)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (10, 10)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (11, 25)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (12, 25)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (13, 28)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (14, 25)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (15, 34)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (16, 35)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (17, 36)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (18, 37)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (19, 37)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (20, 39)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (21, 40)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (22, 41)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (23, 42)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (24, 43)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (25, 45)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (26, 47)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (27, 48)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (28, 48)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (29, 50)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (30, 52)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (31, 54)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (32, 56)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (33, 58)
INSERT [dbo].[familiar] ([id], [persona_id]) VALUES (34, 60)
SET IDENTITY_INSERT [dbo].[familiar] OFF
SET IDENTITY_INSERT [dbo].[jornada_laboral] ON 

INSERT [dbo].[jornada_laboral] ([id], [nombre], [descripcion]) VALUES (1, N'Diurno', N'En la mañana')
INSERT [dbo].[jornada_laboral] ([id], [nombre], [descripcion]) VALUES (2, N'Intermedio', N'En la tarde')
INSERT [dbo].[jornada_laboral] ([id], [nombre], [descripcion]) VALUES (3, N'Vespertino', N'En la noche')
SET IDENTITY_INSERT [dbo].[jornada_laboral] OFF
SET IDENTITY_INSERT [dbo].[material] ON 

INSERT [dbo].[material] ([id], [nombre], [descripcion]) VALUES (1, N'Roble', N'de roble')
INSERT [dbo].[material] ([id], [nombre], [descripcion]) VALUES (2, N'Acero', N'de acero')
SET IDENTITY_INSERT [dbo].[material] OFF
SET IDENTITY_INSERT [dbo].[persona] ON 

INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (1, N'121212-2', N'Pablo', N'Jerez', N'Sepulveda', 19, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (2, N'131313-3', N'Miguel', N'Facundo', N'Gonzales', 22, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (3, N'141414-4', N'Bastian', N'Sifuentes', N'Vergara', 23, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (4, N'151515-5', N'Rosa', N'Espinoza', N'Hernandez', 64, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (5, N'161616-6', N'Bryan', N'Muñoz', N'Pardo', 23, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (6, N'171717-7', N'Patricia', N'Rosas', N'Brito', 43, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (7, N'122121-1', N'Kimberly', N'Perez', N'Gonzales', 45, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (8, N'212233-8', N'Felipe', N'Gonzales', N'Vera', 46, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (9, N'354543-9', N'Ignacio', N'Cardenas', N'Troncozo', 64, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (10, N'445234-k', N'Carlos', N'Barrales', N'Orellana', 46, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (11, N'232323-2', N'Patricia', N'Jerez', N'Sepulveda', 19, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (12, N'354554-3', N'Carlos', N'Facundo', N'Gonzales', 22, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (13, N'234344-4', N'Abigail', N'Sifuentes', N'Vergara', 23, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (14, N'454454-5', N'Javiera', N'Espinoza', N'Hernandez', 64, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (15, N'635356-6', N'Angelica', N'Muñoz', N'Pardo', 23, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (16, N'647458-7', N'Angela', N'Rosas', N'Brito', 43, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (17, N'578857-1', N'Andrea', N'Perez', N'Gonzales', 45, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (18, N'457574-8', N'Andres', N'Gonzales', N'Vera', 46, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (19, N'476757-9', N'Franco', N'Cardenas', N'Troncozo', 64, 121212)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (20, N'546456-k', N'Alan', N'Barrales', N'Orellana', 44, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (25, N'194299419', N'Bredgary', N'Valenzuela', N'Muñoz', 18, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (27, N'194299419', N'Bredgary', N'Valenzuela', N'Muñoz', 23, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (28, N'19721099-0', N'dibewi', N'iughuig', N'iugig', 76843, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (29, N'194299419', N'Bredgary', N'Valenzuela', N'Muñoz', 18, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (30, N'194299419', N'Bredgary', N'Valenzuela', N'Muñoz', 22, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (31, N'19721099-0', N'michael ', N'vega', N'diaz', 33, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (32, N'17426448-5', N'bhb', N'bkj', N'kjb', 4, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (33, N'46844864-4', N'hjb', N'hjb', N'hbj', 4, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (34, N'65498798-8', N'juujuju', N'jujujuju', N'jujujuju', 54, 55486878)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (35, N'13264578-7', N'kjnk', N'bhj', N'nk', 4, 54878984)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (36, N'4564468-8', N'fhv', N'hgv', N'hv', 5, 55454555)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (37, N'10422745-8', N'hu', N'iiuh', N'ih', 65, 55489685)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (38, N'10422745-8', N'hu', N'iiuh', N'ih', 65, 55489685)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (39, N'18848489-8', N'bhjb', N'jhb', N'jh', 54, 54577555)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (40, N'13456788-5', N'yugj', N'jhj', N'jh', 45, 54789878)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (41, N'15487898-9', N'894', N'498', N'498', 45, 54)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (42, N'1346798-9', N'848848', N'848484', N'848484', 84, 848484848)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (43, N'68686889-8', N'gvj', N'jg', N'jh', 48, 488484848)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (44, N'12345678-9', N'prueb', N'prue', N'pru', 25, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (45, N'98765432-1', N'jhkj', N'kj', N'kj', 45, 54545455)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (46, N'12345678-8', N'prueb', N'prue', N'pru', 25, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (47, N'45698778-7', N'456', N'654', N'654', 65, 65468456)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (48, N'1561656-5', N'bhjbj', N'bjh', N'bj', 52, 488848484)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (49, N'1561656-5', N'bhjbj', N'bjh', N'bj', 52, 488848484)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (50, N'18949894', N'hjb', N'k', N'nkj', 4, 45454544)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (51, N'9025848-6', N'tomas', N'rojas', N'alvarado', 40, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (52, N'19721099-5', N'Kiara', N'gato', N'perro', 21, 84956281)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (53, N'17246644-3', N'Kalila', N'Undurraga', N'Piñera', 19, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (54, N'19722010-1', N'Mojojo', N'Ramirez', N'Tapia', 35, 64859785)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (55, N'12456789-8', N'jgj', N'jkg', N'kkg', 456, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (56, N'46987789-9', N'iug', N'igi', N'giu', 45, 65478987)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (57, N'12456789-9', N'jgj', N'jkg', N'kkg', 456, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (58, N'65167887-9', N'yufg', N'yuf', N'uy', 4, 454545445)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (59, N'19191919', N'Bredgary', N'Valenzuela ', N'Munoz', 23, 0)
INSERT [dbo].[persona] ([id], [rut], [nombre], [apellidoPaterno], [apellidoMaterno], [edad], [telefono]) VALUES (60, N'1942941994', N'iug', N'igi', N'giu', 33, 5165156)
SET IDENTITY_INSERT [dbo].[persona] OFF
SET IDENTITY_INSERT [dbo].[sector] ON 

INSERT [dbo].[sector] ([id], [capacidad], [extension_variable]) VALUES (1, 4, CAST(7 AS Decimal(18, 0)))
INSERT [dbo].[sector] ([id], [capacidad], [extension_variable]) VALUES (2, 3, CAST(5 AS Decimal(18, 0)))
INSERT [dbo].[sector] ([id], [capacidad], [extension_variable]) VALUES (3, 2, CAST(3 AS Decimal(18, 0)))
INSERT [dbo].[sector] ([id], [capacidad], [extension_variable]) VALUES (4, 5, CAST(7 AS Decimal(18, 0)))
INSERT [dbo].[sector] ([id], [capacidad], [extension_variable]) VALUES (5, 6, CAST(6 AS Decimal(18, 0)))
INSERT [dbo].[sector] ([id], [capacidad], [extension_variable]) VALUES (6, 3, CAST(1 AS Decimal(18, 0)))
INSERT [dbo].[sector] ([id], [capacidad], [extension_variable]) VALUES (7, 5, CAST(4 AS Decimal(18, 0)))
INSERT [dbo].[sector] ([id], [capacidad], [extension_variable]) VALUES (8, 7, CAST(4 AS Decimal(18, 0)))
INSERT [dbo].[sector] ([id], [capacidad], [extension_variable]) VALUES (9, 4, CAST(13 AS Decimal(18, 0)))
INSERT [dbo].[sector] ([id], [capacidad], [extension_variable]) VALUES (10, 3, CAST(12 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[sector] OFF
SET IDENTITY_INSERT [dbo].[tipo_tumba] ON 

INSERT [dbo].[tipo_tumba] ([id], [nombre], [descripcion]) VALUES (1, N'Nicho', N'capacidad 1 persona')
INSERT [dbo].[tipo_tumba] ([id], [nombre], [descripcion]) VALUES (2, N'Panteon', N'capacidad 4 personas')
INSERT [dbo].[tipo_tumba] ([id], [nombre], [descripcion]) VALUES (3, N'Fosa Comun', N'capacidad no definida')
SET IDENTITY_INSERT [dbo].[tipo_tumba] OFF
SET IDENTITY_INSERT [dbo].[tumba] ON 

INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (1, 1, 1, 1)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (2, 2, 2, 2)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (3, 3, 2, 3)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (4, 1, 1, 4)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (5, 2, 2, 5)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (6, 3, 2, 6)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (7, 1, 1, 7)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (8, 2, 2, 8)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (9, 3, 2, 9)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (10, 1, 1, 10)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (14, 1, 1, 19)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (15, 2, 2, 20)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (16, 2, 2, 21)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (17, 2, 2, 22)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (18, 2, 1, 23)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (19, 2, 2, 24)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (20, 2, 2, 25)
INSERT [dbo].[tumba] ([id], [tipo_tumba_id], [material_id], [fallecido_id]) VALUES (21, 1, 1, 26)
SET IDENTITY_INSERT [dbo].[tumba] OFF
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_factura] FOREIGN KEY([id_factura])
REFERENCES [dbo].[factura] ([id])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK_Detalle_factura]
GO
ALTER TABLE [dbo].[Detalle]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_fallecido] FOREIGN KEY([id_fallecido])
REFERENCES [dbo].[fallecido] ([id])
GO
ALTER TABLE [dbo].[Detalle] CHECK CONSTRAINT [FK_Detalle_fallecido]
GO
ALTER TABLE [dbo].[detalle_dato_interes]  WITH CHECK ADD  CONSTRAINT [fk_datoInteres_ddi] FOREIGN KEY([dato_interes_id])
REFERENCES [dbo].[dato_interes] ([id])
GO
ALTER TABLE [dbo].[detalle_dato_interes] CHECK CONSTRAINT [fk_datoInteres_ddi]
GO
ALTER TABLE [dbo].[detalle_dato_interes]  WITH CHECK ADD  CONSTRAINT [fk_familiar_ddi] FOREIGN KEY([familiar_id])
REFERENCES [dbo].[familiar] ([id])
GO
ALTER TABLE [dbo].[detalle_dato_interes] CHECK CONSTRAINT [fk_familiar_ddi]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [fk_detfac_fal] FOREIGN KEY([fallecido_id])
REFERENCES [dbo].[fallecido] ([id])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [fk_detfac_fal]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [fk_detfac_fam] FOREIGN KEY([familiar_id])
REFERENCES [dbo].[familiar] ([id])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [fk_detfac_fam]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [fk_detfac_mat] FOREIGN KEY([sector_id])
REFERENCES [dbo].[sector] ([id])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [fk_detfac_mat]
GO
ALTER TABLE [dbo].[detalle_factura]  WITH CHECK ADD  CONSTRAINT [fk_detfac_tum] FOREIGN KEY([tumba_id])
REFERENCES [dbo].[tumba] ([id])
GO
ALTER TABLE [dbo].[detalle_factura] CHECK CONSTRAINT [fk_detfac_tum]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [fk_categoria_emp] FOREIGN KEY([categoria_id])
REFERENCES [dbo].[categoria] ([id])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [fk_categoria_emp]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [fk_jornadal_emp] FOREIGN KEY([jornada_laboral_id])
REFERENCES [dbo].[jornada_laboral] ([id])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [fk_jornadal_emp]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [fk_persona_emp] FOREIGN KEY([persona_id])
REFERENCES [dbo].[persona] ([id])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [fk_persona_emp]
GO
ALTER TABLE [dbo].[factura]  WITH CHECK ADD  CONSTRAINT [fk_factura_dfa] FOREIGN KEY([detalle_factura_id])
REFERENCES [dbo].[detalle_factura] ([id])
GO
ALTER TABLE [dbo].[factura] CHECK CONSTRAINT [fk_factura_dfa]
GO
ALTER TABLE [dbo].[fallecido]  WITH CHECK ADD  CONSTRAINT [fk_persona_fal] FOREIGN KEY([persona_id])
REFERENCES [dbo].[persona] ([id])
GO
ALTER TABLE [dbo].[fallecido] CHECK CONSTRAINT [fk_persona_fal]
GO
ALTER TABLE [dbo].[familiar]  WITH CHECK ADD  CONSTRAINT [fk_persona_fam] FOREIGN KEY([persona_id])
REFERENCES [dbo].[persona] ([id])
GO
ALTER TABLE [dbo].[familiar] CHECK CONSTRAINT [fk_persona_fam]
GO
ALTER TABLE [dbo].[tumba]  WITH CHECK ADD  CONSTRAINT [fk_tumba_fal] FOREIGN KEY([fallecido_id])
REFERENCES [dbo].[fallecido] ([id])
GO
ALTER TABLE [dbo].[tumba] CHECK CONSTRAINT [fk_tumba_fal]
GO
ALTER TABLE [dbo].[tumba]  WITH CHECK ADD  CONSTRAINT [fk_tumba_mat] FOREIGN KEY([material_id])
REFERENCES [dbo].[material] ([id])
GO
ALTER TABLE [dbo].[tumba] CHECK CONSTRAINT [fk_tumba_mat]
GO
ALTER TABLE [dbo].[tumba]  WITH CHECK ADD  CONSTRAINT [fk_tumba_tdt] FOREIGN KEY([tipo_tumba_id])
REFERENCES [dbo].[tipo_tumba] ([id])
GO
ALTER TABLE [dbo].[tumba] CHECK CONSTRAINT [fk_tumba_tdt]
GO
/****** Object:  Trigger [dbo].[descuentos]    Script Date: 26/11/2019 10:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[descuentos]
ON [dbo].[factura]
AFTER Update
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO dbo.Detalle(
        id_factura,
         id_fallecido,
         descuento,
         total
          
    )
    SELECT
        f.id,
        df.fallecido_id,
        f.total*0.2,
        f.total
    FROM
        detalle_factura df,factura f
    
    
END
GO
/****** Object:  Trigger [dbo].[descuentos2]    Script Date: 26/11/2019 10:07:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[descuentos2]
ON [dbo].[factura]
AFTER insert
AS
BEGIN
    delete from detalle;
    
    INSERT INTO dbo.Detalle(
        id_factura,
         id_fallecido,
         descuento,
         total
          
    )
    SELECT
        f.id,
        df.fallecido_id,
        f.total*0.2,
        f.total
    FROM
        detalle_factura df,factura f
        where f.detalle_factura_id=df.id
        order by f.id
    
    
END
GO
USE [master]
GO
ALTER DATABASE [mbbCementerio] SET  READ_WRITE 
GO
