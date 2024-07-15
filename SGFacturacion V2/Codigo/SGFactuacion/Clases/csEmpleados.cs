using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private csConexion conexion;

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


    }
}
