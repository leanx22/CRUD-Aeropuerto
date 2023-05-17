namespace AerolineasParcial.Principal
{
    partial class FormVenta
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
            btnCancelar = new Button();
            btnAceptar = new Button();
            lblTitulo = new Label();
            lblViaje = new Label();
            lblFecha = new Label();
            tBoxFecha = new TextBox();
            lblDestino = new Label();
            tBoxDestino = new TextBox();
            btnSelectViaje = new Button();
            pnlViaje = new Panel();
            tBoxDuracion = new TextBox();
            lblDuracion = new Label();
            tBoxSalida = new TextBox();
            lblSalida = new Label();
            pnlPasajero = new Panel();
            tBoxEdad = new TextBox();
            lblEdad = new Label();
            tBoxApellido = new TextBox();
            lblApellido = new Label();
            tBoxNombre = new TextBox();
            lblNombre = new Label();
            btnBuscarPasajero = new Button();
            tBoxDNI = new TextBox();
            lblDNI = new Label();
            lblPasajero = new Label();
            pnlPasaje = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblUSDfinal = new Label();
            lblUSDbase = new Label();
            lblCostoFinal = new Label();
            lblCostoBase = new Label();
            lblPago = new Label();
            numValija2 = new NumericUpDown();
            numValija1 = new NumericUpDown();
            lblValija2 = new Label();
            chbxBolso = new CheckBox();
            lblValija1 = new Label();
            lblEquipaje = new Label();
            chbxEsPremium = new CheckBox();
            panel1.SuspendLayout();
            pnlViaje.SuspendLayout();
            pnlPasajero.SuspendLayout();
            pnlPasaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numValija2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numValija1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAceptar);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 60);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.FromArgb(12, 135, 255);
            btnCancelar.Location = new Point(326, 7);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(228, 46);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.FlatAppearance.BorderSize = 2;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.FromArgb(12, 135, 255);
            btnAceptar.Location = new Point(560, 7);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(228, 46);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Vender";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(69, 77, 109);
            lblTitulo.Location = new Point(12, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(236, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "NUEVA VENTA";
            // 
            // lblViaje
            // 
            lblViaje.AutoSize = true;
            lblViaje.BackColor = Color.Transparent;
            lblViaje.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblViaje.ForeColor = Color.White;
            lblViaje.Location = new Point(58, 0);
            lblViaje.Name = "lblViaje";
            lblViaje.Size = new Size(66, 30);
            lblViaje.TabIndex = 2;
            lblViaje.Text = "VIAJE";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.BackColor = Color.Transparent;
            lblFecha.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblFecha.ForeColor = Color.White;
            lblFecha.Location = new Point(3, 44);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 20);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "Fecha:";
            // 
            // tBoxFecha
            // 
            tBoxFecha.Location = new Point(74, 44);
            tBoxFecha.Name = "tBoxFecha";
            tBoxFecha.Size = new Size(99, 23);
            tBoxFecha.TabIndex = 5;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.BackColor = Color.Transparent;
            lblDestino.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDestino.ForeColor = Color.White;
            lblDestino.Location = new Point(3, 86);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(64, 20);
            lblDestino.TabIndex = 6;
            lblDestino.Text = "Destino:";
            // 
            // tBoxDestino
            // 
            tBoxDestino.Location = new Point(73, 83);
            tBoxDestino.Name = "tBoxDestino";
            tBoxDestino.Size = new Size(100, 23);
            tBoxDestino.TabIndex = 7;
            // 
            // btnSelectViaje
            // 
            btnSelectViaje.FlatAppearance.BorderSize = 2;
            btnSelectViaje.FlatStyle = FlatStyle.Flat;
            btnSelectViaje.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectViaje.ForeColor = Color.FromArgb(12, 135, 255);
            btnSelectViaje.Location = new Point(3, 253);
            btnSelectViaje.Name = "btnSelectViaje";
            btnSelectViaje.Size = new Size(179, 34);
            btnSelectViaje.TabIndex = 8;
            btnSelectViaje.Text = "Seleccionar";
            btnSelectViaje.UseVisualStyleBackColor = true;
            btnSelectViaje.Click += btnSelectViaje_Click;
            // 
            // pnlViaje
            // 
            pnlViaje.BackColor = Color.FromArgb(37, 42, 64);
            pnlViaje.Controls.Add(tBoxDuracion);
            pnlViaje.Controls.Add(lblDuracion);
            pnlViaje.Controls.Add(tBoxSalida);
            pnlViaje.Controls.Add(lblSalida);
            pnlViaje.Controls.Add(btnSelectViaje);
            pnlViaje.Controls.Add(tBoxDestino);
            pnlViaje.Controls.Add(lblViaje);
            pnlViaje.Controls.Add(lblDestino);
            pnlViaje.Controls.Add(tBoxFecha);
            pnlViaje.Controls.Add(lblFecha);
            pnlViaje.Location = new Point(29, 78);
            pnlViaje.Name = "pnlViaje";
            pnlViaje.Size = new Size(186, 290);
            pnlViaje.TabIndex = 9;
            // 
            // tBoxDuracion
            // 
            tBoxDuracion.Location = new Point(85, 165);
            tBoxDuracion.Name = "tBoxDuracion";
            tBoxDuracion.Size = new Size(88, 23);
            tBoxDuracion.TabIndex = 12;
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.BackColor = Color.Transparent;
            lblDuracion.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDuracion.ForeColor = Color.White;
            lblDuracion.Location = new Point(3, 165);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(76, 20);
            lblDuracion.TabIndex = 11;
            lblDuracion.Text = "Duracion:";
            // 
            // tBoxSalida
            // 
            tBoxSalida.Location = new Point(73, 126);
            tBoxSalida.Name = "tBoxSalida";
            tBoxSalida.Size = new Size(100, 23);
            tBoxSalida.TabIndex = 10;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.BackColor = Color.Transparent;
            lblSalida.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblSalida.ForeColor = Color.White;
            lblSalida.Location = new Point(3, 126);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(56, 20);
            lblSalida.TabIndex = 9;
            lblSalida.Text = "Salida:";
            // 
            // pnlPasajero
            // 
            pnlPasajero.BackColor = Color.FromArgb(37, 42, 64);
            pnlPasajero.Controls.Add(tBoxEdad);
            pnlPasajero.Controls.Add(lblEdad);
            pnlPasajero.Controls.Add(tBoxApellido);
            pnlPasajero.Controls.Add(lblApellido);
            pnlPasajero.Controls.Add(tBoxNombre);
            pnlPasajero.Controls.Add(lblNombre);
            pnlPasajero.Controls.Add(btnBuscarPasajero);
            pnlPasajero.Controls.Add(tBoxDNI);
            pnlPasajero.Controls.Add(lblDNI);
            pnlPasajero.Controls.Add(lblPasajero);
            pnlPasajero.Location = new Point(249, 78);
            pnlPasajero.Name = "pnlPasajero";
            pnlPasajero.Size = new Size(186, 290);
            pnlPasajero.TabIndex = 10;
            // 
            // tBoxEdad
            // 
            tBoxEdad.Location = new Point(75, 231);
            tBoxEdad.Name = "tBoxEdad";
            tBoxEdad.Size = new Size(49, 23);
            tBoxEdad.TabIndex = 18;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.BackColor = Color.Transparent;
            lblEdad.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblEdad.ForeColor = Color.White;
            lblEdad.Location = new Point(3, 231);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(48, 20);
            lblEdad.TabIndex = 17;
            lblEdad.Text = "Edad:";
            // 
            // tBoxApellido
            // 
            tBoxApellido.Location = new Point(75, 190);
            tBoxApellido.Name = "tBoxApellido";
            tBoxApellido.Size = new Size(100, 23);
            tBoxApellido.TabIndex = 16;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblApellido.ForeColor = Color.White;
            lblApellido.Location = new Point(3, 190);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 15;
            lblApellido.Text = "Apellido:";
            // 
            // tBoxNombre
            // 
            tBoxNombre.Location = new Point(75, 145);
            tBoxNombre.Name = "tBoxNombre";
            tBoxNombre.Size = new Size(100, 23);
            tBoxNombre.TabIndex = 14;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblNombre.ForeColor = Color.White;
            lblNombre.Location = new Point(3, 145);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(69, 20);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre:";
            // 
            // btnBuscarPasajero
            // 
            btnBuscarPasajero.FlatAppearance.BorderSize = 2;
            btnBuscarPasajero.FlatStyle = FlatStyle.Flat;
            btnBuscarPasajero.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarPasajero.ForeColor = Color.FromArgb(12, 135, 255);
            btnBuscarPasajero.Location = new Point(3, 74);
            btnBuscarPasajero.Name = "btnBuscarPasajero";
            btnBuscarPasajero.Size = new Size(179, 32);
            btnBuscarPasajero.TabIndex = 11;
            btnBuscarPasajero.Text = "Buscar";
            btnBuscarPasajero.UseVisualStyleBackColor = true;
            btnBuscarPasajero.Click += btnBuscarPasajero_Click;
            // 
            // tBoxDNI
            // 
            tBoxDNI.Location = new Point(49, 45);
            tBoxDNI.Name = "tBoxDNI";
            tBoxDNI.Size = new Size(126, 23);
            tBoxDNI.TabIndex = 12;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.Transparent;
            lblDNI.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblDNI.ForeColor = Color.White;
            lblDNI.Location = new Point(3, 47);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(40, 20);
            lblDNI.TabIndex = 11;
            lblDNI.Text = "DNI:";
            // 
            // lblPasajero
            // 
            lblPasajero.AutoSize = true;
            lblPasajero.BackColor = Color.Transparent;
            lblPasajero.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPasajero.ForeColor = Color.White;
            lblPasajero.Location = new Point(38, 0);
            lblPasajero.Name = "lblPasajero";
            lblPasajero.Size = new Size(112, 30);
            lblPasajero.TabIndex = 11;
            lblPasajero.Text = "PASAJERO";
            // 
            // pnlPasaje
            // 
            pnlPasaje.BackColor = Color.FromArgb(37, 42, 64);
            pnlPasaje.Controls.Add(label2);
            pnlPasaje.Controls.Add(label1);
            pnlPasaje.Controls.Add(lblUSDfinal);
            pnlPasaje.Controls.Add(lblUSDbase);
            pnlPasaje.Controls.Add(lblCostoFinal);
            pnlPasaje.Controls.Add(lblCostoBase);
            pnlPasaje.Controls.Add(lblPago);
            pnlPasaje.Controls.Add(numValija2);
            pnlPasaje.Controls.Add(numValija1);
            pnlPasaje.Controls.Add(lblValija2);
            pnlPasaje.Controls.Add(chbxBolso);
            pnlPasaje.Controls.Add(lblValija1);
            pnlPasaje.Controls.Add(lblEquipaje);
            pnlPasaje.Controls.Add(chbxEsPremium);
            pnlPasaje.Location = new Point(465, 78);
            pnlPasaje.Name = "pnlPasaje";
            pnlPasaje.Size = new Size(301, 287);
            pnlPasaje.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(201, 237);
            label2.Name = "label2";
            label2.Size = new Size(37, 17);
            label2.TabIndex = 30;
            label2.Text = "usd$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(201, 197);
            label1.Name = "label1";
            label1.Size = new Size(37, 17);
            label1.TabIndex = 29;
            label1.Text = "usd$";
            // 
            // lblUSDfinal
            // 
            lblUSDfinal.AutoSize = true;
            lblUSDfinal.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUSDfinal.ForeColor = Color.White;
            lblUSDfinal.Location = new Point(150, 234);
            lblUSDfinal.Name = "lblUSDfinal";
            lblUSDfinal.Size = new Size(45, 20);
            lblUSDfinal.TabIndex = 28;
            lblUSDfinal.Text = "9999";
            // 
            // lblUSDbase
            // 
            lblUSDbase.AutoSize = true;
            lblUSDbase.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUSDbase.ForeColor = Color.White;
            lblUSDbase.Location = new Point(150, 194);
            lblUSDbase.Name = "lblUSDbase";
            lblUSDbase.Size = new Size(45, 20);
            lblUSDbase.TabIndex = 27;
            lblUSDbase.Text = "9999";
            // 
            // lblCostoFinal
            // 
            lblCostoFinal.AutoSize = true;
            lblCostoFinal.BackColor = Color.Transparent;
            lblCostoFinal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCostoFinal.ForeColor = Color.White;
            lblCostoFinal.Location = new Point(45, 234);
            lblCostoFinal.Name = "lblCostoFinal";
            lblCostoFinal.Size = new Size(85, 20);
            lblCostoFinal.TabIndex = 26;
            lblCostoFinal.Text = "Costo final:";
            // 
            // lblCostoBase
            // 
            lblCostoBase.AutoSize = true;
            lblCostoBase.BackColor = Color.Transparent;
            lblCostoBase.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblCostoBase.ForeColor = Color.White;
            lblCostoBase.Location = new Point(45, 193);
            lblCostoBase.Name = "lblCostoBase";
            lblCostoBase.Size = new Size(86, 20);
            lblCostoBase.TabIndex = 25;
            lblCostoBase.Text = "Costo base:";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPago.ForeColor = Color.White;
            lblPago.Location = new Point(10, 164);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(50, 20);
            lblPago.TabIndex = 24;
            lblPago.Text = "PAGO";
            // 
            // numValija2
            // 
            numValija2.Location = new Point(202, 113);
            numValija2.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numValija2.Name = "numValija2";
            numValija2.Size = new Size(47, 23);
            numValija2.TabIndex = 23;
            // 
            // numValija1
            // 
            numValija1.Location = new Point(202, 88);
            numValija1.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numValija1.Name = "numValija1";
            numValija1.Size = new Size(47, 23);
            numValija1.TabIndex = 22;
            // 
            // lblValija2
            // 
            lblValija2.AutoSize = true;
            lblValija2.BackColor = Color.Transparent;
            lblValija2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblValija2.ForeColor = Color.White;
            lblValija2.Location = new Point(44, 116);
            lblValija2.Name = "lblValija2";
            lblValija2.Size = new Size(74, 20);
            lblValija2.TabIndex = 21;
            lblValija2.Text = "Valija n2:";
            // 
            // chbxBolso
            // 
            chbxBolso.AutoSize = true;
            chbxBolso.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chbxBolso.ForeColor = Color.White;
            chbxBolso.Location = new Point(45, 66);
            chbxBolso.Name = "chbxBolso";
            chbxBolso.Size = new Size(105, 19);
            chbxBolso.TabIndex = 20;
            chbxBolso.Text = "Bolso de mano";
            chbxBolso.UseVisualStyleBackColor = true;
            // 
            // lblValija1
            // 
            lblValija1.AutoSize = true;
            lblValija1.BackColor = Color.Transparent;
            lblValija1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblValija1.ForeColor = Color.White;
            lblValija1.Location = new Point(45, 88);
            lblValija1.Name = "lblValija1";
            lblValija1.Size = new Size(72, 20);
            lblValija1.TabIndex = 19;
            lblValija1.Text = "Valija n1:";
            // 
            // lblEquipaje
            // 
            lblEquipaje.AutoSize = true;
            lblEquipaje.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEquipaje.ForeColor = Color.White;
            lblEquipaje.Location = new Point(6, 43);
            lblEquipaje.Name = "lblEquipaje";
            lblEquipaje.Size = new Size(79, 20);
            lblEquipaje.TabIndex = 1;
            lblEquipaje.Text = "EQUIPAJE";
            // 
            // chbxEsPremium
            // 
            chbxEsPremium.AutoSize = true;
            chbxEsPremium.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            chbxEsPremium.ForeColor = Color.White;
            chbxEsPremium.Location = new Point(6, 5);
            chbxEsPremium.Name = "chbxEsPremium";
            chbxEsPremium.Size = new Size(143, 25);
            chbxEsPremium.TabIndex = 0;
            chbxEsPremium.Text = "Clase Premium";
            chbxEsPremium.UseVisualStyleBackColor = true;
            chbxEsPremium.CheckedChanged += chbxEsPremium_CheckedChanged;
            // 
            // FormVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(800, 450);
            Controls.Add(pnlPasaje);
            Controls.Add(pnlPasajero);
            Controls.Add(pnlViaje);
            Controls.Add(lblTitulo);
            Controls.Add(panel1);
            Name = "FormVenta";
            Text = "FormVenta";
            Load += FormVenta_Load;
            panel1.ResumeLayout(false);
            pnlViaje.ResumeLayout(false);
            pnlViaje.PerformLayout();
            pnlPasajero.ResumeLayout(false);
            pnlPasajero.PerformLayout();
            pnlPasaje.ResumeLayout(false);
            pnlPasaje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numValija2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numValija1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnAceptar;
        private Label lblTitulo;
        private Label lblViaje;
        private Label lblFecha;
        private TextBox tBoxFecha;
        private Label lblDestino;
        private TextBox tBoxDestino;
        private Button btnSelectViaje;
        private Panel pnlViaje;
        private TextBox tBoxSalida;
        private Label lblSalida;
        private Panel pnlPasajero;
        private Label lblPasajero;
        private TextBox tBoxApellido;
        private Label lblApellido;
        private TextBox tBoxNombre;
        private Label lblNombre;
        private Button btnBuscarPasajero;
        private TextBox tBoxDNI;
        private Label lblDNI;
        private TextBox tBoxEdad;
        private Label lblEdad;
        private Panel pnlPasaje;
        private TextBox tBoxDuracion;
        private Label lblDuracion;
        private Label lblEquipaje;
        private CheckBox chbxEsPremium;
        private Label lblValija1;
        private CheckBox chbxBolso;
        private NumericUpDown numValija2;
        private NumericUpDown numValija1;
        private Label lblValija2;
        private Label lblPago;
        private Label lblCostoFinal;
        private Label lblCostoBase;
        private Label label2;
        private Label label1;
        private Label lblUSDfinal;
        private Label lblUSDbase;
    }
}