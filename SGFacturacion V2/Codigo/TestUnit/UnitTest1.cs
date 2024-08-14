using System;
using System.Collections.Generic;
using SGFactuacion;
using SGFactuacion.Clases;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TestUnit
{
 


    public class UnitTest1
    {
        [Fact]
        public void RegistrarCliente_ShouldReturnTrue_WhenRegistrationIsSuccessful()
        {
            var cliente = new csCliente(1, "2120572321", "Maria", "Elizabe", DateTime.Now, "asss22@example.com");
            bool registrado = cliente.RegistrarCliente();
            Assert.IsTrue(registrado);
        }

        [Fact]
        public void RegistrarCliente_ShouldReturnFalse_OnDuplicateCedula()
        {
            var cliente = new csCliente(1, "0304056789", "Jona", "Martin", DateTime.Now, "jasasahn@example.com");
            bool registrado = cliente.RegistrarCliente();
            Assert.IsFalse(registrado);
        }

        [Fact]
        public void EditarCliente_ShouldReturnTrue_WhenEditIsSuccessful()
        {
            var cliente = new csCliente(1, "1234567890", "John", "Doe", DateTime.Now, "john@example.com");
            bool editado = cliente.EditarCliente();
            Assert.IsTrue(editado);
        }

        [Fact]
        public void ListarClientes_ShouldReturnListOfClients()
        {
            List<csCliente> clientes = csCliente.ListarClientes();
            Assert.IsNotNull(clientes);
            Assert.IsTrue(clientes.Count > 0);
        }

        [Fact]
        public void BuscarClientes_ShouldReturnMatchingClients()
        {
            string busqueda = "John";
            List<csCliente> clientes = csCliente.BuscarClientes(busqueda);
            Assert.IsNotNull(clientes);
            Assert.IsTrue(clientes.Count > 0);
        }

        [Fact]
        public void GetFacturaIDByClienteIDAndFecha_ShouldReturnValidID()
        {
            long idCliente = 1;
            DateTime fecha = Convert.ToDateTime("2024-07-18 00:53:52.380");
            long idFactura = csCliente.GetFacturaIDByClienteIDAndFecha(idCliente, fecha);
            Assert.IsTrue(idFactura >= 1);
        }

        [Fact]
        public void RegistrarEmpleado_ShouldReturnTrue_WhenRegistrationIsSuccessful()
        {
            var credenciales = new csEmpleados.csCredenciales("johndoe", "password");
            var empleado = new csEmpleados(1, "1234567890", "John", "Doe", DateTime.Now, "john@example.com");
            bool registrado = empleado.RegistrarEmpleado(credenciales);
            Assert.IsTrue(registrado);
        }

        [Fact]
        public void EditarEmpleado_ShouldReturnTrue_WhenEditIsSuccessful()
        {
            var credenciales = new csEmpleados.csCredenciales("jp", "root");
            var empleado = new csEmpleados(1, "1234567890", "John", "Doe", DateTime.Now, "john@example.com");
            bool editado = empleado.EditarEmpleado(credenciales);
            Assert.IsTrue(editado);
        }

        [Fact]
        public void IniciarSesion_ShouldReturnTrue_WhenCredentialsAreCorrect()
        {
            var credenciales = new csEmpleados.csCredenciales("jp", "root");
            bool sesionIniciada = credenciales.IniciarSesion();
            Assert.IsTrue(sesionIniciada);
        }

        [Fact]
        public void IniciarSesion_ShouldReturnFalse_WhenIncorrectCredentials()
        {
            var credenciales = new csEmpleados.csCredenciales("ad1", "rootaa");
            bool sesionIniciada = credenciales.IniciarSesion();
            Assert.IsFalse(sesionIniciada);
        }

        [Fact]
        public void ListarEmpleados_ShouldReturnListOfEmployees()
        {
            List<csEmpleados> empleados = csEmpleados.ListarEmpleados();
            Assert.IsNotNull(empleados);
            Assert.IsTrue(empleados.Count > 0);
        }

        [Fact]
        public void BuscarEmpleados_ShouldReturnMatchingEmployees()
        {
            string busqueda = "John";
            List<csEmpleados> empleados = csEmpleados.BuscarEmpleados(busqueda);
            Assert.IsNotNull(empleados);
            Assert.IsTrue(empleados.Count > 0);
        }

        [Fact]
        public void RegistrarProducto_ShouldReturnTrue_WhenRegistrationIsSuccessful()
        {
            var producto = new csProducto("Producto de Prueba", 10.5m, 100);
            bool registrado = producto.RegistrarProducto();
            Assert.IsTrue(registrado);
        }

        [Fact]
        public void EditarProducto_ShouldReturnTrue_WhenEditIsSuccessful()
        {
            var producto = new csProducto(1, "Producto Actualizado", 15.75m, 200);
            bool editado = producto.EditarProducto();
            Assert.IsTrue(editado);
        }

        [Fact]
        public void ListarProductos_ShouldReturnListOfProducts()
        {
            List<csProducto> productos = csProducto.ListarProductos();
            Assert.IsNotNull(productos);
            Assert.IsTrue(productos.Count > 0);
        }

        [Fact]
        public void BuscarProductoPorNombre_ShouldReturnMatchingProducts()
        {
            string patronNombre = "Banano";
            List<csProducto> productos = csProducto.BuscarProductoPorNombre(patronNombre);
            Assert.IsNotNull(productos);
            Assert.IsTrue(productos.Count > 0);
        }

        [Fact]
        public void RegistrarFactura_ShouldReturnTrue_WhenRegistrationIsSuccessful()
        {
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

            List<csFactura.FacturaDetalle> detalles = new List<csFactura.FacturaDetalle> { detalle1, detalle2 };
            csFactura factura = new csFactura();
            DateTime fecha = DateTime.Now;
            long idCliente = 1;
            long idEmpleado = 1;

            bool registrado = factura.RegistrarFactura(idCliente, fecha, detalles, idEmpleado);
            Assert.IsTrue(registrado);
        }

        [Fact]
        public void ObtenerUltimoIDFactura_ShouldReturnValidID()
        {
            csFactura factura = new csFactura();
            long ultimoID = factura.ObtenerUltimoIDFactura();
            Assert.IsTrue(ultimoID > 0);
        }

        [Fact]
        public void FechaFacturaCliente_ShouldReturnListOfDates()
        {
            long idCliente = 1;
            List<csFactura> fechasFacturas = csFactura.FechaFacturaCliente(idCliente);
            Assert.IsNotNull(fechasFacturas);
            Assert.IsTrue(fechasFacturas.Count > 0);
        }
    }
}
