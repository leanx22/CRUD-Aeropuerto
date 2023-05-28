namespace AerolineasParcial.CRUD
{
    partial class ABMpasajeros
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
            tBoxDNI = new TextBox();
            tBoxNombre = new TextBox();
            tBoxApellido = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnEquipaje = new Button();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevo.FlatAppearance.BorderSize = 2;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBaja
            // 
            btnBaja.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBaja.FlatAppearance.BorderSize = 2;
            btnBaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnBaja.Click += btnBaja_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditar.FlatAppearance.BorderSize = 2;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnOK
            // 
            btnOK.FlatAppearance.BorderSize = 2;
            btnOK.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnOK.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOK.Click += btnOK_Click;
            // 
            // tBoxDNI
            // 
            tBoxDNI.Location = new Point(12, 528);
            tBoxDNI.Name = "tBoxDNI";
            tBoxDNI.Size = new Size(100, 23);
            tBoxDNI.TabIndex = 13;
            // 
            // tBoxNombre
            // 
            tBoxNombre.Location = new Point(118, 528);
            tBoxNombre.Name = "tBoxNombre";
            tBoxNombre.Size = new Size(100, 23);
            tBoxNombre.TabIndex = 14;
            // 
            // tBoxApellido
            // 
            tBoxApellido.Location = new Point(224, 528);
            tBoxApellido.Name = "tBoxApellido";
            tBoxApellido.Size = new Size(100, 23);
            tBoxApellido.TabIndex = 15;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(330, 519);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(81, 41);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(417, 519);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(81, 41);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEquipaje
            // 
            btnEquipaje.FlatAppearance.BorderSize = 2;
            btnEquipaje.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnEquipaje.FlatStyle = FlatStyle.Flat;
            btnEquipaje.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnEquipaje.ForeColor = Color.White;
            btnEquipaje.Location = new Point(758, 324);
            btnEquipaje.Name = "btnEquipaje";
            btnEquipaje.Size = new Size(83, 59);
            btnEquipaje.TabIndex = 18;
            btnEquipaje.Text = "Ver equipaje";
            btnEquipaje.UseVisualStyleBackColor = true;
            btnEquipaje.Click += btnEquipaje_Click;
            // 
            // ABMpasajeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(853, 563);
            Controls.Add(btnEquipaje);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(tBoxApellido);
            Controls.Add(tBoxNombre);
            Controls.Add(tBoxDNI);
            Name = "ABMpasajeros";
            FormClosing += ABMpasajeros_FormClosing;
            Load += ABMpasajeros_Load;
            Controls.SetChildIndex(tBoxDNI, 0);
            Controls.SetChildIndex(tBoxNombre, 0);
            Controls.SetChildIndex(tBoxApellido, 0);
            Controls.SetChildIndex(btnBuscar, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(btnNuevo, 0);
            Controls.SetChildIndex(btnBaja, 0);
            Controls.SetChildIndex(btnEditar, 0);
            Controls.SetChildIndex(btnOK, 0);
            Controls.SetChildIndex(lblTitulo, 0);
            Controls.SetChildIndex(btnEquipaje, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBoxDNI;
        private TextBox tBoxNombre;
        private TextBox tBoxApellido;
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnEquipaje;
    }
}