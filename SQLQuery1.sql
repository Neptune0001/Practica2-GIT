USE [master]
GO

CREATE DATABASE [Practica2]
GO

USE [Practica2]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 10/24/2023 12:39:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[IdVehiculo] [bigint] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](100) NOT NULL,
	[Modelo] [varchar](100) NOT NULL,
	[Color] [varchar](100) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[IdVendedor] [bigint] NOT NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[IdVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendedores]    Script Date: 10/24/2023 12:39:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendedores](
	[IdVendedor] [bigint] IDENTITY(1,1) NOT NULL,
	[Cedula] [varchar](50) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Correo] [varchar](100) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Vendedores] PRIMARY KEY CLUSTERED 
(
	[IdVendedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UK_Cedula] UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculos_Vendedores] FOREIGN KEY([IdVendedor])
REFERENCES [dbo].[Vendedores] ([IdVendedor])
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [FK_Vehiculos_Vendedores]
GO
/****** Object:  StoredProcedure [dbo].[RegistrarVehiculoSP]    Script Date: 10/24/2023 12:39:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarVehiculoSP]
	@Marca varchar(100),
	@Modelo varchar(100),
	@Color varchar(100),
	@Precio decimal(18,2),
	@IdVendedor bigint

AS
BEGIN
	INSERT INTO DBO.Vehiculos (Marca,Modelo,Color,Precio,IdVendedor)
	VALUES (@Marca,@Modelo,@Color,@Precio,@IdVendedor)
END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarVendedorSP]    Script Date: 10/24/2023 12:39:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
CREATE PROCEDURE [dbo].[RegistrarVendedorSP]
	@Cedula varchar(50),
	@Nombre varchar(100),
	@Correo varchar(100),
	@Estado bit

AS
BEGIN
	INSERT INTO DBO.Vendedores (Cedula,Nombre,Correo,Estado)
	VALUES (@Cedula,@Nombre,@Correo,@Estado)
END
GO

--DBCC CHECKIDENT('dbo.Vendedores', RESEED, 0);
--Delete from dbo.Vendedores;
Select * from dbo.Vendedores
Select * from dbo.Vehiculos

/*
DELETE FROM [dbo].[Vendedores]
WHERE IdVendedor >= 0;

DELETE FROM [dbo].[Vehiculos]
WHERE IdVendedor >= 0;
*/
GO

