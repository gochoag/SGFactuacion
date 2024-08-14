using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using SGFactuacion;
using SGFactuacion.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TestMoq
{
    [TestClass]
    public class UnitTest1
    {

        private Mock<IConexion> mockConexion;
        private SqlConnection mockSqlConn;
        private csCliente cliente;

        [TestInitialize]
        public void Setup()
        {
            mockConexion = new Mock<IConexion>();
            mockSqlConn = new Mock<SqlConnection>().Object;
            mockConexion.Setup(m => m.GetConnection()).Returns(mockSqlConn);

            cliente = new csCliente("1234567890", "John", "Doe", DateTime.Now, "johndoe@example.com", mockConexion.Object);
        }
        [TestMethod]
        public void RegistrarCliente_ShouldReturnTrue_WhenRegistrationIsSuccessful()
        {
            var mockConexion = new Mock<IConexion>();
            var cliente = new csCliente(mockConexion.Object);
            mockConexion.Setup(x => x.GetConnection()).Returns(new SqlConnection());

            // Act
            bool result = cliente.RegistrarCliente();

            // Assert
            Assert.IsTrue(result);
        }


    }
}
