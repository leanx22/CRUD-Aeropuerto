namespace AerolineasParcial.CRUD.Modificacion
{
    partial class FrmEditarAeronave
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
            ((System.ComponentModel.ISupportInitialize)numBodega).BeginInit();
            SuspendLayout();
            // 
            // numBodega
            // 
            numBodega.Maximum = new decimal(new int[] { 15000, 0, 0, 0 });
            // 
            // chbxComida
            // 
            chbxComida.Size = new Size(70, 19);
            chbxComida.Text = "Comida.";
            // 
            // chbxInternet
            // 
            chbxInternet.Size = new Size(76, 19);
            chbxInternet.Text = "Internet.";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(545, 77);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // FrmEditarAeronave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnBuscar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmEditarAeronave";
            Text = "FrmEditarAeronave";
            Controls.SetChildIndex(tBoxMatricula, 0);
            Controls.SetChildIndex(numBodega, 0);
            Controls.SetChildIndex(chbxComida, 0);
            Controls.SetChildIndex(chbxInternet, 0);
            Controls.SetChildIndex(lblMaxBodega, 0);
            Controls.SetChildIndex(lblMaxBanios, 0);
            Controls.SetChildIndex(lblMaxAsientos, 0);
            Controls.SetChildIndex(btnBuscar, 0);
            ((System.ComponentModel.ISupportInitialize)numBodega).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
    }
}