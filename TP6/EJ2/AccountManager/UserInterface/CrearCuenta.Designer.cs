namespace AccountManager.UserInterface
{
    partial class CrearCuenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_Nombre = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1_Seleccionar = new System.Windows.Forms.Button();
            this.Crear = new System.Windows.Forms.Button();
            this.button3_Cancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Límite descubierto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datos de la cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1_Nombre
            // 
            this.textBox1_Nombre.Location = new System.Drawing.Point(259, 122);
            this.textBox1_Nombre.Name = "textBox1_Nombre";
            this.textBox1_Nombre.Size = new System.Drawing.Size(148, 20);
            this.textBox1_Nombre.TabIndex = 4;
            this.textBox1_Nombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(259, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(259, 234);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1_Seleccionar
            // 
            this.button1_Seleccionar.AccessibleName = "SeleccionarCliente";
            this.button1_Seleccionar.Location = new System.Drawing.Point(431, 231);
            this.button1_Seleccionar.Name = "button1_Seleccionar";
            this.button1_Seleccionar.Size = new System.Drawing.Size(89, 23);
            this.button1_Seleccionar.TabIndex = 7;
            this.button1_Seleccionar.Text = "Seleccionar...";
            this.button1_Seleccionar.UseVisualStyleBackColor = true;
            this.button1_Seleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Crear
            // 
            this.Crear.AccessibleName = "Guardar";
            this.Crear.Location = new System.Drawing.Point(445, 296);
            this.Crear.Name = "Crear";
            this.Crear.Size = new System.Drawing.Size(75, 23);
            this.Crear.TabIndex = 8;
            this.Crear.Text = "Crear";
            this.Crear.UseVisualStyleBackColor = true;
            this.Crear.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3_Cancelar
            // 
            this.button3_Cancelar.Location = new System.Drawing.Point(32, 296);
            this.button3_Cancelar.Name = "button3_Cancelar";
            this.button3_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button3_Cancelar.TabIndex = 9;
            this.button3_Cancelar.Text = "Cancelar";
            this.button3_Cancelar.UseVisualStyleBackColor = true;
            this.button3_Cancelar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox4_id
            // 
            this.textBox4_id.AccessibleName = "Id";
            this.textBox4_id.Enabled = false;
            this.textBox4_id.Location = new System.Drawing.Point(259, 76);
            this.textBox4_id.Name = "textBox4_id";
            this.textBox4_id.ReadOnly = true;
            this.textBox4_id.Size = new System.Drawing.Size(100, 20);
            this.textBox4_id.TabIndex = 11;
            this.textBox4_id.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // CrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 356);
            this.Controls.Add(this.textBox4_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3_Cancelar);
            this.Controls.Add(this.Crear);
            this.Controls.Add(this.button1_Seleccionar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1_Nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearCuenta";
            this.Text = "CrearCuenta";
            this.Load += new System.EventHandler(this.CrearCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_Nombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1_Seleccionar;
        private System.Windows.Forms.Button Crear;
        private System.Windows.Forms.Button button3_Cancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4_id;
    }
}