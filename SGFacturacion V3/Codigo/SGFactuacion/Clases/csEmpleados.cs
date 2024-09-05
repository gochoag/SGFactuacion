using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SGFactuacion.Clases
{
    public class csEmpleados : csPersona
    {
        public long IdEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        private csConexion conexion;


        public csEmpleados()
        {
             conexion=new csConexion();
        }

        public csEmpleados(long idEmpleado,long idPersona, string cedula, string nombre, string apellido, DateTime fechaNacimiento, string email, string usuario, string contraseña)
            : base(idPersona, cedula, nombre, apellido, fechaNacimiento, email)
        {
            IdEmpleado = idEmpleado;
            Usuario = usuario;
            Contraseña = contraseña;
            conexion = new csConexion();
        }

        public csEmpleados(long idEmpleado, string cedula, string nombre, string apellido, DateTime fechaNacimiento, string email)
            : base( cedula, nombre, apellido, fechaNacimiento, email)
        {
            IdEmpleado = idEmpleado;
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
                    MessageBox.Show(
                      ex.Number == 2627 ? "Este registro ya existe en la base de datos." :
                      ex.Number == 547 ? "No puedes eliminar este registro porque está relacionado con otros datos." :
                      ex.Number == 2601 ? "El índice ya existe. Verifica los valores duplicados." :
                      ex.Number == 53 ? "No se puede conectar al servidor. Verifica tu conexión de red." :
                      $"Ocurrió un error de base de datos: {ex.Message}",
                      "Error de SQL",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                  );
                }

                return sesionIniciada;
            }
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
                    cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento.Date);
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
                MessageBox.Show(
                  ex.Number == 2627 ? "Este registro ya existe en la base de datos." :
                  ex.Number == 547 ? "No puedes eliminar este registro porque está relacionado con otros datos." :
                  ex.Number == 2601 ? "El índice ya existe. Verifica los valores duplicados." :
                  ex.Number == 53 ? "No se puede conectar al servidor. Verifica tu conexión de red." :
                  $"Ocurrió un error de base de datos: {ex.Message}",
                  "Error de SQL",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
              );
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
                using (SqlCommand cmd = new SqlCommand("Sp_Update_Empleado", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDEmpleado", IdEmpleado); // IdEmpleado agregado a la actualización
                    cmd.Parameters.AddWithValue("@Cedula", Cedula);
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@Apellido", Apellido);
                    cmd.Parameters.AddWithValue("@FechaNacimiento", FechaNacimiento.Date);
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
                MessageBox.Show(
                   ex.Number == 2627 ? "Este registro ya existe en la base de datos." :
                   ex.Number == 547 ? "No puedes eliminar este registro porque está relacionado con otros datos." :
                   ex.Number == 2601 ? "El índice ya existe. Verifica los valores duplicados." :
                   ex.Number == 53 ? "No se puede conectar al servidor. Verifica tu conexión de red." :
                   $"Ocurrió un error de base de datos: {ex.Message}",
                   "Error de SQL",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
                return false;
            }
        }

        public static  List<csEmpleados> ListarEmpleados()
        {
            List<csEmpleados> empleados = new List<csEmpleados>();
            csConexion conexion = new csConexion();
            try
            {
                using (SqlCommand cmd = new SqlCommand("[Sp_Mostrar_Empleados]", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.OpenOrCloseConnection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            csEmpleados empleado = new csEmpleados(
                                reader.GetInt64(reader.GetOrdinal("ID_Empleado")),
                                reader.GetInt64(reader.GetOrdinal("ID_Persona")),
                                reader.GetString(reader.GetOrdinal("Cedula")).Trim(),
                                reader.GetString(reader.GetOrdinal("Nombre")).Trim(),
                                reader.GetString(reader.GetOrdinal("Apellido")).Trim(),
                                reader.GetDateTime(reader.GetOrdinal("Fecha_nacimiento")).Date,
                                reader.GetString(reader.GetOrdinal("Correo")).Trim(),
                                reader.GetString(reader.GetOrdinal("Usuario")).Trim(),
                                reader.GetString(reader.GetOrdinal("Contraseña")).Trim()
                            );

                            empleados.Add(empleado);
                        }
                    }
                    conexion.OpenOrCloseConnection();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                   ex.Number == 2627 ? "Este registro ya existe en la base de datos." :
                   ex.Number == 547 ? "No puedes eliminar este registro porque está relacionado con otros datos." :
                   ex.Number == 2601 ? "El índice ya existe. Verifica los valores duplicados." :
                   ex.Number == 53 ? "No se puede conectar al servidor. Verifica tu conexión de red." :
                   $"Ocurrió un error de base de datos: {ex.Message}",
                   "Error de SQL",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
            return empleados;
        }

        public static  List<csEmpleados> BuscarEmpleados(string busqueda)
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
                                reader.GetInt64(reader.GetOrdinal("ID_Empleado")),
                                reader.GetInt64(reader.GetOrdinal("ID_Persona")),
                                reader.GetString(reader.GetOrdinal("Cedula")).Trim(),
                                reader.GetString(reader.GetOrdinal("Nombre")).Trim(),
                                reader.GetString(reader.GetOrdinal("Apellido")).Trim(),
                                reader.GetDateTime(reader.GetOrdinal("Fecha_nacimiento")).Date,
                                reader.GetString(reader.GetOrdinal("Correo")).Trim(),
                                reader.GetString(reader.GetOrdinal("Usuario")).Trim(),
                                reader.GetString(reader.GetOrdinal("Contraseña")).Trim()
                            );

                            empleados.Add(empleado);
                        }
                    }
                    conexion.OpenOrCloseConnection();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                  ex.Number == 2627 ? "Este registro ya existe en la base de datos." :
                  ex.Number == 547 ? "No puedes eliminar este registro porque está relacionado con otros datos." :
                  ex.Number == 2601 ? "El índice ya existe. Verifica los valores duplicados." :
                  ex.Number == 53 ? "No se puede conectar al servidor. Verifica tu conexión de red." :
                  $"Ocurrió un error de base de datos: {ex.Message}",
                  "Error de SQL",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Error
              );
            }
            return empleados;
        }


        //Para reportes
        public void CargarReportesp_Sp_Venta_Empleado(ReportViewer reportViewer1, long id)
        {
            csConexion conexion = new csConexion();
            using (SqlConnection conn = conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("Sp_Venta_Empleado", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idempleado", id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                try
                {
                    conn.Open();
                    da.Fill(ds);
                  

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DSVentaempleado", ds.Tables[0]));
                    reportViewer1.LocalReport.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            reportViewer1.RefreshReport();
            reportViewer1.RefreshReport();
        }


    }
}
