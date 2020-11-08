USE [master]
GO
/****** Object:  Database [DB_A69D2C_NoteBugs]    Script Date: 8/11/2020 01:24:39 ******/
CREATE DATABASE [DB_A69D2C_NoteBugs]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_A69D2C_NoteBugs_Data', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_A69D2C_NoteBugs_DATA.mdf' , SIZE = 8192KB , MAXSIZE = 1024000KB , FILEGROWTH = 10%)
 LOG ON 
( NAME = N'DB_A69D2C_NoteBugs_Log', FILENAME = N'H:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DB_A69D2C_NoteBugs_Log.LDF' , SIZE = 3072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_A69D2C_NoteBugs].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET  MULTI_USER 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET QUERY_STORE = OFF
GO
USE [DB_A69D2C_NoteBugs]
GO
/****** Object:  Table [dbo].[Actividades]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actividades](
	[id_actividad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[descripcion] [varchar](400) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Actividades] PRIMARY KEY CLUSTERED 
(
	[id_actividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActividadesXCurso]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActividadesXCurso](
	[id_actividad] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[porc_de_avance] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_ActividadesXCurso] PRIMARY KEY CLUSTERED 
(
	[id_actividad] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Barrios]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barrios](
	[id_barrio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Barrios] PRIMARY KEY CLUSTERED 
(
	[id_barrio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bugs]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bugs](
	[id_bug] [int] IDENTITY(1,1) NOT NULL,
	[titulo] [varchar](100) NOT NULL,
	[descripcion] [varchar](1000) NULL,
	[fecha_alta] [date] NOT NULL,
	[id_usuario_responsable] [int] NULL,
	[id_usuario_asignado] [int] NULL,
	[id_producto] [int] NULL,
	[id_prioridad] [int] NULL,
	[id_criticidad] [int] NULL,
	[id_estado] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Bugs] PRIMARY KEY CLUSTERED 
(
	[id_bug] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BugsHistorico]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BugsHistorico](
	[id_bug_historico] [int] IDENTITY(1,1) NOT NULL,
	[fecha_historico] [date] NULL,
	[titulo] [varchar](100) NOT NULL,
	[descripcion] [varchar](1000) NULL,
	[id_bug] [int] NOT NULL,
	[id_usuario_responsable] [int] NULL,
	[id_usuario_asignado] [int] NULL,
	[id_producto] [int] NULL,
	[id_prioridad] [int] NULL,
	[id_criticidad] [int] NULL,
	[id_estado] [int] NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_BugsHistorico] PRIMARY KEY CLUSTERED 
(
	[id_bug_historico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CasosDePrueba]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CasosDePrueba](
	[id_caso_prueba] [int] IDENTITY(1,1) NOT NULL,
	[id_plan_prueba] [int] NOT NULL,
	[titulo] [varchar](50) NULL,
	[descripcion] [varchar](200) NULL,
	[id_responsable] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_CasosDePrueba_1] PRIMARY KEY CLUSTERED 
(
	[id_caso_prueba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[descripcion] [nvarchar](400) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Categorias] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CiclosPrueba]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CiclosPrueba](
	[id_ciclo_prueba] [int] NOT NULL,
	[fecha_inicio_ejecucion] [datetime] NULL,
	[fecha_fin_ejecucion] [datetime] NULL,
	[id_responsable] [int] NULL,
	[id_plan_prueba] [int] NULL,
	[aceptado] [bit] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_CiclosPrueba] PRIMARY KEY CLUSTERED 
(
	[id_ciclo_prueba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CiclosPruebaDetalle]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CiclosPruebaDetalle](
	[id_ciclo_prueba_detalle] [int] NOT NULL,
	[id_ciclo_prueba] [int] NULL,
	[id_caso_prueba] [int] NULL,
	[id_usuario_tester] [int] NULL,
	[cantidad_horas] [decimal](18, 0) NULL,
	[fecha_ejecucion] [datetime] NULL,
	[aceptado] [bit] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_CiclosPruebaDetalle] PRIMARY KEY CLUSTERED 
(
	[id_ciclo_prueba_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[cuit] [varchar](50) NULL,
	[razon_social] [varchar](50) NULL,
	[borrado] [bit] NULL,
	[calle] [varchar](500) NULL,
	[numero] [varchar](50) NULL,
	[fecha_alta] [datetime] NULL,
	[id_barrio] [int] NULL,
	[id_contacto] [int] NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[id_contacto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Contactos] PRIMARY KEY CLUSTERED 
(
	[id_contacto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Criticidades]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Criticidades](
	[id_criticidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Criticidades] PRIMARY KEY CLUSTERED 
(
	[id_criticidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[id_curso] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[descripcion] [nvarchar](400) NULL,
	[fecha_vigencia] [datetime] NULL,
	[id_categoria] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Cursos] PRIMARY KEY CLUSTERED 
(
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estados]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estados](
	[id_estado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[id_factura] [int] IDENTITY(1,1) NOT NULL,
	[numero_factura] [varchar](50) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_usuario_creador] [int] NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturasDetalle]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturasDetalle](
	[id_detalle_factura] [int] IDENTITY(1,1) NOT NULL,
	[id_factura] [int] NULL,
	[numero_orden] [int] NULL,
	[id_producto] [int] NULL,
	[id_proyecto] [int] NULL,
	[id_ciclo_prueba] [int] NULL,
	[precio] [decimal](18, 0) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_FacturaDetalles] PRIMARY KEY CLUSTERED 
(
	[id_detalle_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Formularios]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Formularios](
	[id_formulario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Formularios] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Objetivos]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Objetivos](
	[id_objetivo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_corto] [varchar](100) NULL,
	[nombre_largo] [varchar](100) NULL,
	[descripcion] [nvarchar](400) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Objetivos] PRIMARY KEY CLUSTERED 
(
	[id_objetivo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ObjetivosCursos]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjetivosCursos](
	[id_objetivo] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[puntos] [int] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_ObjetivosCursos] PRIMARY KEY CLUSTERED 
(
	[id_objetivo] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfiles](
	[id_perfil] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[borrado] [bit] NOT NULL,
 CONSTRAINT [PK_Perfiles] PRIMARY KEY CLUSTERED 
(
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[id_formulario] [int] NOT NULL,
	[id_perfil] [int] NOT NULL,
	[borrado] [int] NULL,
 CONSTRAINT [PK_Permisos] PRIMARY KEY CLUSTERED 
(
	[id_formulario] ASC,
	[id_perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanesDePrueba]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanesDePrueba](
	[id_plan_prueba] [int] IDENTITY(1,1) NOT NULL,
	[id_proyecto] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_responsable] [int] NULL,
	[descripcion] [varchar](100) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_PlanesDePrueba] PRIMARY KEY CLUSTERED 
(
	[id_plan_prueba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prioridades]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prioridades](
	[id_prioridad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Prioridades] PRIMARY KEY CLUSTERED 
(
	[id_prioridad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proyectos]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proyectos](
	[id_proyecto] [int] NOT NULL,
	[id_producto] [int] NULL,
	[descripcion] [varchar](50) NULL,
	[version] [varchar](50) NULL,
	[alcance] [varchar](50) NULL,
	[id_responsable] [int] NULL,
	[borrado] [nchar](10) NULL,
 CONSTRAINT [PK_Proyectos] PRIMARY KEY CLUSTERED 
(
	[id_proyecto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[id_perfil] [int] NOT NULL,
	[usuario] [varchar](100) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[estado] [varchar](1) NOT NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosCurso]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosCurso](
	[id_usuario] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[puntuacion] [int] NULL,
	[observaciones] [varchar](400) NULL,
	[fecha_inicio] [datetime] NULL,
	[fecha_fin] [datetime] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_UsuariosCurso] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_curso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuariosCursoAvance]    Script Date: 8/11/2020 01:24:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuariosCursoAvance](
	[id_usuario] [int] NOT NULL,
	[id_curso] [int] NOT NULL,
	[id_actividad] [int] NOT NULL,
	[fin] [datetime] NULL,
	[porc_avance] [int] NULL,
	[finalizado] [bit] NULL,
	[borrado] [bit] NULL,
 CONSTRAINT [PK_UsuariosCursoAvance] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC,
	[id_curso] ASC,
	[id_actividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Actividades] ON 
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (1, N'TEMAS MULTIMEDIA', N'Explicaciones de los profesores «in situ» en el programa, no se
salte ninguno, vealos en el orden establecido aunque crea que ya los conoce. Repita
aquellos que no le queden perfectamente claros.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (2, N'MANUAL Y EJERCICIOS CS5', N'Son ejercicios muy guiados, muy paso a paso,
contemplan la práctica de lo aprendido anteriormente, los tiene que imprimir y realizar en
el programa Photoshop.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (3, N'EJERCICIOS FINALES y UTILIDADES', N'Son ejercicios menos guiados, debe prestarles
más antención, sirven para confirmar conocimientos adquiridos.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (4, N'Demo Photoshop CS5', N'Incluimos demo del programa para poder practicar y realizar los
ejercicios propuestos.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (5, N'1. Interfaz', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (6, N'2. Otros elementos de la Interfaz I', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (7, N'3. Otros elementos de la Interfaz II', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (8, N'4. Otros elementos de la Interfaz III', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (9, N'5. Coordenadas Autocad', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (10, N'6. Ayudas visuales', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (11, N'7. Asistente', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (12, N'8. Parámetros', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (13, N'9. Objetos básicos I', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (14, N'10. Objetos básicos II', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (15, N'11. Objetos básicos III', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (16, N'12. Objetos compuestos I', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (17, N'13. Objetos compuestos II', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (18, N'Polígonos', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (19, N'Formas básicas', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (20, N'Herramientas de texto', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (21, N'Contorno y relleno', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (22, N'Extrusión', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (23, N'Dar forma', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (24, N'Plantillas', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (25, N'Repaso', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (26, N'Instalar Joomla! en local', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (27, N'Elementos básicos de Joomla!', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (28, N'Categorías y Artículos', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (29, N'Artículos', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (30, N'Menús I', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (31, N'Menús II', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (32, N'Módulos', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (33, N'Usuarios y permisos', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (34, N'Extensiones', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (35, N'Plantillas y Gestor Multimedia', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (36, N'Instalar Joomla! en remoto', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (37, N'Programación en Joomla!', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (38, N'Conceptos básicos de Dreamweaver', N'Introducción.
Entrar y salir de Dreamweaver.
Crear, guardar y abrir documentos.
Resumen.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (39, N'El entorno de trabajo', N'Introducción.
La interfaz del programa.
El panel insertar.
El espacio de trabajo.
Definir un navegador web.
Resumen.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (40, N'Configuración de un sitio local', N'Introducción.
Crear un sitio local.
Administración de archivos y carpetas.
Resumen.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (41, N'Trabajar con Dreamweaver', N'Introducción.
Parámetros de apariencia de la página.
Trabajar con imágenes.
Trabajar con Texto.
Editar XHTML en Dreamweaver.
Creación de enlaces.
Resumen.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (42, N'Las hojas de estilos en cascada (CSS)', N'Introducción.
Hojas de estilo.
Crear una hoja de estilo.
El panel Estilos CSS.
Selectores CSS.
Resumen.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (43, N'Celdas y tablas', N'Introducción.
Crear tablas.
Dar formato a tabla y celdas.
Dar color a las tablas.
Ordenar los datos de una tabla.
Otras acciones con las tablas.
Resumen.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (44, N'Plantillas y librerías', N'Introducción.
Creación de plantillas.
Crear la composición de elementos en la plantilla.
Crear páginas a partir de una plantilla.
Modificar una plantilla.
Añadir regiones repetidas y opcionales.
La biblioteca.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (45, N'La publicación', N'Introducción.
Definición del Sitio.
Alojar nuestra primera página web.
Configurar la conexión FTP.
Resume', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (46, N'Promoción web gratis y de pago', N'Descubre herramientas para promocionar tu web, tanto gratuitas como de pago.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (47, N'Dominios', N'¿Influyen en el posicionamiento web? ¿Como?', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (48, N'Plantear la web ', N'Como plantear la web para tener una buena puntuación SEO.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (49, N'Enlaces internos', N'¿Qué son, para qué sirven?', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (50, N'Promoción de pago', N'Conoce un poco sobre SEM, Google AdWords.', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (51, N'1. Inicio WordPress I', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (52, N'2. Comenzar en WordPress', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (53, N'3. Personalización', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (54, N'4. Otras formas', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (55, N'5. Entradas', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (56, N'6. Ejercicio de inicio', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (57, N'7. Enlaces', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (58, N'8. Apariencia. Temas', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (59, N'El emprendedor y la idea emprendedora', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (60, N'La financiación de la empresa', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (61, N'El plan de empresa. Estructura y contenido', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (62, N'Modelo de plan de empresa', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (63, N'Los bienes inmuebles y La propiedad', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (64, N'Concepto de propiedad', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (65, N'La interpretación de Los Contratos', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (66, N'Naturaleza jurídica de La donación', N'', 0)
GO
INSERT [dbo].[Actividades] ([id_actividad], [nombre], [descripcion], [borrado]) VALUES (67, N'Efectos de La inscripción en el registro de La propiedad', N'', 0)
GO
SET IDENTITY_INSERT [dbo].[Actividades] OFF
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (1, 1, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (2, 1, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (3, 1, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (4, 1, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (5, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (6, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (7, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (8, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (9, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (10, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (11, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (12, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (13, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (14, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (15, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (16, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (17, 2, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (18, 3, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (19, 3, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (20, 3, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (21, 3, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (22, 3, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (23, 3, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (24, 3, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (25, 3, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (26, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (27, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (28, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (29, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (30, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (31, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (32, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (33, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (34, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (35, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (36, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (37, 4, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (38, 5, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (39, 5, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (40, 5, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (41, 5, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (42, 5, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (43, 5, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (44, 5, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (45, 5, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (46, 6, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (47, 6, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (48, 6, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (49, 6, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (50, 6, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (51, 8, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (52, 8, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (53, 8, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (54, 8, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (55, 8, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (56, 8, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (57, 8, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (58, 8, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (59, 9, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (60, 9, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (61, 9, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (62, 9, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (63, 10, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (64, 10, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (65, 10, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (66, 10, 0, 0)
GO
INSERT [dbo].[ActividadesXCurso] ([id_actividad], [id_curso], [porc_de_avance], [borrado]) VALUES (67, 10, 0, 0)
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON 
GO
INSERT [dbo].[Categorias] ([id_categoria], [nombre], [descripcion], [borrado]) VALUES (1, N'Diseño gráfico', N'El diseño gráfico es una profesión y disciplina académica cuya actividad consiste en proyectar comunicaciones visuales destinadas a transmitir mensajes específicos a grupos sociales, con objetivos determinados.', 0)
GO
INSERT [dbo].[Categorias] ([id_categoria], [nombre], [descripcion], [borrado]) VALUES (2, N'Desarrollo web y multimedia', N'Desarrollo web y multimedia es una de nuestras divisiones creativas y técnicas en la cual nos encargamos del desarrollo de su imagen en la web, desde la planeación del proyecto al desarrollo técnico, creativo, pruebas y producción.', 0)
GO
INSERT [dbo].[Categorias] ([id_categoria], [nombre], [descripcion], [borrado]) VALUES (3, N'Comercio y marketing', N'Cursos relacionados con esta categoría', 0)
GO
INSERT [dbo].[Categorias] ([id_categoria], [nombre], [descripcion], [borrado]) VALUES (4, N'Derecho', N'El derecho es un conjunto de principios y normas, generalmente inspirados en ideas de justicia y orden, que regulan las relaciones humanas en toda sociedad y cuya observancia es impuesta de forma coactiva por parte de un poder público.', 0)
GO
SET IDENTITY_INSERT [dbo].[Categorias] OFF
GO
SET IDENTITY_INSERT [dbo].[Cursos] ON 
GO
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (1, N'ADOBE ILLUSTRATOR- Online-', N'Curso de Adobe Photoshop CS5, curso que se desarrolla online, tiene un título al finalizar el mismo. ', CAST(N'2021-01-31T00:00:00.000' AS DateTime), 1, 0)
GO
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (2, N'CURSO DE 3D STUDIO MAX- Online-', N'El curso es totalmente online y cuenta con título acreditativo de haber superado el mismo con éxito. ', CAST(N'2021-06-09T00:00:00.000' AS DateTime), 1, 0)
GO
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (3, N'Curso Corel Draw versión 12 y la X3-Online–', N'Aprender de forma cómoda, rápida y sencilla a utilizar el programa de diseño Corel Draw.', CAST(N'2021-10-21T00:00:00.000' AS DateTime), 1, 0)
GO
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (4, N'Curso de Joomla -Online-', N'Joomla es un CMS para diseñar y crear páginas web.', CAST(N'2021-06-25T00:00:00.000' AS DateTime), 2, 0)
GO
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (5, N'Curso de DreamWeaver CS6 -Online-', N'Curso de DreamWeaver CS6  online que permite dominar este programa para editar y diseñar páginas web.', CAST(N'2021-02-18T00:00:00.000' AS DateTime), 2, 0)
GO
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (6, N'Posicionamiento web y promoción web', N'Completo curso online de posicionamiento web y promoción web. ', CAST(N'2021-06-09T00:00:00.000' AS DateTime), 2, 0)
GO
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (8, N'Máster Experto Web', N'El objetivo del Máster es formar a profesionales en desarrollo web con todos los conocimientos necesarios para poder realizar sitios webs de empresa con tiendas online y preparados en las necesarias condiciones de usabilidad y aptitudes para un buen posicionamiento.', CAST(N'2021-03-10T00:00:00.000' AS DateTime), 2, 0)
GO
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (9, N'Curso guía de emprendedores', N'Al calor de la crisis son muchos los que se han decidido a dar el gran salto hacia adelante y montar su propio negocio.
Sumate vos también.', CAST(N'2021-09-08T00:00:00.000' AS DateTime), 3, 0)
GO
INSERT [dbo].[Cursos] ([id_curso], [nombre], [descripcion], [fecha_vigencia], [id_categoria], [borrado]) VALUES (10, N'Curso de Derecho Civil Inmobiliario', N'Curso de Derecho Civil Inmobiliario a distancia, con título acreditativo al finalizar con éxito el curso.', CAST(N'2021-05-13T00:00:00.000' AS DateTime), 4, 0)
GO
SET IDENTITY_INSERT [dbo].[Cursos] OFF
GO
SET IDENTITY_INSERT [dbo].[Objetivos] ON 
GO
INSERT [dbo].[Objetivos] ([id_objetivo], [nombre_corto], [nombre_largo], [descripcion], [borrado]) VALUES (1, N'IA', N'Informática avanzada', N'Adquirir conceptos avanzados.', 0)
GO
INSERT [dbo].[Objetivos] ([id_objetivo], [nombre_corto], [nombre_largo], [descripcion], [borrado]) VALUES (2, N'DD', N'Diseño digital 2', N'Aprender herramientas de diseño', 0)
GO
SET IDENTITY_INSERT [dbo].[Objetivos] OFF
GO
SET IDENTITY_INSERT [dbo].[Perfiles] ON 
GO
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (1, N'Administrador', 0)
GO
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (2, N'Tester', 0)
GO
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (3, N'Desarrollador', 0)
GO
INSERT [dbo].[Perfiles] ([id_perfil], [nombre], [borrado]) VALUES (4, N'Usuario', 0)
GO
SET IDENTITY_INSERT [dbo].[Perfiles] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (1, 1, N'administrador', N'12345', N'admin@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (2, 2, N'Ariel', N'12345', N'ariel@gmail.com', N'N', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (3, 3, N'Miguel', N'12345', N'miguel@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (4, 2, N'Ana', N'12345', N'ana@gmail.com', N'N', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (5, 3, N'Diego', N'12345', N'diego@gmail.com', N'N', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (6, 2, N'Micaela', N'12345', N'mica@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (7, 1, N'Franco', N'12345', N'franco_cosci@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (8, 1, N'Candela', N'12345', N'candelamessiperez@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (9, 1, N'Tomas', N'12345', N'tomas00@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (10, 2, N'Antonio', N'12345', N'antonio99@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (11, 3, N'Juan', N'12345', N'juan87@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (12, 4, N'Carlota', N'12345', N'carlotaaa@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (13, 4, N'Nina', N'12345', N'ninaa@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (14, 4, N'Mirta', N'12345', N'mirtalegrand1800@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (15, 4, N'Esteban', N'12345', N'esteban_carro87@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (16, 3, N'Ramon', N'12345', N'ramon87@gmail.com', N'S', 0)
GO
INSERT [dbo].[Usuarios] ([id_usuario], [id_perfil], [usuario], [password], [email], [estado], [borrado]) VALUES (17, 3, N'Guido', N'12345', N'guido-kaska@gmail.com', N'S', 0)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (1, 1, 200, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (1, 2, 250, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (1, 3, 250, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (1, 4, 300, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (1, 5, 300, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (1, 6, 255, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (1, 8, 555, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (1, 9, 444, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (1, 10, 654, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (2, 2, 677, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (3, 2, 400, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (3, 9, 555, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (5, 2, 300, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (7, 1, 200, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-10-28T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (7, 2, 333, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-10-28T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (7, 3, 600, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-10-28T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (7, 4, 55, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-10-29T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (7, 5, 250, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-10-28T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (7, 6, 255, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-10-28T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (7, 8, 255, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-10-28T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (7, 9, 555, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-10-28T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (7, 10, 55, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-10-28T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (10, 4, 500, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-11-01T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (12, 2, 666, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (13, 2, 15, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (15, 4, 200, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-11-06T00:00:00.000' AS DateTime), 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (17, 3, 500, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), NULL, 0)
GO
INSERT [dbo].[UsuariosCurso] ([id_usuario], [id_curso], [puntuacion], [observaciones], [fecha_inicio], [fecha_fin], [borrado]) VALUES (17, 10, 333, N'', CAST(N'2020-09-20T00:00:00.000' AS DateTime), CAST(N'2020-10-29T00:00:00.000' AS DateTime), 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 1, 1, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 1, 2, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 1, 3, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 1, 4, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 5, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 6, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 7, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 8, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 9, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 10, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 11, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 12, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 13, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 14, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 15, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 16, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 2, 17, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 3, 18, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 3, 19, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 3, 20, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 3, 21, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 3, 22, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 3, 23, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 3, 24, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 3, 25, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 26, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 27, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 28, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 29, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 30, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 31, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 32, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 33, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 34, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 35, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 36, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 4, 37, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 5, 38, CAST(N'2020-11-03T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 5, 39, CAST(N'2020-11-03T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 5, 40, CAST(N'2020-11-03T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 5, 41, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 5, 42, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 5, 43, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 5, 44, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 5, 45, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 6, 46, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 6, 47, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 6, 48, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 6, 49, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 6, 50, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 8, 51, CAST(N'2020-10-30T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 8, 52, CAST(N'2020-10-30T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 8, 53, CAST(N'2020-10-30T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 8, 54, CAST(N'2020-10-30T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 8, 55, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 8, 56, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 8, 57, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 8, 58, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 9, 59, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 9, 60, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 9, 61, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 9, 62, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 10, 63, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 10, 64, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 10, 65, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 10, 66, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (1, 10, 67, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 5, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 6, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 7, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 8, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 9, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 10, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 11, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 12, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 13, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 14, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 15, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 16, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (2, 2, 17, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 5, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 6, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 7, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 8, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 9, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 10, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 11, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 12, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 13, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 14, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 15, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 16, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 2, 17, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 9, 59, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 9, 60, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 9, 61, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (3, 9, 62, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 5, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 6, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 7, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 8, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 9, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 10, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 11, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 12, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 13, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 14, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 15, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 16, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (5, 2, 17, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 1, 1, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 1, 2, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 1, 3, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 1, 4, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 5, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 6, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 7, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 8, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 9, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 10, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 11, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 12, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 13, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 14, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 15, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 16, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 17, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 2, 18, NULL, 0, 0, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 3, 18, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 3, 19, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 3, 20, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 3, 21, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 3, 22, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 3, 23, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 3, 24, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 3, 25, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 26, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 27, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 28, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 29, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 30, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 31, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 32, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 33, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 34, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 35, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 36, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 4, 37, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 5, 38, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 5, 39, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 5, 40, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 5, 41, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 5, 42, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 5, 43, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 5, 44, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 5, 45, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 6, 46, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 6, 47, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 6, 48, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 6, 49, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 6, 50, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 8, 51, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 8, 52, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 8, 53, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 8, 54, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 8, 55, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 8, 56, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 8, 57, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 8, 58, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 9, 59, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 9, 60, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 9, 61, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 9, 62, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 10, 63, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 10, 64, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 10, 65, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 10, 66, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (7, 10, 67, CAST(N'2020-10-28T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 26, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 27, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 28, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 29, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 30, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 31, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 32, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 33, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 34, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 35, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 36, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (10, 4, 37, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 5, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 6, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 7, CAST(N'2020-11-01T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 8, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 9, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 10, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 11, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 12, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 13, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 14, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 15, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 16, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (12, 2, 17, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 5, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 6, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 7, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 8, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 9, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 10, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 11, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 12, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 13, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 14, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 15, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 16, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (13, 2, 17, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 26, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 27, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 28, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 29, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 30, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 31, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 32, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 33, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 34, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 35, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 36, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (15, 4, 37, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 3, 18, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 3, 19, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 3, 20, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 3, 21, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 3, 22, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 3, 23, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 3, 24, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 3, 25, NULL, 0, 0, 0)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 10, 63, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 10, 64, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 10, 65, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 10, 66, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[UsuariosCursoAvance] ([id_usuario], [id_curso], [id_actividad], [fin], [porc_avance], [finalizado], [borrado]) VALUES (17, 10, 67, CAST(N'2020-10-29T00:00:00.000' AS DateTime), 0, 1, 1)
GO
ALTER TABLE [dbo].[Actividades] ADD  CONSTRAINT [DF_Actividades_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[ActividadesXCurso] ADD  CONSTRAINT [DF_ActividadesXCurso_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[BugsHistorico] ADD  CONSTRAINT [DF_BugsHistorico_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Criticidades] ADD  CONSTRAINT [DF_Criticidades_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Estados] ADD  CONSTRAINT [DF_Estados_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Formularios] ADD  CONSTRAINT [DF_Formularios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Perfiles] ADD  CONSTRAINT [DF_Perfiles_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Prioridades] ADD  CONSTRAINT [DF_Prioridades_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Productos] ADD  CONSTRAINT [DF_Productos_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [DF_Usuarios_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[UsuariosCurso] ADD  CONSTRAINT [DF_UsuariosCurso_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[UsuariosCursoAvance] ADD  CONSTRAINT [DF_UsuariosCursoAvance_finalizado]  DEFAULT ((0)) FOR [finalizado]
GO
ALTER TABLE [dbo].[UsuariosCursoAvance] ADD  CONSTRAINT [DF_UsuariosCursoAvance_borrado]  DEFAULT ((0)) FOR [borrado]
GO
ALTER TABLE [dbo].[ActividadesXCurso]  WITH CHECK ADD  CONSTRAINT [FK_ActividadesXCurso_Actividades] FOREIGN KEY([id_actividad])
REFERENCES [dbo].[Actividades] ([id_actividad])
GO
ALTER TABLE [dbo].[ActividadesXCurso] CHECK CONSTRAINT [FK_ActividadesXCurso_Actividades]
GO
ALTER TABLE [dbo].[ActividadesXCurso]  WITH CHECK ADD  CONSTRAINT [FK_ActividadesXCurso_Cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Cursos] ([id_curso])
GO
ALTER TABLE [dbo].[ActividadesXCurso] CHECK CONSTRAINT [FK_ActividadesXCurso_Cursos]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Criticidades] FOREIGN KEY([id_criticidad])
REFERENCES [dbo].[Criticidades] ([id_criticidad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Criticidades]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Estados] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estados] ([id_estado])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Estados]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Prioridades] FOREIGN KEY([id_prioridad])
REFERENCES [dbo].[Prioridades] ([id_prioridad])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Prioridades]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Productos]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Usuarios] FOREIGN KEY([id_usuario_asignado])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Usuarios]
GO
ALTER TABLE [dbo].[Bugs]  WITH CHECK ADD  CONSTRAINT [FK_Bugs_Usuarios1] FOREIGN KEY([id_usuario_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Bugs] CHECK CONSTRAINT [FK_Bugs_Usuarios1]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Bugs] FOREIGN KEY([id_bug])
REFERENCES [dbo].[Bugs] ([id_bug])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Bugs]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Criticidades] FOREIGN KEY([id_criticidad])
REFERENCES [dbo].[Criticidades] ([id_criticidad])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Criticidades]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Estados] FOREIGN KEY([id_estado])
REFERENCES [dbo].[Estados] ([id_estado])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Estados]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Prioridades] FOREIGN KEY([id_prioridad])
REFERENCES [dbo].[Prioridades] ([id_prioridad])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Prioridades]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Productos]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Usuarios] FOREIGN KEY([id_usuario_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Usuarios]
GO
ALTER TABLE [dbo].[BugsHistorico]  WITH CHECK ADD  CONSTRAINT [FK_BugsHistorico_Usuarios1] FOREIGN KEY([id_usuario_asignado])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[BugsHistorico] CHECK CONSTRAINT [FK_BugsHistorico_Usuarios1]
GO
ALTER TABLE [dbo].[CasosDePrueba]  WITH CHECK ADD  CONSTRAINT [FK_CasosDePrueba_PlanesDePrueba] FOREIGN KEY([id_plan_prueba])
REFERENCES [dbo].[PlanesDePrueba] ([id_plan_prueba])
GO
ALTER TABLE [dbo].[CasosDePrueba] CHECK CONSTRAINT [FK_CasosDePrueba_PlanesDePrueba]
GO
ALTER TABLE [dbo].[CiclosPrueba]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPrueba_PlanesDePrueba] FOREIGN KEY([id_plan_prueba])
REFERENCES [dbo].[PlanesDePrueba] ([id_plan_prueba])
GO
ALTER TABLE [dbo].[CiclosPrueba] CHECK CONSTRAINT [FK_CiclosPrueba_PlanesDePrueba]
GO
ALTER TABLE [dbo].[CiclosPrueba]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPrueba_Usuarios] FOREIGN KEY([id_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[CiclosPrueba] CHECK CONSTRAINT [FK_CiclosPrueba_Usuarios]
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPruebaDetalle_CasosDePrueba] FOREIGN KEY([id_caso_prueba])
REFERENCES [dbo].[CasosDePrueba] ([id_caso_prueba])
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle] CHECK CONSTRAINT [FK_CiclosPruebaDetalle_CasosDePrueba]
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPruebaDetalle_CiclosPrueba] FOREIGN KEY([id_ciclo_prueba])
REFERENCES [dbo].[CiclosPrueba] ([id_ciclo_prueba])
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle] CHECK CONSTRAINT [FK_CiclosPruebaDetalle_CiclosPrueba]
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_CiclosPruebaDetalle_Usuarios] FOREIGN KEY([id_usuario_tester])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[CiclosPruebaDetalle] CHECK CONSTRAINT [FK_CiclosPruebaDetalle_Usuarios]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Barrios] FOREIGN KEY([id_barrio])
REFERENCES [dbo].[Barrios] ([id_barrio])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Barrios]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Contactos] FOREIGN KEY([id_contacto])
REFERENCES [dbo].[Contactos] ([id_contacto])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Contactos]
GO
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Categorias] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categorias] ([id_categoria])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Categorias]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Clientes] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[Clientes] ([id_cliente])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Clientes]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_Facturas_Usuarios] FOREIGN KEY([id_usuario_creador])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_Facturas_Usuarios]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_CiclosPrueba] FOREIGN KEY([id_ciclo_prueba])
REFERENCES [dbo].[CiclosPrueba] ([id_ciclo_prueba])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_CiclosPrueba]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_Facturas] FOREIGN KEY([id_factura])
REFERENCES [dbo].[Facturas] ([id_factura])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_Facturas]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_Productos] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_Productos]
GO
ALTER TABLE [dbo].[FacturasDetalle]  WITH CHECK ADD  CONSTRAINT [FK_FacturasDetalle_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id_proyecto])
GO
ALTER TABLE [dbo].[FacturasDetalle] CHECK CONSTRAINT [FK_FacturasDetalle_Proyectos]
GO
ALTER TABLE [dbo].[ObjetivosCursos]  WITH CHECK ADD  CONSTRAINT [FK_ObjetivosCursos_Cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Cursos] ([id_curso])
GO
ALTER TABLE [dbo].[ObjetivosCursos] CHECK CONSTRAINT [FK_ObjetivosCursos_Cursos]
GO
ALTER TABLE [dbo].[ObjetivosCursos]  WITH CHECK ADD  CONSTRAINT [FK_ObjetivosCursos_Objetivos] FOREIGN KEY([id_objetivo])
REFERENCES [dbo].[Objetivos] ([id_objetivo])
GO
ALTER TABLE [dbo].[ObjetivosCursos] CHECK CONSTRAINT [FK_ObjetivosCursos_Objetivos]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Formularios] FOREIGN KEY([id_formulario])
REFERENCES [dbo].[Formularios] ([id_formulario])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Formularios]
GO
ALTER TABLE [dbo].[Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Permisos_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Permisos] CHECK CONSTRAINT [FK_Permisos_Perfiles]
GO
ALTER TABLE [dbo].[PlanesDePrueba]  WITH CHECK ADD  CONSTRAINT [FK_PlanesDePrueba_Proyectos] FOREIGN KEY([id_proyecto])
REFERENCES [dbo].[Proyectos] ([id_proyecto])
GO
ALTER TABLE [dbo].[PlanesDePrueba] CHECK CONSTRAINT [FK_PlanesDePrueba_Proyectos]
GO
ALTER TABLE [dbo].[PlanesDePrueba]  WITH CHECK ADD  CONSTRAINT [FK_PlanesDePrueba_Usuarios] FOREIGN KEY([id_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[PlanesDePrueba] CHECK CONSTRAINT [FK_PlanesDePrueba_Usuarios]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Producto]
GO
ALTER TABLE [dbo].[Proyectos]  WITH CHECK ADD  CONSTRAINT [FK_Proyectos_Responsable] FOREIGN KEY([id_responsable])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[Proyectos] CHECK CONSTRAINT [FK_Proyectos_Responsable]
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([id_perfil])
REFERENCES [dbo].[Perfiles] ([id_perfil])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
ALTER TABLE [dbo].[UsuariosCurso]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCurso_Cursos] FOREIGN KEY([id_curso])
REFERENCES [dbo].[Cursos] ([id_curso])
GO
ALTER TABLE [dbo].[UsuariosCurso] CHECK CONSTRAINT [FK_UsuariosCurso_Cursos]
GO
ALTER TABLE [dbo].[UsuariosCurso]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCurso_Usuarios] FOREIGN KEY([id_usuario])
REFERENCES [dbo].[Usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[UsuariosCurso] CHECK CONSTRAINT [FK_UsuariosCurso_Usuarios]
GO
ALTER TABLE [dbo].[UsuariosCursoAvance]  WITH CHECK ADD  CONSTRAINT [FK_UsuariosCursoAvance_UsuariosCurso] FOREIGN KEY([id_usuario], [id_curso])
REFERENCES [dbo].[UsuariosCurso] ([id_usuario], [id_curso])
GO
ALTER TABLE [dbo].[UsuariosCursoAvance] CHECK CONSTRAINT [FK_UsuariosCursoAvance_UsuariosCurso]
GO
USE [master]
GO
ALTER DATABASE [DB_A69D2C_NoteBugs] SET  READ_WRITE 
GO