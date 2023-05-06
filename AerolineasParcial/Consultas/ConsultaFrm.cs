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
    public partial class ConsultaFrm : Form
    {
        EEntidad entidad;
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
            entidad = EEntidad.Pasajero; //Busqueda por defecto.
            this.aeropuerto = aeropuerto;
            InitializeComponent();
        }

        private void CRUDform_Load(object sender, EventArgs e)
        {
            this.Text = "Nueva consulta";
            this.txtTitulo.Text = "Consulta de datos";
            this.btnAceptar.Text = "Listo";
            this.btnPasajero.TabIndex = 0; //Para que este seleccionado por defecto.

            this.MinimumSize = new Size(650, 480); //Tamanio minimo del formulario.

            gridPasajeros.ReadOnly = true;
            gridPasajeros.AllowUserToResizeRows = false;
            #region AnchorStyles
            this.txtTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.btnPasajero.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.btnViaje.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.btnAeronave.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.btnAceptar.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            this.gridPasajeros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                                        AnchorStyles.Left | AnchorStyles.Right;
            #endregion


        }

        private void btnPasajero_Click(object sender, EventArgs e)
        {
            BuscadorPasajero ventana = new BuscadorPasajero(this.aeropuerto);
            DialogResult res = ventana.ShowDialog();
            if (res == DialogResult.OK)
            {
                gridPasajeros.DataSource = ventana.Resultados;
            }
        }

        private void btnViaje_Click(object sender, EventArgs e)
        {


        }

        private void btnAeronave_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
