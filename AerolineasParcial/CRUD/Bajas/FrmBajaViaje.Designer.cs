namespace AerolineasParcial.CRUD.Bajas
{
    partial class FrmBajaViaje
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
            btnBuscarViaje = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Size = new Size(91, 20);
            lblTitulo.Text = "Nuevo viaje";
            // 
            // btnOK
            // 
            btnOK.Text = "Guardar";
            //
            // dateTimePicker
            // 
            dateTimePicker.MinDate = new DateTime(2023, 5, 16, 0, 0, 0, 0);
            // 
            // btnAsignarAeronave
            // 
            btnAsignarAeronave.Text = "Buscar";
            // 
            // chbxInternacional
            // 
            chbxInternacional.Size = new Size(95, 19);
            chbxInternacional.Text = "Internacional";
            // 
            // tBoxDuracion
            // 
            tBoxDuracion.Text = "4";
            // 
            // lblPrecioTurista
            // 
            lblPrecioTurista.Size = new Size(28, 15);
            lblPrecioTurista.Text = "200";
            // 
            // lblPrecioPremium
            // 
            lblPrecioPremium.Size = new Size(27, 15);
            lblPrecioPremium.Text = "270";
            // 
            // btnBuscarViaje
            // 
            btnBuscarViaje.Location = new Point(395, 12);
            btnBuscarViaje.Name = "btnBuscarViaje";
            btnBuscarViaje.Size = new Size(97, 23);
            btnBuscarViaje.TabIndex = 24;
            btnBuscarViaje.Text = "Seleccionar...";
            btnBuscarViaje.UseVisualStyleBackColor = true;
            btnBuscarViaje.Click += btnBuscarViaje_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(283, 16);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 25;
            label5.Text = "Seleccione un viaje";
            // 
            // FrmBajaViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 450);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(btnBuscarViaje);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmBajaViaje";
            Text = "FrmBajaViaje";
            Load += FrmBajaViaje_Load;
            Controls.SetChildIndex(chbxInternacional, 0);
            Controls.SetChildIndex(cBoxDestinos, 0);
            Controls.SetChildIndex(tBoxPartida, 0);
            Controls.SetChildIndex(dateTimePicker, 0);
            Controls.SetChildIndex(tBoxAeronave, 0);
            Controls.SetChildIndex(btnAsignarAeronave, 0);
            Controls.SetChildIndex(lblCantTurista, 0);
            Controls.SetChildIndex(lblCantPremium, 0);
            Controls.SetChildIndex(lblPrecioTurista, 0);
            Controls.SetChildIndex(lblPrecioPremium, 0);
            Controls.SetChildIndex(tBoxDuracion, 0);
            Controls.SetChildIndex(btnBuscarViaje, 0);
            Controls.SetChildIndex(label5, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarViaje;
        private Label label5;
    }
}