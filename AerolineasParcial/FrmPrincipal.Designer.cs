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
            barraMenu = new MenuStrip();
            cRUDToolStripMenuItem = new ToolStripMenuItem();
            nuevaAltaToolStripMenuItem = new ToolStripMenuItem();
            nuevaModificacionToolStripMenuItem = new ToolStripMenuItem();
            nuevaBajaToolStripMenuItem = new ToolStripMenuItem();
            busquedaToolStripMenuItem = new ToolStripMenuItem();
            tBoxInfoBar = new TextBox();
            listVuelos = new ListBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            barraMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            nuevaAltaToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nuevaAltaToolStripMenuItem.Name = "nuevaAltaToolStripMenuItem";
            nuevaAltaToolStripMenuItem.Size = new Size(144, 22);
            nuevaAltaToolStripMenuItem.Text = "Alta";
            // 
            // nuevaModificacionToolStripMenuItem
            // 
            nuevaModificacionToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nuevaModificacionToolStripMenuItem.Name = "nuevaModificacionToolStripMenuItem";
            nuevaModificacionToolStripMenuItem.Size = new Size(144, 22);
            nuevaModificacionToolStripMenuItem.Text = "Modificación";
            // 
            // nuevaBajaToolStripMenuItem
            // 
            nuevaBajaToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nuevaBajaToolStripMenuItem.Name = "nuevaBajaToolStripMenuItem";
            nuevaBajaToolStripMenuItem.Size = new Size(144, 22);
            nuevaBajaToolStripMenuItem.Text = "Baja";
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
            // listVuelos
            // 
            listVuelos.FormattingEnabled = true;
            listVuelos.ItemHeight = 15;
            listVuelos.Location = new Point(12, 63);
            listVuelos.Name = "listVuelos";
            listVuelos.Size = new Size(370, 514);
            listVuelos.TabIndex = 0;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(428, 63);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(389, 337);
            dataGridView1.TabIndex = 3;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 623);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(listVuelos);
            Controls.Add(tBoxInfoBar);
            Controls.Add(barraMenu);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            barraMenu.ResumeLayout(false);
            barraMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private ListBox listVuelos;
        private Label label1;
        private ToolStripMenuItem busquedaToolStripMenuItem;
        private DataGridView dataGridView1;
    }
}