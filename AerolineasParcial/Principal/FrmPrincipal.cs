using AerolineasParcial.CRUD;
using AerolineasParcial.CRUD.Altas;
using AerolineasParcial.CRUD.Bajas;
using AerolineasParcial.CRUD.Modificacion;
using AerolineasParcial.Principal;
using BibliotecaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "No se inicio sesion.";
            lblUsuario.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;

            #region Anchors
            tabControl.Anchor = AnchorStyles.Left | AnchorStyles.Right |
                                AnchorStyles.Top | AnchorStyles.Bottom;
            lblUsuario.Anchor = AnchorStyles.Left;
            btnVenta.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEstadisticas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            #endregion

            #region TEXTOS
            btnAltaPasajero.Text = "ALTA\nPASAJERO";
            btnAltaAeronave.Text = "ALTA\nAERONAVE";
            btnAltaViaje.Text = "ALTA\nVIAJE";

            btnModificarPasajero.Text = "EDITAR\nPASAJERO";
            btnModificarAeronave.Text = "EDITAR\nAERONAVE";
            btnModificarViaje.Text = "EDITAR\nVIAJE";

            btnBajaPasajero.Text = "BAJA\nPASAJERO";
            btnBajaAeronave.Text = "BAJA\nAERONAVE";
            btnBajaViaje.Text = "BAJA\nVIAJE";
            #endregion

            IniciarSesion();

            #region Desactivo todos los controles
            this.btnAltaPasajero.Enabled = false;
            this.btnModificarPasajero.Enabled = false;
            this.btnBajaPasajero.Enabled = false;

            this.btnAltaAeronave.Enabled = false;
            this.btnModificarAeronave.Enabled = false;
            this.btnBajaAeronave.Enabled = false;

            this.btnAltaViaje.Enabled = false;
            this.btnModificarViaje.Enabled = false;
            this.btnBajaViaje.Enabled = false;

            this.btnListado.Enabled = false;//Listado
            this.btnVenta.Enabled = false;//Vender
            this.btnEstadisticas.Enabled = false;//Estadisticas
            #endregion
            
            //Los activo segun el perfil.
            EstablecerOperaciones();
        }

        private void IniciarSesion()
        {
            FrmInicioSesion ventanaSesion = new FrmInicioSesion();
            DialogResult result = ventanaSesion.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.usuario = ventanaSesion.Usuario;

                this.lblUsuario.Text = " [" + this.usuario.perfil + "] " + this.usuario.apellido +
                  " " + this.usuario.nombre + " - " +
                  DateTime.Now.ToShortDateString();
            }
        }

        private void EstablecerOperaciones()
        {
            if (this.usuario.perfil == EPerfil.vendedor)
            {
                this.btnListado.Enabled = true;//Listado
                this.btnVenta.Enabled = true;//Vender
                this.btnEstadisticas.Enabled = true;//Estadisticas
                this.btnAltaPasajero.Enabled = true;//CRUD
                this.btnModificarPasajero.Enabled = true;
                this.btnBajaPasajero.Enabled = true;
            }

            if (this.usuario.perfil == EPerfil.supervisor)
            {
                this.btnListado.Enabled = false;//Listado
                this.btnAltaPasajero.Enabled = true;//CRUD
                this.btnModificarPasajero.Enabled = true;
                this.btnBajaPasajero.Enabled = true;
                this.btnEstadisticas.Enabled = true;
            }

            if (this.usuario.perfil == EPerfil.administrador)
            {
                this.btnAltaAeronave.Enabled = true;
                this.btnModificarAeronave.Enabled = true;
                this.btnBajaAeronave.Enabled = true;

                this.btnAltaViaje.Enabled = true;
                this.btnModificarViaje.Enabled = true;
                this.btnBajaViaje.Enabled = true;
            }

        }

        private void btnAltas_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;//ALTAS
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;//Modificar
        }

        private void btnBajas_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;//Baja
        }

        #region PASAJERO

        private void btnAltaPasajero_Click(object sender, EventArgs e)
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

        private void btnModificarPasajero_Click(object sender, EventArgs e)
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

        private void btnBajaPasajero_Click(object sender, EventArgs e)
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
        private void btnAltaAeronave_Click(object sender, EventArgs e)
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

        private void btnModificarAeronave_Click(object sender, EventArgs e)
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

        private void btnBajaAeronave_Click(object sender, EventArgs e)
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
        private void btnAltaViaje_Click(object sender, EventArgs e)
        {
            FormAltaViaje ventana = new FormAltaViaje(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (this.aeropuerto != ventana.Viaje)
                {
                    this.aeropuerto += ventana.Viaje;
                    Archivos.GuardarViajes(this.aeropuerto.Viajes);
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

        private void btnModificarViaje_Click(object sender, EventArgs e)
        {
            FrmEditarViaje ventana = new FrmEditarViaje(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (this.aeropuerto != ventana.Viaje)
                {
                    this.aeropuerto += ventana.Viaje;
                    Archivos.GuardarViajes(this.aeropuerto.Viajes);
                    MessageBox.Show("Edicion completa", "Exito!", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void btnBajaViaje_Click(object sender, EventArgs e)
        {
            FrmBajaViaje ventana = new FrmBajaViaje(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                this.aeropuerto -= ventana.Viaje;

                Archivos.GuardarViajes(this.aeropuerto.Viajes);
                MessageBox.Show("Viaje eliminado!", "Exito!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion

        private void btnListado_Click(object sender, EventArgs e)
        {
            ConsultaFrm consulta = new ConsultaFrm(this.aeropuerto);
            consulta.Show(this);//dialog?
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            FormVenta ventana = new FormVenta(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                MessageBox.Show("Que tenga buen viaje.","Exito!",MessageBoxButtons.OK);
            }
        }
    }
}
