namespace AerolineasParcial.CRUD.Bajas
{
    partial class FormBajaPasajero
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
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Size = new Size(133, 21);
            lblTitle.Text = "Alta de pasajero";
            // 
            // btnGuardar
            // 
            btnGuardar.Text = "Guardar";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(496, 83);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 21;
            btnBuscar.Text = "button1";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FormBajaPasajero
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 441);
            ControlBox = false;
            Controls.Add(btnBuscar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormBajaPasajero";
            Text = "FormBajaPasajero";
            Controls.SetChildIndex(tBoxDni, 0);
            Controls.SetChildIndex(tBoxNombre, 0);
            Controls.SetChildIndex(tBoxApellido, 0);
            Controls.SetChildIndex(tBoxEdad, 0);
            Controls.SetChildIndex(btnBuscar, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
    }
}