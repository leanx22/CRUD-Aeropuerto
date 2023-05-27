using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerolineasParcial.CRUD
{
    public partial class FrmCRUD : Form
    {
        public FrmCRUD()
        {
            InitializeComponent();
        }

        protected void FrmCRUD_Load(object sender, EventArgs e)
        {
            this.lblTitulo.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            this.btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnBaja.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            this.dGrid.ReadOnly = true;
            this.dGrid.MultiSelect = false;
            this.dGrid.AllowUserToResizeColumns = false;
            this.dGrid.AllowUserToResizeRows = false;
            this.dGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
                AnchorStyles.Right | AnchorStyles.Left;
            this.dGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
