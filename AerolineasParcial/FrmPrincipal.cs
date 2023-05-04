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
        List<Pasajero> listaPasajeros;
        List<Viaje> listaViajes;
        List<Aeronave> listaAeronave;
        public FrmPrincipal()
        {
            InitializeComponent();
            usuario = new Usuario();
            listaPasajeros = new List<Pasajero>();
            listaViajes = new List<Viaje>();
            listaAeronave = new List<Aeronave>();
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
            ConsultaFrm consulta = new ConsultaFrm();
            consulta.Show();//dialog?
        }

        private void IniciarSesion()
        {
            FrmInicioSesion ventanaSesion = new FrmInicioSesion();
            DialogResult result = ventanaSesion.ShowDialog();
            if (result == DialogResult.OK)
            {
                dataGridView1.DataSource = ventanaSesion.listaUsers;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToResizeRows = false;

                this.usuario = ventanaSesion.Usuario;
                tBoxInfoBar.Text = "  " + this.usuario.apellido +
                  " " + this.usuario.nombre + " - " +
                  DateTime.Now.ToShortDateString();
            }
        }

    }
}
