namespace AerolineasParcial.CRUD
{
    partial class FrmCRUD
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
            dGrid = new DataGridView();
            btnNuevo = new Button();
            btnBaja = new Button();
            btnEditar = new Button();
            btnOK = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dGrid).BeginInit();
            SuspendLayout();
            // 
            // dGrid
            // 
            dGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dGrid.BackgroundColor = Color.FromArgb(14, 110, 140);
            dGrid.BorderStyle = BorderStyle.None;
            dGrid.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(19, 150, 191);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(19, 150, 191);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(14, 110, 140);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(228, 0, 70);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dGrid.DefaultCellStyle = dataGridViewCellStyle2;
            dGrid.EnableHeadersVisualStyles = false;
            dGrid.Location = new Point(12, 64);
            dGrid.Name = "dGrid";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.OrangeRed;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dGrid.RowHeadersVisible = false;
            dGrid.RowTemplate.Height = 50;
            dGrid.Size = new Size(740, 442);
            dGrid.TabIndex = 7;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevo.FlatAppearance.BorderSize = 2;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(758, 64);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(83, 90);
            btnNuevo.TabIndex = 8;
            btnNuevo.Text = "+";
            btnNuevo.TextAlign = ContentAlignment.TopCenter;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnBaja
            // 
            btnBaja.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBaja.FlatAppearance.BorderSize = 2;
            btnBaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnBaja.FlatStyle = FlatStyle.Flat;
            btnBaja.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaja.ForeColor = Color.White;
            btnBaja.Location = new Point(758, 160);
            btnBaja.Name = "btnBaja";
            btnBaja.Size = new Size(83, 90);
            btnBaja.TabIndex = 9;
            btnBaja.Text = "-";
            btnBaja.TextAlign = ContentAlignment.TopCenter;
            btnBaja.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEditar.FlatAppearance.BorderSize = 2;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(758, 256);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(83, 62);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "M";
            btnEditar.TextAlign = ContentAlignment.TopCenter;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.FlatAppearance.BorderSize = 2;
            btnOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(758, 519);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(83, 41);
            btnOK.TabIndex = 11;
            btnOK.Text = "Aceptar";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.Location = new Point(12, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(72, 30);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Titulo";
            // 
            // FrmCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 30, 38);
            ClientSize = new Size(853, 563);
            Controls.Add(lblTitulo);
            Controls.Add(btnOK);
            Controls.Add(btnEditar);
            Controls.Add(btnBaja);
            Controls.Add(btnNuevo);
            Controls.Add(dGrid);
            MinimumSize = new Size(869, 602);
            Name = "FrmCRUD";
            Text = "FrmCRUD";
            Load += FrmCRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        protected DataGridView dGrid;
        protected Button btnNuevo;
        protected Button btnBaja;
        protected Button btnEditar;
        protected Button btnOK;
        protected Label lblTitulo;
    }
}