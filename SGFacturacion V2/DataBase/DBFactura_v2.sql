USE [master]
GO
/****** Object:  Database [BDFactura]    Script Date: 27/07/2024 14:20:07 ******/
CREATE DATABASE [BDFactura]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDFactura', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BDFactura.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDFactura_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\BDFactura_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BDFactura] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDFactura].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDFactura] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDFactura] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDFactura] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDFactura] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDFactura] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDFactura] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDFactura] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDFactura] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDFactura] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDFactura] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDFactura] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDFactura] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDFactura] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDFactura] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDFactura] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BDFactura] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDFactura] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDFactura] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDFactura] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDFactura] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDFactura] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDFactura] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDFactura] SET RECOVERY FULL 
GO
ALTER DATABASE [BDFactura] SET  MULTI_USER 
GO
ALTER DATABASE [BDFactura] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDFactura] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDFactura] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDFactura] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDFactura] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDFactura] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BDFactura] SET QUERY_STORE = OFF
GO
USE [BDFactura]
GO
/****** Object:  UserDefinedTableType [dbo].[FacturaDetalleType]    Script Date: 27/07/2024 14:20:08 ******/
CREATE TYPE [dbo].[FacturaDetalleType] AS TABLE(
	[ID_Produc] [bigint] NULL,
	[Precio] [decimal](14, 4) NULL,
	[Cantidad] [decimal](14, 4) NULL,
	[IVA] [decimal](14, 4) NULL
)
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ID_Cliente] [bigint] IDENTITY(1,1) NOT NULL,
	[Cedula] [char](10) NOT NULL,
	[Apellido] [char](35) NOT NULL,
	[Nombre] [char](35) NOT NULL,
	[Fecha_nacimiento] [date] NOT NULL,
	[Correo] [char](50) NULL,
 CONSTRAINT [CLIENTE_IDCLIENTE_PK] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credenciales]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credenciales](
	[ID_Credencial] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_Empleado] [bigint] NOT NULL,
	[Usuario] [char](50) NOT NULL,
	[Contraseña] [char](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Credencial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Credenciales_Usuario] UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[ID_Empleado] [bigint] IDENTITY(1,1) NOT NULL,
	[Cedula] [char](10) NOT NULL,
	[Nombre] [char](35) NOT NULL,
	[Apellido] [char](35) NOT NULL,
	[Fecha_Nac] [date] NOT NULL,
	[Correo] [char](75) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[ID_Factu] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_Cliente] [bigint] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Total] [decimal](14, 4) NOT NULL,
	[ID_Empleado] [bigint] NOT NULL,
 CONSTRAINT [FACTURA_IDFACTURA_PK] PRIMARY KEY CLUSTERED 
