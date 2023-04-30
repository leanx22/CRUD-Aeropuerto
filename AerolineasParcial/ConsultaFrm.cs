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
        public ConsultaFrm(Usuario user)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            entidad = EEntidad.Pasajero; //Busqueda por defecto
            InitializeComponent();
        }

        private void CRUDform_Load(object sender, EventArgs e)
        {
            this.Text = "Nueva consulta";
            this.txtTitulo.Text = "Consulta de Datos";
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.btnAceptar.Text = "Listo";
            this.btnPasajero.TabIndex = 0; //Para que este seleccionado por defecto
        }
    }
}
