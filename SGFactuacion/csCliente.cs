using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFactuacion
{
    internal class csCliente
    {
        public long IdCliente { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string NombreCompleto
        {
            get { return $"{Nombre} {Apellido}"; }
        }


        private csConexion conexion;

        public csCliente(long idcliente, string cedula, string nombre, string apellido, DateTime fechaNacimiento)
        {
            IdCliente = idcliente;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento.Date;
            conexion = new csConexion();
        }
        public csCliente(string cedula, string nombre, string apellido, DateTime fechaNacimiento)
        {
       
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento.Date;
            conexion = new csConexion();
        }
        public bool RegistrarCliente()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("[Sp_Insert_Cliente]", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cedula", Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    cmd.Parameters.AddWithValue("@Fecha_Nac", FechaNacimiento.Date);

                    conexion.OpenOrCloseConnection();
                    cmd.ExecuteNonQuery();
                    conexion.OpenOrCloseConnection(); return true;
                }
               
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error cliente: "+ex.ToString());
                return false;
            }
        }


        public bool EditarCliente()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Update_Cliente", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDCLIENTE", IdCliente);
                    cmd.Parameters.AddWithValue("@Cedula", Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    cmd.Parameters.AddWithValue("@Fecha_Nac", FechaNacimiento.Date); 

                    conexion.OpenOrCloseConnection();
                    cmd.ExecuteNonQuery();
                    conexion.OpenOrCloseConnection();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al editar el cliente: " + ex.Message);
                return false;
            }
        }



        public static List<csCliente> ListarClientes()
        {
            List<csCliente> clientes = new List<csCliente>();
            csConexion conexion = new csConexion();
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Listado_Cliente", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.OpenOrCloseConnection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            csCliente cliente = new csCliente(
                                long.Parse(reader["ID"].ToString()),
                                reader["Cedula"].ToString(),
                                reader["Nombre"].ToString(),
                                reader["Apellido"].ToString(),
                                Convert.ToDateTime(reader["Fecha Nacimiento"]).Date
                            );
                            clientes.Add(cliente);
                        }
                    }
                    conexion.OpenOrCloseConnection();
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al listar los clientes: " + ex.Message);
            }
            return clientes;
        }


        public static List<csCliente> BuscarClientes(string busqueda)
        {
            List<csCliente> clientes = new List<csCliente>();
            csConexion conexion = new csConexion();
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Buscar_Cliente", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Busqueda", busqueda);
                    conexion.OpenOrCloseConnection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            csCliente cliente = new csCliente(
                                long.Parse(reader["ID"].ToString()),
                                reader["Cedula"].ToString(),
                                reader["Nombre"].ToString(),
                                reader["Apellido"].ToString(),
                                Convert.ToDateTime(reader["Fecha_nacimiento"]).Date  
                            );
                            clientes.Add(cliente);
                        }
                    }
                    conexion.OpenOrCloseConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al buscar los clientes: " + ex.Message);
            }
            return clientes;
        }

        public static AutoCompleteStringCollection Autocompletado()
        {
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            List<csCliente> clientes = ListarClientes();

            foreach (csCliente cliente in clientes)
            {
                coleccion.Add(cliente.NombreCompleto);
            }

            return coleccion;
        }
    
    }
}
