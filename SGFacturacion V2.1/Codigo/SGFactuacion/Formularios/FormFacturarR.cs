using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SGFactuacion.Clases.csEmpleados;
using static SGFactuacion.csFactura;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGFactuacion
{
    public partial class FormFacturarR : Form
    {
        private List<csCliente> clientes;
        private List<csProducto> productos;
        private List<FacturaDetalle> detallesFactura;
        private long idEmpleado;
        private BindingSource bindingSource;
        private bool ProductoOCliente = true; //Si esta true entonces el dgv tiene datos de cliente

        //Ides
        private long idCliente;
        private long idProducto;
        
        public FormFacturarR()
        {
            InitializeComponent();
            this.idEmpleado = csCredenciales.IdEmpleadoLogueado;
            try
            {
                CargarCliente(); 
                bindingSource = new BindingSource();
                bindingSource.DataSource = clientes;
                dgvDatosBuscados.DataSource = bindingSource;
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al inicializar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
        private void CargarCliente()
        {
            try
            {
                clientes = csCliente.ListarClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private void CargarProductos()
        {
            try
            {
                productos = csProducto.ListarProductos();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

        }
        private void FormFacturarR_Load(object sender, EventArgs e)
        {
            dgvListaProductos.ColumnCount = 4;
            dgvListaProductos.Columns[0].Name = "ID_Producto";
            dgvListaProductos.Columns[1].Name = "Nombre";
            dgvListaProductos.Columns[2].Name = "Precio";
            dgvListaProductos.Columns[3].Name = "Cantidad";
        }

        private void cbBuscarCliente_TextChanged(object sender, EventArgs e)
        {
           
        }

        

        private void FormFacturarR_Activated(object sender, EventArgs e)
        {
            CargarCliente();
        }

        
        private void LimpiarCamposProducto()
        {
      
            txtCantidad.Clear();
            lblNombreProducto.Text = string.Empty;
            lblPrecio.Text = string.Empty;
            lblStock.Text = string.Empty;
        }
        private void LimpiarCamposCliente()
        {
            lblNombreCliente.Text = string.Empty;
        }

        private void btnAgregarProductoToDGV_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtCantidad.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de agregar el producto.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               
                decimal cantidad;
                if (!decimal.TryParse(txtCantidad.Text.Replace('.', ','), out cantidad))
                {
                    MessageBox.Show("La cantidad ingresada no es válida.", "Cantidad Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cantidad > Convert.ToDecimal(lblStock.Text))
                {
                    MessageBox.Show("La cantidad ingresada excede el stock disponible.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow row in dgvListaProductos.Rows)
                {
                    if (row.Cells["ID_Producto"].Value != null && (long)row.Cells["ID_Producto"].Value == idProducto)
                    {
                        MessageBox.Show("El producto ya está en la lista.", "Producto Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                dgvListaProductos.Rows.Add(idProducto, lblNombreProducto.Text, decimal.Parse(lblPrecio.Text), cantidad);

                //validar que tenga contenido el dgv
                BTNRegistrarFactura.Enabled = dgvListaProductos.Rows.Count > 0;


                LimpiarCamposProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al agregar el producto a la lista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnQuitarProductoToDGV_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvListaProductos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, seleccione un producto de la lista para eliminar.", "Producto no Seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvListaProductos.Rows.RemoveAt(dgvListaProductos.SelectedRows[0].Index);
                BTNRegistrarFactura.Enabled = dgvListaProductos.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al quitar el producto a la lista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }

        private void dgvListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GenerarReporte(long idFactura)
        {
            try
            {
             
                FrmReporte rp = new FrmReporte();
                rp.panel1.Visible = false;
                rp.FormBorderStyle=FormBorderStyle.SizableToolWindow;
                rp.StartPosition = FormStartPosition.CenterScreen;
                rp.Width = 630;
                rp.GenerarReporte1(idFactura);

                rp.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al generar el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BTNRegistrarFactura_Click(object sender, EventArgs e)
        {
            try
            {

                
                List<FacturaDetalle> detallesFactura = new List<FacturaDetalle>();
                foreach (DataGridViewRow fila in dgvListaProductos.Rows)
                {
                    long idProducto = Convert.ToInt64(fila.Cells["ID_Producto"].Value);
                    decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                    decimal cantidad = Convert.ToDecimal(fila.Cells["Cantidad"].Value);
                    FacturaDetalle detalle = new FacturaDetalle
                    {
                        ID_Produc = idProducto,
                        Precio = precio,
                        Cantidad = cantidad,
                        IVA = decimal.Parse(txtIVA.Text) /100,
                    };
                    detallesFactura.Add(detalle);
                }
                csFactura facturaManager = new csFactura();

                DateTime fechaActual = DateTime.Now;

                DialogResult result = MessageBox.Show("¿Está seguro de que desea registrar la factura?", "Confirmar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (facturaManager.RegistrarFactura(idCliente, fechaActual, detallesFactura,idEmpleado))
                    {
                        MessageBox.Show("La factura se ha registrado correctamente.", "Factura Registrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvListaProductos.Rows.Clear();
                        LimpiarCamposCliente();
                        CargarProductos();
                        GenerarReporte(facturaManager.ObtenerUltimoIDFactura());
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al registrar la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El registro de la factura ha sido cancelado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            if (e.KeyChar == '.' && !txtCantidad.Text.Contains("."))
            {
                return;
            }
            e.Handled = true;
        }

        private void lblNombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (lblNombreCliente.Text != string.Empty)
            {
     
                txtCantidad.Enabled=true;
                txtIVA.Enabled=true;
                txtBuscarProducto.Enabled=true;
            }
            else
            {
               
                txtCantidad.Enabled = false;
                txtIVA.Enabled=false;
                txtBuscarProducto.Enabled=false;
            }

        }

        private void txtIVA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                return;
            }
            e.Handled = true;
        }

        private void txtIVA_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIVA.Text))
            {
                txtIVA.Text = "15";
            }
        }

        private void txtIVA_Enter(object sender, EventArgs e)
        {
            if (txtIVA.Text == "15")
            {
                txtIVA.Text = "";
            }
        }

        private void dgvListaProductos_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtBuscarCliente.Text;
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    bindingSource.DataSource = clientes;
                }
                else
                {
                    bindingSource.DataSource = csCliente.BuscarClientes(filterText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar clientes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarCliente_Enter(object sender, EventArgs e)
        {
            txtBuscarCliente.Text = "";
            bindingSource.DataSource = clientes;
            panel1.Visible = true;
            ProductoOCliente= true; btnCerrarDGV.Enabled = true;
        }

        private void txtBuscarCliente_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtBuscaarProducto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = txtBuscarProducto.Text;
                if (string.IsNullOrWhiteSpace(filterText))
                {
                    bindingSource.DataSource = productos;
                }
                else
                {
                    bindingSource.DataSource = csProducto.BuscarProductoPorNombre(filterText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al buscar los productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtBuscaarProducto_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtBuscaarProducto_Enter(object sender, EventArgs e)
        {
            txtBuscarProducto.Text = "";
            bindingSource.DataSource = productos;
            panel1.Visible = true; 
            ProductoOCliente = false;
            btnCerrarDGV.Enabled = true;
        }

        private void dgvDatosBuscados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductoOCliente)
            {
                //Jalo datos de clientes del dgv
                // Asegúrate de que el índice de la fila sea válido
                if (e.RowIndex >= 0)
                {
                    // Pregunta al usuario si está seguro de elegir este cliente y verifica la respuesta
                    if (MessageBox.Show("¿Está seguro de elegir este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Obtén la fila seleccionada
                        DataGridViewRow selectedRow = dgvDatosBuscados.Rows[e.RowIndex];

                        // Obtén los datos de las columnas necesarias
                        idCliente = Convert.ToInt64(selectedRow.Cells["IdCliente"].Value);
                        string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                        string apellido = selectedRow.Cells["Apellido"].Value.ToString();

                        // Combina el nombre y el apellido
                        lblNombreCliente.Text = nombre + " " + apellido;

                        panel1.Visible = false;
                        txtBuscarProducto.Enabled = true;
                        btnCerrarDGV.Enabled = false;
                    }
                    else
                    {
                        panel1.Visible = false;
                        btnCerrarDGV.Enabled = false;
                    }
                }
                
            }
            else
            {
                //Jalo datos de productos del dgv
                // Asegúrate de que el índice de la fila sea válido
                if (e.RowIndex >= 0)
                {
                    // Pregunta al usuario si está seguro de elegir este cliente y verifica la respuesta
                    if (MessageBox.Show("¿Está seguro de elegir este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Obtén la fila seleccionada
                        DataGridViewRow selectedRow = dgvDatosBuscados.Rows[e.RowIndex];

                        // Obtén los datos de las columnas necesarias
                        idProducto = Convert.ToInt64(selectedRow.Cells["IdProducto"].Value);
                        lblNombreProducto.Text = selectedRow.Cells["Nombre"].Value.ToString();
                        lblPrecio.Text = selectedRow.Cells["PrecioUnitario"].Value.ToString();
                        lblStock.Text= selectedRow.Cells["Stock"].Value.ToString();


                        panel1.Visible = false;
                        btnCerrarDGV.Enabled = false;

                    }
                    else
                    {
                        panel1.Visible = false; 
                        btnCerrarDGV.Enabled = false;
                    }

                }
            }
        }
        private void dgvDatosBuscados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrarDGV_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            btnCerrarDGV.Enabled = false;
        }
    }
}
