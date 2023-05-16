using AerolineasParcial.CRUD;
using AerolineasParcial.CRUD.Altas;
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

            #region DATA_GRID
            gridVuelos.DataSource = this.aeropuerto.Viajes;
            gridVuelos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridVuelos.ReadOnly = true;
            gridVuelos.AllowUserToResizeRows = false;
            #endregion

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
                this.usuario = ventanaSesion.Usuario;
                tBoxInfoBar.Text = "  " + this.usuario.apellido +
                  " " + this.usuario.nombre + " - " +
                  DateTime.Now.ToShortDateString();
            }
        }

        #region PASAJERO
        private void nuevoPasajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaPasajero ventana = new FormAltaPasajero();
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (this.aeropuerto != ventana.Pasajero)
                {
                    this.aeropuerto += ventana.Pasajero;
                    Archivos.GuardarPasajeros(this.aeropuerto.Pasajeros);
                    MessageBox.Show("Pasajero dado de alta con exito!", "Exito!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Archivos.GuardarPasajeros(this.aeropuerto.Pasajeros);
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
                Archivos.GuardarPasajeros(this.aeropuerto.Pasajeros);
                MessageBox.Show("Pasajero eliminado!", "Exito!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region AERONAVE
        private void nuevaAeronaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaAeronave ventana = new FormAltaAeronave();
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (aeropuerto != ventana.Aeronave)
                {
                    this.aeropuerto += ventana.Aeronave;
                    Archivos.GuardarAeronaves(this.aeropuerto.Aeronaves);
                    MessageBox.Show("Alta exitosa", "Exito!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo dar de alta. La aeronave ya existe!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }
            }
        }

        private void editarAeronaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aeronave aeronave;
            FrmEditarAeronave ventana = new FrmEditarAeronave(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                aeronave = ventana.Aeronave;
                this.aeropuerto -= aeronave;//utiliza equals elimino a la aeronave con la misma matric.
                this.aeropuerto += aeronave;//lo reemplazo por la que tiene los nuevos datos.
                Archivos.GuardarAeronaves(this.aeropuerto.Aeronaves);
                MessageBox.Show("Edicion completa!", "Exito!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bajaDeAeronaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aeronave aeronave;
            FrmBajaAeronave ventana = new FrmBajaAeronave(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                aeronave = ventana.Aeronave;
                this.aeropuerto -= aeronave;
                Archivos.GuardarAeronaves(this.aeropuerto.Aeronaves);
                MessageBox.Show("Aeronave eliminada!", "Exito!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region VIAJE
        private void nuevoViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAltaViaje ventana = new FormAltaViaje(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (this.aeropuerto != ventana.Viaje)
                {
                    this.aeropuerto += ventana.Viaje;
                    //Archivos.GuardarViajes(this.aeropuerto.Viajes);
                    MessageBox.Show("Alta exitosa", "Exito!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo dar de alta. El viaje ya existe!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }

            }

        }

        private void editarViajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditarViaje ventana = new FrmEditarViaje(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (this.aeropuerto != ventana.Viaje)
                {
                    this.aeropuerto += ventana.Viaje;
                    //Archivos.GuardarViajes(this.aeropuerto.Viajes);
                    MessageBox.Show("Edicion completa", "Exito!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        #endregion


    }
}
