﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFactuacion
{
    public class csProducto
    {
        public long IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Stock { get; set; }

        private csConexion conexion;

        public csProducto(string nombre, decimal precioUnitario, decimal stock)
        {
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Stock = stock;
            conexion = new csConexion();
        }

        public csProducto(long idProducto, string nombre, decimal precioUnitario, decimal stock)
        {
            IdProducto = idProducto;
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

                    conexion.OpenOrCloseConnection();
                    cmd.ExecuteNonQuery();
                    conexion.OpenOrCloseConnection();
                }
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar el producto: " + ex.Message);
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
                Console.WriteLine("Error al editar el producto: " + ex.Message);
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
                Console.WriteLine("Error al listar los productos: " + ex.Message);
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
                                     reader.GetInt64(reader.GetOrdinal("ID_Produc")),
                                     reader.GetString(reader.GetOrdinal("Nombre")),
                                     reader.GetDecimal(reader.GetOrdinal("Precio_unitario")),
                                     reader.GetDecimal(reader.GetOrdinal("Stock"))
                                 );
                            productos.Add(producto);
                            }
                        }
                        conexion.OpenOrCloseConnection();
                    }
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al buscar los productos: " + ex.Message);
            }
            return productos;
        }




    }
}
