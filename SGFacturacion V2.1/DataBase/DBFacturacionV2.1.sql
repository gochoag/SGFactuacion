Use master
Go
	IF EXISTS(SELECT * FROM DBO.SYSDATABASES WHERE NAME = 'BDFactura')
    BEGIN
             USE MASTER
             DROP DATABASE BDFactura
    END
   CREATE DATABASE BDFactura;
Go
SELECT @@language;
SET LANGUAGE us_english;
Go
   USE BDFactura;
Go  
If Exists(Select * From INFORMATION_SCHEMA.TABLES Where TABLE_NAME ='PRODUCTO')
	Begin
		Drop Table PRODUCTO
	End
Go
CREATE TABLE Producto
(
	ID_Produc			bigint IDENTITY(1,1)	NOT NULL,
	Nombre				nchar(35)				NOT NULL,
	Precio_unitario		decimal (14, 4)			NOT NULL,
	Stock				decimal(14, 4)			NOT NULL,
	CONSTRAINT PRODUCTO_IDPRODUCTO_PK PRIMARY KEY CLUSTERED (ID_Produc ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
	CONSTRAINT CHK_Precio_unitario CHECK (Precio_unitario >= 0),
	CONSTRAINT CHK_Stock CHECK (Stock >= 0)
) ON [PRIMARY]
GO
If Exists(Select * From INFORMATION_SCHEMA.TABLES Where TABLE_NAME ='Persona')
	Begin
		Drop Table Persona
	End
Go
CREATE TABLE Persona
(
	ID_Persona			bigint IDENTITY(1,1)	NOT NULL,
	Cedula				char (10)				NOT NULL,
	Apellido			char (35)				NOT NULL,
	Nombre				char (35)				NOT NULL,
	Fecha_nacimiento	date					NOT NULL,
	Correo				char (50)				NULL,
    CONSTRAINT Persona_IDPersona_PK PRIMARY KEY CLUSTERED ( ID_Persona ASC ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
    CONSTRAINT Persona_CEDULA_UQ UNIQUE NONCLUSTERED (Cedula ASC ) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
If Exists(Select * From INFORMATION_SCHEMA.TABLES Where TABLE_NAME ='Empleado')
	Begin
		Drop Table Empleado
	End
Go
CREATE TABLE Empleado
(
	ID_Empleado			bigint IDENTITY(1,1)	NOT NULL,
	ID_Persona			bigint					NOT NULL,
	Usuario				char (50)				NOT NULL,
	Contraseña			char (50)				NOT NULL,
    CONSTRAINT PK_Empleado PRIMARY KEY CLUSTERED ( ID_Empleado ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
    CONSTRAINT UQ_Empleado_Usuario UNIQUE NONCLUSTERED ( Usuario ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
    CONSTRAINT FK_Empleado_Persona FOREIGN KEY (ID_Persona) REFERENCES Persona(ID_Persona)
) ON [PRIMARY]
Go
If Exists(Select * From INFORMATION_SCHEMA.TABLES Where TABLE_NAME ='Factura')
	Begin
		Drop Table Factura
	End
Go
CREATE TABLE Factura
(
	ID_Factu			bigint IDENTITY(1,1)	NOT NULL,
	ID_Empleado			bigint					NOT NULL,
	ID_Persona			bigint					NOT NULL,
	Fecha				datetime				NOT NULL,
	Total				decimal(14, 4)			NOT NULL,
    CONSTRAINT PK_Factura PRIMARY KEY CLUSTERED ( ID_Factu ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
    CONSTRAINT FK_Factura_Empleado FOREIGN KEY (ID_Empleado) REFERENCES Empleado(ID_Empleado),
    CONSTRAINT FK_Factura_Persona FOREIGN KEY (ID_Persona) REFERENCES Persona(ID_Persona)
	
) ON [PRIMARY]
GO
If Exists(Select * From INFORMATION_SCHEMA.TABLES Where TABLE_NAME ='Factura_detalle')
	Begin
		Drop Table Factura_detalle
	End
Go
CREATE TABLE Factura_detalle(
	ID_Deta				bigint IDENTITY(1,1)	NOT NULL,
	ID_Factu			bigint					NOT NULL,
	ID_Produc			bigint					NOT NULL,
	Precio				decimal(14, 4)			NOT NULL,
	Cantidad			decimal(14, 4)			NOT NULL,
	IVA					decimal(14, 4)			NOT NULL,
	Sub_Total			decimal(14, 4)			NULL,
    CONSTRAINT PK_Factura_detalle PRIMARY KEY CLUSTERED ( ID_Deta ASC) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
    CONSTRAINT FK_Factura_detalle_Factura FOREIGN KEY (ID_Factu) REFERENCES Factura(ID_Factu),
    CONSTRAINT FK_Factura_detalle_Producto FOREIGN KEY (ID_Produc) REFERENCES Producto(ID_Produc),
	CONSTRAINT Factura_detalle_CHK_Precio CHECK (Precio >= 0),
	CONSTRAINT Factura_detalle_CHK_Cantidad CHECK (Cantidad >= 0),
	CONSTRAINT Factura_detalle_CHK_IVA CHECK (IVA >= 0),
	CONSTRAINT Factura_detalle_CHK_Sub_Total CHECK (Sub_Total >= 0),
) ON [PRIMARY]
GO
If Exists(Select * From INFORMATION_SCHEMA.TABLES Where TABLE_NAME ='FacturaDetalleType')
	Begin
		Drop Table FacturaDetalleType
	End
Go
CREATE TYPE FacturaDetalleType AS TABLE(
	ID_Produc			bigint					NOT NULL,
	Precio				decimal(14, 4)			NOT NULL,
	Cantidad			decimal(14, 4)			NOT NULL,
	IVA					decimal(14, 4)			NOT NULL
)
GO
CREATE Trigger Trg_UpdateStock_CalculateSubtotal
ON Factura_detalle
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    -- Actualizar el stock del producto
    UPDATE Producto
    SET Stock = Producto.Stock - inserted.Cantidad
    FROM Producto
    INNER JOIN inserted ON Producto.ID_Produc = inserted.ID_Produc;

    -- Calcular el subtotal en la tabla Factura_detalle
    UPDATE Factura_detalle
    SET Sub_Total = inserted.Cantidad * inserted.Precio * (1 + (inserted.IVA*100) / 100)
    FROM Factura_detalle
    INNER JOIN inserted ON Factura_detalle.ID_Deta = inserted.ID_Deta;
END
GO

--Sp
---------CRUD Producto
-----------------------------------------------
Create Procedure Sp_Insert_Producto
@Nombre				char(30), 
@precio_unitario	decimal(14,4), 
@stock				decimal(14, 4)
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
Go
Create Procedure Sp_Update_Producto
@idproducto			bigint, 
@producto			char(35), 
@precio_unitario	decimal(14,4), 
@stock				decimal(14, 4)
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
Go
Create Procedure Sp_Delete_Producto
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
Go
Create Procedure sp_rep_Listado_Producto
AS
BEGIN
	select RTRIM(ID_Produc) AS IDPRODUCTO, RTRIM(Nombre) AS PRODUCTO, RTRIM(Precio_unitario) AS PRECIO_UNITARIO,
		RTRIM(Stock) AS STOCK from Producto
END
Go
Create Procedure sp_rep_Producto_By_Nombre
    @PatronNombre nvarchar(35)
AS
BEGIN
    SELECT * 
    FROM Producto 
    WHERE Nombre LIKE '%' + @PatronNombre + '%'
END
Go
---------CRUD Persona
-----------------------------------------------
Create Procedure Sp_Insert_Persona
@Cedula char(10), 
@Nombre char(35), 
@Apellido char(35), 
@Fecha_Nac date, 	
@Correo char(50)
AS
DECLARE @identificador integer;
BEGIN
		
		INSERT INTO Persona VALUES (@Cedula, @Apellido, @Nombre, @Fecha_Nac, @Correo);
END
Go
Create Procedure Sp_Update_Persona
@ID_Persona bigint, 
@Cedula char(10), 
@Nombre char(35), 
@Apellido char(35), 
@Fecha_Nac date, 
@Correo char(50)
AS
BEGIN
BEGIN TRY		
	UPDATE Persona SET Cedula = @Cedula, Nombre = @Nombre, Apellido = @Apellido, FECHA_NACIMIENTO = @Fecha_Nac, Correo= @Correo
	WHERE ID_Persona = @ID_Persona
	END TRY
	BEGIN CATCH
		PRINT 'Error ' + ERROR_MESSAGE();
	END CATCH
END
Go
Create Procedure Sp_Delete_Persona
@ID_Persona bigint
AS
BEGIN
BEGIN TRY		
	DELETE Persona 
	WHERE ID_Persona = @ID_Persona
	END TRY
	BEGIN CATCH
		PRINT 'Error ' + ERROR_MESSAGE();
	END CATCH
END
GO
Create Procedure [dbo].[sp_rep_Listado_Persona]
AS
BEGIN
    BEGIN TRY
        -- Seleccionar personas que no están en la tabla Empleado
        SELECT 
            ID_Persona as ID, 
            RTRIM(Cedula) as Cedula, 
            RTRIM(Nombre) as Nombre, 
            RTRIM(Apellido) as Apellido, 
            FECHA_NACIMIENTO as 'Fecha Nacimiento', 
            Correo
        FROM 
            Persona p
        WHERE 
            NOT EXISTS (
                SELECT 1 
                FROM Empleado e 
                WHERE e.ID_Persona = p.ID_Persona
            );
    END TRY
    BEGIN CATCH
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END
GO
Go
Create PROCEDURE Sp_Buscar_Persona
   @Busqueda NVARCHAR(100)
AS
BEGIN
    BEGIN TRY
        SELECT 
            ID_Persona as ID, 
            Cedula, 
            Nombre, 
            Apellido, 
            Fecha_nacimiento, 
            Correo
        FROM 
            Persona p
        WHERE 
            (Cedula LIKE '%' + @Busqueda + '%'
            OR Nombre LIKE '%' + @Busqueda + '%'
            OR Apellido LIKE '%' + @Busqueda + '%')
            AND NOT EXISTS (
                SELECT 1 
                FROM Empleado e 
                WHERE e.ID_Persona = p.ID_Persona
            );
    END TRY
    BEGIN CATCH
        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END
GO
---------CRUD Empleado
-----------------------------------------------
CREATE PROCEDURE Sp_Login_Empleado
    @Usuario CHAR(50),
    @Contraseña CHAR(50)
AS
BEGIN
    DECLARE @ID_Empleado BIGINT;
    DECLARE @LoginSuccess BIT;

    SELECT @ID_Empleado = C.ID_Empleado
    FROM Empleado C
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
Create PROCEDURE Sp_Insertar_Empleado
    @Cedula CHAR(10),
    @Nombre CHAR(35),
    @Apellido CHAR(35),
    @FechaNacimiento DATE,
    @Correo CHAR(50),
    @Usuario CHAR(50),
    @Contraseña CHAR(50)
AS
BEGIN
    BEGIN TRY
        -- Iniciar una transacción para asegurar la atomicidad de las operaciones
        BEGIN TRANSACTION;

        -- Insertar en la tabla Persona
        INSERT INTO Persona (Cedula, Nombre, Apellido, Fecha_nacimiento, Correo)
        VALUES (@Cedula, @Nombre, @Apellido, @FechaNacimiento, @Correo);

        -- Obtener el ID_Persona recién insertado
        DECLARE @ID_Persona BIGINT;
        SET @ID_Persona = SCOPE_IDENTITY();

        -- Insertar en la tabla Empleado usando el ID_Persona obtenido
        INSERT INTO Empleado (ID_Persona, Usuario, Contraseña)
        VALUES (@ID_Persona, @Usuario, @Contraseña);

        -- Confirmar la transacción
        COMMIT TRANSACTION;

        PRINT 'Persona y Empleado insertados exitosamente';

    END TRY
    BEGIN CATCH
        -- En caso de error, revertir la transacción
        ROLLBACK TRANSACTION;

        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END
GO
Create PROCEDURE Sp_Update_Empleado
    @IDEmpleado BIGINT,
    @Cedula CHAR(10),
    @Nombre CHAR(35),
    @Apellido CHAR(35),
    @FechaNacimiento DATE,
    @Correo CHAR(50),
    @Usuario CHAR(50),
    @Contraseña CHAR(50)
AS
BEGIN
    BEGIN TRY
        -- Iniciar una transacción para asegurar la atomicidad de las operaciones
        BEGIN TRANSACTION;

        -- Actualizar la tabla Persona
        UPDATE Persona
        SET Cedula = @Cedula,
            Nombre = @Nombre,
            Apellido = @Apellido,
            Fecha_nacimiento = @FechaNacimiento,
            Correo = @Correo
        WHERE ID_Persona = (SELECT ID_Persona FROM Empleado WHERE ID_Empleado = @IDEmpleado);

        -- Actualizar la tabla Empleado
        UPDATE Empleado
        SET Usuario = @Usuario,
            Contraseña = @Contraseña
        WHERE ID_Empleado = @IDEmpleado;

        -- Confirmar la transacción
        COMMIT TRANSACTION;

        PRINT 'Persona y Empleado actualizados exitosamente';

    END TRY
    BEGIN CATCH
        -- En caso de error, revertir la transacción
        ROLLBACK TRANSACTION;

        PRINT 'Error: ' + ERROR_MESSAGE();
    END CATCH
END
GO
Create Procedure Sp_Venta_Empleado
@idempleado BIGINT
AS
BEGIN
BEGIN TRY
SELECT e.ID_Empleado,p.Nombre, p.Apellido, sum(f.Total)AS total 
FROM Empleado AS e ,Factura AS f , Persona p
WHERE e.ID_Empleado= @idempleado and e.ID_Empleado=f.ID_Empleado and e.ID_Empleado=p.ID_Persona
GROUP BY  p.Nombre, p.Apellido,e.ID_Empleado
END TRY
	BEGIN CATCH
		PRINT 'Error ' + ERROR_MESSAGE();
	END CATCH
END
Go
Create PROCEDURE Sp_Buscar_Empleados
    @Busqueda nvarchar(100)
AS
BEGIN
    BEGIN TRY
        SELECT E.ID_Empleado, C.Cedula, C.Nombre, C.Apellido, C.Fecha_nacimiento, C.Correo, E.Usuario, E.Contraseña
        FROM Empleado E
        INNER JOIN Persona C ON E.ID_Empleado = C.ID_Persona
        WHERE Cedula LIKE '%' + @Busqueda + '%'
			 OR Nombre LIKE '%' + @Busqueda + '%'
			OR Apellido LIKE '%' + @Busqueda + '%'
    END TRY
    BEGIN CATCH
        PRINT 'Error ' + ERROR_MESSAGE();
    END CATCH
END
Go
Create PROCEDURE Sp_Mostrar_Empleados
AS
BEGIN
    BEGIN TRY
        SELECT E.ID_Empleado, C.Cedula, C.Nombre, C.Apellido, C.Fecha_nacimiento, C.Correo, E.Usuario, E.Contraseña
        FROM Empleado E
        INNER JOIN Persona C ON E.ID_Persona = C.ID_Persona;
    END TRY
    BEGIN CATCH
        PRINT 'Error ' + ERROR_MESSAGE();
    END CATCH
END
Go
---------CRUD Factura
-----------------------------------------------
Create PROCEDURE Sp_Insert_Factura
@ID_Persona bigint, 
@Fecha datetime,
@Id_Empleado bigint,
@Detalles FacturaDetalleType READONLY
AS
BEGIN
    DECLARE @ID_Factura bigint;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- Insertar en la tabla Factura
        INSERT INTO Factura (ID_Empleado,ID_Persona,Fecha,Total) 
        VALUES (@Id_Empleado, @ID_Persona ,@Fecha, 0 );

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
Go
Create PROCEDURE sp_GetMaxFacturaID
AS
BEGIN
    SET NOCOUNT ON;

    SELECT MAX(ID_Factu) AS MaxFacturaID
    FROM Factura;
END
Go
Create PROCEDURE sp_GetFacturaDetalles
    @ID_Factu BIGINT
AS
BEGIN

    SELECT 
        F.ID_Factu,
		E.ID_Empleado,
		(D.Apellido +' ' +D.Nombre) As Empleado,
        F.ID_Persona,
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
        Persona C ON F.ID_Persona = C.ID_Persona
    INNER JOIN 
        Producto P ON FD.ID_Produc = P.ID_Produc
	INNER JOIN 
        Empleado E ON E.ID_Empleado = F.ID_Empleado 
		Inner Join 
		Persona D ON D.ID_Persona=E.ID_Persona
    WHERE 
        F.ID_Factu = @ID_Factu
    ORDER BY 
        F.ID_Factu, FD.ID_Produc
END
Go
Create PROCEDURE Sp_Get_Factura_By_Cedula_And_Fecha
    @ID BIGINT,
    @Fecha DATETIME
AS
BEGIN
    SET NOCOUNT ON;
	SET LANGUAGE us_english;
    SELECT ID_Factu 
    FROM Factura F 
    JOIN Persona C ON F.ID_Persona = C.ID_Persona
    WHERE C.ID_Persona = @ID 
      AND F.Fecha = @Fecha;
END
Go
Create PROCEDURE Sp_Get_Facturas_By_ClienteID
    @ID_Cliente INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT F.Fecha 
    FROM Factura F 
    JOIN Persona C ON C.ID_Persona = F.ID_Persona
    WHERE C.ID_Persona = @ID_Cliente;
END
exec  Sp_Get_Facturas_By_ClienteID 1
Go
Create Procedure Sp_Listado_Cliente_Top5
as
BEGIN
SELECT top 5 c.ID_Persona,C.Nombre, SUM(FD.Cantidad)AS cantidad, sum(fd.Sub_Total)as total 
FROM Factura AS F INNER JOIN 
Factura_detalle AS FD ON F.ID_Factu=FD.ID_Factu 
INNER JOIN Persona AS C ON F.ID_Persona=C.ID_Persona
GROUP BY C.Nombre,c.ID_Persona
order by cantidad desc
END
Go
/****** Object:  StoredProcedure [dbo].[sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5]    Script Date: 15/7/2024 5:02:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[sp_rep_Listado_Factura_Mayor_Cantidad_Productos_Top5]
AS
BEGIN
    SELECT TOP 5 f.ID_Factu, f.ID_Persona, f.Fecha, Sum(fd.Cantidad) AS CantidadProductos
    FROM Factura f
    INNER JOIN Factura_detalle fd ON f.ID_Factu = fd.ID_Factu Inner Join Producto P On fd.ID_Produc=P.ID_Produc
    GROUP BY f.ID_Factu, f.ID_Persona, f.Fecha
    ORDER BY CantidadProductos DESC
END
GO
/****** Object:  StoredProcedure [dbo].[sp_rep_Productos_Vendidos_Top5]    Script Date: 15/7/2024 5:02:26 ******/
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

-----------------------------------------------
---------Execute Sp InserT Persona
-----------------------------------------------

EXEC Sp_Insert_Persona '0506078901', 'Carlos Alberto', 'Espinoza Rodr guez', '1985-05-05', 'carlos.espinoza@gmail.com'
EXEC Sp_Insert_Persona '0607089012', 'Luc a Andrea', 'Flores Castillo', '1990-06-10', 'lucia.flores@gmail.com'
EXEC Sp_Insert_Persona '0708090123', 'Pedro Jos ', 'Garc a Torres', '1987-07-15', 'pedro.garcia@gmail.com'
EXEC Sp_Insert_Persona '0809101234', 'Sof a Elena', 'Hern ndez Rivera', '1992-08-20', 'sofia.hernandez@gmail.com'
EXEC Sp_Insert_Persona '0910112345', 'Jos  Miguel', 'Jim nez Moreno', '1985-09-25', 'jose.jimenez@gmail.com'
EXEC Sp_Insert_Persona '1011123456', 'Elena Patricia', 'L pez Rojas', '1990-10-30', 'elena.lopez@gmail.com'
EXEC Sp_Insert_Persona '1112134567', 'Luis Enrique', 'Mart nez Salazar', '1987-11-15', 'luis.martinez@gmail.com'
EXEC Sp_Insert_Persona '1213145678', 'Carmen Teresa', 'Navarrete Romero', '1992-12-20', 'carmen.navarrete@gmail.com'
EXEC Sp_Insert_Persona '1314156789', 'Jorge Arturo', 'Ortiz S nchez', '1985-01-05', 'jorge.ortiz@gmail.com'
EXEC Sp_Insert_Persona '1415167890', 'Andrea Gabriela', 'P rez Su rez', '1990-02-15', 'andrea.perez@gmail.com'
EXEC Sp_Insert_Persona '1516178901', 'Diego Alejandro', 'Quintero Vargas', '1987-03-20', 'diego.quintero@gmail.com'
EXEC Sp_Insert_Persona '1617189012', 'Fernanda Luc a', 'Ram rez Vera', '1992-04-25', 'fernanda.ramirez@gmail.com'
EXEC Sp_Insert_Persona '1718190123', 'Mario Esteban', 'S nchez Aguirre', '1985-05-30', 'mario.sanchez@gmail.com'
EXEC Sp_Insert_Persona '1819201234', 'Isabel Cristina', 'Toledo Carrillo', '1990-06-05', 'isabel.toledo@gmail.com'
EXEC Sp_Insert_Persona '1920212345', 'Gonzalo Javier', 'Ulloa Valle', '1987-07-10', 'gonzalo.ulloa@gmail.com'
EXEC Sp_Insert_Persona '2021223456', 'Natalia Daniela', 'Vallejo Romero', '1992-08-15', 'natalia.vallejo@gmail.com'
EXEC Sp_Insert_Persona '2122234567', 'Ricardo Antonio', 'Wong Guti rrez', '1985-09-20', 'ricardo.wong@gmail.com'
EXEC Sp_Insert_Persona '2223245678', 'Paola Fernanda', 'Xavier Herrera', '1990-10-25', 'paola.xavier@gmail.com'
EXEC Sp_Insert_Persona '2324256789', 'Felipe Ignacio', 'Y nez V squez', '1987-11-30', 'felipe.yanez@gmail.com'
EXEC Sp_Insert_Persona '2425267890', 'Gabriela Paola', 'Zambrano Molina', '1992-12-05', 'gabriela.zambrano@gmail.com'
EXEC Sp_Insert_Persona '2526278901', 'Esteban Ricardo', 'Almeida Guerrero', '1985-01-10', 'esteban.almeida@gmail.com'
EXEC Sp_Insert_Persona '2627289012', 'Cecilia Alejandra', 'Bravo Mu oz', '1990-02-18', 'cecilia.bravo@gmail.com'
EXEC Sp_Insert_Persona '2728290123', 'Victor Hugo', 'Castro Salinas', '1987-03-22', 'victor.castro@gmail.com'
EXEC Sp_Insert_Persona '2829301234', 'Patricia Isabel', 'Dom nguez Narv ez', '1992-04-27', 'patricia.dominguez@gmail.com'
EXEC Sp_Insert_Persona '2930312345', 'Miguel  ngel', 'Estrada Maldonado', '1985-05-12', 'miguel.estrada@gmail.com'
EXEC Sp_Insert_Persona '3031323456', 'Diana Carolina', 'Figueroa Paredes', '1990-06-17', 'diana.figueroa@gmail.com'
Go
Select * from Persona
Go
-----------------------------------------------
---------Execute Sp InserT Persona
-----------------------------------------------
Exec Sp_Insertar_Empleado '0102034567', 'Luis Eduardo', 'Andrade P rez', '1985-01-15', 'stevengualpa@gmail.com','jp', 'root'
Exec Sp_Insertar_Empleado '0203045678', 'Mar a Fernanda', 'Barrera G mez', '1990-02-20', 'maria.barrera@gmail.com','mariagomez', 'password456'
Exec Sp_Insertar_Empleado '0304056789', 'Juan Carlos', 'C rdenas L pez', '1987-03-25', 'juan.cardenas@gmail.com','carloslopez', 'password789'
Exec Sp_Insertar_Empleado '0405067890', 'Ana Isabel', 'D az Mart nez', '1992-04-30', 'ana.diaz@gmail.com','anamartinez', 'password101'
Go
Select * from Empleado
Go
-----------------------------------------------
---------Execute Sp InserT Producto
-----------------------------------------------
EXEC Sp_Insert_Producto 'Caf  de Loja', 8.5000, 2000
EXEC Sp_Insert_Producto 'Chocolate Pacari', 4.7500, 2000
EXEC Sp_Insert_Producto 'Banano', 0.1500, 2000
EXEC Sp_Insert_Producto 'Rosas de Cayambe', 1.5000, 2000
EXEC Sp_Insert_Producto 'Camar n de Manab ', 15.0000, 2000
EXEC Sp_Insert_Producto 'Helado de Salcedo', 2.5000, 2000
EXEC Sp_Insert_Producto 'Queso de Hoja', 3.8000, 2000
EXEC Sp_Insert_Producto 'Pan de Yuca', 1.2000, 2000
EXEC Sp_Insert_Producto 'Manjar de Leche', 3.0000, 2000
EXEC Sp_Insert_Producto 'Chifles', 0.7500, 2000
EXEC Sp_Insert_Producto 'Chocolates Kallari', 6.5000, 2000
EXEC Sp_Insert_Producto 'Tuna de Gal pagos', 2.0000, 2000
EXEC Sp_Insert_Producto 'Miel de Abeja', 5.0000, 2000
EXEC Sp_Insert_Producto 'Choclo', 0.5000, 2000
EXEC Sp_Insert_Producto 'Mote', 1.0000, 2000
EXEC Sp_Insert_Producto 'At n enlatado', 2.2500, 2000
EXEC Sp_Insert_Producto 'Caf  de Gal pagos', 10.0000, 2000
EXEC Sp_Insert_Producto 'Cacao Fino de Aroma', 12.0000, 2000
EXEC Sp_Insert_Producto 'Aguardiente Zhumir', 6.7500, 2000
EXEC Sp_Insert_Producto 'Pan de Ambato', 1.5000, 2000
EXEC Sp_Insert_Producto 'Fruta deshidratada', 3.7500, 2000
EXEC Sp_Insert_Producto 'Quinua', 2.5000, 2000
EXEC Sp_Insert_Producto 'Arroz de Daule', 1.0000, 2000
EXEC Sp_Insert_Producto 'Camarones enlatados', 8.0000, 2000
EXEC Sp_Insert_Producto 'Moras de los Andes', 4.0000, 2000
EXEC Sp_Insert_Producto 'Aj  de Man ', 3.2000, 2000
EXEC Sp_Insert_Producto 'Galletas Amor', 1.7500, 2000
EXEC Sp_Insert_Producto 'Refresco Pony Malta', 1.0000, 2000
EXEC Sp_Insert_Producto 'N ctar de Guayaba', 2.5000, 2000
EXEC Sp_Insert_Producto 'Dulce de Higos', 3.5000, 2000
EXEC Sp_Insert_Producto 'Alfajores de Man ', 2.0000, 2000
EXEC Sp_Insert_Producto 'Jugo de Naranja', 1.5000, 2000
EXEC Sp_Insert_Producto 'Chicha de Jora', 3.0000, 2000
EXEC Sp_Insert_Producto 'Licor de Ca a', 5.0000, 2000
EXEC Sp_Insert_Producto 'Salsa de Ajo', 1.7500, 2000
EXEC Sp_Insert_Producto 'Cerveza Club', 1.2500, 2000
EXEC Sp_Insert_Producto 'Turr n de Man ', 2.7500, 2000
EXEC Sp_Insert_Producto 'Galletas Ducales', 1.5000, 2000
EXEC Sp_Insert_Producto 'Granola de Quinua', 4.5000, 2000
EXEC Sp_Insert_Producto 'Pan de El Oro', 1.2500, 2000
EXEC Sp_Insert_Producto 'Bizcochos de Cayambe', 2.5000, 2000
EXEC Sp_Insert_Producto 'Ma z Tostado', 1.0000, 2000
EXEC Sp_Insert_Producto 'Papas Chauchas', 0.8000, 2000
EXEC Sp_Insert_Producto 'Mermelada de Mora', 3.2000, 2000
EXEC Sp_Insert_Producto 'Enlatado de Vegetales', 2.7500, 2000
EXEC Sp_Insert_Producto 'Juguete de Ferreter a', 12.0000, 2000
EXEC Sp_Insert_Producto 'Tornillos de Acero', 0.5000, 2000
EXEC Sp_Insert_Producto 'Martillo', 5.0000, 2000
EXEC Sp_Insert_Producto 'Llave Inglesa', 7.5000, 2000
EXEC Sp_Insert_Producto 'Alicate', 3.7500, 2000
EXEC Sp_Insert_Producto 'Cinta M trica', 2.5000, 2000
EXEC Sp_Insert_Producto 'Destornillador', 2.0000, 2000
EXEC Sp_Insert_Producto 'Sierra Manual', 4.5000, 2000
Go
Select * From Producto
Go
-- Crear una variable de tipo tabla para almacenar los detalles de factura
DECLARE @FacturaDetalles1 AS FacturaDetalleType;
DECLARE @FacturaDetalles2 AS FacturaDetalleType;
DECLARE @FacturaDetalles3 AS FacturaDetalleType;
-- Insertar detalles de productos en la variable tipo tabla para la primera factura
INSERT INTO @FacturaDetalles1 (ID_Produc, Precio, Cantidad, IVA)
VALUES
(1, 8.5000, 5, 0.12),   -- 5 unidades de "Café de Loja"
(2, 4.7500, 2, 0.12),   -- 2 unidades de "Chocolate Pacari"
(3, 0.1500, 100, 0.12); -- 100 unidades de "Banano"

INSERT INTO @FacturaDetalles2 (ID_Produc, Precio, Cantidad, IVA)
VALUES
(4, 1.5000, 15, 0.12),  -- 15 unidades de "Rosas de Cayambe"
(5, 15.0000, 10, 0.12), -- 10 unidades de "Camarón de Manabí"
(6, 2.5000, 20, 0.12);  -- 20 unidades de "Helado de Salcedo"

INSERT INTO @FacturaDetalles3 (ID_Produc, Precio, Cantidad, IVA)
VALUES
(7, 3.8000, 10, 0.12),  -- 10 unidades de "Queso de Hoja"
(8, 1.2000, 30, 0.12),  -- 30 unidades de "Pan de Yuca"
(9, 3.0000, 25, 0.12);  -- 25 unidades de "Manjar de Leche"


-- Insertar la primera factura
EXEC Sp_Insert_Factura 5, '2024-07-22 23:52:13.827', 1, @FacturaDetalles1
EXEC Sp_Insert_Factura 6, '2024-07-22 23:52:13.827', 2, @FacturaDetalles2
EXEC Sp_Insert_Factura 7, '2024-07-22 23:52:13.827', 3, @FacturaDetalles3
Go

exec sp_GetFacturaDetalles 1
Go
exec sp_GetFacturaDetalles 2
Go
exec sp_GetFacturaDetalles 3
Go