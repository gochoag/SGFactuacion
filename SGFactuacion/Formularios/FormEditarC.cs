﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SGFactuacion
{
    public partial class FormEditarC : Form
    {
        private List<csCliente> clientes;
        private BindingSource bindingSource;
        public FormEditarC()
        {
            InitializeComponent();
            CargarClientes();
            bindingSource = new BindingSource();
            bindingSource.DataSource = clientes;
            dgvListadoCliente.DataSource = bindingSource;
            txtcedulaC.KeyPress += txtcedulaC_KeyPress;
        }
        private void CargarClientes()
        {
            clientes = csCliente.ListarClientes();

        }
        private void FormEditarC_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filterText = txtBuscar.Text;
            if (string.IsNullOrWhiteSpace(filterText))
            {
                bindingSource.DataSource = clientes;
            }
            else
            {
                bindingSource.DataSource = csCliente.BuscarClientes(filterText);
            }
        }
        long idCLIENTE;
        private void dgvListadoCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListadoCliente.Rows[e.RowIndex];
                idCLIENTE = long.Parse(row.Cells["IdCliente"].Value.ToString());
                txtcedulaC.Text = row.Cells["Cedula"].Value.ToString();
                txtNombreC.Text = row.Cells["Nombre"].Value.ToString();
                txtApellidoC.Text = row.Cells["Apellido"].Value.ToString();
                dtFechaC.Value = Convert.ToDateTime(row.Cells["FechaNacimiento"].Value);
                txtEmailC.Text = row.Cells["Email"].Value.ToString();
            }
        }
        public void LimpiarControles()
        {
            txtcedulaC.Text = string.Empty;
            txtApellidoC.Text = string.Empty;
            txtNombreC.Text = string.Empty;
            txtEmailC.Text = string.Empty;
            dtFechaC.Value = new DateTime(2000, 9, 1);
            txtBuscar.Text = String.Empty;
            txtEmailC.Text = string.Empty;
        }
        private void BTEditarC_Click(object sender, EventArgs e)
        {
            string cedula = txtcedulaC.Text;
            string nombre = txtNombreC.Text;
            string apellido = txtApellidoC.Text;
            DateTime fechaNacimiento = dtFechaC.Value;
            string email = txtEmailC.Text;
            if (string.IsNullOrEmpty(cedula) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas editar este cliente?", "Confirmar edición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                csCliente cliente = new csCliente(idCLIENTE, cedula, nombre, apellido, fechaNacimiento, email);

                if (cliente.EditarCliente())
                {
                    MessageBox.Show("Cliente editado exitosamente.", "Edición exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarControles();
                    CargarClientes();
                    bindingSource.DataSource = clientes;
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al editar el cliente", "Error de edición", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvListadoCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcedulaC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                return;
            }
            if (char.IsDigit(e.KeyChar))
            {
                if (txtcedulaC.Text.Length >= 10)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }
    }
}