(
	[ID_Factu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura_detalle]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura_detalle](
	[ID_Deta] [bigint] IDENTITY(1,1) NOT NULL,
	[ID_Factu] [bigint] NOT NULL,
	[ID_Produc] [bigint] NOT NULL,
	[Precio] [decimal](14, 4) NOT NULL,
	[Cantidad] [decimal](14, 4) NOT NULL,
	[IVA] [decimal](14, 4) NOT NULL,
	[Sub_Total] [decimal](14, 4) NULL,
 CONSTRAINT [Factura_detalle_ID_Deta_PK] PRIMARY KEY CLUSTERED 
(
	[ID_Deta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ID_Produc] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](35) NOT NULL,
	[Precio_unitario] [decimal](14, 4) NOT NULL,
	[Stock] [decimal](14, 4) NOT NULL,
 CONSTRAINT [PRODUCTO_IDPRODUCTO_PK] PRIMARY KEY CLUSTERED 
(
	[ID_Produc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Factura_detalle] ADD  DEFAULT ((15)) FOR [IVA]
GO
ALTER TABLE [dbo].[Credenciales]  WITH CHECK ADD FOREIGN KEY([ID_Empleado])
REFERENCES [dbo].[Empleado] ([ID_Empleado])
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FACTURA_CLIENTE_IDCLIENTE_FK] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Cliente] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FACTURA_CLIENTE_IDCLIENTE_FK]
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Empleado] FOREIGN KEY([ID_Empleado])
REFERENCES [dbo].[Empleado] ([ID_Empleado])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Empleado]
GO
ALTER TABLE [dbo].[Factura_detalle]  WITH CHECK ADD  CONSTRAINT [Factura_detalle_ID_Factu_FK] FOREIGN KEY([ID_Factu])
REFERENCES [dbo].[Factura] ([ID_Factu])
GO
ALTER TABLE [dbo].[Factura_detalle] CHECK CONSTRAINT [Factura_detalle_ID_Factu_FK]
GO
ALTER TABLE [dbo].[Factura_detalle]  WITH CHECK ADD  CONSTRAINT [Factura_detalle_ID_Produc_FK] FOREIGN KEY([ID_Produc])
REFERENCES [dbo].[Producto] ([ID_Produc])
GO
ALTER TABLE [dbo].[Factura_detalle] CHECK CONSTRAINT [Factura_detalle_ID_Produc_FK]
GO
ALTER TABLE [dbo].[Factura_detalle]  WITH CHECK ADD CHECK  (([Cantidad]>=(0)))
GO
ALTER TABLE [dbo].[Factura_detalle]  WITH CHECK ADD CHECK  (([Precio]>=(0)))
GO
ALTER TABLE [dbo].[Factura_detalle]  WITH CHECK ADD CHECK  (([Sub_Total]>=(0)))
GO
ALTER TABLE [dbo].[Factura_detalle]  WITH CHECK ADD CHECK  (([IVA]>=(0)))
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD CHECK  (([Precio_unitario]>=(0)))
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD CHECK  (([Stock]>=(0)))
GO
/****** Object:  StoredProcedure [dbo].[Sp_Buscar_Cliente]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Buscar_Cliente]
    @Busqueda nvarchar(100)
AS
BEGIN
    SELECT ID_Cliente as ID, Cedula, Nombre, Apellido, Fecha_nacimiento, Correo
    FROM Cliente
    WHERE Cedula LIKE '%' + @Busqueda + '%'
       OR Nombre LIKE '%' + @Busqueda + '%'
       OR Apellido LIKE '%' + @Busqueda + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Buscar_Empleados]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Buscar_Empleados]
    @Busqueda nvarchar(100)
AS
BEGIN
    BEGIN TRY
        SELECT E.ID_Empleado, E.Cedula, E.Nombre, E.Apellido, E.Fecha_Nac, E.Correo, C.Usuario, C.Contraseña
        FROM Empleado E
        INNER JOIN Credenciales C ON E.ID_Empleado = C.ID_Empleado
        WHERE Cedula LIKE '%' + @Busqueda + '%'
			 OR Nombre LIKE '%' + @Busqueda + '%'
			OR Apellido LIKE '%' + @Busqueda + '%'
    END TRY
    BEGIN CATCH
        PRINT 'Error ' + ERROR_MESSAGE();
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[Sp_Delete_Cliente]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_Delete_Cliente]
@IDCLIENTE bigint
AS
BEGIN
BEGIN TRY		
	DELETE CLIENTE 
	WHERE ID_Cliente = @IDCLIENTE
	END TRY
	BEGIN CATCH
		PRINT 'Error ' + ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Delete_Producto]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_Delete_Producto]
@idproducto bigint
AS
BEGIN
BEGIN TRY		
	DELETE PRODUCTO
	WHERE ID_Produc = @idproducto
	END TRY
	BEGIN CATCH
		PRINT 'Error ' + ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Get_Factura_By_Cedula_And_Fecha]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Get_Factura_By_Cedula_And_Fecha]
    @ID BIGINT,
    @Fecha DATETIME
AS
BEGIN
    SET NOCOUNT ON;
	SET LANGUAGE us_english;
    SELECT ID_Factu 
    FROM Factura F 
    JOIN Cliente C ON F.ID_Cliente = C.ID_Cliente
    WHERE C.ID_Cliente = @ID 
      AND F.Fecha = @Fecha;
END;

GO
/****** Object:  StoredProcedure [dbo].[Sp_Get_Facturas_By_ClienteID]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Get_Facturas_By_ClienteID]
    @ID_Cliente INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT F.Fecha 
    FROM Factura F 
    JOIN Cliente C ON C.ID_Cliente = F.ID_Cliente
    WHERE C.ID_Cliente = @ID_Cliente;
END;

GO
/****** Object:  StoredProcedure [dbo].[sp_GetFacturaDetalles]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetFacturaDetalles]
    @ID_Factu BIGINT
AS
BEGIN
    SELECT 
        F.ID_Factu,
		E.ID_Empleado,
		(E.Apellido +' ' +E.Nombre) As Empleado,
        F.ID_Cliente,
        (C.Apellido + ' ' + C.Nombre) AS Cliente,
        F.Fecha,
        FD.ID_Produc,
        P.Nombre AS Producto,
        FD.Precio,
        FD.Cantidad,
        FD.IVA,
        FD.Sub_Total,
        SUM(FD.Sub_Total) OVER (PARTITION BY F.ID_Factu) AS Total
    FROM 
        Factura F
    INNER JOIN 
        Factura_detalle FD ON F.ID_Factu = FD.ID_Factu
    INNER JOIN 
        Cliente C ON F.ID_Cliente = C.ID_Cliente
    INNER JOIN 
        Producto P ON FD.ID_Produc = P.ID_Produc
	INNER JOIN 
        Empleado E ON E.ID_Empleado = F.ID_Empleado
    WHERE 
        F.ID_Factu = @ID_Factu
    ORDER BY 
        F.ID_Factu, FD.ID_Produc;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetMaxFacturaID]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetMaxFacturaID]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MAX(ID_Factu) AS MaxFacturaID
    FROM Factura;
END;
GO
/****** Object:  StoredProcedure [dbo].[Sp_Insert_Cliente]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Sp_Insert_Cliente]
@Cedula char(10), @Nombre char(35), @Apellido char(35), 
@Fecha_Nac date, 	@Correo char(50)
AS
DECLARE @identificador integer;
BEGIN
		
		INSERT INTO CLIENTE VALUES (@Cedula, @Apellido, @Nombre, @Fecha_Nac, @Correo);
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Insert_Factura]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Insert_Factura]
@ID_Cliente bigint, 
@Fecha datetime,
@Id_Empleado bigint,
@Detalles FacturaDetalleType READONLY
AS
BEGIN
    DECLARE @ID_Factura bigint;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Insertar en la tabla Factura
        INSERT INTO Factura (ID_Cliente, Fecha, Total, ID_Empleado) 
        VALUES (@ID_Cliente, @Fecha, 0, @Id_Empleado);

        SET @ID_Factura = SCOPE_IDENTITY();

        -- Insertar en la tabla Factura_detalle usando el par metro de tabla
        INSERT INTO Factura_detalle (ID_Factu, ID_Produc, Precio, Cantidad, IVA)
        SELECT @ID_Factura, 
               ID_Produc, 
               Precio, 
               Cantidad, 
               IVA
        FROM @Detalles;

        -- Actualizar el Total de la Factura
        UPDATE Factura
        SET Total = (SELECT SUM(Sub_Total) FROM Factura_detalle WHERE ID_Factu = @ID_Factura)
        WHERE ID_Factu = @ID_Factura;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        PRINT 'Error ' + ERROR_MESSAGE();
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Insert_Producto]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-----------------------------------------------
---------CRUD Producto
-----------------------------------------------
Create Procedure [dbo].[Sp_Insert_Producto]
@Nombre char(30), @precio_unitario decimal(14,4), @stock decimal(14, 4)
AS
DECLARE @identificador integer;
BEGIN
	BEGIN TRY	
		INSERT INTO PRODUCTO VALUES (@Nombre, @precio_unitario, @stock);
	END TRY
	BEGIN CATCH
		PRINT 'Error ' + ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Insertar_Empleado]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Insertar_Empleado]
    @Cedula CHAR(10),
    @Nombre CHAR(35),
    @Apellido CHAR(35),
    @Fecha_Nac DATE,
    @Correo CHAR(70),
    @Usuario CHAR(50),
    @Contraseña CHAR(50)
AS
BEGIN
    DECLARE @ID_Empleado BIGINT;

    BEGIN TRY
        -- Insertar el empleado
        INSERT INTO Empleado (Cedula, Nombre, Apellido, Fecha_Nac, Correo)
        VALUES (@Cedula, @Nombre, @Apellido, @Fecha_Nac, @Correo);

        SET @ID_Empleado = SCOPE_IDENTITY();

        -- Insertar las credenciales
        INSERT INTO Credenciales (ID_Empleado, Usuario, Contraseña)
        VALUES (@ID_Empleado, @Usuario, @Contraseña);

        PRINT 'Empleado y credenciales insertados exitosamente';
    END TRY
    BEGIN CATCH
        PRINT 'Error ' + ERROR_MESSAGE();
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[Sp_Listado_Cliente_Top5]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_Listado_Cliente_Top5]
as
BEGIN
SELECT top 5 c.ID_Cliente,C.Nombre, SUM(FD.Cantidad)AS cantidad, sum(fd.Sub_Total)as total FROM Factura AS F INNER JOIN 
Factura_detalle AS FD ON F.ID_Factu=FD.ID_Factu 
INNER JOIN Cliente AS C ON F.ID_Cliente=C.ID_Cliente
GROUP BY C.Nombre,c.ID_Cliente
order by cantidad desc
END

GO
/****** Object:  StoredProcedure [dbo].[Sp_Login_Empleado]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Login_Empleado]
    @Usuario CHAR(50),
    @Contraseña CHAR(50)
AS
BEGIN
    DECLARE @ID_Empleado BIGINT;
    DECLARE @LoginSuccess BIT;

    SELECT @ID_Empleado = C.ID_Empleado
    FROM Credenciales C
    WHERE C.Usuario = @Usuario AND C.Contraseña = @Contraseña;
    
    IF @ID_Empleado IS NOT NULL
    BEGIN
        SET @LoginSuccess = 1; -- Bien
    END
    ELSE
    BEGIN
        SET @LoginSuccess = 0; -- Mal
    END

    SELECT @LoginSuccess as UserEncontrado, isnull(@ID_Empleado,0) AS ID_Empleado;
END;
GO
/****** Object:  StoredProcedure [dbo].[Sp_Modificar_Empleado_&_Credenciales]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Modificar_Empleado_&_Credenciales]
    @ID_Empleado BIGINT,
    @Cedula CHAR(10),
    @Nombre CHAR(35),
    @Apellido CHAR(35),
    @Fecha_Nac DATE,
    @Correo CHAR(70),
    @Usuario CHAR(50),
    @Contraseña CHAR(50)
AS
BEGIN
    BEGIN TRY
        -- Iniciar una transacción
        BEGIN TRANSACTION;

        -- Modificar los datos del empleado
        UPDATE Empleado
        SET Cedula = @Cedula, Nombre = @Nombre, Apellido = @Apellido, Fecha_Nac = @Fecha_Nac, Correo = @Correo
        WHERE ID_Empleado = @ID_Empleado;

        -- Modificar las credenciales del empleado
        UPDATE Credenciales
        SET Usuario = @Usuario, Contraseña = @Contraseña
        WHERE ID_Empleado = @ID_Empleado;

        -- Confirmar la transacción
        COMMIT TRANSACTION;

        PRINT 'Empleado y credenciales modificados exitosamente';
    END TRY
    BEGIN CATCH
        -- Revertir la transacción en caso de error
        ROLLBACK TRANSACTION;
        PRINT 'Error ' + ERROR_MESSAGE();
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mostrar_Empleados]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_Mostrar_Empleados]
AS
BEGIN
    BEGIN TRY
        SELECT E.ID_Empleado, E.Cedula, E.Nombre, E.Apellido, E.Fecha_Nac, E.Correo, C.Usuario, C.Contraseña
        FROM Empleado E
        INNER JOIN Credenciales C ON E.ID_Empleado = C.ID_Empleado;
    END TRY
    BEGIN CATCH
        PRINT 'Error ' + ERROR_MESSAGE();
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Cliente_By_Apellido]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Procedure [dbo].[sp_rep_Cliente_By_Apellido]
    @PatronApellido char(35)
AS
BEGIN
    SELECT * 
    FROM Cliente 
    WHERE Apellido LIKE '%' + @PatronApellido + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Cliente_By_Cedula]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_rep_Cliente_By_Cedula]
    @PatronCedula char(10)
AS
BEGIN
    SELECT * 
    FROM Cliente 
    WHERE Cedula LIKE '%' + @PatronCedula + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Cliente_By_Nombre]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_rep_Cliente_By_Nombre]
    @PatronNombre char(35)
AS
BEGIN
    SELECT * 
    FROM Cliente 
    WHERE Nombre LIKE '%' + @PatronNombre + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Listado_Cliente]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_rep_Listado_Cliente]
AS
	BEGIN
		BEGIN TRY	
			select ID_Cliente as ID, RTRIM(Cedula) as Cedula, RTRIM(Nombre) as Nombre, RTRIM(Apellido) as Apellido, 
			FECHA_NACIMIENTO as 'Fecha Nacimiento', Correo
				from Cliente
		END TRY
	BEGIN CATCH
		PRINT 'Error ' + ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Listado_Factura]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_rep_Listado_Factura]
AS
BEGIN
    SELECT F.ID_Factu,f.ID_Cliente, (C.Apellido+ ' '+C.Nombre) as Cliente,F.Fecha,SUM(FD.Sub_Total) as Total 
	FROM Factura F, Factura_detalle FD, Cliente C
    WHERE F.ID_Factu=FD.ID_Factu And F.ID_Cliente=C.ID_Cliente
	Group By F.ID_Factu,f.ID_Cliente, F.Fecha, C.Apellido+ ' '+C.Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Listado_Factura_Cliente]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_rep_Listado_Factura_Cliente]
    @ID_Cliente bigint
AS
BEGIN
    SELECT F.ID_Factu,f.ID_Cliente, F.Fecha,SUM(FD.Sub_Total) as Total, (C.Apellido+ ' '+C.Nombre) as Cliente  FROM Factura F, Factura_detalle FD, Cliente C
    WHERE F.ID_Factu=FD.ID_Factu and F.ID_Cliente = @ID_Cliente AND C.ID_Cliente=F.ID_Cliente
	Group By F.ID_Factu,f.ID_Cliente, F.Fecha, C.Apellido+ ' '+C.Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5]
AS
BEGIN
    SELECT TOP 5 f.ID_Factu, f.ID_Cliente, f.Fecha, Sum(fd.Cantidad) AS CantidadProductos
    FROM Factura f
    INNER JOIN Factura_detalle fd ON f.ID_Factu = fd.ID_Factu Inner Join Producto P On fd.ID_Produc=P.ID_Produc
    GROUP BY f.ID_Factu, f.ID_Cliente, f.Fecha
    ORDER BY CantidadProductos DESC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5_anio]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5_anio]
 @Anio INT
AS
BEGIN
    SELECT TOP 5 f.ID_Factu, f.ID_Cliente, f.Fecha, Sum(fd.Cantidad) AS CantidadProductos
    FROM Factura f
    INNER JOIN Factura_detalle fd ON f.ID_Factu = fd.ID_Factu Inner Join Producto P On fd.ID_Produc=P.ID_Produc
	WHERE YEAR(f.Fecha) = @Anio
    GROUP BY f.ID_Factu, f.ID_Cliente, f.Fecha
    ORDER BY CantidadProductos DESC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Listado_Producto]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_rep_Listado_Producto]
AS
BEGIN
	select RTRIM(ID_Produc) AS IDPRODUCTO, RTRIM(Nombre) AS PRODUCTO, RTRIM(Precio_unitario) AS PRECIO_UNITARIO,
		RTRIM(Stock) AS STOCK from Producto
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Producto_By_Nombre]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[sp_rep_Producto_By_Nombre]
    @PatronNombre nvarchar(35)
AS
BEGIN
    SELECT * 
    FROM Producto 
    WHERE Nombre LIKE '%' + @PatronNombre + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Productos_Vendidos_Top5]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_rep_Productos_Vendidos_Top5]
AS
BEGIN
    SELECT TOP 5 P.ID_Produc, P.Nombre, SUM(FD.Cantidad) AS TotalVendido
    FROM Factura_detalle FD, Producto P
	Where FD.ID_Produc=P.ID_Produc
    GROUP BY P.ID_Produc, P.Nombre
    ORDER BY TotalVendido DESC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Productos_Vendidos_Top5_anio]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_rep_Productos_Vendidos_Top5_anio]
	 @Anio INT
AS
BEGIN
    SELECT TOP 5 P.ID_Produc, P.Nombre, SUM(FD.Cantidad) AS TotalVendido
    FROM Factura_detalle FD, Producto P, Factura F
	Where FD.ID_Produc=P.ID_Produc and FD.ID_Factu=F.ID_Factu and YEAR(F.Fecha) = @Anio
    GROUP BY P.ID_Produc, P.Nombre
    ORDER BY TotalVendido DESC
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Update_Cliente]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_Update_Cliente]
@IDCLIENTE bigint, @Cedula char(10), @Nombre char(35), @Apellido char(35), @Fecha_Nac date, @Correo char(50)
AS
BEGIN
BEGIN TRY		
	UPDATE CLIENTE SET Cedula = @Cedula, Nombre = @Nombre, Apellido = @Apellido, FECHA_NACIMIENTO = @Fecha_Nac, Correo= @Correo
	WHERE ID_Cliente = @IDCLIENTE
	END TRY
	BEGIN CATCH
		PRINT 'Error ' + ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Update_Producto]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_Update_Producto]
@idproducto bigint, @producto char(35), @precio_unitario decimal(14,4), @stock decimal(14, 4)
AS
BEGIN
BEGIN TRY		
	UPDATE PRODUCTO SET Nombre = @producto, Precio_unitario=@precio_unitario, STOCK=@stock
	WHERE ID_Produc = @idproducto
	END TRY
	BEGIN CATCH
		PRINT 'Error ' + ERROR_MESSAGE();
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_Venta_Empleado]    Script Date: 27/07/2024 14:20:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Sp_Venta_Empleado]
@idempleado BIGINT
AS
BEGIN
BEGIN TRY
SELECT e.ID_Empleado,e.Nombre, e.Apellido, sum(f.Total)AS total FROM Empleado AS e inner join Factura AS f 
on f.ID_Empleado=e.ID_Empleado 
WHERE e.ID_Empleado= @idempleado
GROUP BY  e.Nombre, e.Apellido,e.ID_Empleado
END TRY
	BEGIN CATCH
		PRINT 'Error ' + ERROR_MESSAGE();
	END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [BDFactura] SET  READ_WRITE 
GO
