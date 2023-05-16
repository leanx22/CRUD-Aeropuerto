namespace AerolineasParcial.CRUD.Modificacion
{
    partial class FrmEditarViaje
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
            label5 = new Label();
            btnBuscarViaje = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Size = new Size(63, 20);
            lblTitulo.Text = "Destino";
            // 
            // btnOK
            // 
            btnOK.Text = "Guardar";
            // 
            //
            // dateTimePicker
            // 
            dateTimePicker.MinDate = new DateTime(2023, 5, 16, 5, 55, 42, 386);
            dateTimePicker.Value = new DateTime(2023, 5, 16, 5, 55, 42, 386);
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
            tBoxDuracion.Text = "3";
            // 
            // lblPrecioTurista
            // 
            lblPrecioTurista.Size = new Size(26, 15);
            lblPrecioTurista.Text = "100";
            // 
            // lblPrecioPremium
            // 
            lblPrecioPremium.Size = new Size(26, 15);
            lblPrecioPremium.Text = "135";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(236, 9);
            label5.Name = "label5";
            label5.Size = new Size(109, 15);
            label5.TabIndex = 24;
            label5.Text = "Seleccione un viaje:";
            // 
            // btnBuscarViaje
            // 
            btnBuscarViaje.Location = new Point(371, 5);
            btnBuscarViaje.Name = "btnBuscarViaje";
            btnBuscarViaje.Size = new Size(125, 23);
            btnBuscarViaje.TabIndex = 25;
            btnBuscarViaje.Text = "Seleccionar...";
            btnBuscarViaje.UseVisualStyleBackColor = true;
            btnBuscarViaje.Click += btnBuscarViaje_Click;
            // 
            // FrmEditarViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 450);
            ControlBox = false;
            Controls.Add(btnBuscarViaje);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmEditarViaje";
            Text = "FrmEditarViaje";
            Controls.SetChildIndex(lblPrecioTurista, 0);
            Controls.SetChildIndex(lblPrecioPremium, 0);
            Controls.SetChildIndex(chbxInternacional, 0);
            Controls.SetChildIndex(cBoxDestinos, 0);
            Controls.SetChildIndex(tBoxPartida, 0);
            Controls.SetChildIndex(dateTimePicker, 0);
            Controls.SetChildIndex(tBoxAeronave, 0);
            Controls.SetChildIndex(btnAsignarAeronave, 0);
            Controls.SetChildIndex(lblCantTurista, 0);
            Controls.SetChildIndex(lblCantPremium, 0);
            Controls.SetChildIndex(tBoxDuracion, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(btnBuscarViaje, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnBuscarViaje;
    }
}