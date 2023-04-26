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
            menuStrip1 = new MenuStrip();
            crearToolStripMenuItem = new ToolStripMenuItem();
            nuevaVentaToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem = new ToolStripMenuItem();
            modificarPasajeroToolStripMenuItem = new ToolStripMenuItem();
            modificarViajeToolStripMenuItem = new ToolStripMenuItem();
            modificarAeronaveToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            aeronavesToolStripMenuItem = new ToolStripMenuItem();
            informaciónToolStripMenuItem = new ToolStripMenuItem();
            viajesToolStripMenuItem = new ToolStripMenuItem();
            estadísticasToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            modificarToolStripMenuItem1 = new ToolStripMenuItem();
            eliminarToolStripMenuItem1 = new ToolStripMenuItem();
            agregarToolStripMenuItem1 = new ToolStripMenuItem();
            modificarToolStripMenuItem2 = new ToolStripMenuItem();
            eliminarToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { crearToolStripMenuItem, modificarToolStripMenuItem, eliminarToolStripMenuItem, aeronavesToolStripMenuItem, informaciónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1028, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "stripMenu";
            // 
            // crearToolStripMenuItem
            // 
            crearToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaVentaToolStripMenuItem });
            crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            crearToolStripMenuItem.Size = new Size(53, 20);
            crearToolStripMenuItem.Text = "Ventas";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            nuevaVentaToolStripMenuItem.Size = new Size(140, 22);
            nuevaVentaToolStripMenuItem.Text = "Nueva venta";
            // 
            // modificarToolStripMenuItem
            // 
            modificarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modificarPasajeroToolStripMenuItem, modificarViajeToolStripMenuItem, modificarAeronaveToolStripMenuItem });
            modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            modificarToolStripMenuItem.Size = new Size(68, 20);
            modificarToolStripMenuItem.Text = "Pasajeros";
            // 
            // modificarPasajeroToolStripMenuItem
            // 
            modificarPasajeroToolStripMenuItem.Name = "modificarPasajeroToolStripMenuItem";
            modificarPasajeroToolStripMenuItem.Size = new Size(125, 22);
            modificarPasajeroToolStripMenuItem.Text = "Agregar";
            // 
            // modificarViajeToolStripMenuItem
            // 
            modificarViajeToolStripMenuItem.Name = "modificarViajeToolStripMenuItem";
            modificarViajeToolStripMenuItem.Size = new Size(125, 22);
            modificarViajeToolStripMenuItem.Text = "Modificar";
            // 
            // modificarAeronaveToolStripMenuItem
            // 
            modificarAeronaveToolStripMenuItem.Name = "modificarAeronaveToolStripMenuItem";
            modificarAeronaveToolStripMenuItem.Size = new Size(125, 22);
            modificarAeronaveToolStripMenuItem.Text = "Eliminar";
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem, modificarToolStripMenuItem1, eliminarToolStripMenuItem1 });
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(54, 20);
            eliminarToolStripMenuItem.Text = "Vuelos";
            // 
            // aeronavesToolStripMenuItem
            // 
            aeronavesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem1, modificarToolStripMenuItem2, eliminarToolStripMenuItem2 });
            aeronavesToolStripMenuItem.Name = "aeronavesToolStripMenuItem";
            aeronavesToolStripMenuItem.Size = new Size(74, 20);
            aeronavesToolStripMenuItem.Text = "Aeronaves";
            // 
            // informaciónToolStripMenuItem
            // 
            informaciónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viajesToolStripMenuItem, estadísticasToolStripMenuItem });
            informaciónToolStripMenuItem.Name = "informaciónToolStripMenuItem";
            informaciónToolStripMenuItem.Size = new Size(84, 20);
            informaciónToolStripMenuItem.Text = "Información";
            // 
            // viajesToolStripMenuItem
            // 
            viajesToolStripMenuItem.Name = "viajesToolStripMenuItem";
            viajesToolStripMenuItem.Size = new Size(180, 22);
            viajesToolStripMenuItem.Text = "Viajes";
            // 
            // estadísticasToolStripMenuItem
            // 
            estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            estadísticasToolStripMenuItem.Size = new Size(180, 22);
            estadísticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(180, 22);
            agregarToolStripMenuItem.Text = "Agregar";
            // 
            // modificarToolStripMenuItem1
            // 
            modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            modificarToolStripMenuItem1.Size = new Size(180, 22);
            modificarToolStripMenuItem1.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem1
            // 
            eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            eliminarToolStripMenuItem1.Size = new Size(180, 22);
            eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // agregarToolStripMenuItem1
            // 
            agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            agregarToolStripMenuItem1.Size = new Size(180, 22);
            agregarToolStripMenuItem1.Text = "Agregar";
            // 
            // modificarToolStripMenuItem2
            // 
            modificarToolStripMenuItem2.Name = "modificarToolStripMenuItem2";
            modificarToolStripMenuItem2.Size = new Size(180, 22);
            modificarToolStripMenuItem2.Text = "Modificar";
            // 
            // eliminarToolStripMenuItem2
            // 
            eliminarToolStripMenuItem2.Name = "eliminarToolStripMenuItem2";
            eliminarToolStripMenuItem2.Size = new Size(180, 22);
            eliminarToolStripMenuItem2.Text = "Eliminar";
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 623);
            Controls.Add(menuStrip1);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem;
        private ToolStripMenuItem modificarPasajeroToolStripMenuItem;
        private ToolStripMenuItem modificarViajeToolStripMenuItem;
        private ToolStripMenuItem modificarAeronaveToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem aeronavesToolStripMenuItem;
        private ToolStripMenuItem informaciónToolStripMenuItem;
        private ToolStripMenuItem viajesToolStripMenuItem;
        private ToolStripMenuItem estadísticasToolStripMenuItem;
        private ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem modificarToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem1;
        private ToolStripMenuItem agregarToolStripMenuItem1;
        private ToolStripMenuItem modificarToolStripMenuItem2;
        private ToolStripMenuItem eliminarToolStripMenuItem2;
    }
}