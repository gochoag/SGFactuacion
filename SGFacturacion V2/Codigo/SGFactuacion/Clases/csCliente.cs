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
        public string Email { get; set; }
        


        private csConexion conexion;
        
        public csCliente(long idcliente, string cedula, string nombre, string apellido, DateTime fechaNacimiento, string email)
        {
            IdCliente = idcliente;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento.Date;
            Email = email;
            conexion = new csConexion();
        }
        public csCliente(string cedula, string nombre, string apellido, DateTime fechaNacimiento, string email)
        {
       
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento.Date;
            Email=email;
            conexion = new csConexion();
        }
        public bool RegistrarCliente()
        {
            bool registrado = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand("[Sp_Insert_Cliente]", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cedula", Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    cmd.Parameters.AddWithValue("@Fecha_Nac", FechaNacimiento.Date);
                    cmd.Parameters.AddWithValue("@Correo", Email);

                    conexion.OpenOrCloseConnection();
                    cmd.ExecuteNonQuery();
                    registrado = true;
                   
                }
             

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cliente: Cedula duplicada", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registrado = false;
            }
            finally
            {

               conexion.OpenOrCloseConnection();
            }

            return registrado;
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
                    cmd.Parameters.AddWithValue("@Correo", Email);

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
                using (SqlCommand cmd = new SqlCommand("sp_rep_Listado_cliente", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.OpenOrCloseConnection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            csCliente cliente = new csCliente(
                                reader.GetInt64(reader.GetOrdinal("ID")),
                                reader.GetString(reader.GetOrdinal("Cedula")).Trim(),
                                reader.GetString(reader.GetOrdinal("Nombre")).Trim(),
                                reader.GetString(reader.GetOrdinal("Apellido")).Trim(),
                                reader.GetDateTime(reader.GetOrdinal("Fecha Nacimiento")).Date,
                                reader.GetString(reader.GetOrdinal("Correo")).Trim()
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
                                reader.GetInt64(reader.GetOrdinal("ID")),
                                reader.GetString(reader.GetOrdinal("Cedula")).Trim(),
                                reader.GetString(reader.GetOrdinal("Nombre")).Trim(),
                                reader.GetString(reader.GetOrdinal("Apellido")).Trim(),
                                reader.GetDateTime(reader.GetOrdinal("Fecha_nacimiento")).Date,
                                reader.GetString(reader.GetOrdinal("Correo")).Trim()
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
        
        
        public static long GetFacturaIDByClienteIDAndFecha(long idCliente, DateTime fecha)
        {
            long idFactura = -1;
            csConexion conexion = new csConexion();

            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Get_Factura_By_Cedula_And_Fecha", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", idCliente);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    conexion.OpenOrCloseConnection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idFactura = Convert.ToInt64(reader["ID_Factu"]);
                        }
                    }

                    conexion.OpenOrCloseConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al obtener el ID de la factura: " + ex.Message);
            }

            return idFactura;
        }
    }
}
