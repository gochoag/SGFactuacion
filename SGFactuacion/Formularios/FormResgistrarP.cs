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

namespace SGFactuacion
{
    public partial class FormResgistrarP : Form
    {

        public FormResgistrarP()
        {
            InitializeComponent();
        }
        public void LimpiarCampos()
        {
            TBNombreP.Text = string.Empty;
            TBPrecioP.Text = string.Empty;
            TBStockP.Text= string.Empty;
        }

        private void FormResgistrarP_Load(object sender, EventArgs e)
        {

        }

        private void BTRegistrarP_Click(object sender, EventArgs e)
        {
            if (TBNombreP.Text != string.Empty && TBPrecioP.Text != string.Empty && TBStockP.Text!=string.Empty)
            {
                csProducto regisprodu = new csProducto(TBNombreP.Text, decimal.Parse(TBPrecioP.Text, CultureInfo.InvariantCulture), int.Parse(TBStockP.Text));
                if (regisprodu.RegistrarProducto())
                {
                    MessageBox.Show("El producto se ha registrado con exito","Registro de producto",MessageBoxButtons.OK);
                    LimpiarCampos();
                }
                else MessageBox.Show("No se pudo lograr el registro del producto","Error de registro",MessageBoxButtons.OK);
            }
            else MessageBox.Show("Complete todos los campos necesarios para el registro del producto","Alerta campos vacios",MessageBoxButtons.OK);
        }
    }
}
