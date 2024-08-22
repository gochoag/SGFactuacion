using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SGFactuacion.Formularios;
using SGFactuacion.Clases;
using System;
using System.Data.SqlClient;
using System.Data;
using SGFactuacion;


namespace LoginTest
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RegistrarCliente_ShouldReturnTrue_WhenRegistrationIsSuccessful()
        {
            // Arrange
            var cliente = new csCliente(1, "1234567890", "John", "Doe", DateTime.Now, "john@example.com");

            // Act
            bool registrado = cliente.RegistrarCliente();

            // Assert
            Assert.IsTrue(registrado);
        }

        [TestMethod]
        public void RegistrarCliente_ShouldReturnFalse_OnDuplicateCedula()
        {
            // Arrange
            var cliente = new csCliente(1, "1234567890", "John", "Doe", DateTime.Now, "john@example.com");

            // Act
            bool registrado = cliente.RegistrarCliente();

            // Assert
            Assert.IsFalse(registrado);
        }

        [TestMethod]
        public void EditarCliente_ShouldReturnTrue_WhenEditIsSuccessful()
        {
            // Arrange
            var cliente = new csCliente(1, "1234567890", "John", "Doe", DateTime.Now, "john@example.com");

            // Act
            bool editado = cliente.EditarCliente();

            // Assert
            Assert.IsTrue(editado);
        }
    }
}