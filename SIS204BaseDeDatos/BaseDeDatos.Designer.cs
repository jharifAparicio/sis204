namespace SIS204BaseDeDatos
{
    partial class BaseDeDatos
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
            this.TxtCi = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtRegistrar = new System.Windows.Forms.Button();
            this.BtMostrar = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.BtMayor = new System.Windows.Forms.Button();
            this.Menor = new System.Windows.Forms.Button();
            this.BtBuscar = new System.Windows.Forms.Button();
            this.BtVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de estudiante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "CI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE";
            // 
            // TxtCi
            // 
            this.TxtCi.Location = new System.Drawing.Point(107, 50);
            this.TxtCi.Name = "TxtCi";
            this.TxtCi.Size = new System.Drawing.Size(100, 23);
            this.TxtCi.TabIndex = 3;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(107, 79);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(100, 23);
            this.TxtNombre.TabIndex = 4;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(107, 108);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(100, 23);
            this.TxtApellido.TabIndex = 5;
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(107, 137);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(100, 23);
            this.TxtEdad.TabIndex = 6;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(107, 166);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(100, 23);
            this.TxtDireccion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "APELLIDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "EDAD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "DIRECCIÓN";
            // 
            // BtRegistrar
            // 
            this.BtRegistrar.Location = new System.Drawing.Point(242, 50);
            this.BtRegistrar.Name = "BtRegistrar";
            this.BtRegistrar.Size = new System.Drawing.Size(75, 23);
            this.BtRegistrar.TabIndex = 11;
            this.BtRegistrar.Text = "REGISTRAR";
            this.BtRegistrar.UseVisualStyleBackColor = true;
            this.BtRegistrar.Click += new System.EventHandler(this.BtRegistrar_Click);
            // 
            // BtMostrar
            // 
            this.BtMostrar.Location = new System.Drawing.Point(242, 79);
            this.BtMostrar.Name = "BtMostrar";
            this.BtMostrar.Size = new System.Drawing.Size(75, 23);
            this.BtMostrar.TabIndex = 12;
            this.BtMostrar.Text = "MOSTRAR";
            this.BtMostrar.UseVisualStyleBackColor = true;
            this.BtMostrar.Click += new System.EventHandler(this.BtMostrar_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(242, 108);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(75, 23);
            this.BtEliminar.TabIndex = 13;
            this.BtEliminar.Text = "ELIMINAR";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // BtMayor
            // 
            this.BtMayor.Location = new System.Drawing.Point(242, 137);
            this.BtMayor.Name = "BtMayor";
            this.BtMayor.Size = new System.Drawing.Size(75, 23);
            this.BtMayor.TabIndex = 14;
            this.BtMayor.Text = "MAYOR";
            this.BtMayor.UseVisualStyleBackColor = true;
            this.BtMayor.Click += new System.EventHandler(this.BtMayor_Click);
            // 
            // Menor
            // 
            this.Menor.Location = new System.Drawing.Point(242, 166);
            this.Menor.Name = "Menor";
            this.Menor.Size = new System.Drawing.Size(75, 23);
            this.Menor.TabIndex = 15;
            this.Menor.Text = "MENOR";
            this.Menor.UseVisualStyleBackColor = true;
            this.Menor.Click += new System.EventHandler(this.Menor_Click);
            // 
            // BtBuscar
            // 
            this.BtBuscar.Location = new System.Drawing.Point(323, 108);
            this.BtBuscar.Name = "BtBuscar";
            this.BtBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtBuscar.TabIndex = 16;
            this.BtBuscar.Text = "BUSCAR";
            this.BtBuscar.UseVisualStyleBackColor = true;
            this.BtBuscar.Click += new System.EventHandler(this.BtBuscar_Click);
            // 
            // BtVolver
            // 
            this.BtVolver.Location = new System.Drawing.Point(323, 195);
            this.BtVolver.Name = "BtVolver";
            this.BtVolver.Size = new System.Drawing.Size(75, 23);
            this.BtVolver.TabIndex = 17;
            this.BtVolver.Text = "VOLVER";
            this.BtVolver.UseVisualStyleBackColor = true;
            this.BtVolver.Click += new System.EventHandler(this.BtVolver_Click);
            // 
            // BaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 257);
            this.Controls.Add(this.BtVolver);
            this.Controls.Add(this.BtBuscar);
            this.Controls.Add(this.Menor);
            this.Controls.Add(this.BtMayor);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.BtMostrar);
            this.Controls.Add(this.BtRegistrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDireccion);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaseDeDatos";
            this.Text = "BaseDeDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TxtCi;
        private TextBox TxtNombre;
        private TextBox TxtApellido;
        private TextBox TxtEdad;
        private TextBox TxtDireccion;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BtRegistrar;
        private Button BtMostrar;
        private Button BtEliminar;
        private Button BtMayor;
        private Button Menor;
        private Button BtBuscar;
        private Button BtVolver;
    }
}