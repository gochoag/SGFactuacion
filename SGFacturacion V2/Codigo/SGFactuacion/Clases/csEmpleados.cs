using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFactuacion.Clases
{
    internal class csEmpleados
    {
        public long IdEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        private csConexion conexion;

        public csEmpleados(long idEmpleado, string cedula, string nombre, string apellido, DateTime fechaNacimiento, string email, string usuario, string contraseña)
        {
            IdEmpleado = idEmpleado;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento.Date;
            Email = email;
            Usuario = usuario;
            Contraseña = contraseña;
            conexion = new csConexion();
        }

        public class csCredenciales
        {
            public string Usuario { get; set; }
            public string Contraseña { get; set; }
            public static long IdEmpleadoLogueado { get; private set; }
            private csConexion conexion;

            public csCredenciales(string usuario, string contraseña)
            {
                Usuario = usuario;
                Contraseña = contraseña;
                conexion = new csConexion();
            }

            public bool IniciarSesion()
            {
                bool sesionIniciada = false;
                try
                {
                    using (SqlCommand cmd = new SqlCommand("Sp_Login_Empleado", conexion.GetConnection()))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Usuario", Usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                        conexion.OpenOrCloseConnection();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                sesionIniciada = Convert.ToBoolean(reader["UserEncontrado"]);
                                if (sesionIniciada)
                                {
                                    IdEmpleadoLogueado = Convert.ToInt64(reader["ID_Empleado"]);
                                }
                            }
                        }
                        conexion.OpenOrCloseConnection();
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error al iniciar sesión: " + ex.Message);
                }

                return sesionIniciada;
            }
        }

        public csEmpleados(long idEmpleado, string cedula, string nombre, string apellido, DateTime fechaNacimiento, string email)
        {
            IdEmpleado = idEmpleado;
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento.Date;
            Email = email;
            conexion = new csConexion();
        }

        //registrar empleado
        public bool RegistrarEmpleado(csCredenciales credenciales)
        {
            bool registrado = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand("[Sp_Insertar_Empleado]", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Cedula", Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    cmd.Parameters.AddWithValue("@Fecha_Nac", FechaNacimiento.Date);
                    cmd.Parameters.AddWithValue("@Correo", Email);
                    cmd.Parameters.AddWithValue("@Usuario", credenciales.Usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", credenciales.Contraseña);

                    conexion.OpenOrCloseConnection();
                    cmd.ExecuteNonQuery();
                    registrado = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error cliente: " + ex.Message, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registrado = false;
            }
            finally
            {
                conexion.OpenOrCloseConnection();
            }

            return registrado;
        }

        public bool EditarEmpleado(csCredenciales credenciales)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("[Sp_Modificar_Empleado_&_Credenciales]", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Empleado", IdEmpleado);
                    cmd.Parameters.AddWithValue("@Cedula", Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    cmd.Parameters.AddWithValue("@Fecha_Nac", FechaNacimiento.Date);
                    cmd.Parameters.AddWithValue("@Correo", Email);
                    cmd.Parameters.AddWithValue("@Usuario", credenciales.Usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", credenciales.Contraseña);

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

        public static List<csEmpleados> ListarEmpleados()
        {
            List<csEmpleados> empleados = new List<csEmpleados>();
            csConexion conexion = new csConexion();
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Listar_Empleados", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.OpenOrCloseConnection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            csEmpleados empleado = new csEmpleados(
                                long.Parse(reader["ID"].ToString()),
                                reader["Cedula"].ToString().Trim(),
                                reader["Nombre"].ToString().Trim(),
                                reader["Apellido"].ToString().Trim(),
                                Convert.ToDateTime(reader["Fecha Nacimiento"]).Date,
                                reader["Correo"].ToString().Trim(),
                                reader["Usuario"].ToString().Trim(),
                                reader["Contraseña"].ToString().Trim()
                            );

                            empleados.Add(empleado);
                        }
                    }
                    conexion.OpenOrCloseConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al listar los empleados: " + ex.Message);
            }
            return empleados;
        }

        public static List<csEmpleados> BuscarEmpleados(string busqueda)
        {
            List<csEmpleados> empleados = new List<csEmpleados>();
            csConexion conexion = new csConexion();
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Buscar_Empleados", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Busqueda", busqueda);
                    conexion.OpenOrCloseConnection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            csEmpleados empleado = new csEmpleados(
                                long.Parse(reader["ID_Empleado"].ToString()),
                                reader["Cedula"].ToString().Trim(),
                                reader["Nombre"].ToString().Trim(),
                                reader["Apellido"].ToString().Trim(),
                                Convert.ToDateTime(reader["Fecha_Nac"]).Date,
                                reader["Correo"].ToString().Trim(),
                                reader["Usuario"].ToString().Trim(),
                                reader["Contraseña"].ToString().Trim()
                            );

                            empleados.Add(empleado);
                        }
                    }
                    conexion.OpenOrCloseConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al buscar los empleados: " + ex.Message);
            }
            return empleados;
        }


    }
}
