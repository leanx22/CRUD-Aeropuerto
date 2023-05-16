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

namespace AerolineasParcial.Consultas
{
    public partial class FrmSelectorAeronaves : Form
    {
        Aeropuerto aeropuerto;
        Aeronave aeronave;

        public FrmSelectorAeronaves(Aeropuerto aeropuerto)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;            
            this.aeropuerto = aeropuerto;
            this.aeronave = new Aeronave();
        }

        public Aeronave Aeronave { get { return this.aeronave; } }

        private void FrmSelectorAeronaves_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            this.MaximizeBox = false;

            this.dataGridView1.DataSource = aeropuerto.Aeronaves;
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ReadOnly = true;

            this.btnSelect.Text = "Seleccionar";
            this.btnCancelar.Text = "Cancelar";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            int indice;

            if (!(dataGridView1.SelectedRows.Count > 0))
            {
                MessageBox.Show("Primero debe seleccionar una nave en la lista.",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;                
            }

            //obtengo el indice de la seleccion.            
            indice = indice = dataGridView1.SelectedRows[0].Index;
            this.aeronave = this.aeropuerto.Aeronaves[indice];

            if (!this.aeronave.Disponible)
            {
                MessageBox.Show("Esta aeronave no esta disponible para ser asignada.\n" +
                    "Posiblemente, este asignada a otro vuelo.", "Error", MessageBoxButtons.OK);
                return;
            }
                      
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
