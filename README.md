# ArchivosSQL

Ejemplo de archivos con SQL (en este caso imagenes)

### Instrucciones

Es necesario cambiar la conexion a la base de datos en el archivo Database.cs y el origen de datos de la ventana FrmUsers

### Tabla
```
USE [Ejemplos]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17/05/2022 09:28:19 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Avatar] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
```
