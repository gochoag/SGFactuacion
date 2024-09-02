using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SGFactuacion.Clases.csEmpleados;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SGFactuacion.Clases
{
    class CsProveedor
    {
        public long ID_Proveedor { get; set; }
        public string Ruc { get; set; }
        public string RazonComercial { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        private csConexion conexion;

        public CsProveedor(long iD_Proveedor, string ruc, string razonComercial, string telefono, string direccion, string email)
        {
            ID_Proveedor = iD_Proveedor;
            Ruc = ruc;
            RazonComercial = razonComercial;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
            conexion = new csConexion();
        }

        public CsProveedor(long iD_Proveedor, string ruc, string razonComercial, string telefono, string direccion, string email, csConexion conexion)
        {
            ID_Proveedor = iD_Proveedor;
            Ruc = ruc;
            RazonComercial = razonComercial;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
            this.conexion = conexion;
        }

        //registrar Proveedor
        public bool RegistrarProveedor()
        {
            bool registrado = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand("[Sp_Insert_Proveedor]", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Ruc", Ruc);
                    cmd.Parameters.AddWithValue("@RazonComercial", RazonComercial);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@Correo", Email);
                    conexion.OpenOrCloseConnection();
                    cmd.ExecuteNonQuery();
                    registrado = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error proveedor: " + ex.Message, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registrado = false;
            }
            finally
            {
                conexion.OpenOrCloseConnection();
            }

            return registrado;
        }

        public bool EditarProveedor()
        {
            bool registrado = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand("[Sp_Update_Proveedor]", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor); 
                    cmd.Parameters.AddWithValue("@Ruc", Ruc);
                    cmd.Parameters.AddWithValue("@RazonComercial", RazonComercial);
                    cmd.Parameters.AddWithValue("@Telefono", Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", Direccion);
                    cmd.Parameters.AddWithValue("@Correo", Email);
                    conexion.OpenOrCloseConnection();
                    cmd.ExecuteNonQuery();
                    registrado = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error proveedor: " + ex.Message, "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registrado = false;
            }
            finally
            {
                conexion.OpenOrCloseConnection();
            }

            return registrado;
        }

        public bool EliminarProveedor()
        {
            bool registrado = false;
            try
            {
                using (SqlCommand cmd = new SqlCommand("[Sp_Delete_Proveedor]", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);
                    conexion.OpenOrCloseConnection();
                    cmd.ExecuteNonQuery();
                    registrado = true;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error proveedor: " + ex.Message, "Error de Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                registrado = false;
            }
            finally
            {
                conexion.OpenOrCloseConnection();
            }

            return registrado;
        }

        public static List<CsProveedor> ListarProveedores()
        {
            List<CsProveedor> proveedores = new List<CsProveedor>();
            csConexion conexion = new csConexion();
            try
            {
                using (SqlCommand cmd = new SqlCommand("[Sp_Listado_Proveedor]", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.OpenOrCloseConnection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CsProveedor proveedor = new CsProveedor(
                                reader.GetInt64(reader.GetOrdinal("ID")),        //si no es ID es ID_Proveedor
                                reader.GetString(reader.GetOrdinal("Ruc")).Trim(),
                                reader.GetString(reader.GetOrdinal("RazonComercial")).Trim(),
                                reader.GetString(reader.GetOrdinal("Telefono")).Trim(),
                                reader.GetString(reader.GetOrdinal("Direccion")).Trim(),
                                reader.GetString(reader.GetOrdinal("Correo")).Trim()      
                            );

                            proveedores.Add(proveedor);
                        }
                    }
                    conexion.OpenOrCloseConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al listar los proveedores: " + ex.Message);
            }
            return proveedores;
        }

        public static List<CsProveedor> BuscarProveedor(string busqueda)
        {
            List<CsProveedor> proveedores = new List<CsProveedor>();
            csConexion conexion = new csConexion();
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Buscar_Proveedor", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Busqueda", busqueda);
                    conexion.OpenOrCloseConnection();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CsProveedor proveedor = new CsProveedor(

                                reader.GetInt64(reader.GetOrdinal("ID")),        //si no es ID es ID_Proveedor
                                reader.GetString(reader.GetOrdinal("Ruc")).Trim(),
                                reader.GetString(reader.GetOrdinal("RazonComercial")).Trim(),
                                reader.GetString(reader.GetOrdinal("Telefono")).Trim(),
                                reader.GetString(reader.GetOrdinal("Direccion")).Trim(),
                                reader.GetString(reader.GetOrdinal("Correo")).Trim()
                            );

                            proveedores.Add(proveedor);
                        }
                    }
                    conexion.OpenOrCloseConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al buscar los proveedores: " + ex.Message);
            }
            return proveedores;
        }
    }
}
