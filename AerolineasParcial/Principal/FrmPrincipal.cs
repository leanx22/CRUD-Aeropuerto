using AerolineasParcial.CRUD;
using AerolineasParcial.CRUD.Modificacion;
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
        Aeropuerto aeropuerto;

        public FrmPrincipal()
        {
            InitializeComponent();
            usuario = new Usuario();
            aeropuerto = new Aeropuerto();
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

            gridVuelos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;

            IniciarSesion();

        }

        private void busquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaFrm consulta = new ConsultaFrm(this.aeropuerto);
            consulta.Show();//dialog?
        }

        private void IniciarSesion()
        {
            FrmInicioSesion ventanaSesion = new FrmInicioSesion();
            DialogResult result = ventanaSesion.ShowDialog();
            if (result == DialogResult.OK)
            {
                #region PRUEBA DATA_GRID
                gridVuelos.DataSource = ventanaSesion.listaUsers;
                gridVuelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gridVuelos.ReadOnly = true;
                gridVuelos.AllowUserToResizeRows = false;
                #endregion

                this.usuario = ventanaSesion.Usuario;
                tBoxInfoBar.Text = "  " + this.usuario.apellido +
                  " " + this.usuario.nombre + " - " +
                  DateTime.Now.ToShortDateString();
            }
        }

        private void nuevoPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaPasajero ventana = new FormAltaPasajero();
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (this.aeropuerto != ventana.Pasajero)
                {
                    this.aeropuerto += ventana.Pasajero;
                    MessageBox.Show("Alta completada.", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo dar de alta!\nRazon: El pasajero ya existe.",
                        "Operacion cancelada", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
        }

        private void editarPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarPasajero ventana = new FrmEditarPasajero(this.aeropuerto);
            ventana.Show();
        }
    }
}
