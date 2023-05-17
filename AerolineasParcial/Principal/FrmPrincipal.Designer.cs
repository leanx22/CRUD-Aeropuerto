namespace AerolineasParcial
{
    partial class FrmPrincipal
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
            lblUsuario = new Label();
            btnEstadisticas = new Button();
            btnVenta = new Button();
            btnListado = new Button();
            btnBajas = new Button();
            btnModificar = new Button();
            btnAltas = new Button();
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            btnAltaAeronave = new Button();
            btnAltaViaje = new Button();
            btnAltaPasajero = new Button();
            tabPage2 = new TabPage();
            btnModificarViaje = new Button();
            btnModificarAeronave = new Button();
            btnModificarPasajero = new Button();
            tabPage3 = new TabPage();
            btnBajaViaje = new Button();
            btnBajaAeronave = new Button();
            btnBajaPasajero = new Button();
            pnlMenu.SuspendLayout();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(24, 30, 54);
            pnlMenu.Controls.Add(lblUsuario);
            pnlMenu.Controls.Add(btnEstadisticas);
            pnlMenu.Controls.Add(btnVenta);
            pnlMenu.Controls.Add(btnListado);
            pnlMenu.Controls.Add(btnBajas);
            pnlMenu.Controls.Add(btnModificar);
            pnlMenu.Controls.Add(btnAltas);
            pnlMenu.Dock = DockStyle.Bottom;
            pnlMenu.Location = new Point(0, 483);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1028, 140);
            pnlMenu.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Enabled = false;
            lblUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.FromArgb(12, 135, 255);
            lblUsuario.Location = new Point(4, 111);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(51, 20);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "label1";
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.FlatAppearance.BorderSize = 2;
            btnEstadisticas.FlatStyle = FlatStyle.Flat;
            btnEstadisticas.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEstadisticas.ForeColor = Color.FromArgb(12, 135, 255);
            btnEstadisticas.Location = new Point(940, 63);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(85, 41);
            btnEstadisticas.TabIndex = 5;
            btnEstadisticas.Text = "ESTADISTICA";
            btnEstadisticas.UseVisualStyleBackColor = true;
            // 
            // btnVenta
            // 
            btnVenta.FlatAppearance.BorderSize = 2;
            btnVenta.FlatStyle = FlatStyle.Flat;
            btnVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVenta.ForeColor = Color.FromArgb(12, 135, 255);
            btnVenta.Location = new Point(4, 16);
            btnVenta.Name = "btnVenta";
            btnVenta.Size = new Size(1021, 41);
            btnVenta.TabIndex = 4;
            btnVenta.Text = "NUEVA VENTA";
            btnVenta.UseVisualStyleBackColor = true;
            btnVenta.Click += btnVenta_Click;
            // 
            // btnListado
            // 
            btnListado.FlatAppearance.BorderSize = 2;
            btnListado.FlatStyle = FlatStyle.Flat;
            btnListado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnListado.ForeColor = Color.FromArgb(12, 135, 255);
            btnListado.Location = new Point(706, 63);
            btnListado.Name = "btnListado";
            btnListado.Size = new Size(228, 41);
            btnListado.TabIndex = 3;
            btnListado.Text = "LISTADOS";
            btnListado.UseVisualStyleBackColor = true;
            btnListado.Click += btnListado_Click;
            // 
            // btnBajas
            // 
            btnBajas.FlatAppearance.BorderSize = 2;
            btnBajas.FlatStyle = FlatStyle.Flat;
            btnBajas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBajas.ForeColor = Color.FromArgb(12, 135, 255);
            btnBajas.Location = new Point(472, 63);
            btnBajas.Name = "btnBajas";
            btnBajas.Size = new Size(228, 41);
            btnBajas.TabIndex = 2;
            btnBajas.Text = "BAJA";
            btnBajas.UseVisualStyleBackColor = true;
            btnBajas.Click += btnBajas_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderSize = 2;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.FromArgb(12, 135, 255);
            btnModificar.Location = new Point(238, 63);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(228, 41);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "MODIFICACION";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAltas
            // 
            btnAltas.FlatAppearance.BorderSize = 2;
            btnAltas.FlatStyle = FlatStyle.Flat;
            btnAltas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltas.ForeColor = Color.FromArgb(12, 135, 255);
            btnAltas.Location = new Point(4, 63);
            btnAltas.Name = "btnAltas";
            btnAltas.Size = new Size(228, 41);
            btnAltas.TabIndex = 0;
            btnAltas.Text = "ALTAS";
            btnAltas.UseVisualStyleBackColor = true;
            btnAltas.Click += btnAltas_Click;
            // 
            // tabControl
            // 
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.ImeMode = ImeMode.NoControl;
            tabControl.Location = new Point(-4, -1);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1037, 486);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(46, 51, 73);
            tabPage1.Controls.Add(btnAltaAeronave);
            tabPage1.Controls.Add(btnAltaViaje);
            tabPage1.Controls.Add(btnAltaPasajero);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1029, 455);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ALTAS";
            // 
            // btnAltaAeronave
            // 
            btnAltaAeronave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAltaAeronave.BackColor = Color.FromArgb(37, 42, 64);
            btnAltaAeronave.FlatAppearance.BorderColor = Color.FromArgb(69, 213, 172);
            btnAltaAeronave.FlatAppearance.BorderSize = 2;
            btnAltaAeronave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAltaAeronave.FlatStyle = FlatStyle.Flat;
            btnAltaAeronave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaAeronave.ForeColor = Color.FromArgb(145, 155, 176);
            btnAltaAeronave.Location = new Point(366, 66);
            btnAltaAeronave.Name = "btnAltaAeronave";
            btnAltaAeronave.Size = new Size(300, 300);
            btnAltaAeronave.TabIndex = 9;
            btnAltaAeronave.Text = "AERONAVE";
            btnAltaAeronave.UseVisualStyleBackColor = false;
            btnAltaAeronave.Click += btnAltaAeronave_Click;
            // 
            // btnAltaViaje
            // 
            btnAltaViaje.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAltaViaje.BackColor = Color.FromArgb(37, 42, 64);
            btnAltaViaje.FlatAppearance.BorderColor = Color.FromArgb(69, 213, 172);
            btnAltaViaje.FlatAppearance.BorderSize = 2;
            btnAltaViaje.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAltaViaje.FlatStyle = FlatStyle.Flat;
            btnAltaViaje.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaViaje.ForeColor = Color.FromArgb(145, 155, 176);
            btnAltaViaje.Location = new Point(716, 66);
            btnAltaViaje.Name = "btnAltaViaje";
            btnAltaViaje.Size = new Size(300, 300);
            btnAltaViaje.TabIndex = 8;
            btnAltaViaje.Text = "VIAJE";
            btnAltaViaje.UseVisualStyleBackColor = false;
            btnAltaViaje.Click += btnAltaViaje_Click;
            // 
            // btnAltaPasajero
            // 
            btnAltaPasajero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnAltaPasajero.BackColor = Color.FromArgb(37, 42, 64);
            btnAltaPasajero.FlatAppearance.BorderColor = Color.FromArgb(69, 213, 172);
            btnAltaPasajero.FlatAppearance.BorderSize = 2;
            btnAltaPasajero.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAltaPasajero.FlatStyle = FlatStyle.Flat;
            btnAltaPasajero.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAltaPasajero.ForeColor = Color.FromArgb(145, 155, 176);
            btnAltaPasajero.Location = new Point(12, 66);
            btnAltaPasajero.Name = "btnAltaPasajero";
            btnAltaPasajero.Size = new Size(300, 300);
            btnAltaPasajero.TabIndex = 7;
            btnAltaPasajero.Text = "PASAJERO";
            btnAltaPasajero.UseVisualStyleBackColor = false;
            btnAltaPasajero.Click += btnAltaPasajero_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(46, 51, 73);
            tabPage2.Controls.Add(btnModificarViaje);
            tabPage2.Controls.Add(btnModificarAeronave);
            tabPage2.Controls.Add(btnModificarPasajero);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1029, 455);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "MODIFICAR";
            // 
            // btnModificarViaje
            // 
            btnModificarViaje.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnModificarViaje.BackColor = Color.FromArgb(37, 42, 64);
            btnModificarViaje.FlatAppearance.BorderColor = Color.FromArgb(69, 213, 172);
            btnModificarViaje.FlatAppearance.BorderSize = 2;
            btnModificarViaje.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnModificarViaje.FlatStyle = FlatStyle.Flat;
            btnModificarViaje.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarViaje.ForeColor = Color.FromArgb(145, 155, 176);
            btnModificarViaje.Location = new Point(716, 66);
            btnModificarViaje.Name = "btnModificarViaje";
            btnModificarViaje.Size = new Size(300, 277);
            btnModificarViaje.TabIndex = 10;
            btnModificarViaje.Text = "VIAJE";
            btnModificarViaje.UseVisualStyleBackColor = false;
            btnModificarViaje.Click += btnModificarViaje_Click;
            // 
            // btnModificarAeronave
            // 
            btnModificarAeronave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnModificarAeronave.BackColor = Color.FromArgb(37, 42, 64);
            btnModificarAeronave.FlatAppearance.BorderColor = Color.FromArgb(69, 213, 172);
            btnModificarAeronave.FlatAppearance.BorderSize = 2;
            btnModificarAeronave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnModificarAeronave.FlatStyle = FlatStyle.Flat;
            btnModificarAeronave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarAeronave.ForeColor = Color.FromArgb(145, 155, 176);
            btnModificarAeronave.Location = new Point(366, 66);
            btnModificarAeronave.Name = "btnModificarAeronave";
            btnModificarAeronave.Size = new Size(300, 277);
            btnModificarAeronave.TabIndex = 9;
            btnModificarAeronave.Text = "AERONAVE";
            btnModificarAeronave.UseVisualStyleBackColor = false;
            btnModificarAeronave.Click += btnModificarAeronave_Click;
            // 
            // btnModificarPasajero
            // 
            btnModificarPasajero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnModificarPasajero.BackColor = Color.FromArgb(37, 42, 64);
            btnModificarPasajero.FlatAppearance.BorderColor = Color.FromArgb(69, 213, 172);
            btnModificarPasajero.FlatAppearance.BorderSize = 2;
            btnModificarPasajero.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnModificarPasajero.FlatStyle = FlatStyle.Flat;
            btnModificarPasajero.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificarPasajero.ForeColor = Color.FromArgb(145, 155, 176);
            btnModificarPasajero.Location = new Point(12, 66);
            btnModificarPasajero.Name = "btnModificarPasajero";
            btnModificarPasajero.Size = new Size(300, 277);
            btnModificarPasajero.TabIndex = 8;
            btnModificarPasajero.Text = "PASAJERO";
            btnModificarPasajero.UseVisualStyleBackColor = false;
            btnModificarPasajero.Click += btnModificarPasajero_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(46, 51, 73);
            tabPage3.Controls.Add(btnBajaViaje);
            tabPage3.Controls.Add(btnBajaAeronave);
            tabPage3.Controls.Add(btnBajaPasajero);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1029, 455);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "BAJAS";
            // 
            // btnBajaViaje
            // 
            btnBajaViaje.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnBajaViaje.BackColor = Color.FromArgb(37, 42, 64);
            btnBajaViaje.FlatAppearance.BorderColor = Color.FromArgb(69, 213, 172);
            btnBajaViaje.FlatAppearance.BorderSize = 2;
            btnBajaViaje.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBajaViaje.FlatStyle = FlatStyle.Flat;
            btnBajaViaje.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBajaViaje.ForeColor = Color.FromArgb(145, 155, 176);
            btnBajaViaje.Location = new Point(716, 66);
            btnBajaViaje.Name = "btnBajaViaje";
            btnBajaViaje.Size = new Size(300, 277);
            btnBajaViaje.TabIndex = 11;
            btnBajaViaje.Text = "VIAJE";
            btnBajaViaje.UseVisualStyleBackColor = false;
            btnBajaViaje.Click += btnBajaViaje_Click;
            // 
            // btnBajaAeronave
            // 
            btnBajaAeronave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBajaAeronave.BackColor = Color.FromArgb(37, 42, 64);
            btnBajaAeronave.FlatAppearance.BorderColor = Color.FromArgb(69, 213, 172);
            btnBajaAeronave.FlatAppearance.BorderSize = 2;
            btnBajaAeronave.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBajaAeronave.FlatStyle = FlatStyle.Flat;
            btnBajaAeronave.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBajaAeronave.ForeColor = Color.FromArgb(145, 155, 176);
            btnBajaAeronave.Location = new Point(366, 66);
            btnBajaAeronave.Name = "btnBajaAeronave";
            btnBajaAeronave.Size = new Size(300, 277);
            btnBajaAeronave.TabIndex = 10;
            btnBajaAeronave.Text = "AERONAVE";
            btnBajaAeronave.UseVisualStyleBackColor = false;
            btnBajaAeronave.Click += btnBajaAeronave_Click;
            // 
            // btnBajaPasajero
            // 
            btnBajaPasajero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnBajaPasajero.BackColor = Color.FromArgb(37, 42, 64);
            btnBajaPasajero.FlatAppearance.BorderColor = Color.FromArgb(69, 213, 172);
            btnBajaPasajero.FlatAppearance.BorderSize = 2;
            btnBajaPasajero.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBajaPasajero.FlatStyle = FlatStyle.Flat;
            btnBajaPasajero.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBajaPasajero.ForeColor = Color.FromArgb(145, 155, 176);
            btnBajaPasajero.Location = new Point(12, 66);
            btnBajaPasajero.Name = "btnBajaPasajero";
            btnBajaPasajero.Size = new Size(300, 277);
            btnBajaPasajero.TabIndex = 9;
            btnBajaPasajero.Text = "PASAJERO";
            btnBajaPasajero.UseVisualStyleBackColor = false;
            btnBajaPasajero.Click += btnBajaPasajero_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(1028, 623);
            Controls.Add(tabControl);
            Controls.Add(pnlMenu);
            MinimumSize = new Size(1044, 662);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlMenu;
        private Button btnAltas;
        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnListado;
        private Button btnBajas;
        private Button btnModificar;
        private Label lblUsuario;
        private Button btnVenta;
        private Button btnEstadisticas;
        private Button btnAltaPasajero;
        private Button btnAltaAeronave;
        private Button btnAltaViaje;
        private Button btnModificarViaje;
        private Button btnModificarAeronave;
        private Button btnModificarPasajero;
        private TabPage tabPage3;
        private Button btnBajaViaje;
        private Button btnBajaAeronave;
        private Button btnBajaPasajero;
    }
}