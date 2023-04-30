using BibliotecaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineasParcial
{
    public partial class FrmPrincipal : Form
    {
        Usuario usuario;
        public FrmPrincipal()
        {
            usuario = new Usuario();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Gainsboro;
            InitializeComponent();
        }

        //public Usuario Usuario { get { return this.usuario; } set { this.usuario = value; } }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            barraMenu.BackColor = Color.GhostWhite;

            tBoxInfoBar.Text = "Se debe iniciar sesion para iniciar con las operaciones.";
            tBoxInfoBar.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            tBoxInfoBar.Enabled = false;
            tBoxInfoBar.BorderStyle = BorderStyle.Fixed3D;

            listVuelos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;

            FrmInicioSesion ventanaSesion = new FrmInicioSesion();
            DialogResult result = ventanaSesion.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.usuario = ventanaSesion.usuario;
                tBoxInfoBar.Text = this.usuario.apellido + " " + this.usuario.nombre + " - " +
                  DateTime.Now.ToShortDateString();
            }
            else
            {
                MessageBox.Show("Hubo un error en el inicio de sesion!", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFrm crud = new ConsultaFrm(this.usuario);
            crud.Show();//dialog?
        }
    }
}
