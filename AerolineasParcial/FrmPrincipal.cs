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
            InitializeComponent();
            usuario = new Usuario();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Gainsboro;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            barraMenu.BackColor = Color.GhostWhite;

            tBoxInfoBar.Text = "Se debe iniciar sesion para comenzar con las operaciones.";
            tBoxInfoBar.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom;
            tBoxInfoBar.Enabled = false;
            tBoxInfoBar.BorderStyle = BorderStyle.FixedSingle;

            listVuelos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;

            IniciarSesion();

        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFrm crud = new ConsultaFrm(this.usuario);
            crud.Show();//dialog?
        }

        private void IniciarSesion()
        {
            FrmInicioSesion ventanaSesion = new FrmInicioSesion();
            DialogResult result = ventanaSesion.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.usuario = ventanaSesion.Usuario;
                tBoxInfoBar.Text = "  " + this.usuario.apellido +
                  " " + this.usuario.nombre + " - " +
                  DateTime.Now.ToShortDateString();
            }
        }

    }
}
