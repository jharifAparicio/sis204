namespace SIS204BaseDeDatos {
    partial class ListasEnlazadas {
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
            this.BtnListSimpElaz = new System.Windows.Forms.Button();
            this.BtnDoblemente = new System.Windows.Forms.Button();
            this.BtnSimplementeCircu = new System.Windows.Forms.Button();
            this.BtnDoblementeCir = new System.Windows.Forms.Button();
            this.BtnNodoCabeza = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnListSimpElaz
            // 
            this.BtnListSimpElaz.Location = new System.Drawing.Point(12, 31);
            this.BtnListSimpElaz.Name = "BtnListSimpElaz";
            this.BtnListSimpElaz.Size = new System.Drawing.Size(102, 53);
            this.BtnListSimpElaz.TabIndex = 0;
            this.BtnListSimpElaz.Text = "LISTAS SIMPLEMENTE ENLAZADAS";
            this.BtnListSimpElaz.UseVisualStyleBackColor = true;
            this.BtnListSimpElaz.Click += new System.EventHandler(this.BtnListSimpElaz_Click);
            // 
            // BtnDoblemente
            // 
            this.BtnDoblemente.Location = new System.Drawing.Point(120, 31);
            this.BtnDoblemente.Name = "BtnDoblemente";
            this.BtnDoblemente.Size = new System.Drawing.Size(102, 53);
            this.BtnDoblemente.TabIndex = 1;
            this.BtnDoblemente.Text = "LISTAS DOBLEMENTE ENLAZADAS";
            this.BtnDoblemente.UseVisualStyleBackColor = true;
            this.BtnDoblemente.Click += new System.EventHandler(this.BtnDoblemente_Click);
            // 
            // BtnSimplementeCircu
            // 
            this.BtnSimplementeCircu.Location = new System.Drawing.Point(12, 89);
            this.BtnSimplementeCircu.Name = "BtnSimplementeCircu";
            this.BtnSimplementeCircu.Size = new System.Drawing.Size(102, 70);
            this.BtnSimplementeCircu.TabIndex = 2;
            this.BtnSimplementeCircu.Text = "LISTAS SIMPLEMENTE ENLAZADAS CIRCULARES";
            this.BtnSimplementeCircu.UseVisualStyleBackColor = true;
            this.BtnSimplementeCircu.Click += new System.EventHandler(this.BtnSimplementeCircu_Click);
            // 
            // BtnDoblementeCir
            // 
            this.BtnDoblementeCir.Location = new System.Drawing.Point(120, 90);
            this.BtnDoblementeCir.Name = "BtnDoblementeCir";
            this.BtnDoblementeCir.Size = new System.Drawing.Size(102, 69);
            this.BtnDoblementeCir.TabIndex = 5;
            this.BtnDoblementeCir.Text = "LISTAS DOBLEMENTE ENLAZADAS CIRCULARES";
            this.BtnDoblementeCir.UseVisualStyleBackColor = true;
            this.BtnDoblementeCir.Click += new System.EventHandler(this.BtnDoblementeCir_Click);
            // 
            // BtnNodoCabeza
            // 
            this.BtnNodoCabeza.Location = new System.Drawing.Point(57, 165);
            this.BtnNodoCabeza.Name = "BtnNodoCabeza";
            this.BtnNodoCabeza.Size = new System.Drawing.Size(102, 52);
            this.BtnNodoCabeza.TabIndex = 4;
            this.BtnNodoCabeza.Text = "LISTAS CON NODO CABEZA";
            this.BtnNodoCabeza.UseVisualStyleBackColor = true;
            this.BtnNodoCabeza.Click += new System.EventHandler(this.BtnNodoCabeza_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(149, 220);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 3;
            this.BtnReturn.Text = "VOLVER";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "LISTAS ENLAZADAS";
            // 
            // ListasEnlazadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 252);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDoblementeCir);
            this.Controls.Add(this.BtnNodoCabeza);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnSimplementeCircu);
            this.Controls.Add(this.BtnDoblemente);
            this.Controls.Add(this.BtnListSimpElaz);
            this.Name = "ListasEnlazadas";
            this.Text = "ListasEnlazadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnListSimpElaz;
        private Button BtnDoblemente;
        private Button BtnSimplementeCircu;
        private Button BtnDoblementeCir;
        private Button BtnNodoCabeza;
        private Button BtnReturn;
        private Label label1;
    }
}