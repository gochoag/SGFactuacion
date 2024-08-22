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
    public class csFactura
    {
       
        public DateTime FechaFactura { get; set; }
        private csConexion conexion;
        public class FacturaDetalle
        {
            public long ID_DetalleFact { get; set; }
            public long ID_Produc { get; set; }
            public decimal Precio { get; set; }
            public decimal Cantidad { get; set; }
            public decimal IVA { get; set; }
        }
        public static List<csFactura> FechaFacturaCliente(long id)
        {
            List<csFactura> fechasFacturas = new List<csFactura>();
            csConexion conexion = new csConexion();

            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Get_Facturas_By_ClienteID", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Cliente", id);
                    conexion.OpenOrCloseConnection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            csFactura factura = new csFactura
                            {
                                FechaFactura = Convert.ToDateTime(reader["Fecha"])
                            };
                            fechasFacturas.Add(factura);
                        }
                    }

                    conexion.OpenOrCloseConnection();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al buscar las fechas de las facturas: " + ex.Message);
            }

            return fechasFacturas;
        }
        public csFactura()
        {
            conexion = new csConexion();
        }
        public long ObtenerUltimoIDFactura()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("sp_GetMaxFacturaID", conexion.GetConnection()))
                {
                    conexion.OpenOrCloseConnection();
                    long id = Convert.ToInt64(cmd.ExecuteScalar());
                    conexion.OpenOrCloseConnection();
                    return id;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al obtener el último ID de factura: " + ex.Message);
                return 0;
            }
        }
        public bool RegistrarFactura(long idPersona, DateTime fecha, List<FacturaDetalle> detalles, long idEmpleado)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("Sp_Insert_Factura", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Persona", idPersona);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);
                    cmd.Parameters.AddWithValue("@Id_Empleado", idEmpleado);

                    // Crear una DataTable para almacenar los detalles de la factura
                    DataTable dtDetalles = new DataTable();
                    dtDetalles.Columns.Add("ID_Produc", typeof(long));
                    dtDetalles.Columns.Add("Precio", typeof(decimal));
                    dtDetalles.Columns.Add("Cantidad", typeof(decimal));
                    dtDetalles.Columns.Add("IVA", typeof(decimal));

                    // Agregar los detalles de la factura a la DataTable
                    foreach (var detalle in detalles)
                    {
                        dtDetalles.Rows.Add(detalle.ID_Produc, detalle.Precio, detalle.Cantidad, detalle.IVA);
                    }

                    // Agregar la DataTable como parámetro de tabla al comando SQL
                    SqlParameter parameter = cmd.Parameters.AddWithValue("@Detalles", dtDetalles);
                    parameter.SqlDbType = SqlDbType.Structured;
                    parameter.TypeName = "dbo.FacturaDetalleType";

                    // Abrir la conexión, ejecutar el comando y cerrar la conexión
                    conexion.OpenOrCloseConnection();
                    cmd.ExecuteNonQuery();
                    conexion.OpenOrCloseConnection();

                    return true;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar la factura: " + ex.Message);
                return false;
            }
        }
    }


}
