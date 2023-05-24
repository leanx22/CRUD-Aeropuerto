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
            labelPswrd = new Label();
            labelMail = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.FlatAppearance.BorderColor = Color.White;
            btnAceptar.FlatAppearance.BorderSize = 2;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(12, 132);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(299, 46);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "button2";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnSalir
            // 
            btnSalir.FlatAppearance.BorderColor = Color.White;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(12, 184);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(299, 47);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "button1";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tBoxUser
            // 
            tBoxUser.BackColor = Color.White;
            tBoxUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tBoxUser.ForeColor = Color.Black;
            tBoxUser.Location = new Point(150, 35);
            tBoxUser.Name = "tBoxUser";
            tBoxUser.Size = new Size(161, 23);
            tBoxUser.TabIndex = 2;
            // 
            // tBoxPswrd
            // 
            tBoxPswrd.BackColor = Color.White;
            tBoxPswrd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tBoxPswrd.ForeColor = Color.Black;
            tBoxPswrd.Location = new Point(150, 93);
            tBoxPswrd.Name = "tBoxPswrd";
            tBoxPswrd.Size = new Size(161, 23);
            tBoxPswrd.TabIndex = 3;
            // 
            // labelPswrd
            // 
            labelPswrd.AutoSize = true;
            labelPswrd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPswrd.ForeColor = Color.White;
            labelPswrd.Location = new Point(150, 73);
            labelPswrd.Name = "labelPswrd";
            labelPswrd.Size = new Size(81, 17);
            labelPswrd.TabIndex = 5;
            labelPswrd.Text = "Contraseña:";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelMail.ForeColor = Color.White;
            labelMail.Location = new Point(150, 12);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(51, 20);
            labelMail.TabIndex = 4;
            labelMail.Text = "Email:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userIcon;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FrmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 30, 38);
            ClientSize = new Size(323, 249);
            Controls.Add(pictureBox1);
            Controls.Add(labelMail);
            Controls.Add(labelPswrd);
            Controls.Add(btnSalir);
            Controls.Add(tBoxPswrd);
            Controls.Add(tBoxUser);
            Controls.Add(btnAceptar);
            Name = "FrmInicioSesion";
            Text = "Inicio de sesion";
            Load += InicioSesion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnSalir;
        private TextBox tBoxUser;
        private TextBox tBoxPswrd;
        private Label labelPswrd;
        private Label labelMail;
        private PictureBox pictureBox1;
    }
}