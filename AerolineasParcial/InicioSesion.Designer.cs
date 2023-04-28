namespace AerolineasParcial
{
    partial class FrmInicioSesion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            btnSalir = new Button();
            tBoxUser = new TextBox();
            tBoxPswrd = new TextBox();
            GrpBox = new GroupBox();
            labelPswrd = new Label();
            labelMail = new Label();
            GrpBox.SuspendLayout();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 179);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(151, 52);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "button1";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(186, 179);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(147, 52);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "button1";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tBoxUser
            // 
            tBoxUser.Location = new Point(58, 52);
            tBoxUser.Name = "tBoxUser";
            tBoxUser.Size = new Size(198, 23);
            tBoxUser.TabIndex = 2;
            // 
            // tBoxPswrd
            // 
            tBoxPswrd.Location = new Point(58, 110);
            tBoxPswrd.Name = "tBoxPswrd";
            tBoxPswrd.Size = new Size(198, 23);
            tBoxPswrd.TabIndex = 3;
            // 
            // GrpBox
            // 
            GrpBox.Controls.Add(labelPswrd);
            GrpBox.Controls.Add(labelMail);
            GrpBox.Controls.Add(tBoxUser);
            GrpBox.Controls.Add(tBoxPswrd);
            GrpBox.Location = new Point(12, 12);
            GrpBox.Name = "GrpBox";
            GrpBox.Size = new Size(321, 161);
            GrpBox.TabIndex = 4;
            GrpBox.TabStop = false;
            GrpBox.Text = "Datos del Usuario";
            // 
            // labelPswrd
            // 
            labelPswrd.AutoSize = true;
            labelPswrd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPswrd.Location = new Point(58, 92);
            labelPswrd.Name = "labelPswrd";
            labelPswrd.Size = new Size(72, 15);
            labelPswrd.TabIndex = 5;
            labelPswrd.Text = "Contraseña:";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMail.Location = new Point(58, 34);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(39, 15);
            labelMail.TabIndex = 4;
            labelMail.Text = "Email:";
            // 
            // FrmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 240);
            Controls.Add(GrpBox);
            Controls.Add(btnSalir);
            Controls.Add(btnAceptar);
            Name = "FrmInicioSesion";
            Text = "Inicio de sesion";
            Load += Form1_Load;
            GrpBox.ResumeLayout(false);
            GrpBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private Button btnSalir;
        private TextBox tBoxUser;
        private TextBox tBoxPswrd;
        private GroupBox GrpBox;
        private Label labelPswrd;
        private Label labelMail;
    }
}