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
            btnPasajero = new Button();
            btnViaje = new Button();
            btnAeronave = new Button();
            btnAceptar = new Button();
            txtTitulo = new Label();
            gridPasajeros = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridPasajeros).BeginInit();
            SuspendLayout();
            // 
            // btnPasajero
            // 
            btnPasajero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPasajero.Location = new Point(12, 61);
            btnPasajero.Name = "btnPasajero";
            btnPasajero.Size = new Size(88, 36);
            btnPasajero.TabIndex = 1;
            btnPasajero.Text = "PASAJERO";
            btnPasajero.UseVisualStyleBackColor = true;
            btnPasajero.Click += btnPasajero_Click;
            // 
            // btnViaje
            // 
            btnViaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnViaje.Location = new Point(12, 103);
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
            btnAeronave.Location = new Point(12, 145);
            btnAeronave.Name = "btnAeronave";
            btnAeronave.Size = new Size(88, 36);
            btnAeronave.TabIndex = 3;
            btnAeronave.Text = "AERONAVE";
            btnAeronave.UseVisualStyleBackColor = true;
            btnAeronave.Click += btnAeronave_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 462);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(88, 28);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "button5";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.AutoSize = true;
            txtTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTitulo.Location = new Point(12, 20);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(88, 21);
            txtTitulo.TabIndex = 6;
            txtTitulo.Text = "Consultar:";
            txtTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // gridPasajeros
            // 
            gridPasajeros.BackgroundColor = SystemColors.ControlLight;
            gridPasajeros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridPasajeros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridPasajeros.Location = new Point(106, 61);
            gridPasajeros.Name = "gridPasajeros";
            gridPasajeros.RowTemplate.Height = 25;
            gridPasajeros.Size = new Size(573, 429);
            gridPasajeros.TabIndex = 10;
            // 
            // ConsultaFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 509);
            Controls.Add(gridPasajeros);
            Controls.Add(txtTitulo);
            Controls.Add(btnAceptar);
            Controls.Add(btnAeronave);
            Controls.Add(btnViaje);
            Controls.Add(btnPasajero);
            Name = "ConsultaFrm";
            Text = "CRUDform";
            Load += CRUDform_Load;
            ((System.ComponentModel.ISupportInitialize)gridPasajeros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPasajero;
        private Button btnViaje;
        private Button btnAeronave;
        private Button btnAceptar;
        private Label txtTitulo;
        private DataGridView gridPasajeros;
    }
}