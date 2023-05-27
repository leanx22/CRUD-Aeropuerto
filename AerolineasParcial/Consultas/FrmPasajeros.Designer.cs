namespace AerolineasParcial.Consultas
{
    partial class FrmPasajeros
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
            gridPasajeros = new DataGridView();
            btnSalir = new Button();
            tBoxDNI = new TextBox();
            tBoxNombre = new TextBox();
            tBoxApellido = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridPasajeros).BeginInit();
            SuspendLayout();
            // 
            // gridPasajeros
            // 
            gridPasajeros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridPasajeros.BackgroundColor = Color.FromArgb(14, 110, 140);
            gridPasajeros.BorderStyle = BorderStyle.None;
            gridPasajeros.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            gridPasajeros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(19, 150, 191);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(19, 150, 191);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridPasajeros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(14, 110, 140);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(228, 0, 70);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            gridPasajeros.DefaultCellStyle = dataGridViewCellStyle5;
            gridPasajeros.EnableHeadersVisualStyles = false;
            gridPasajeros.Location = new Point(12, 12);
            gridPasajeros.Name = "gridPasajeros";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.OrangeRed;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            gridPasajeros.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            gridPasajeros.RowHeadersVisible = false;
            gridPasajeros.RowTemplate.Height = 50;
            gridPasajeros.Size = new Size(840, 425);
            gridPasajeros.TabIndex = 6;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(676, 443);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(176, 41);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tBoxDNI
            // 
            tBoxDNI.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tBoxDNI.Location = new Point(12, 451);
            tBoxDNI.Name = "tBoxDNI";
            tBoxDNI.Size = new Size(109, 23);
            tBoxDNI.TabIndex = 8;
            // 
            // tBoxNombre
            // 
            tBoxNombre.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tBoxNombre.Location = new Point(242, 451);
            tBoxNombre.Name = "tBoxNombre";
            tBoxNombre.Size = new Size(109, 23);
            tBoxNombre.TabIndex = 9;
            // 
            // tBoxApellido
            // 
            tBoxApellido.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tBoxApellido.Location = new Point(127, 451);
            tBoxApellido.Name = "tBoxApellido";
            tBoxApellido.Size = new Size(109, 23);
            tBoxApellido.TabIndex = 10;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(382, 443);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 41);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(497, 443);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 41);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmPasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 30, 38);
            ClientSize = new Size(864, 490);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(tBoxApellido);
            Controls.Add(tBoxNombre);
            Controls.Add(tBoxDNI);
            Controls.Add(btnSalir);
            Controls.Add(gridPasajeros);
            MinimumSize = new Size(880, 529);
            Name = "FrmPasajeros";
            Text = "FrmPasajeros";
            Load += FrmPasajeros_Load;
            ((System.ComponentModel.ISupportInitialize)gridPasajeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gridPasajeros;
        private Button btnSalir;
        private TextBox tBoxDNI;
        private TextBox tBoxNombre;
        private TextBox tBoxApellido;
        private Button btnBuscar;
        private Button btnLimpiar;
    }
}