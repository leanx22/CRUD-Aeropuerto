namespace AerolineasParcial.CRUD
{
    partial class FormAltaPasajero
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
            pnlMenu = new Panel();
            lblTitle = new Label();
            btnSalir = new Button();
            btnGuardar = new Button();
            pnlMain = new Panel();
            numCantidad = new NumericUpDown();
            lblCantidad = new Label();
            cBoxEquipaje = new ComboBox();
            tBoxEdad = new TextBox();
            tBoxApellido = new TextBox();
            tBoxNombre = new TextBox();
            lbl = new Label();
            label2 = new Label();
            label1 = new Label();
            lblNombre = new Label();
            tBoxDni = new TextBox();
            lblDni = new Label();
            pnlMenu.SuspendLayout();
            pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.DarkSlateGray;
            pnlMenu.Controls.Add(lblTitle);
            pnlMenu.Controls.Add(btnSalir);
            pnlMenu.Controls.Add(btnGuardar);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.ForeColor = Color.White;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(168, 441);
            pnlMenu.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(55, 21);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Titulo";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Teal;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Location = new Point(12, 118);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(141, 38);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "button1";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Teal;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(12, 74);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(141, 38);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "button1";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(numCantidad);
            pnlMain.Controls.Add(lblCantidad);
            pnlMain.Controls.Add(cBoxEquipaje);
            pnlMain.Controls.Add(tBoxEdad);
            pnlMain.Controls.Add(tBoxApellido);
            pnlMain.Controls.Add(tBoxNombre);
            pnlMain.Controls.Add(lbl);
            pnlMain.Controls.Add(label2);
            pnlMain.Controls.Add(label1);
            pnlMain.Controls.Add(lblNombre);
            pnlMain.Controls.Add(tBoxDni);
            pnlMain.Controls.Add(lblDni);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(168, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(466, 441);
            pnlMain.TabIndex = 1;
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(384, 267);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(41, 23);
            numCantidad.TabIndex = 11;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(320, 271);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad:";
            // 
            // cBoxEquipaje
            // 
            cBoxEquipaje.FormattingEnabled = true;
            cBoxEquipaje.Location = new Point(193, 267);
            cBoxEquipaje.Name = "cBoxEquipaje";
            cBoxEquipaje.Size = new Size(121, 23);
            cBoxEquipaje.TabIndex = 9;
            // 
            // tBoxEdad
            // 
            tBoxEdad.Location = new Point(177, 219);
            tBoxEdad.Name = "tBoxEdad";
            tBoxEdad.Size = new Size(153, 23);
            tBoxEdad.TabIndex = 8;
            // 
            // tBoxApellido
            // 
            tBoxApellido.Location = new Point(177, 176);
            tBoxApellido.Name = "tBoxApellido";
            tBoxApellido.Size = new Size(153, 23);
            tBoxApellido.TabIndex = 7;
            // 
            // tBoxNombre
            // 
            tBoxNombre.Location = new Point(177, 132);
            tBoxNombre.Name = "tBoxNombre";
            tBoxNombre.Size = new Size(153, 23);
            tBoxNombre.TabIndex = 6;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(74, 265);
            lbl.Name = "lbl";
            lbl.Size = new Size(81, 21);
            lbl.TabIndex = 5;
            lbl.Text = "Equipaje:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 217);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 4;
            label2.Text = "Edad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 174);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 3;
            label1.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(74, 130);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 21);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // tBoxDni
            // 
            tBoxDni.Location = new Point(177, 83);
            tBoxDni.Name = "tBoxDni";
            tBoxDni.Size = new Size(153, 23);
            tBoxDni.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(74, 81);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(44, 21);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI:";
            // 
            // FormAltaPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 441);
            Controls.Add(pnlMain);
            Controls.Add(pnlMenu);
            MinimumSize = new Size(650, 480);
            Name = "FormAltaPasajero";
            Text = "FormAlta";
            Load += FormAltaPasajero_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Button btnGuardar;
        private Button btnSalir;
        private Panel pnlMain;
        private Label lblTitle;
        private Label label1;
        private Label lblNombre;
        private TextBox tBoxDni;
        private Label lblDni;
        private Label label2;
        private Label lbl;
        private ComboBox cBoxEquipaje;
        private TextBox tBoxEdad;
        private TextBox tBoxApellido;
        private TextBox tBoxNombre;
        private NumericUpDown numCantidad;
        private Label lblCantidad;
    }
}