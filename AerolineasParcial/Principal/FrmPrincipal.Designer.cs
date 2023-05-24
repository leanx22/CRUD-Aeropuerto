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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            btnEstadisticas = new Button();
            btnVenta = new Button();
            btnListado = new Button();
            btnBajas = new Button();
            btnModificar = new Button();
            btnAltas = new Button();
            gridVuelos = new DataGridView();
            lblTitulo = new Label();
            lblAyuda = new Label();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridVuelos).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(4, 30, 38);
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Controls.Add(lblUsuario);
            pnlMenu.Controls.Add(btnEstadisticas);
            pnlMenu.Controls.Add(btnVenta);
            pnlMenu.Controls.Add(btnListado);
            pnlMenu.Controls.Add(btnBajas);
            pnlMenu.Controls.Add(btnModificar);
            pnlMenu.Controls.Add(btnAltas);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(185, 623);
            pnlMenu.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userIcon;
            pictureBox1.Location = new Point(3, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(176, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.FlatStyle = FlatStyle.Flat;
            lblUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(40, 146);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(102, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Guia Leandro";
            lblUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.FlatAppearance.BorderSize = 2;
            btnEstadisticas.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnEstadisticas.FlatStyle = FlatStyle.Flat;
            btnEstadisticas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEstadisticas.ForeColor = Color.White;
            btnEstadisticas.Location = new Point(4, 465);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(176, 41);
            btnEstadisticas.TabIndex = 5;
            btnEstadisticas.Text = "ESTADISTICA";
            btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // btnVenta
            // 
            btnVenta.FlatAppearance.BorderSize = 2;
            btnVenta.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVenta.ForeColor = Color.White;
            btnVenta.Location = new Point(4, 230);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(176, 41);
            btnVenta.TabIndex = 4;
            btnVenta.Text = "NUEVA VENTA";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // btnListado
            // 
            btnListado.FlatAppearance.BorderSize = 2;
            btnListado.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnListado.FlatStyle = FlatStyle.Flat;
            btnListado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListado.ForeColor = Color.White;
            btnListado.Location = new Point(4, 418);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(177, 41);
            btnListado.TabIndex = 3;
            btnListado.Text = "LISTADOS";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnListado_Click;
            // 
            // btnBajas
            // 
            btnBajas.FlatAppearance.BorderSize = 2;
            btnBajas.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnBajas.FlatStyle = FlatStyle.Flat;
            btnBajas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBajas.ForeColor = Color.White;
            btnBajas.Location = new Point(4, 371);
            btnBajas.Name = "btnBajas";
            btnBajas.Size = new Size(176, 41);
            btnBajas.TabIndex = 2;
            btnBajas.Text = "BAJA";
            btnBajas.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(4, 324);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(176, 41);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "MODIFICACION";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnAltas
            // 
            btnAltas.FlatAppearance.BorderSize = 2;
            btnAltas.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnAltas.FlatStyle = FlatStyle.Flat;
            btnAltas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltas.ForeColor = Color.White;
            btnAltas.Location = new Point(4, 277);
            btnAltas.Name = "btnAltas";
            btnAltas.Size = new Size(176, 41);
            btnAltas.TabIndex = 0;
            btnAltas.Text = "ALTAS";
            btnAltas.UseVisualStyleBackColor = true;
            // 
            // gridVuelos
            // 
            gridVuelos.BackgroundColor = Color.FromArgb(14, 110, 140);
            gridVuelos.BorderStyle = BorderStyle.None;
            gridVuelos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            gridVuelos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(19, 150, 191);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(19, 150, 191);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            gridVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            gridVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(14, 110, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(228, 0, 70);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            gridVuelos.DefaultCellStyle = dataGridViewCellStyle2;
            gridVuelos.Dock = DockStyle.Bottom;
            gridVuelos.EnableHeadersVisualStyles = false;
            gridVuelos.Location = new Point(185, 108);
            gridVuelos.Name = "gridVuelos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.OrangeRed;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            gridVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            gridVuelos.RowHeadersVisible = false;
            gridVuelos.RowTemplate.Height = 50;
            gridVuelos.Size = new Size(843, 515);
            gridVuelos.TabIndex = 5;
            gridVuelos.CellMouseDoubleClick += gridVuelos_CellMouseDoubleClick;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(14, 110, 140);
            lblTitulo.Location = new Point(740, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(276, 86);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "VUELOS";
            // 
            // lblAyuda
            // 
            lblAyuda.AutoSize = true;
            lblAyuda.BackColor = Color.Transparent;
            lblAyuda.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAyuda.ForeColor = Color.FromArgb(14, 110, 140);
            lblAyuda.Location = new Point(675, 85);
            lblAyuda.Name = "lblAyuda";
            lblAyuda.Size = new Size(353, 20);
            lblAyuda.TabIndex = 7;
            lblAyuda.Text = "Haga doble click en un vuelo para ver sus detalles";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 70, 89);
            ClientSize = new Size(1028, 623);
            Controls.Add(lblAyuda);
            Controls.Add(lblTitulo);
            Controls.Add(gridVuelos);
            Controls.Add(pnlMenu);
            MinimumSize = new Size(1044, 662);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridVuelos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnlMenu;
        private Button btnAltas;
        private Button btnListado;
        private Button btnBajas;
        private Button btnModificar;
        private Label lblUsuario;
        private Button btnVenta;
        private Button btnEstadisticas;
        private PictureBox pictureBox1;
        private DataGridView gridVuelos;
        private Label lblTitulo;
        private Label lblAyuda;
    }
}