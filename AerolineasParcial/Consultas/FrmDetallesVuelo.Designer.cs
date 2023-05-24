namespace AerolineasParcial.Consultas
{
    partial class FrmDetallesVuelo
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
            propGridVuelo = new PropertyGrid();
            btnInfoPasajeros = new Button();
            SuspendLayout();
            // 
            // propGridVuelo
            // 
            propGridVuelo.BackColor = Color.FromArgb(60, 72, 107);
            propGridVuelo.CategorySplitterColor = Color.Lime;
            propGridVuelo.CommandsLinkColor = Color.FromArgb(60, 72, 107);
            propGridVuelo.DisabledItemForeColor = Color.White;
            propGridVuelo.Dock = DockStyle.Top;
            propGridVuelo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            propGridVuelo.HelpVisible = false;
            propGridVuelo.LineColor = Color.FromArgb(14, 110, 140);
            propGridVuelo.Location = new Point(0, 0);
            propGridVuelo.Name = "propGridVuelo";
            propGridVuelo.SelectedItemWithFocusBackColor = Color.Transparent;
            propGridVuelo.SelectedItemWithFocusForeColor = Color.Transparent;
            propGridVuelo.Size = new Size(452, 409);
            propGridVuelo.TabIndex = 0;
            propGridVuelo.ToolbarVisible = false;
            propGridVuelo.ViewBackColor = Color.FromArgb(4, 30, 38);
            propGridVuelo.ViewBorderColor = Color.Transparent;
            // 
            // btnInfoPasajeros
            // 
            btnInfoPasajeros.FlatAppearance.BorderSize = 2;
            btnInfoPasajeros.FlatAppearance.MouseDownBackColor = Color.FromArgb(19, 150, 191);
            btnInfoPasajeros.FlatStyle = FlatStyle.Flat;
            btnInfoPasajeros.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInfoPasajeros.ForeColor = Color.White;
            btnInfoPasajeros.Location = new Point(12, 415);
            btnInfoPasajeros.Name = "btnInfoPasajeros";
            btnInfoPasajeros.Size = new Size(428, 33);
            btnInfoPasajeros.TabIndex = 2;
            btnInfoPasajeros.Text = "PASAJEROS";
            btnInfoPasajeros.UseVisualStyleBackColor = true;
            // 
            // FrmDetallesVuelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 70, 89);
            ClientSize = new Size(452, 456);
            Controls.Add(btnInfoPasajeros);
            Controls.Add(propGridVuelo);
            Name = "FrmDetallesVuelo";
            Text = "FrmDetallesVuelo";
            Load += FrmDetallesVuelo_Load;
            ResumeLayout(false);
        }

        #endregion

        private PropertyGrid propGridVuelo;
        private Button btnInfoPasajeros;
    }
}