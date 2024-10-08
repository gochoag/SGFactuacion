﻿using System;
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

        public csEmpleados(long idEmpleado, string cedula, string nombre, string apellido, DateTime fechaNacimiento, string email, string usuario, string contraseña)
            : base( cedula, nombre, apellido, fechaNacimiento, email)
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
                    Console.WriteLine("Error al iniciar sesión: " + ex.Message);
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
                MessageBox.Show("Error empleados: " + ex.Message, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Console.WriteLine("Error al editar el empleados: " + ex.Message);
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
                Console.WriteLine("Error al listar los empleados: " + ex.Message);
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
                Console.WriteLine("Error al buscar los empleados: " + ex.Message);
            }
            return empleados;
        }
    }
}
