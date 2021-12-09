using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiBiblioteca
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            AbrirFormEnPanel(new ImagenCentral());
            pnlPanelDelAutor.Visible = false;
        }

        //Abre los formularios en la pantalla principal
        public void AbrirFormEnPanel(object Formhija)
        {
            if (this.pnlPanelCentral.Controls.Count > 0)
                this.pnlPanelCentral.Controls.RemoveAt(0);
            Form fh = Formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlPanelCentral.Controls.Add(fh);
            this.pnlPanelCentral.Tag = fh;
            fh.Show();
        }

        private void pnlPanelSuperiorDelpanelDerecho_Paint(object sender, PaintEventArgs e)
        {
            AbrirFormEnPanel(new ImagenCentral());
            pnlPanelDelAutor.Visible = true;
        }
    }
}
