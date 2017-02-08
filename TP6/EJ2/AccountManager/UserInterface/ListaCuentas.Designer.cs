namespace AccountManager.UserInterface
{
    partial class ListaCuentas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem_Crear = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.todasLasCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasEnDescubiertoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.actualizarTablaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem_Crear,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.dataToolStripMenuItem.Text = "Gestion";
            // 
            // crearToolStripMenuItem_Crear
            // 
            this.crearToolStripMenuItem_Crear.Name = "crearToolStripMenuItem_Crear";
            this.crearToolStripMenuItem_Crear.Size = new System.Drawing.Size(125, 22);
            this.crearToolStripMenuItem_Crear.Text = "Crear";
            this.crearToolStripMenuItem_Crear.Click += new System.EventHandler(this.crearToolStripMenuItem_Crear_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // actualizarTablaToolStripMenuItem
            // 
            this.actualizarTablaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasLasCuentasToolStripMenuItem,
            this.cuentasEnDescubiertoToolStripMenuItem});
            this.actualizarTablaToolStripMenuItem.Name = "actualizarTablaToolStripMenuItem";
            this.actualizarTablaToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.actualizarTablaToolStripMenuItem.Text = "Actualizar Tabla";
            this.actualizarTablaToolStripMenuItem.Click += new System.EventHandler(this.actualizarTablaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 331);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // todasLasCuentasToolStripMenuItem
            // 
            this.todasLasCuentasToolStripMenuItem.Name = "todasLasCuentasToolStripMenuItem";
            this.todasLasCuentasToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.todasLasCuentasToolStripMenuItem.Text = "Todas las Cuentas";
            this.todasLasCuentasToolStripMenuItem.Click += new System.EventHandler(this.todasLasCuentasToolStripMenuItem_Click);
            // 
            // cuentasEnDescubiertoToolStripMenuItem
            // 
            this.cuentasEnDescubiertoToolStripMenuItem.Name = "cuentasEnDescubiertoToolStripMenuItem";
            this.cuentasEnDescubiertoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.cuentasEnDescubiertoToolStripMenuItem.Text = "Cuentas en Descubierto";
            this.cuentasEnDescubiertoToolStripMenuItem.Click += new System.EventHandler(this.cuentasEnDescubiertoToolStripMenuItem_Click);
            // 
            // ListaCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListaCuentas";
            this.Text = "ListaCuentas";
            this.Load += new System.EventHandler(this.ListaCuentas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem_Crear;
        private System.Windows.Forms.ToolStripMenuItem actualizarTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasLasCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasEnDescubiertoToolStripMenuItem;
    }
}