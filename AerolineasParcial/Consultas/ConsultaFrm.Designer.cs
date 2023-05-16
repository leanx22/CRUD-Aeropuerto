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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnBuscarPasajero = new Button();
            btnViaje = new Button();
            btnAeronave = new Button();
            gridDatos = new DataGridView();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            lblApellido = new Label();
            lblNombre = new Label();
            lblDNI = new Label();
            tBoxApellido = new TextBox();
            tBoxNombre = new TextBox();
            tBoxDNI = new TextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            btnBuscarAeronave = new Button();
            label1 = new Label();
            tBoxMatricula = new TextBox();
            btnLimpiar = new Button();
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
            btnBuscarPasajero.Location = new Point(673, 38);
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
            // 
            // gridDatos
            // 
            gridDatos.AllowUserToResizeColumns = false;
            gridDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.CadetBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            gridDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            gridDatos.Anchor = AnchorStyles.None;
            gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridDatos.BackgroundColor = SystemColors.Control;
            gridDatos.BorderStyle = BorderStyle.Fixed3D;
            gridDatos.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            gridDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gridDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gridDatos.DefaultCellStyle = dataGridViewCellStyle3;
            gridDatos.EnableHeadersVisualStyles = false;
            gridDatos.Location = new Point(12, 161);
            gridDatos.Name = "gridDatos";
            gridDatos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            gridDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            gridDatos.RowHeadersVisible = false;
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
            tabControl.Size = new Size(796, 126);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Transparent;
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
            tabPage1.Size = new Size(788, 98);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "PASAJEROS";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(440, 41);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(55, 15);
            lblApellido.TabIndex = 16;
            lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(209, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 15;
            lblNombre.Text = "Nombre:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(8, 41);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(32, 15);
            lblDNI.TabIndex = 14;
            lblDNI.Text = "DNI:";
            // 
            // tBoxApellido
            // 
            tBoxApellido.Location = new Point(501, 38);
            tBoxApellido.Name = "tBoxApellido";
            tBoxApellido.Size = new Size(128, 23);
            tBoxApellido.TabIndex = 13;
            // 
            // tBoxNombre
            // 
            tBoxNombre.Location = new Point(271, 38);
            tBoxNombre.Name = "tBoxNombre";
            tBoxNombre.Size = new Size(128, 23);
            tBoxNombre.TabIndex = 12;
            // 
            // tBoxDNI
            // 
            tBoxDNI.Location = new Point(46, 38);
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
            tabPage2.Size = new Size(788, 98);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "VIAJE";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnBuscarAeronave);
            tabPage3.Controls.Add(btnAeronave);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(tBoxMatricula);
            tabPage3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(788, 98);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "AERONAVE";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAeronave
            // 
            btnBuscarAeronave.Location = new Point(215, 38);
            btnBuscarAeronave.Name = "btnBuscarAeronave";
            btnBuscarAeronave.Size = new Size(75, 23);
            btnBuscarAeronave.TabIndex = 5;
            btnBuscarAeronave.Text = "Buscar";
            btnBuscarAeronave.UseVisualStyleBackColor = true;
            btnBuscarAeronave.Click += btnBuscarAeronave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 41);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Matricula:";
            // 
            // tBoxMatricula
            // 
            tBoxMatricula.Location = new Point(76, 38);
            tBoxMatricula.Name = "tBoxMatricula";
            tBoxMatricula.Size = new Size(122, 23);
            tBoxMatricula.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(706, 132);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(78, 23);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // ConsultaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 631);
            Controls.Add(btnLimpiar);
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
            tabPage3.PerformLayout();
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
        private Button btnBuscarAeronave;
        private TextBox tBoxMatricula;
        private Label label1;
    }
}