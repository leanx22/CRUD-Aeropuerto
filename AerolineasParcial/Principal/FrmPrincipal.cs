using AerolineasParcial.CRUD;
using AerolineasParcial.CRUD.Bajas;
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
                    MessageBox.Show("Pasajero dado de alto con exito!", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se puede dar de alta.\n" +
                        "Ya existe un pasajero con el mismo DNI.",
                        "Operacion cancelada", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
        }

        private void editarPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasajero pasajero;
            FrmEditarPasajero ventana = new FrmEditarPasajero(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                pasajero = ventana.Pasajero;
                this.aeropuerto -= pasajero;//utiliza equals elimino al pasajero con el mismo dni.
                this.aeropuerto += pasajero;//lo reemplazo por el que tiene los nuevos datos.
                MessageBox.Show("Edicion completa!", "Exito!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bajaDePasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pasajero pasajero;
            FormBajaPasajero ventana = new FormBajaPasajero(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                pasajero = ventana.Pasajero;
                this.aeropuerto -= pasajero;
                MessageBox.Show("Pasajero eliminado!", "Exito!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
