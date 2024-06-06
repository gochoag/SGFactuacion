    using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFactuacion
{
    internal class csFactura
    {
        private csConexion conexion;

        public class FacturaDetalle
        {
            public long ID_DetalleFact { get; set; }
            public long ID_Produc { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public decimal IVA { get; set; }
        }

        public csFactura()
        {
            conexion = new csConexion();
        }

        public bool RegistrarFactura(long idCliente, DateTime fecha, List<FacturaDetalle> detalles)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("[dbo].[Sp_Insert_Factura]", conexion.GetConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_Cliente", idCliente);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);

                    // Crear una DataTable para almacenar los detalles de la factura
                    DataTable dtDetalles = new DataTable();
                    dtDetalles.Columns.Add("ID_Produc", typeof(long));
                    dtDetalles.Columns.Add("Precio", typeof(decimal));
                    dtDetalles.Columns.Add("Cantidad", typeof(int));
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
