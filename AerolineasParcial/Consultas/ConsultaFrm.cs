using BibliotecaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineasParcial
{
    public partial class ConsultaFrm : Form
    {
        Aeropuerto aeropuerto;
        private static ConsultaFrm? instancia;
        public ConsultaFrm(Aeropuerto aeropuerto)
        {
            if (instancia == null)
            {
                instancia = this;
            }
            else
            {
                instancia.Close();
                instancia = this;
            }
            this.StartPosition = FormStartPosition.CenterScreen;
            this.aeropuerto = aeropuerto;
            InitializeComponent();
        }

        private void CRUDform_Load(object sender, EventArgs e)
        {
            this.Text = "Listado de datos";

            this.MinimumSize = new Size(812, 670); //Tamanio minimo del formulario.

            tabControl.SelectedIndex = 0;

            #region DATAGRID
            gridDatos.ReadOnly = true;
            gridDatos.AllowUserToResizeRows = false;
            gridDatos.DataSource = aeropuerto.Pasajeros;
            gridDatos.EnableHeadersVisualStyles = true;
            gridDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            #endregion

            #region AnchorStyles

            this.btnLimpiar.Anchor = AnchorStyles.Left;
            this.btnBuscarPasajero.Anchor = AnchorStyles.Left;
            this.lblDNI.Anchor = AnchorStyles.Left;
            this.lblNombre.Anchor = AnchorStyles.Left;
            this.lblApellido.Anchor = AnchorStyles.Left;

            this.btnViaje.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            this.btnAeronave.Anchor = AnchorStyles.Left | AnchorStyles.Right;

            this.gridDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                                       AnchorStyles.Left | AnchorStyles.Right;
            #endregion


        }

        private void btnBuscarPasajero_Click(object sender, EventArgs e)
        {
            long dni = 0;

            if (tBoxDNI.Text != string.Empty && !long.TryParse(tBoxDNI.Text, out dni))
            {
                MessageBox.Show("El DNI ingresado no es valido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            gridDatos.DataSource = this.aeropuerto.BuscarPasajero(dni, tBoxNombre.Text, tBoxApellido.Text);
        }

        private void btnBuscarAeronave_Click(object sender, EventArgs e)
        {
            Aeronave aeronave;
            List<Aeronave> lista=new List<Aeronave>();
            if (tBoxMatricula.Text == string.Empty)
            {
                MessageBox.Show("Se debe ingresar una matricula.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.aeropuerto.BuscarAeronave(tBoxMatricula.Text, out aeronave))
            {
                lista.Add(aeronave);
                gridDatos.DataSource = lista;
            }
            else
            {
                gridDatos.DataSource = null;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)//eliminar
        {
            this.Close();
        }

        /// <summary>
        /// Cuando cambio de pestania se actualiza el source.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0://Pasajeros
                    gridDatos.DataSource = aeropuerto.Pasajeros;
                    break;
                case 1://Viajes
                    gridDatos.DataSource = null;
                    break;
                case 2://Aeronaves
                    gridDatos.DataSource = aeropuerto.Aeronaves;
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e) //Probar
        {
            tBoxNombre.Text = string.Empty;
            tBoxApellido.Text = string.Empty;
            tBoxDNI.Text = string.Empty;

            tBoxMatricula.Text = string.Empty;

            //"simulo" que cambie de pestania para que se actualize el datasource.
            tabControl_SelectedIndexChanged(sender, e);

        }


    }
}
