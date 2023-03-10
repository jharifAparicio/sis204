namespace SIS204BaseDeDatos
{
    partial class Inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtBaseDeDatos = new System.Windows.Forms.Button();
            this.BtListas = new System.Windows.Forms.Button();
            this.BtColas = new System.Windows.Forms.Button();
            this.BtListasEnlazadas = new System.Windows.Forms.Button();
            this.BtArboles = new System.Windows.Forms.Button();
            this.BtMultilistas = new System.Windows.Forms.Button();
            this.BtArbolesGral = new System.Windows.Forms.Button();
            this.BtSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BASE DE DATOS";
            // 
            // BtBaseDeDatos
            // 
            this.BtBaseDeDatos.Location = new System.Drawing.Point(12, 44);
            this.BtBaseDeDatos.Name = "BtBaseDeDatos";
            this.BtBaseDeDatos.Size = new System.Drawing.Size(75, 43);
            this.BtBaseDeDatos.TabIndex = 1;
            this.BtBaseDeDatos.Text = "Base de datos";
            this.BtBaseDeDatos.UseVisualStyleBackColor = true;
            this.BtBaseDeDatos.Click += new System.EventHandler(this.BtBaseDeDatos_Click);
            // 
            // BtListas
            // 
            this.BtListas.Location = new System.Drawing.Point(93, 44);
            this.BtListas.Name = "BtListas";
            this.BtListas.Size = new System.Drawing.Size(75, 43);
            this.BtListas.TabIndex = 2;
            this.BtListas.Text = "pilas";
            this.BtListas.UseVisualStyleBackColor = true;
            this.BtListas.Click += new System.EventHandler(this.BtListas_Click);
            // 
            // BtColas
            // 
            this.BtColas.Location = new System.Drawing.Point(174, 44);
            this.BtColas.Name = "BtColas";
            this.BtColas.Size = new System.Drawing.Size(75, 43);
            this.BtColas.TabIndex = 3;
            this.BtColas.Text = "colas";
            this.BtColas.UseVisualStyleBackColor = true;
            this.BtColas.Click += new System.EventHandler(this.BtColas_Click);
            // 
            // BtListasEnlazadas
            // 
            this.BtListasEnlazadas.Location = new System.Drawing.Point(12, 93);
            this.BtListasEnlazadas.Name = "BtListasEnlazadas";
            this.BtListasEnlazadas.Size = new System.Drawing.Size(75, 43);
            this.BtListasEnlazadas.TabIndex = 4;
            this.BtListasEnlazadas.Text = "listas enlazadas";
            this.BtListasEnlazadas.UseVisualStyleBackColor = true;
            this.BtListasEnlazadas.Click += new System.EventHandler(this.BtListasEnlazadas_Click);
            // 
            // BtArboles
            // 
            this.BtArboles.Location = new System.Drawing.Point(174, 93);
            this.BtArboles.Name = "BtArboles";
            this.BtArboles.Size = new System.Drawing.Size(75, 43);
            this.BtArboles.TabIndex = 7;
            this.BtArboles.Text = "arboles";
            this.BtArboles.UseVisualStyleBackColor = true;
            // 
            // BtMultilistas
            // 
            this.BtMultilistas.Location = new System.Drawing.Point(93, 93);
            this.BtMultilistas.Name = "BtMultilistas";
            this.BtMultilistas.Size = new System.Drawing.Size(75, 43);
            this.BtMultilistas.TabIndex = 6;
            this.BtMultilistas.Text = "multilistas";
            this.BtMultilistas.UseVisualStyleBackColor = true;
            // 
            // BtArbolesGral
            // 
            this.BtArbolesGral.Location = new System.Drawing.Point(12, 142);
            this.BtArbolesGral.Name = "BtArbolesGral";
            this.BtArbolesGral.Size = new System.Drawing.Size(75, 43);
            this.BtArbolesGral.TabIndex = 5;
            this.BtArbolesGral.Text = "arboles generales";
            this.BtArbolesGral.UseVisualStyleBackColor = true;
            // 
            // BtSalir
            // 
            this.BtSalir.Location = new System.Drawing.Point(174, 152);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(75, 23);
            this.BtSalir.TabIndex = 9;
            this.BtSalir.Text = "salir";
            this.BtSalir.UseVisualStyleBackColor = true;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 226);
            this.Controls.Add(this.BtSalir);
            this.Controls.Add(this.BtArboles);
            this.Controls.Add(this.BtMultilistas);
            this.Controls.Add(this.BtArbolesGral);
            this.Controls.Add(this.BtListasEnlazadas);
            this.Controls.Add(this.BtColas);
            this.Controls.Add(this.BtListas);
            this.Controls.Add(this.BtBaseDeDatos);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button BtBaseDeDatos;
        private Button BtListas;
        private Button BtColas;
        private Button BtListasEnlazadas;
        private Button BtArboles;
        private Button BtMultilistas;
        private Button BtArbolesGral;
        private Button BtSalir;
    }
}