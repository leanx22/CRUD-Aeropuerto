namespace AerolineasParcial.CRUD.Altas
{
    partial class FormAltaViaje
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
            chbxInternacional = new CheckBox();
            lblDestino = new Label();
            cBoxDestinos = new ComboBox();
            lblPartida = new Label();
            tBoxPartida = new TextBox();
            label1 = new Label();
            dateTimePicker = new DateTimePicker();
            lblAeronave = new Label();
            tBoxAeronave = new TextBox();
            btnAsignarAeronave = new Button();
            label2 = new Label();
            lblTipo = new Label();
            lblDisponibilidad = new Label();
            lblTurista = new Label();
            lblPremium = new Label();
            lblCantTurista = new Label();
            lblCantPremium = new Label();
            lblPrecio = new Label();
            lblPrecioTurista = new Label();
            lblPrecioPremium = new Label();
            label3 = new Label();
            tBoxDuracion = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnOK);
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 441);
            panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.RosyBrown;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(12, 118);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 40);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "button2";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.RosyBrown;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.Location = new Point(12, 72);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(140, 40);
            btnOK.TabIndex = 1;
            btnOK.Text = "button1";
            btnOK.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(12, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(51, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "label1";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chbxInternacional
            // 
            chbxInternacional.AutoSize = true;
            chbxInternacional.Location = new Point(498, 52);
            chbxInternacional.Name = "chbxInternacional";
            chbxInternacional.Size = new Size(83, 19);
            chbxInternacional.TabIndex = 1;
            chbxInternacional.Text = "checkBox1";
            chbxInternacional.UseVisualStyleBackColor = true;
            chbxInternacional.CheckedChanged += chbxInternacional_CheckedChanged;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDestino.Location = new Point(263, 47);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(67, 20);
            lblDestino.TabIndex = 2;
            lblDestino.Text = "Destino:";
            // 
            // cBoxDestinos
            // 
            cBoxDestinos.FormattingEnabled = true;
            cBoxDestinos.Location = new Point(371, 48);
            cBoxDestinos.Name = "cBoxDestinos";
            cBoxDestinos.Size = new Size(121, 23);
            cBoxDestinos.TabIndex = 3;
            // 
            // lblPartida
            // 
            lblPartida.AutoSize = true;
            lblPartida.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPartida.Location = new Point(263, 92);
            lblPartida.Name = "lblPartida";
            lblPartida.Size = new Size(63, 20);
            lblPartida.TabIndex = 4;
            lblPartida.Text = "Partida:";
            // 
            // tBoxPartida
            // 
            tBoxPartida.Location = new Point(371, 93);
            tBoxPartida.Name = "tBoxPartida";
            tBoxPartida.Size = new Size(121, 23);
            tBoxPartida.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(263, 138);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 6;
            label1.Text = "Fecha:";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(371, 136);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(229, 23);
            dateTimePicker.TabIndex = 7;
            // 
            // lblAeronave
            // 
            lblAeronave.AutoSize = true;
            lblAeronave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblAeronave.Location = new Point(263, 202);
            lblAeronave.Name = "lblAeronave";
            lblAeronave.Size = new Size(80, 20);
            lblAeronave.TabIndex = 8;
            lblAeronave.Text = "Aeronave:";
            // 
            // tBoxAeronave
            // 
            tBoxAeronave.Location = new Point(371, 203);
            tBoxAeronave.Name = "tBoxAeronave";
            tBoxAeronave.Size = new Size(121, 23);
            tBoxAeronave.TabIndex = 9;
            // 
            // btnAsignarAeronave
            // 
            btnAsignarAeronave.Location = new Point(498, 203);
            btnAsignarAeronave.Name = "btnAsignarAeronave";
            btnAsignarAeronave.Size = new Size(75, 23);
            btnAsignarAeronave.TabIndex = 10;
            btnAsignarAeronave.Text = "button1";
            btnAsignarAeronave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(263, 253);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 11;
            label2.Text = "Asientos:";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(303, 287);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(35, 17);
            lblTipo.TabIndex = 12;
            lblTipo.Text = "TIPO";
            // 
            // lblDisponibilidad
            // 
            lblDisponibilidad.AutoSize = true;
            lblDisponibilidad.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisponibilidad.Location = new Point(371, 287);
            lblDisponibilidad.Name = "lblDisponibilidad";
            lblDisponibilidad.Size = new Size(70, 17);
            lblDisponibilidad.TabIndex = 13;
            lblDisponibilidad.Text = "Cant. Disp.";
            // 
            // lblTurista
            // 
            lblTurista.AutoSize = true;
            lblTurista.Location = new Point(303, 319);
            lblTurista.Name = "lblTurista";
            lblTurista.Size = new Size(42, 15);
            lblTurista.TabIndex = 14;
            lblTurista.Text = "Turista";
            // 
            // lblPremium
            // 
            lblPremium.AutoSize = true;
            lblPremium.Location = new Point(303, 343);
            lblPremium.Name = "lblPremium";
            lblPremium.Size = new Size(56, 15);
            lblPremium.TabIndex = 15;
            lblPremium.Text = "Premium";
            // 
            // lblCantTurista
            // 
            lblCantTurista.AutoSize = true;
            lblCantTurista.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantTurista.Location = new Point(395, 319);
            lblCantTurista.Name = "lblCantTurista";
            lblCantTurista.Size = new Size(14, 15);
            lblCantTurista.TabIndex = 16;
            lblCantTurista.Text = "0";
            lblCantTurista.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantPremium
            // 
            lblCantPremium.AutoSize = true;
            lblCantPremium.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantPremium.Location = new Point(395, 343);
            lblCantPremium.Name = "lblCantPremium";
            lblCantPremium.Size = new Size(14, 15);
            lblCantPremium.TabIndex = 17;
            lblCantPremium.Text = "0";
            lblCantPremium.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(458, 287);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(44, 17);
            lblPrecio.TabIndex = 18;
            lblPrecio.Text = "Precio";
            // 
            // lblPrecioTurista
            // 
            lblPrecioTurista.AutoSize = true;
            lblPrecioTurista.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioTurista.Location = new Point(470, 319);
            lblPrecioTurista.Name = "lblPrecioTurista";
            lblPrecioTurista.Size = new Size(14, 15);
            lblPrecioTurista.TabIndex = 19;
            lblPrecioTurista.Text = "0";
            lblPrecioTurista.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrecioPremium
            // 
            lblPrecioPremium.AutoSize = true;
            lblPrecioPremium.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioPremium.Location = new Point(470, 343);
            lblPrecioPremium.Name = "lblPrecioPremium";
            lblPrecioPremium.Size = new Size(14, 15);
            lblPrecioPremium.TabIndex = 20;
            lblPrecioPremium.Text = "0";
            lblPrecioPremium.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(263, 378);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 21;
            label3.Text = "Duracion:";
            // 
            // tBoxDuracion
            // 
            tBoxDuracion.Location = new Point(371, 375);
            tBoxDuracion.Name = "tBoxDuracion";
            tBoxDuracion.Size = new Size(121, 23);
            tBoxDuracion.TabIndex = 22;
            // 
            // FormAltaViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(tBoxDuracion);
            Controls.Add(label3);
            Controls.Add(lblPrecioPremium);
            Controls.Add(lblPrecioTurista);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantPremium);
            Controls.Add(lblCantTurista);
            Controls.Add(lblPremium);
            Controls.Add(lblTurista);
            Controls.Add(lblDisponibilidad);
            Controls.Add(lblTipo);
            Controls.Add(label2);
            Controls.Add(btnAsignarAeronave);
            Controls.Add(tBoxAeronave);
            Controls.Add(lblAeronave);
            Controls.Add(dateTimePicker);
            Controls.Add(label1);
            Controls.Add(tBoxPartida);
            Controls.Add(lblPartida);
            Controls.Add(cBoxDestinos);
            Controls.Add(lblDestino);
            Controls.Add(chbxInternacional);
            Controls.Add(panel1);
            MinimumSize = new Size(640, 480);
            Name = "FormAltaViaje";
            Text = "FormAltaViaje";
            Load += FormAltaViaje_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        protected Label lblTitulo;
        private Button btnCancel;
        protected Button btnOK;
        private CheckBox chbxInternacional;
        private Label lblDestino;
        private ComboBox cBoxDestinos;
        private Label lblPartida;
        private TextBox tBoxPartida;
        private Label label1;
        private DateTimePicker dateTimePicker;
        private Label lblAeronave;
        private TextBox tBoxAeronave;
        private Button btnAsignarAeronave;
        private Label label2;
        private Label lblTipo;
        private Label lblDisponibilidad;
        private Label lblTurista;
        private Label lblPremium;
        private Label lblCantTurista;
        private Label lblCantPremium;
        private Label lblPrecio;
        private Label lblPrecioTurista;
        private Label lblPrecioPremium;
        private Label label3;
        private TextBox tBoxDuracion;
    }
}