USE [simulacroPAV]
GO
/****** Object:  Table [dbo].[alumnos]    Script Date: 19/06/22 19:18:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumnos](
	[legajo] [int] NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
 CONSTRAINT [PK_alumnos] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materias]    Script Date: 19/06/22 19:18:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materias](
	[codigo] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_materias] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materias_x_alumnos]    Script Date: 19/06/22 19:18:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materias_x_alumnos](
	[codigo_materia] [int] NOT NULL,
	[nombre_materia] [varchar](50) NOT NULL,
	[legajo_alumno] [int] NOT NULL,
 CONSTRAINT [PK_materias_x_alumnos_1] PRIMARY KEY CLUSTERED 
(
	[codigo_materia] ASC,
	[legajo_alumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[alumnos] ([legajo], [apellido], [nombres]) VALUES (84646, N'Martínez', N'Thiago')
GO
INSERT [dbo].[alumnos] ([legajo], [apellido], [nombres]) VALUES (87779, N'González', N'Mateo')
GO
INSERT [dbo].[alumnos] ([legajo], [apellido], [nombres]) VALUES (87867, N'Rojas', N'María')
GO
INSERT [dbo].[materias] ([codigo], [nombre]) VALUES (1, N'Diseño de Sistemas')
GO
INSERT [dbo].[materias] ([codigo], [nombre]) VALUES (2, N'Comunicaciones')
GO
INSERT [dbo].[materias] ([codigo], [nombre]) VALUES (3, N'Inglés II')
GO
INSERT [dbo].[materias] ([codigo], [nombre]) VALUES (4, N'Sistemas de Representación')
GO
INSERT [dbo].[materias] ([codigo], [nombre]) VALUES (5, N'Gestión de Datos')
GO
INSERT [dbo].[materias] ([codigo], [nombre]) VALUES (6, N'Matemática Superior')
GO
INSERT [dbo].[materias] ([codigo], [nombre]) VALUES (7, N'Economía')
GO
INSERT [dbo].[materias] ([codigo], [nombre]) VALUES (8, N'Programación de Aplicaciones Visuales')
GO
INSERT [dbo].[materias] ([codigo], [nombre]) VALUES (9, N'Tecnología del Software de Base')
GO
INSERT [dbo].[materias_x_alumnos] ([codigo_materia], [nombre_materia], [legajo_alumno]) VALUES (1, N'Diseño de Sistemas', 84646)
GO
INSERT [dbo].[materias_x_alumnos] ([codigo_materia], [nombre_materia], [legajo_alumno]) VALUES (1, N'Diseño de Sistemas', 87779)
GO
INSERT [dbo].[materias_x_alumnos] ([codigo_materia], [nombre_materia], [legajo_alumno]) VALUES (2, N'Comunicaciones', 84646)
GO
ALTER TABLE [dbo].[materias_x_alumnos]  WITH CHECK ADD  CONSTRAINT [FK_materias_x_alumnos_alumnos] FOREIGN KEY([legajo_alumno])
REFERENCES [dbo].[alumnos] ([legajo])
GO
ALTER TABLE [dbo].[materias_x_alumnos] CHECK CONSTRAINT [FK_materias_x_alumnos_alumnos]
GO
ALTER TABLE [dbo].[materias_x_alumnos]  WITH CHECK ADD  CONSTRAINT [FK_materias_x_alumnos_materias] FOREIGN KEY([codigo_materia])
REFERENCES [dbo].[materias] ([codigo])
GO
ALTER TABLE [dbo].[materias_x_alumnos] CHECK CONSTRAINT [FK_materias_x_alumnos_materias]
GO
