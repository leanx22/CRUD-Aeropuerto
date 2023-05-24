namespace AerolineasParcial.Consultas
{
    partial class FormViajes
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
            gridVuelos = new DataGridView();
            btnSelect = new Button();
            btnSalir = new Button();
            chbxInternet = new CheckBox();
            chbxComida = new CheckBox();
            linkDatosCompletos = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)gridVuelos).BeginInit();
            SuspendLayout();
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
            gridVuelos.EnableHeadersVisualStyles = false;
            gridVuelos.Location = new Point(12, 12);
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
            gridVuelos.Size = new Size(833, 500);
            gridVuelos.TabIndex = 6;
            // 
            // btnSelect
            // 
            btnSelect.FlatAppearance.BorderSize = 2;
            btnSelect.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(613, 518);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(113, 35);
            btnSelect.TabIndex = 7;
            btnSelect.Text = "Seleccionar";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(732, 518);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 35);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // chbxInternet
            // 
            chbxInternet.AutoSize = true;
            chbxInternet.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chbxInternet.ForeColor = Color.White;
            chbxInternet.Location = new Point(12, 527);
            chbxInternet.Name = "chbxInternet";
            chbxInternet.Size = new Size(76, 21);
            chbxInternet.TabIndex = 9;
            chbxInternet.Text = "Internet";
            chbxInternet.UseVisualStyleBackColor = true;
            // 
            // chbxComida
            // 
            chbxComida.AutoSize = true;
            chbxComida.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            chbxComida.ForeColor = Color.White;
            chbxComida.Location = new Point(108, 527);
            chbxComida.Name = "chbxComida";
            chbxComida.Size = new Size(73, 21);
            chbxComida.TabIndex = 10;
            chbxComida.Text = "Comida";
            chbxComida.UseVisualStyleBackColor = true;
            // 
            // linkDatosCompletos
            // 
            linkDatosCompletos.AutoSize = true;
            linkDatosCompletos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            linkDatosCompletos.LinkColor = Color.White;
            linkDatosCompletos.Location = new Point(187, 528);
            linkDatosCompletos.Name = "linkDatosCompletos";
            linkDatosCompletos.Size = new Size(161, 17);
            linkDatosCompletos.TabIndex = 11;
            linkDatosCompletos.TabStop = true;
            linkDatosCompletos.Text = "Mostrar datos completos";
            // 
            // FormViajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 70, 89);
            ClientSize = new Size(859, 559);
            Controls.Add(linkDatosCompletos);
            Controls.Add(chbxComida);
            Controls.Add(chbxInternet);
            Controls.Add(btnSalir);
            Controls.Add(btnSelect);
            Controls.Add(gridVuelos);
            MinimumSize = new Size(875, 598);
            Name = "FormViajes";
            Text = "FormViajes";
            Load += FormViajes_Load;
            ((System.ComponentModel.ISupportInitialize)gridVuelos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSelect;
        private Button btnSalir;
        private DataGridView gridVuelos;
        private CheckBox chbxInternet;
        private CheckBox chbxComida;
        private LinkLabel linkDatosCompletos;
    }
}