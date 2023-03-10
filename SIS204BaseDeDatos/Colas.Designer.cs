namespace SIS204BaseDeDatos {
    partial class Colas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BtnColaSimple = new System.Windows.Forms.Button();
            this.BtnColaCircular = new System.Windows.Forms.Button();
            this.BtnDeCola = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnColaSimple
            // 
            this.BtnColaSimple.Location = new System.Drawing.Point(11, 57);
            this.BtnColaSimple.Name = "BtnColaSimple";
            this.BtnColaSimple.Size = new System.Drawing.Size(75, 46);
            this.BtnColaSimple.TabIndex = 0;
            this.BtnColaSimple.Text = "COLAS SIMPLES";
            this.BtnColaSimple.UseVisualStyleBackColor = true;
            this.BtnColaSimple.Click += new System.EventHandler(this.BtnColaSimple_Click);
            // 
            // BtnColaCircular
            // 
            this.BtnColaCircular.Location = new System.Drawing.Point(92, 57);
            this.BtnColaCircular.Name = "BtnColaCircular";
            this.BtnColaCircular.Size = new System.Drawing.Size(75, 46);
            this.BtnColaCircular.TabIndex = 1;
            this.BtnColaCircular.Text = "COLA CIRCULAR";
            this.BtnColaCircular.UseVisualStyleBackColor = true;
            this.BtnColaCircular.Click += new System.EventHandler(this.BtnColaCircular_Click);
            // 
            // BtnDeCola
            // 
            this.BtnDeCola.Location = new System.Drawing.Point(173, 57);
            this.BtnDeCola.Name = "BtnDeCola";
            this.BtnDeCola.Size = new System.Drawing.Size(75, 46);
            this.BtnDeCola.TabIndex = 2;
            this.BtnDeCola.Text = "DECOLA";
            this.BtnDeCola.UseVisualStyleBackColor = true;
            this.BtnDeCola.Click += new System.EventHandler(this.BtnDeCola_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "COLAS";
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(173, 112);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 4;
            this.BtnReturn.Text = "VOLVER";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // Colas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 147);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDeCola);
            this.Controls.Add(this.BtnColaCircular);
            this.Controls.Add(this.BtnColaSimple);
            this.Name = "Colas";
            this.Text = "Colas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnColaSimple;
        private Button BtnColaCircular;
        private Button BtnDeCola;
        private Label label1;
        private Button BtnReturn;
    }
}