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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            pnlMenu = new Panel();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            btnEstadisticas = new Button();
            btnVenta = new Button();
            btnListado = new Button();
            btnViajes = new Button();
            btnAeronaves = new Button();
            btnPasajeros = new Button();
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
            pnlMenu.Controls.Add(btnViajes);
            pnlMenu.Controls.Add(btnAeronaves);
            pnlMenu.Controls.Add(btnPasajeros);
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
            btnEstadisticas.Location = new Point(3, 495);
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
            btnVenta.Location = new Point(3, 217);
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
            btnListado.Location = new Point(3, 448);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(176, 41);
            btnListado.TabIndex = 3;
            btnListado.Text = "LISTADOS";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnListado_Click;
            // 
            // btnViajes
            // 
            btnViajes.FlatAppearance.BorderSize = 2;
            btnViajes.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnViajes.FlatStyle = FlatStyle.Flat;
            btnViajes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnViajes.ForeColor = Color.White;
            btnViajes.Location = new Point(3, 381);
            btnViajes.Name = "btnViajes";
            btnViajes.Size = new Size(176, 41);
            btnViajes.TabIndex = 2;
            btnViajes.Text = "VIAJES";
            btnViajes.UseVisualStyleBackColor = true;
            // 
            // btnAeronaves
            // 
            btnAeronaves.FlatAppearance.BorderSize = 2;
            btnAeronaves.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnAeronaves.FlatStyle = FlatStyle.Flat;
            btnAeronaves.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAeronaves.ForeColor = Color.White;
            btnAeronaves.Location = new Point(3, 334);
            btnAeronaves.Name = "btnAeronaves";
            btnAeronaves.Size = new Size(176, 41);
            btnAeronaves.TabIndex = 1;
            btnAeronaves.Text = "AERONAVES";
            btnAeronaves.UseVisualStyleBackColor = true;
            // 
            // btnPasajeros
            // 
            btnPasajeros.FlatAppearance.BorderSize = 2;
            btnPasajeros.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnPasajeros.FlatStyle = FlatStyle.Flat;
            btnPasajeros.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPasajeros.ForeColor = Color.White;
            btnPasajeros.Location = new Point(3, 287);
            btnPasajeros.Name = "btnPasajeros";
            btnPasajeros.Size = new Size(176, 41);
            btnPasajeros.TabIndex = 0;
            btnPasajeros.Text = "PASAJEROS";
            btnPasajeros.UseVisualStyleBackColor = true;
            btnPasajeros.Click += btnPasajeros_Click;
            // 
            // gridVuelos
            // 
            gridVuelos.BackgroundColor = Color.FromArgb(14, 110, 140);
            gridVuelos.BorderStyle = BorderStyle.None;
            gridVuelos.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            gridVuelos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(19, 150, 191);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(19, 150, 191);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridVuelos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridVuelos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(14, 110, 140);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(228, 0, 70);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            gridVuelos.DefaultCellStyle = dataGridViewCellStyle5;
            gridVuelos.Dock = DockStyle.Bottom;
            gridVuelos.EnableHeadersVisualStyles = false;
            gridVuelos.Location = new Point(185, 108);
            gridVuelos.Name = "gridVuelos";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.OrangeRed;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridVuelos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
        private Button btnPasajeros;
        private Button btnListado;
        private Button btnViajes;
        private Button btnAeronaves;
        private Label lblUsuario;
        private Button btnVenta;
        private Button btnEstadisticas;
        private PictureBox pictureBox1;
        private DataGridView gridVuelos;
        private Label lblTitulo;
        private Label lblAyuda;
    }
}