﻿namespace AccountManager.UserInterface
{
    partial class SeleccionarCliente
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1_Seleccionar = new System.Windows.Forms.Button();
            this.button2_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 312);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1_Seleccionar
            // 
            this.button1_Seleccionar.AccessibleName = "Seleccionar";
            this.button1_Seleccionar.Location = new System.Drawing.Point(457, 321);
            this.button1_Seleccionar.Name = "button1_Seleccionar";
            this.button1_Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.button1_Seleccionar.TabIndex = 1;
            this.button1_Seleccionar.Text = "Seleccionar";
            this.button1_Seleccionar.UseVisualStyleBackColor = true;
            this.button1_Seleccionar.Click += new System.EventHandler(this.button1_Seleccionar_Click);
            // 
            // button2_Cancelar
            // 
            this.button2_Cancelar.AccessibleName = "Cancelar";
            this.button2_Cancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button2_Cancelar.Location = new System.Drawing.Point(12, 321);
            this.button2_Cancelar.Name = "button2_Cancelar";
            this.button2_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button2_Cancelar.TabIndex = 2;
            this.button2_Cancelar.Text = "Cancelar";
            this.button2_Cancelar.UseVisualStyleBackColor = true;
            this.button2_Cancelar.Click += new System.EventHandler(this.button2_Cancelar_Click);
            // 
            // SeleccionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 356);
            this.Controls.Add(this.button2_Cancelar);
            this.Controls.Add(this.button1_Seleccionar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SeleccionarCliente";
            this.Text = "SeleccionarCliente";
            this.Load += new System.EventHandler(this.SeleccionarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_Seleccionar;
        private System.Windows.Forms.Button button2_Cancelar;
    }
}