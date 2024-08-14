using SGFactuacion;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void RegistrarCliente_DebeRetornarVerdadero_CuandoElRegistroEsExitoso()
        {
            var cliente = new csCliente(1, "2120572321", "Maria", "Elizabe", DateTime.Now, "email@example.com");
            bool registrado = cliente.RegistrarCliente();
            Assert.True(registrado);
        }

        [Fact]
        public void RegistrarCliente_DebeRetornarFalso_CuandoLaCedulaEstaDuplicada()
        {
            var cliente = new csCliente(1, "0304056789", "Jona", "Martin", DateTime.Now, "email@example.com");
            bool registrado = cliente.RegistrarCliente();
            Assert.False(registrado);
        }

        [Fact]
        public void EditarCliente_DebeRetornarVerdadero_CuandoLaEdicionEsExitosa()
        {
            var cliente = new csCliente(1, "1234567890", "John", "Doe", DateTime.Now, "email@example.com");
            bool editado = cliente.EditarCliente();
            Assert.True(editado);
        }
    }
}