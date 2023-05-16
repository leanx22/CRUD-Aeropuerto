namespace AerolineasParcial.CRUD.Altas
{
    partial class FormAltaAeronave
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
            panel1 = new Panel();
            btnCancel = new Button();
            btnOK = new Button();
            lblTitulo = new Label();
            lblMatricula = new Label();
            tBoxMatricula = new TextBox();
            lblAsientos = new Label();
            lblbanios = new Label();
            lblCapBodega = new Label();
            numBodega = new NumericUpDown();
            chbxComida = new CheckBox();
            chbxInternet = new CheckBox();
            lblMaxBodega = new Label();
            numAsientos = new NumericUpDown();
            numBanios = new NumericUpDown();
            lblMaxBanios = new Label();
            lblMaxAsientos = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBodega).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAsientos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBanios).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnOK);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 441);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.MediumPurple;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(12, 113);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 38);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "button2";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.MediumPurple;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Location = new Point(12, 69);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(142, 38);
            btnOK.TabIndex = 1;
            btnOK.Text = "button1";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(12, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(55, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMatricula.Location = new Point(252, 76);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(79, 20);
            lblMatricula.TabIndex = 1;
            lblMatricula.Text = "Matricula:";
            // 
            // tBoxMatricula
            // 
            tBoxMatricula.Location = new Point(404, 77);
            tBoxMatricula.Name = "tBoxMatricula";
            tBoxMatricula.Size = new Size(135, 23);
            tBoxMatricula.TabIndex = 2;
            // 
            // lblAsientos
            // 
            lblAsientos.AutoSize = true;
            lblAsientos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAsientos.Location = new Point(252, 131);
            lblAsientos.Name = "lblAsientos";
            lblAsientos.Size = new Size(74, 20);
            lblAsientos.TabIndex = 3;
            lblAsientos.Text = "Asientos:";
            // 
            // lblbanios
            // 
            lblbanios.AutoSize = true;
            lblbanios.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblbanios.Location = new Point(252, 182);
            lblbanios.Name = "lblbanios";
            lblbanios.Size = new Size(60, 20);
            lblbanios.TabIndex = 5;
            lblbanios.Text = "Banios:";
            // 
            // lblCapBodega
            // 
            lblCapBodega.AutoSize = true;
            lblCapBodega.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCapBodega.Location = new Point(252, 243);
            lblCapBodega.Name = "lblCapBodega";
            lblCapBodega.Size = new Size(100, 20);
            lblCapBodega.TabIndex = 7;
            lblCapBodega.Text = "Cap. Bodega:";
            // 
            // numBodega
            // 
            numBodega.Location = new Point(404, 245);
            numBodega.Name = "numBodega";
            numBodega.Size = new Size(135, 23);
            numBodega.TabIndex = 8;
            // 
            // chbxComida
            // 
            chbxComida.AutoSize = true;
            chbxComida.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chbxComida.Location = new Point(273, 318);
            chbxComida.Name = "chbxComida";
            chbxComida.Size = new Size(88, 19);
            chbxComida.TabIndex = 10;
            chbxComida.Text = "checkBox1";
            chbxComida.UseVisualStyleBackColor = true;
            // 
            // chbxInternet
            // 
            chbxInternet.AutoSize = true;
            chbxInternet.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chbxInternet.Location = new Point(434, 318);
            chbxInternet.Name = "chbxInternet";
            chbxInternet.Size = new Size(88, 19);
            chbxInternet.TabIndex = 11;
            chbxInternet.Text = "checkBox2";
            chbxInternet.UseVisualStyleBackColor = true;
            // 
            // lblMaxBodega
            // 
            lblMaxBodega.AutoSize = true;
            lblMaxBodega.Enabled = false;
            lblMaxBodega.Location = new Point(459, 271);
            lblMaxBodega.Name = "lblMaxBodega";
            lblMaxBodega.Size = new Size(80, 15);
            lblMaxBodega.TabIndex = 12;
            lblMaxBodega.Text = "Max: 15000Kg";
            // 
            // numAsientos
            // 
            numAsientos.Location = new Point(404, 133);
            numAsientos.Name = "numAsientos";
            numAsientos.Size = new Size(71, 23);
            numAsientos.TabIndex = 13;
            // 
            // numBanios
            // 
            numBanios.Location = new Point(404, 184);
            numBanios.Name = "numBanios";
            numBanios.Size = new Size(71, 23);
            numBanios.TabIndex = 14;
            // 
            // lblMaxBanios
            // 
            lblMaxBanios.AutoSize = true;
            lblMaxBanios.Enabled = false;
            lblMaxBanios.Location = new Point(433, 210);
            lblMaxBanios.Name = "lblMaxBanios";
            lblMaxBanios.Size = new Size(42, 15);
            lblMaxBanios.TabIndex = 15;
            lblMaxBanios.Text = "Max: 8";
            // 
            // lblMaxAsientos
            // 
            lblMaxAsientos.AutoSize = true;
            lblMaxAsientos.Enabled = false;
            lblMaxAsientos.Location = new Point(421, 159);
            lblMaxAsientos.Name = "lblMaxAsientos";
            lblMaxAsientos.Size = new Size(54, 15);
            lblMaxAsientos.TabIndex = 16;
            lblMaxAsientos.Text = "Max: 800";
            // 
            // FormAltaAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 441);
            Controls.Add(lblMaxAsientos);
            Controls.Add(lblMaxBanios);
            Controls.Add(numBanios);
            Controls.Add(numAsientos);
            Controls.Add(lblMaxBodega);
            Controls.Add(chbxInternet);
            Controls.Add(chbxComida);
            Controls.Add(numBodega);
            Controls.Add(lblCapBodega);
            Controls.Add(lblbanios);
            Controls.Add(lblAsientos);
            Controls.Add(tBoxMatricula);
            Controls.Add(lblMatricula);
            Controls.Add(panel1);
            Name = "FormAltaAeronave";
            Text = "FormAltaAeronave";
            Load += FormAltaAeronave_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBodega).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAsientos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBanios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancel;
        protected TextBox tBoxMatricula;
        private Label lblMatricula;
        private Label lblAsientos;
        private Label lblbanios;
        private Label lblCapBodega;
        protected NumericUpDown numBodega;
        protected CheckBox chbxComida;
        protected CheckBox chbxInternet;
        protected Label lblMaxBodega;
        protected Label lblMaxBanios;
        protected Label lblMaxAsientos;
        protected Label lblTitulo;
        protected NumericUpDown numAsientos;
        protected NumericUpDown numBanios;
        protected Button btnOK;
    }
}