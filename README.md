ALUMNO-607-01\SQLEXPRESS





insert Editorial (Editorial_ID, Nombre) values 
('c4053dd1-1f98-4452-b513-7b4cb2d04bbc',
'Debate');

insert Editorial (Editorial_ID, Nombre) values 
('15f449a9-a7f2-4292-b9b1-1c251a8041e9',
'SUDAMERICANA');

insert Libros (ID,Titulo,Autor,Editorial_ID) values (
'72634e53-0ac6-47e7-b271-7338e4ebd0ec',
'ARDE LA VIDA',
'Tajes Magali',
'15f449a9-a7f2-4292-b9b1-1c251a8041e9'
)

insert Libros (ID,Titulo,Autor,Editorial_ID) values (
'a092e57a-54fb-4cdb-8567-f152f12cd5df',
'DE ANIMALES A DIOSES',
'Tajes Magali',
'15f449a9-a7f2-4292-b9b1-1c251a8041e9'
)

insert Libros (ID,Titulo,Autor,Editorial_ID) values (
'd73bc13d-7b3c-4cd9-b61a-00481f5d085a',
'CAOS',
' La minita de antes',
'15f449a9-a7f2-4292-b9b1-1c251a8041e9'
)


USE [Libros]
GO

/****** Object:  Table [dbo].[Libros]    Script Date: 14/01/2019 19:32:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Libros](
	[ID] [varchar](36) NOT NULL,
	[Titulo] [varchar](50) NOT NULL,
	[Autor] [varchar](50) NOT NULL,
	[Editorial_ID] [varchar](36) NOT NULL,
 CONSTRAINT [PK_Libros] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [Libros]
GO

/****** Object:  Table [dbo].[Editorial]    Script Date: 14/01/2019 19:33:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Editorial](
	[Editorial_ID] [varchar](36) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Editorial] PRIMARY KEY CLUSTERED 
(
	[Editorial_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


select * from libros inner join editorial on editorial.editorial_id = libros.Editorial_ID
