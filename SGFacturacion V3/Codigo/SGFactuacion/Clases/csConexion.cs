using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFactuacion
{
    public class csConexion
    {
        private SqlConnection connection;
        private string connectionString;
        public string Server { get; set; }
        public string DataBase { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public csConexion()
        {
            Server = ".";
            DataBase = "BDFactura";
            Usuario = "sa";
            Contraseña = "123456";
            connectionString = $"Server={Server};Database={DataBase};User Id={Usuario};Password={Contraseña};";
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenOrCloseConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                    Console.WriteLine("Conexión abierta.");
                }
                else if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Conexión cerrada.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al cambiar el estado de la conexión: " + ex.Message);
            }
        }
    }
}
