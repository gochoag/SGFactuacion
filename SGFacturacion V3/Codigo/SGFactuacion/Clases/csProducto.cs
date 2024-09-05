using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SGFactuacion
{
    public class csProducto
    {
        public long IdProducto { get; set; }

        public long ID_Proveedor { get; set; }

        public string RazonComercial { get; set; }


        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Stock { get; set; }

        private csConexion conexion;

        public csProducto()
        {
            conexion = new csConexion();
        }

        public csProducto(string nombre, decimal precioUnitario, decimal stock)
        {
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Stock = stock;
            conexion = new csConexion();
        }


        public csProducto(long idProveedor, string nombre, decimal precioUnitario, decimal stock)
        {
            ID_Proveedor = idProveedor;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Stock = stock;
            conexion = new csConexion();
        }

        public csProducto(long idProducto, long idProveedor, string razonComercial,string nombre, decimal precioUnitario, decimal stock)
        {
            IdProducto = idProducto;
            ID_Proveedor = idProveedor;
            RazonComercial = razonComercial;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Stock = stock;
            conexion = new csConexion();
        }
        public csProducto(long idProducto, long idProveedor, string nombre, decimal precioUnitario, decimal stock)
        {
            IdProducto = idProducto;
            ID_Proveedor = idProveedor;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Stock = stock;
            conexion = new csConexion();
        }
        public bool RegistrarProducto()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Insert_Producto", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", Nombre);
                    cmd.Parameters.AddWithValue("@precio_unitario", PrecioUnitario);
                    cmd.Parameters.AddWithValue("@stock", Stock);
                    cmd.Parameters.AddWithValue("@ID_Proveedor", ID_Proveedor);

                    conexion.OpenOrCloseConnection();
                    cmd.ExecuteNonQuery();
                    conexion.OpenOrCloseConnection();
                }
                return true;
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

        public bool EditarProducto()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Update_Producto", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idproducto", IdProducto);
                    cmd.Parameters.AddWithValue("@idproveedor", ID_Proveedor);
                    cmd.Parameters.AddWithValue("@producto", Nombre);
                    cmd.Parameters.AddWithValue("@precio_unitario", PrecioUnitario);
                    cmd.Parameters.AddWithValue("@stock", Stock);

                    conexion.OpenOrCloseConnection();
                    cmd.ExecuteNonQuery();
                    conexion.OpenOrCloseConnection();
                }
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number == 2627 ? "Este registro ya existe en la base de datos." : ex.Number == 547 ? "No puedes eliminar este registro porque está relacionado con otros datos." : ex.Number == 2601 ? "El índice ya existe. Verifica los valores duplicados." : ex.Number == 53 ? "No se puede conectar al servidor. Verifica tu conexión de red." : $"Ocurrió un error de base de datos: {ex.Message}", "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static List<csProducto> ListarProductos()
        {
            List<csProducto> productos = new List<csProducto>();
            csConexion conexion = new csConexion();
            try
            {
               
                    using (SqlCommand cmd = new SqlCommand("sp_rep_Listado_Producto", conexion.GetConnection()))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conexion.OpenOrCloseConnection();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                   csProducto producto = new csProducto(
                                       long.Parse(reader["IDPRODUCTO"].ToString()),
                                       long.Parse(reader["IDPROVEEDOR"].ToString()),
                                       reader["RAZONCOMERCIAL"].ToString(),
                                       reader["PRODUCTO"].ToString(),
                                       decimal.Parse(reader["PRECIO_UNITARIO"].ToString(), System.Globalization.CultureInfo.InvariantCulture),
                                       decimal.Parse(reader["STOCK"].ToString(), System.Globalization.CultureInfo.InvariantCulture)
                                 );
                            productos.Add(producto);
                            }
                        }
                        conexion.OpenOrCloseConnection();
                    }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number == 2627 ? "Este registro ya existe en la base de datos." : ex.Number == 547 ? "No puedes eliminar este registro porque está relacionado con otros datos." : ex.Number == 2601 ? "El índice ya existe. Verifica los valores duplicados." : ex.Number == 53 ? "No se puede conectar al servidor. Verifica tu conexión de red." : $"Ocurrió un error de base de datos: {ex.Message}", "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return productos;
        }

        public static List<csProducto> BuscarProductoPorNombre(string patronNombre)
        {
            List<csProducto> productos = new List<csProducto>();
            csConexion conexion = new csConexion();
            try
            {
                
                    using (SqlCommand cmd = new SqlCommand("[sp_rep_Producto_By_Nombre]", conexion.GetConnection()))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PatronNombre", patronNombre);
                        conexion.OpenOrCloseConnection();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                 csProducto producto = new csProducto(
                                     long.Parse(reader["IDPRODUCTO"].ToString()),
                                     long.Parse(reader["IDPROVEEDOR"].ToString()),
                                     reader["RAZONCOMERCIAL"].ToString(),
                                     reader["PRODUCTO"].ToString(),
                                     decimal.Parse(reader["PRECIO_UNITARIO"].ToString(), System.Globalization.CultureInfo.InvariantCulture),
                                     decimal.Parse(reader["STOCK"].ToString(), System.Globalization.CultureInfo.InvariantCulture)
                                 );
                            productos.Add(producto);
                            }
                        }
                        conexion.OpenOrCloseConnection();
                    }
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number == 2627 ? "Este registro ya existe en la base de datos." : ex.Number == 547 ? "No puedes eliminar este registro porque está relacionado con otros datos." : ex.Number == 2601 ? "El índice ya existe. Verifica los valores duplicados." : ex.Number == 53 ? "No se puede conectar al servidor. Verifica tu conexión de red." : $"Ocurrió un error de base de datos: {ex.Message}", "Error de SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return productos;
        }




        //Para reportes
        public void CargarReporteListarProductos(ReportViewer reportViewer1)
        {
            csConexion conexion = new csConexion();
            using (SqlConnection conn = conexion.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("[sp_rep_Productos_Vendidos_Top5]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                try
                {
                    conn.Open();
                    da.Fill(ds);
                  

                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", ds.Tables[0]));
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
