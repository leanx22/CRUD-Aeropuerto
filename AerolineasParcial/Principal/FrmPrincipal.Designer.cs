namespace AerolineasParcial
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            barraMenu = new MenuStrip();
            cRUDToolStripMenuItem = new ToolStripMenuItem();
            nuevaAltaToolStripMenuItem = new ToolStripMenuItem();
            nuevoPasajeroToolStripMenuItem = new ToolStripMenuItem();
            nuevoViajeToolStripMenuItem = new ToolStripMenuItem();
            nuevaAeronaveToolStripMenuItem = new ToolStripMenuItem();
            nuevaModificacionToolStripMenuItem = new ToolStripMenuItem();
            editarPasajeroToolStripMenuItem = new ToolStripMenuItem();
            editarAeronaveToolStripMenuItem = new ToolStripMenuItem();
            editarViajeToolStripMenuItem = new ToolStripMenuItem();
            nuevaBajaToolStripMenuItem = new ToolStripMenuItem();
            bajaDePasajeroToolStripMenuItem = new ToolStripMenuItem();
            bajaDeAeronaveToolStripMenuItem = new ToolStripMenuItem();
            eliminarViajeToolStripMenuItem = new ToolStripMenuItem();
            busquedaToolStripMenuItem = new ToolStripMenuItem();
            tBoxInfoBar = new TextBox();
            label1 = new Label();
            gridVuelos = new DataGridView();
            barraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridVuelos).BeginInit();
            SuspendLayout();
            // 
            // barraMenu
            // 
            barraMenu.Items.AddRange(new ToolStripItem[] { cRUDToolStripMenuItem, busquedaToolStripMenuItem });
            barraMenu.Location = new Point(0, 0);
            barraMenu.Name = "barraMenu";
            barraMenu.RenderMode = ToolStripRenderMode.Professional;
            barraMenu.Size = new Size(1028, 24);
            barraMenu.TabIndex = 0;
            barraMenu.Text = "stripMenu";
            // 
            // cRUDToolStripMenuItem
            // 
            cRUDToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaAltaToolStripMenuItem, nuevaModificacionToolStripMenuItem, nuevaBajaToolStripMenuItem });
            cRUDToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cRUDToolStripMenuItem.Name = "cRUDToolStripMenuItem";
            cRUDToolStripMenuItem.Size = new Size(52, 20);
            cRUDToolStripMenuItem.Text = "CRUD";
            // 
            // nuevaAltaToolStripMenuItem
            // 
            nuevaAltaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoPasajeroToolStripMenuItem, nuevoViajeToolStripMenuItem, nuevaAeronaveToolStripMenuItem });
            nuevaAltaToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nuevaAltaToolStripMenuItem.Name = "nuevaAltaToolStripMenuItem";
            nuevaAltaToolStripMenuItem.Size = new Size(180, 22);
            nuevaAltaToolStripMenuItem.Text = "Alta";
            // 
            // nuevoPasajeroToolStripMenuItem
            // 
            nuevoPasajeroToolStripMenuItem.Name = "nuevoPasajeroToolStripMenuItem";
            nuevoPasajeroToolStripMenuItem.Size = new Size(159, 22);
            nuevoPasajeroToolStripMenuItem.Text = "Nuevo pasajero";
            nuevoPasajeroToolStripMenuItem.Click += nuevoPasajeroToolStripMenuItem_Click;
            // 
            // nuevoViajeToolStripMenuItem
            // 
            nuevoViajeToolStripMenuItem.Name = "nuevoViajeToolStripMenuItem";
            nuevoViajeToolStripMenuItem.Size = new Size(159, 22);
            nuevoViajeToolStripMenuItem.Text = "Nuevo viaje";
            // 
            // nuevaAeronaveToolStripMenuItem
            // 
            nuevaAeronaveToolStripMenuItem.Name = "nuevaAeronaveToolStripMenuItem";
            nuevaAeronaveToolStripMenuItem.Size = new Size(159, 22);
            nuevaAeronaveToolStripMenuItem.Text = "Nueva aeronave";
            // 
            // nuevaModificacionToolStripMenuItem
            // 
            nuevaModificacionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editarPasajeroToolStripMenuItem, editarAeronaveToolStripMenuItem, editarViajeToolStripMenuItem });
            nuevaModificacionToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nuevaModificacionToolStripMenuItem.Name = "nuevaModificacionToolStripMenuItem";
            nuevaModificacionToolStripMenuItem.Size = new Size(180, 22);
            nuevaModificacionToolStripMenuItem.Text = "Modificación";
            // 
            // editarPasajeroToolStripMenuItem
            // 
            editarPasajeroToolStripMenuItem.Name = "editarPasajeroToolStripMenuItem";
            editarPasajeroToolStripMenuItem.Size = new Size(180, 22);
            editarPasajeroToolStripMenuItem.Text = "Editar pasajero";
            editarPasajeroToolStripMenuItem.Click += editarPasajeroToolStripMenuItem_Click;
            // 
            // editarAeronaveToolStripMenuItem
            // 
            editarAeronaveToolStripMenuItem.Name = "editarAeronaveToolStripMenuItem";
            editarAeronaveToolStripMenuItem.Size = new Size(180, 22);
            editarAeronaveToolStripMenuItem.Text = "Editar Aeronave";
            // 
            // editarViajeToolStripMenuItem
            // 
            editarViajeToolStripMenuItem.Name = "editarViajeToolStripMenuItem";
            editarViajeToolStripMenuItem.Size = new Size(180, 22);
            editarViajeToolStripMenuItem.Text = "Editar Viaje";
            // 
            // nuevaBajaToolStripMenuItem
            // 
            nuevaBajaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bajaDePasajeroToolStripMenuItem, bajaDeAeronaveToolStripMenuItem, eliminarViajeToolStripMenuItem });
            nuevaBajaToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nuevaBajaToolStripMenuItem.Name = "nuevaBajaToolStripMenuItem";
            nuevaBajaToolStripMenuItem.Size = new Size(180, 22);
            nuevaBajaToolStripMenuItem.Text = "Baja";
            // 
            // bajaDePasajeroToolStripMenuItem
            // 
            bajaDePasajeroToolStripMenuItem.Name = "bajaDePasajeroToolStripMenuItem";
            bajaDePasajeroToolStripMenuItem.Size = new Size(165, 22);
            bajaDePasajeroToolStripMenuItem.Text = "Baja de Pasajero";
            // 
            // bajaDeAeronaveToolStripMenuItem
            // 
            bajaDeAeronaveToolStripMenuItem.Name = "bajaDeAeronaveToolStripMenuItem";
            bajaDeAeronaveToolStripMenuItem.Size = new Size(165, 22);
            bajaDeAeronaveToolStripMenuItem.Text = "Baja de Aeronave";
            // 
            // eliminarViajeToolStripMenuItem
            // 
            eliminarViajeToolStripMenuItem.Name = "eliminarViajeToolStripMenuItem";
            eliminarViajeToolStripMenuItem.Size = new Size(165, 22);
            eliminarViajeToolStripMenuItem.Text = "Eliminar Viaje";
            // 
            // busquedaToolStripMenuItem
            // 
            busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            busquedaToolStripMenuItem.Size = new Size(66, 20);
            busquedaToolStripMenuItem.Text = "Consulta";
            busquedaToolStripMenuItem.Click += busquedaToolStripMenuItem_Click;
            // 
            // tBoxInfoBar
            // 
            tBoxInfoBar.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            tBoxInfoBar.Location = new Point(0, 598);
            tBoxInfoBar.Name = "tBoxInfoBar";
            tBoxInfoBar.Size = new Size(1028, 29);
            tBoxInfoBar.TabIndex = 1;
            tBoxInfoBar.Text = "Prueba";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 2;
            label1.Text = "PRÓXIMOS VUELOS";
            // 
            // gridVuelos
            // 
            gridVuelos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RosyBrown;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Pink;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.Crimson;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridVuelos.DefaultCellStyle = dataGridViewCellStyle2;
            gridVuelos.EnableHeadersVisualStyles = false;
            gridVuelos.Location = new Point(12, 63);
            gridVuelos.Name = "gridVuelos";
            gridVuelos.RowHeadersVisible = false;
            gridVuelos.RowTemplate.Height = 25;
            gridVuelos.Size = new Size(367, 529);
            gridVuelos.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 623);
            Controls.Add(gridVuelos);
            Controls.Add(label1);
            Controls.Add(tBoxInfoBar);
            Controls.Add(barraMenu);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            barraMenu.ResumeLayout(false);
            barraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridVuelos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip barraMenu;
        private TextBox tBoxInfoBar;
        private ToolStripMenuItem cRUDToolStripMenuItem;
        private ToolStripMenuItem nuevaAltaToolStripMenuItem;
        private ToolStripMenuItem nuevaModificacionToolStripMenuItem;
        private ToolStripMenuItem nuevaBajaToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem busquedaToolStripMenuItem;
        private DataGridView gridVuelos;
        private ToolStripMenuItem nuevoPasajeroToolStripMenuItem;
        private ToolStripMenuItem nuevoViajeToolStripMenuItem;
        private ToolStripMenuItem nuevaAeronaveToolStripMenuItem;
        private ToolStripMenuItem editarPasajeroToolStripMenuItem;
        private ToolStripMenuItem editarAeronaveToolStripMenuItem;
        private ToolStripMenuItem editarViajeToolStripMenuItem;
        private ToolStripMenuItem bajaDePasajeroToolStripMenuItem;
        private ToolStripMenuItem bajaDeAeronaveToolStripMenuItem;
        private ToolStripMenuItem eliminarViajeToolStripMenuItem;
    }
}