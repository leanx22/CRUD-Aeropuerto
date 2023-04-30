namespace AerolineasParcial
{
    partial class ConsultaFrm
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
            pnlAlta = new Panel();
            tBoxTerciario = new TextBox();
            lblTerciario = new Label();
            tBoxSecundario = new TextBox();
            lblSecundario = new Label();
            lblPrimario = new Label();
            tBoxPrimario = new TextBox();
            btnPasajero = new Button();
            btnViaje = new Button();
            btnAeronave = new Button();
            btnAceptar = new Button();
            txtTitulo = new Label();
            listBox1 = new ListBox();
            btnBuscar = new Button();
            label1 = new Label();
            pnlAlta.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAlta
            // 
            pnlAlta.BackColor = SystemColors.ButtonHighlight;
            pnlAlta.Controls.Add(tBoxTerciario);
            pnlAlta.Controls.Add(lblTerciario);
            pnlAlta.Controls.Add(tBoxSecundario);
            pnlAlta.Controls.Add(lblSecundario);
            pnlAlta.Controls.Add(lblPrimario);
            pnlAlta.Controls.Add(tBoxPrimario);
            pnlAlta.Location = new Point(133, 61);
            pnlAlta.Name = "pnlAlta";
            pnlAlta.Size = new Size(300, 120);
            pnlAlta.TabIndex = 0;
            // 
            // tBoxTerciario
            // 
            tBoxTerciario.Location = new Point(113, 74);
            tBoxTerciario.Name = "tBoxTerciario";
            tBoxTerciario.Size = new Size(162, 23);
            tBoxTerciario.TabIndex = 5;
            // 
            // lblTerciario
            // 
            lblTerciario.AutoSize = true;
            lblTerciario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTerciario.Location = new Point(23, 75);
            lblTerciario.Name = "lblTerciario";
            lblTerciario.Size = new Size(61, 19);
            lblTerciario.TabIndex = 4;
            lblTerciario.Text = "Apellido:";
            // 
            // tBoxSecundario
            // 
            tBoxSecundario.Location = new Point(113, 45);
            tBoxSecundario.Name = "tBoxSecundario";
            tBoxSecundario.Size = new Size(162, 23);
            tBoxSecundario.TabIndex = 3;
            // 
            // lblSecundario
            // 
            lblSecundario.AutoSize = true;
            lblSecundario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSecundario.Location = new Point(23, 46);
            lblSecundario.Name = "lblSecundario";
            lblSecundario.Size = new Size(62, 19);
            lblSecundario.TabIndex = 2;
            lblSecundario.Text = "Nombre:";
            // 
            // lblPrimario
            // 
            lblPrimario.AutoSize = true;
            lblPrimario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimario.Location = new Point(23, 17);
            lblPrimario.Name = "lblPrimario";
            lblPrimario.Size = new Size(36, 19);
            lblPrimario.TabIndex = 1;
            lblPrimario.Text = "DNI:";
            // 
            // tBoxPrimario
            // 
            tBoxPrimario.Location = new Point(113, 16);
            tBoxPrimario.Name = "tBoxPrimario";
            tBoxPrimario.Size = new Size(162, 23);
            tBoxPrimario.TabIndex = 0;
            // 
            // btnPasajero
            // 
            btnPasajero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPasajero.Location = new Point(12, 61);
            btnPasajero.Name = "btnPasajero";
            btnPasajero.Size = new Size(103, 36);
            btnPasajero.TabIndex = 1;
            btnPasajero.Text = "PASAJERO";
            btnPasajero.UseVisualStyleBackColor = true;
            // 
            // btnViaje
            // 
            btnViaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViaje.Location = new Point(12, 103);
            btnViaje.Name = "btnViaje";
            btnViaje.Size = new Size(103, 36);
            btnViaje.TabIndex = 2;
            btnViaje.Text = "VIAJE";
            btnViaje.UseVisualStyleBackColor = true;
            // 
            // btnAeronave
            // 
            btnAeronave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAeronave.Location = new Point(12, 145);
            btnAeronave.Name = "btnAeronave";
            btnAeronave.Size = new Size(103, 36);
            btnAeronave.TabIndex = 3;
            btnAeronave.Text = "AERONAVE";
            btnAeronave.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(358, 496);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 37);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "button5";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.Location = new Point(12, 23);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(55, 21);
            txtTitulo.TabIndex = 6;
            txtTitulo.Text = "Titulo";
            txtTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 231);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(421, 259);
            listBox1.TabIndex = 7;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(358, 172);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 209);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 9;
            label1.Text = "Resultados";
            // 
            // ConsultaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 540);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(listBox1);
            Controls.Add(txtTitulo);
            Controls.Add(btnAceptar);
            Controls.Add(btnAeronave);
            Controls.Add(btnViaje);
            Controls.Add(btnPasajero);
            Controls.Add(pnlAlta);
            Name = "ConsultaFrm";
            Text = "CRUDform";
            Load += CRUDform_Load;
            pnlAlta.ResumeLayout(false);
            pnlAlta.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlAlta;
        private Button btnPasajero;
        private Button btnViaje;
        private Button btnAeronave;
        private Button btnAceptar;
        private Label txtTitulo;
        private TextBox tBoxPrimario;
        private Label lblPrimario;
        private ListBox listBox1;
        private TextBox tBoxTerciario;
        private Label lblTerciario;
        private TextBox tBoxSecundario;
        private Label lblSecundario;
        private Button btnBuscar;
        private Label label1;
    }
}