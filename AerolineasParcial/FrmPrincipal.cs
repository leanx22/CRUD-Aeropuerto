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
        public FrmPrincipal(Usuario usuario)
        {
            this.usuario = usuario;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Gainsboro;
            this.IsMdiContainer = true; //Testear
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.GhostWhite;
        }
    }
}
