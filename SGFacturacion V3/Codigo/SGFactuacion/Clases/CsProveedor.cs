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
    public class CsProveedor
    {
        public long ID_Proveedor { get; set; }
        public string Ruc { get; set; }
        public string RazonComercial { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }

        private csConexion conexion;

        public CsProveedor()
        {

        }
        //Editar un proveedor yo instancio este constructor
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
        //Insertar un proveedor yo isntancio este constructor
        public CsProveedor(string ruc, string razonComercial, string telefono, string direccion, string email)
        {
            Ruc = ruc;
            RazonComercial = razonComercial;
            Telefono = telefono;
            Direccion = direccion;
            Email = email;
            conexion = new csConexion();
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
                    conexion.OpenOrCloseConnection();
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
                                long.Parse(reader["ID"].ToString()),
                                reader["Ruc"].ToString().Trim(),
                                reader["RazonComercial"].ToString().Trim(),
                                reader["Telefono"].ToString().Trim(),
                                reader["Direccion"].ToString().Trim(),
                                reader["Correo"].ToString().Trim()
                            );

                            proveedores.Add(proveedor);
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
                                long.Parse(reader["ID"].ToString()),
                                reader["Ruc"].ToString().Trim(),
                                reader["RazonComercial"].ToString().Trim(),
                                reader["Telefono"].ToString().Trim(),
                                reader["Direccion"].ToString().Trim(),
                                reader["Correo"].ToString().Trim()

                            );

                            proveedores.Add(proveedor);
                        }
                    }
                    conexion.OpenOrCloseConnection();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number == 2627 ? "Este registro ya existe en la base de datos." : ex.Number == 547 ? "No puedes eliminar este registro porque está relacionado con otros datos." : ex.Number == 2601 ? "El índice ya existe. Verifica los valores duplicados." : ex.Number == 53 ? "No se puede conectar al servidor. Verifica tu conexión de red." : $"Ocurrió un error de base de datos: {ex.Message}", "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return proveedores;
        }



    }
}
