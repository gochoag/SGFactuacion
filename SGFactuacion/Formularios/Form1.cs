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
        FormRegistrarC RegistroC;
        FormResgistrarP RegistrarP;
        FormListarC ListarC;
        FormListarP ListarP;
        FormEditarC EditarC;
        FormEditarP EditarP;
        FormFacturarR Facturar;
        public Principal()
        {
            InitializeComponent();
        }
        bool menuExpand = false;
        bool menuExpand2 = false;

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
                    Panelcliente.Width = Panelmenu.Width;
                    Panelproducto.Width = Panelmenu.Width;
                }
            }
            else
            {
                Panelmenu.Width += 10;
                if (Panelmenu.Width >= 205)
                {
                    sidbarExpand = true;
                    SidbarTr.Stop();
                    Panelcliente.Width = Panelmenu.Width;
                    Panelproducto.Width = Panelmenu.Width;
                }
            }
        }

        private void Imagelateral_Click(object sender, EventArgs e)
        {
            SidbarTr.Start();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void BregistarC_Click(object sender, EventArgs e)
        {
            if (RegistroC == null)
            {
                RegistroC = new FormRegistrarC();
                RegistroC.FormClosed += RegistroC_FormClosed;
                RegistroC.MdiParent = this;
                RegistroC.Dock = DockStyle.Fill;
                RegistroC.Show();
            }
            else
            {
                RegistroC.Activate();
            }
        }

        private void RegistroC_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegistroC = null;
        }

        private void BEditarC_Click(object sender, EventArgs e)
        {
            if (EditarC == null)
            {
                EditarC = new FormEditarC();
                EditarC.FormClosed += EditarC_FormClosed;
                EditarC.MdiParent = this;
                EditarC.Dock = DockStyle.Fill;
                EditarC.Show();
            }
            else
            {
                EditarC.Activate();
            }

        }

        private void EditarC_FormClosed(object sender, FormClosedEventArgs e)
        {
            EditarC = null;
        }

        private void BlistarC_Click(object sender, EventArgs e)
        {
            if (ListarC == null)
            {
                ListarC = new FormListarC();
                ListarC.FormClosed += ListarC_FormClosed;
                ListarC.MdiParent = this;
                ListarC.Dock = DockStyle.Fill;
                ListarC.Show();
            }
            else
            {
                ListarC.Activate();
            }
        }

        private void ListarC_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarC = null;
        }

        private void BregistrarP_Click(object sender, EventArgs e)
        {
            if (RegistrarP == null)
            {
                RegistrarP = new FormResgistrarP();
                RegistrarP.FormClosed += RegistrarP_FormClosed; ;
                RegistrarP.MdiParent = this;
                RegistrarP.Dock = DockStyle.Fill;
                RegistrarP.Show();
            }
            else
            {
                RegistrarP.Activate();
            }
        }

        private void RegistrarP_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegistrarP = null;
        }

        private void BeditarP_Click(object sender, EventArgs e)
        {
            if (EditarP == null)
            {
                EditarP = new FormEditarP();
                EditarP.FormClosed += EditarP_FormClosed;
                EditarP.MdiParent = this;
                EditarP.Dock = DockStyle.Fill;
                EditarP.Show();
            }
            else
            {
                EditarP.Activate();
            }
        }

        private void EditarP_FormClosed(object sender, FormClosedEventArgs e)
        {
            EditarP = null;
        }

        private void BlistarP_Click(object sender, EventArgs e)
        {
            if (ListarP == null)
            {
                ListarP = new FormListarP();
                ListarP.FormClosed += ListarP_FormClosed; ;
                ListarP.MdiParent = this;
                ListarP.Dock = DockStyle.Fill;
                ListarP.Show();
            }
            else
            {
                ListarP.Activate();
            }
        }

        private void ListarP_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListarP = null;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Facturar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Facturar = null;
        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (Facturar == null)
            {
                Facturar = new FormFacturarR();
                Facturar.FormClosed += Facturar_FormClosed;
                Facturar.MdiParent = this;
                Facturar.Dock = DockStyle.Fill;
                Facturar.Show();
            }
            else
            {
                Facturar.Activate();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

