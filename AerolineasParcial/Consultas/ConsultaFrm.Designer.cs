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
            btnBuscarPasajero = new Button();
            btnViaje = new Button();
            btnAeronave = new Button();
            gridDatos = new DataGridView();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            btnLimpiar = new Button();
            lblApellido = new Label();
            lblNombre = new Label();
            lblDNI = new Label();
            tBoxApellido = new TextBox();
            tBoxNombre = new TextBox();
            tBoxDNI = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)gridDatos).BeginInit();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscarPasajero
            // 
            btnBuscarPasajero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscarPasajero.Location = new Point(684, 33);
            btnBuscarPasajero.Name = "btnBuscarPasajero";
            btnBuscarPasajero.Size = new Size(78, 23);
            btnBuscarPasajero.TabIndex = 1;
            btnBuscarPasajero.Text = "Buscar";
            btnBuscarPasajero.UseVisualStyleBackColor = true;
            btnBuscarPasajero.Click += btnBuscarPasajero_Click;
            // 
            // btnViaje
            // 
            btnViaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViaje.Location = new Point(331, 272);
            btnViaje.Name = "btnViaje";
            btnViaje.Size = new Size(88, 36);
            btnViaje.TabIndex = 2;
            btnViaje.Text = "VIAJE";
            btnViaje.UseVisualStyleBackColor = true;
            btnViaje.Click += btnViaje_Click;
            // 
            // btnAeronave
            // 
            btnAeronave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAeronave.Location = new Point(334, 275);
            btnAeronave.Name = "btnAeronave";
            btnAeronave.Size = new Size(88, 36);
            btnAeronave.TabIndex = 3;
            btnAeronave.Text = "AERONAVE";
            btnAeronave.UseVisualStyleBackColor = true;
            btnAeronave.Click += btnAeronave_Click;
            // 
            // gridDatos
            // 
            gridDatos.Anchor = AnchorStyles.None;
            gridDatos.BackgroundColor = SystemColors.ControlLight;
            gridDatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatos.Location = new Point(12, 161);
            gridDatos.Name = "gridDatos";
            gridDatos.RowTemplate.Height = 25;
            gridDatos.Size = new Size(772, 458);
            gridDatos.TabIndex = 10;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Dock = DockStyle.Top;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(796, 143);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLimpiar);
            tabPage1.Controls.Add(lblApellido);
            tabPage1.Controls.Add(lblNombre);
            tabPage1.Controls.Add(lblDNI);
            tabPage1.Controls.Add(tBoxApellido);
            tabPage1.Controls.Add(tBoxNombre);
            tabPage1.Controls.Add(tBoxDNI);
            tabPage1.Controls.Add(btnBuscarPasajero);
            tabPage1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(788, 115);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PASAJEROS";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(684, 62);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(78, 23);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Reiniciar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(451, 50);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(55, 15);
            lblApellido.TabIndex = 16;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(221, 50);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "Nombre:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(19, 50);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(32, 15);
            lblDNI.TabIndex = 14;
            lblDNI.Text = "DNI:";
            // 
            // tBoxApellido
            // 
            tBoxApellido.Location = new Point(512, 47);
            tBoxApellido.Name = "tBoxApellido";
            tBoxApellido.Size = new Size(128, 23);
            tBoxApellido.TabIndex = 13;
            // 
            // tBoxNombre
            // 
            tBoxNombre.Location = new Point(283, 47);
            tBoxNombre.Name = "tBoxNombre";
            tBoxNombre.Size = new Size(128, 23);
            tBoxNombre.TabIndex = 12;
            // 
            // tBoxDNI
            // 
            tBoxDNI.Location = new Point(57, 47);
            tBoxDNI.Name = "tBoxDNI";
            tBoxDNI.Size = new Size(128, 23);
            tBoxDNI.TabIndex = 11;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnViaje);
            tabPage2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(788, 115);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "VIAJE";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnAeronave);
            tabPage3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(788, 115);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "AERONAVE";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ConsultaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 631);
            Controls.Add(tabControl);
            Controls.Add(gridDatos);
            Name = "ConsultaFrm";
            Text = "CRUDform";
            Load += CRUDform_Load;
            ((System.ComponentModel.ISupportInitialize)gridDatos).EndInit();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnBuscarPasajero;
        private Button btnViaje;
        private Button btnAeronave;
        private DataGridView gridDatos;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnLimpiar;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblDNI;
        private TextBox tBoxApellido;
        private TextBox tBoxNombre;
        private TextBox tBoxDNI;
        private TabPage tabPage3;
    }
}