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
            tBoxEdad = new TextBox();
            tBoxApellido = new TextBox();
            tBoxNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblNombre = new Label();
            tBoxDni = new TextBox();
            lblDni = new Label();
            pnlMenu.SuspendLayout();
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
            // tBoxEdad
            // 
            tBoxEdad.Location = new Point(337, 219);
            tBoxEdad.Name = "tBoxEdad";
            tBoxEdad.Size = new Size(153, 23);
            tBoxEdad.TabIndex = 20;
            // 
            // tBoxApellido
            // 
            tBoxApellido.Location = new Point(337, 176);
            tBoxApellido.Name = "tBoxApellido";
            tBoxApellido.Size = new Size(153, 23);
            tBoxApellido.TabIndex = 19;
            // 
            // tBoxNombre
            // 
            tBoxNombre.Location = new Point(337, 132);
            tBoxNombre.Name = "tBoxNombre";
            tBoxNombre.Size = new Size(153, 23);
            tBoxNombre.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(234, 217);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 16;
            label2.Text = "Edad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(234, 174);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 15;
            label1.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(234, 130);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(77, 21);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre:";
            // 
            // tBoxDni
            // 
            tBoxDni.Location = new Point(337, 83);
            tBoxDni.Name = "tBoxDni";
            tBoxDni.Size = new Size(153, 23);
            tBoxDni.TabIndex = 13;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDni.Location = new Point(234, 81);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(44, 21);
            lblDni.TabIndex = 12;
            lblDni.Text = "DNI:";
            // 
            // FormAltaPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 441);
            Controls.Add(tBoxEdad);
            Controls.Add(tBoxApellido);
            Controls.Add(tBoxNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombre);
            Controls.Add(tBoxDni);
            Controls.Add(lblDni);
            Controls.Add(pnlMenu);
            MinimumSize = new Size(650, 480);
            Name = "FormAltaPasajero";
            Text = "FormAlta";
            Load += FormAltaPasajero_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMenu;
        private Button btnSalir;
        protected Label lblTitle;
        protected TextBox tBoxEdad;
        protected TextBox tBoxApellido;
        private Label label2;
        private Label label1;
        private Label lblNombre;
        protected TextBox tBoxDni;
        private Label lblDni;
        protected TextBox tBoxNombre;
        protected Button btnGuardar;
    }
}