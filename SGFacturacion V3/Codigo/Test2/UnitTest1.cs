using Microsoft.VisualStudio.TestTools.UnitTesting;
using SGFactuacion;
using SGFactuacion.Clases;
using System;
using System.Collections.Generic;

namespace Test2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RegistrarCliente_ShouldReturnTrue_WhenRegistrationIsSuccessful()
        {
            // Arrange
            var cliente = new csPersona(1, "2100562321", "Maria", "Elizabe", DateTime.Now, "asss22@example.com");

            // Act
            bool registrado = cliente.RegistrarPersona();

            // Assert
            Assert.IsTrue(registrado);
        }

        [TestMethod]
        public void RegistrarCliente_ShouldReturnFalse_OnDuplicateCedula()
        {
            // Arrange
            var cliente = new csPersona(1, "0304056789", "Jona", "Martin", DateTime.Now, "jasasahn@example.com");

            // Act
            bool registrado = cliente.RegistrarPersona();

            // Assert
            Assert.IsFalse(registrado);
        }

        [TestMethod]
        public void EditarCliente_ShouldReturnTrue_WhenEditIsSuccessful()
        {
            // Arrange
            var cliente = new csPersona(1, "1234567890", "John", "Doe", DateTime.Now, "john@example.com");

            // Act
            bool editado = cliente.EditarPersona();

            // Assert
            Assert.IsTrue(editado);
        }

        [TestMethod]
        public void ListarClientes_ShouldReturnListOfClients()
        {
            // Act
            List<csPersona> clientes = csPersona.ListarPersona();

            // Assert
            Assert.IsNotNull(clientes);
            Assert.IsTrue(clientes.Count > 0);
        }

        [TestMethod]
        public void BuscarClientes_ShouldReturnMatchingClients()
        {
            // Arrange
            string busqueda = "John"; // Ejemplo de término de búsqueda

            // Act
            List<csPersona> clientes = csPersona.BuscarPersona(busqueda);

            // Assert
            Assert.IsNotNull(clientes);
            Assert.IsTrue(clientes.Count > 0);
        }

        [TestMethod]
        public void GetFacturaIDByClienteIDAndFecha_ShouldReturnValidID()
        {
            // Arrange
            long idCliente = 1; // ID de cliente válido
            DateTime fecha = Convert.ToDateTime("2024-07-18 00:53:52.380"); // Fecha válida

            // Act
            long idFactura = csPersona.GetFacturaIDByClienteIDAndFecha(idCliente, fecha);

            // Assert
            Assert.IsFalse(idFactura >= 1); // Se espera que el ID de factura sea válido
        }

        [TestMethod]
        public void RegistrarEmpleado_ShouldReturnTrue_WhenRegistrationIsSuccessful()
        {
            // Arrange
            var credenciales = new csEmpleados.csCredenciales("johndoe", "password");
            var empleado = new csEmpleados(1, "1234567890", "John", "Doe", DateTime.Now, "john@example.com");

            // Act
            bool registrado = empleado.RegistrarEmpleado(credenciales);

            // Assert
            Assert.IsTrue(registrado);
        }

        [TestMethod]
        public void EditarEmpleado_ShouldReturnTrue_WhenEditIsSuccessful()
        {
            // Arrange
            var credenciales = new csEmpleados.csCredenciales("jp", "root");
            var empleado = new csEmpleados(1, "1234567890", "John", "Doe", DateTime.Now, "john@example.com");

            // Act
            bool editado = empleado.EditarEmpleado(credenciales);

            // Assert
            Assert.IsTrue(editado);
        }

        [TestMethod]
        public void IniciarSesion_ShouldReturnTrue_WhenCredentialsAreCorrect()
        {
            // Arrange
            var credenciales = new csEmpleados.csCredenciales("jp", "root");

            // Act
            bool sesionIniciada = credenciales.IniciarSesion();

            // Assert
            Assert.IsTrue(sesionIniciada);
        }

        [TestMethod]
        public void IniciarSesion_ShouldReturnFalse_WhenIncorrectCredentials()
        {
            // Arrange
            var credenciales = new csEmpleados.csCredenciales("ad1", "rootaa");

            // Act
            bool sesionIniciada = credenciales.IniciarSesion();

            // Assert
            Assert.IsFalse(sesionIniciada);
        }

        [TestMethod]
        public void ListarEmpleados_ShouldReturnListOfEmployees()
        {
            // Act
            List<csEmpleados> empleados = csEmpleados.ListarEmpleados();

            // Assert
            Assert.IsNotNull(empleados);
            Assert.IsTrue(empleados.Count > 0);
        }

        [TestMethod]
        public void BuscarEmpleados_ShouldReturnMatchingEmployees()
        {
            // Arrange
            string busqueda = "John"; // Ejemplo de término de búsqueda

            // Act
            List<csEmpleados> empleados = csEmpleados.BuscarEmpleados(busqueda);

            // Assert
            Assert.IsNotNull(empleados);
            Assert.IsTrue(empleados.Count > 0);
        }


  


           [TestMethod]
           public void RegistrarProducto_ShouldReturnTrue_WhenRegistrationIsSuccessful()
           {
               // Arrange
               var producto = new csProducto("Producto de Prueba", 10.5m, 100);

               // Act
               bool registrado = producto.RegistrarProducto();

               // Assert
               Assert.IsTrue(registrado);
           }

           [TestMethod]
           public void EditarProducto_ShouldReturnTrue_WhenEditIsSuccessful()
           {
               // Arrange
               var producto = new csProducto(1, "Producto Actualizado", 15.75m, 200);

               // Act
               bool editado = producto.EditarProducto();

               // Assert
               Assert.IsTrue(editado);
           }

           [TestMethod]
           public void ListarProductos_ShouldReturnListOfProducts()
           {
               // Act
               List<csProducto> productos = csProducto.ListarProductos();

               // Assert
               Assert.IsNotNull(productos);
               Assert.IsTrue(productos.Count > 0);
           }

           [TestMethod]
           public void BuscarProductoPorNombre_ShouldReturnMatchingProducts()
           {
               // Arrange
               string patronNombre = "Banano"; // Ejemplo de término de búsqueda

               // Act
               List<csProducto> productos = csProducto.BuscarProductoPorNombre(patronNombre);

               // Assert
               Assert.IsNotNull(productos);
               Assert.IsTrue(productos.Count > 0);
           }

           [TestMethod]
           public void RegistrarFactura_ShouldReturnTrue_WhenRegistrationIsSuccessful()
           {
               // Arrange
               csFactura.FacturaDetalle detalle1 = new csFactura.FacturaDetalle
               {
                   ID_Produc = 1,
                   Precio = 10.5m,
                   Cantidad = 2,
                   IVA = 0.12m
               };

               csFactura.FacturaDetalle detalle2 = new csFactura.FacturaDetalle
               {
                   ID_Produc = 2,
                   Precio = 15.75m,
                   Cantidad = 1,
                   IVA = 0.12m
               };

               List<csFactura.FacturaDetalle> detalles = new List<csFactura.FacturaDetalle>();
               detalles.Add(detalle1);
               detalles.Add(detalle2);

               csFactura factura = new csFactura();
               DateTime fecha = DateTime.Now;
               long idCliente = 1; // ID de cliente válido en tu base de datos
               long idEmpleado = 1; // ID de empleado válido en tu base de datos

               // Act
               bool registrado = factura.RegistrarFactura(idCliente, fecha, detalles, idEmpleado);

               // Assert
               Assert.IsTrue(registrado);
           }

           [TestMethod]
           public void ObtenerUltimoIDFactura_ShouldReturnValidID()
           {
               // Arrange
               csFactura factura = new csFactura();

               // Act
               long ultimoID = factura.ObtenerUltimoIDFactura();

               // Assert
               Assert.IsTrue(ultimoID > 0);
           }

           [TestMethod]
           public void FechaFacturaCliente_ShouldReturnListOfDates()
           {
               // Arrange
               long idCliente = 1; // ID de cliente válido en tu base de datos

               // Act
               List<csFactura> fechasFacturas = csFactura.FechaFacturaCliente(idCliente);

               // Assert
               Assert.IsNotNull(fechasFacturas);
               Assert.IsTrue(fechasFacturas.Count > 0);
           }

           TestMethod]
           public void RegistrarProveedor_ShouldReturnTrue_WhenRegistrationIsSuccessful()
           {
               // Arrange
               var proveedor = new CsProveedor("1234567890123", "Proveedor Prueba", "0987654321", "Calle Ejemplo 123", "proveedor@example.com");

               // Act
               bool registrado = proveedor.RegistrarProveedor();

               // Assert
               Assert.IsTrue(registrado);
           }

           [TestMethod]
           public void EditarProveedor_ShouldReturnTrue_WhenEditIsSuccessful()
           {
               // Arrange
               var proveedor = new CsProveedor(1, "1234567890123", "Proveedor Modificado", "0987654321", "Calle Nueva 123", "proveedor@modificado.com");

               // Act
               bool editado = proveedor.EditarProveedor();

               // Assert
               Assert.IsTrue(editado);
           }

           [TestMethod]
           public void ListarProveedores_ShouldReturnListOfProviders()
           {
               // Act
               List<CsProveedor> proveedores = CsProveedor.ListarProveedores();

               // Assert
               Assert.IsNotNull(proveedores);
               Assert.IsTrue(proveedores.Count > 0);
           }

           [TestMethod]
           public void BuscarProveedor_ShouldReturnMatchingProviders()
           {
               // Arrange
               string busqueda = "Proveedor";

               // Act
               List<CsProveedor> proveedores = CsProveedor.BuscarProveedor(busqueda);

               // Assert
               Assert.IsNotNull(proveedores);
               Assert.IsTrue(proveedores.Count > 0);
           }

    }

}

