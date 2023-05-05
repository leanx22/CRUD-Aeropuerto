namespace AerolineasParcial
{
    partial class BuscadorPasajero
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
            btnCancelar = new Button();
            btnBuscar = new Button();
            tBoxDni = new TextBox();
            tBoxNombre = new TextBox();
            tBoxApellido = new TextBox();
            lblDni = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(274, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "button1";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(193, 303);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "button2";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tBoxDni
            // 
            tBoxDni.Location = new Point(91, 105);
            tBoxDni.Name = "tBoxDni";
            tBoxDni.Size = new Size(177, 23);
            tBoxDni.TabIndex = 2;
            // 
            // tBoxNombre
            // 
            tBoxNombre.Location = new Point(91, 166);
            tBoxNombre.Name = "tBoxNombre";
            tBoxNombre.Size = new Size(177, 23);
            tBoxNombre.TabIndex = 3;
            // 
            // tBoxApellido
            // 
            tBoxApellido.Location = new Point(91, 229);
            tBoxApellido.Name = "tBoxApellido";
            tBoxApellido.Size = new Size(177, 23);
            tBoxApellido.TabIndex = 4;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(163, 87);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(30, 15);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(154, 148);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(154, 211);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(54, 15);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(124, 34);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 8;
            label4.Text = "BUSQUEDA";
            // 
            // BuscadorPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 338);
            Controls.Add(label4);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDni);
            Controls.Add(tBoxApellido);
            Controls.Add(tBoxNombre);
            Controls.Add(tBoxDni);
            Controls.Add(btnBuscar);
            Controls.Add(btnCancelar);
            Name = "BuscadorPasajero";
            Text = "BuscadorPasajero";
            Load += BuscadorPasajero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnBuscar;
        private TextBox tBoxDni;
        private TextBox tBoxNombre;
        private TextBox tBoxApellido;
        private Label lblDni;
        private Label lblNombre;
        private Label lblApellido;
        private Label label4;
    }
}