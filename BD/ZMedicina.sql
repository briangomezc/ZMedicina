USE [ZMedicina]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19/03/2018 17:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 19/03/2018 17:53:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[PacienteID] [int] IDENTITY(1,1) NOT NULL,
	[Apellidos] [nvarchar](30) NOT NULL,
	[Cedula] [nvarchar](max) NOT NULL,
	[Celular] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[Pass] [nvarchar](max) NULL,
	[Telefono] [nvarchar](max) NOT NULL,
	[sexo] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[PacienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
