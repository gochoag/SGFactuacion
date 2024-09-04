using SGFactuacion.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGFactuacion
{
    public partial class Principal : Form
    {
        private Form activeForm = null;
        public Principal()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        bool menuExpand2 = false;
        bool menuExpand3 = false;
        bool menuExpand4 = false;

        private void Menutransacion_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                Flowcliente.Height += 40;
                if (Flowcliente.Height >= 160)
                {
                    Menutransacion.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                Flowcliente.Height -= 40;
                if (Flowcliente.Height <= 37)
                {
                    Menutransacion.Stop();
                    menuExpand = false;
                }
            }
        }

        private void Bcliente_Click(object sender, EventArgs e)
        {
            Menutransacion.Start();
        }

        private void Bproducto_Click(object sender, EventArgs e)
        {
            MenuTrP.Start();
        }

        private void MenuTrP_Tick(object sender, EventArgs e)
        {
            if (menuExpand2 == false)
            {
                FlowProducto.Height += 40;
                if (FlowProducto.Height >= 174)
                {
                    MenuTrP.Stop();
                    menuExpand2 = true;
                }


            }
            else
            {

                FlowProducto.Height -= 40;
                if (FlowProducto.Height <= 37)
                {
                    MenuTrP.Stop();
                    menuExpand2 = false;
                }

            }
        }
        bool sidbarExpand = true;
        private void SidbarTr_Tick(object sender, EventArgs e)
        {
            if (sidbarExpand)
            {
                Panelmenu.Width -= 10;
                if (Panelmenu.Width <= 51)
                {
                    sidbarExpand = false;
                    SidbarTr.Stop();
                   
                }
            }
            else
            {
                Panelmenu.Width += 10;
                if (Panelmenu.Width >= 205)
                {
                    sidbarExpand = true;
                    SidbarTr.Stop();
                   
                }
            }
        }

        private void Imagelateral_Click(object sender, EventArgs e)
        {
            SidbarTr.Start();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirHijo (object hijo)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            if (this.PnContenedor.Controls.Count>0)
            {
                this.PnContenedor.Controls.RemoveAt(0);
            }
            Form fh = hijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PnContenedor.Controls.Add(fh);
            this.PnContenedor.Tag = fh;
            fh.Show(); 
        }

        private void BEditarC_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FormEditarC());
        }

        private void BeditarP_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FormEditarP());
        }

        private void BlistarC_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FormListarC());
        }

        private void BlistarP_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FormListarP());
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FormFacturarR());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FrmReporte());
        }

        private void BregistarC_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FormRegistrarC());
        }

        private void BregistrarP_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FormResgistrarP());
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            btnFacturar_Click(null, e);
        }
        int posY = 0;
        int posX = 0;   
        private void Barra_Arriba_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button!=MouseButtons.Left)
            {
                posY = e.Y;
                posX = e.X;
            }
            else
            {
                Left=Left+(e.X-posX);
                Top=Top+(e.Y-posY); 
            }
        }

        private void PnContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuTrE_Tick(object sender, EventArgs e)
        {
            if (menuExpand3 == false)
            {
                FlowEmpleado.Height += 40;
                if (FlowEmpleado.Height >= 160)
                {
                    MenuTrE.Stop();
                    menuExpand3 = true;
                }
            }
            else
            {
                FlowEmpleado.Height -= 40;
                if (FlowEmpleado.Height <= 37)
                {
                    MenuTrE.Stop();
                    menuExpand3 = false;
                }
            }
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            MenuTrE.Start();
        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FrmRegistrarE());
        }

        private void btnEditarE_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FrmEditarE());
        }

        private void btnListarE_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FrmListarE());
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            MenuTrV.Start();
        }

        private void MenuTrV_Tick(object sender, EventArgs e)
        {
            if (menuExpand4 == false)
            {
                FlowProveedor.Height += 40;
                if (FlowProveedor.Height >= 160)
                {
                    MenuTrV.Stop();
                    menuExpand4 = true;
                }
            }
            else
            {
                FlowProveedor.Height -= 40;
                if (FlowProveedor.Height <= 37)
                {
                    MenuTrV.Stop();
                    menuExpand4 = false;
                }
            }
        }

        private void BtnProveeR_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FrmRegistrarProveer());
        }

        private void BtnProveeE_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FrmEditarProvee());
        }

        private void BtnProveeL_Click(object sender, EventArgs e)
        {
            AbrirHijo(new FrmListarProveer());
        }
    }
}

