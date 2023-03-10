namespace SIS204BaseDeDatos {
    partial class Pila {
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListElements = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtElements = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PILAS";
            // 
            // ListElements
            // 
            this.ListElements.FormattingEnabled = true;
            this.ListElements.ItemHeight = 15;
            this.ListElements.Location = new System.Drawing.Point(12, 37);
            this.ListElements.Name = "ListElements";
            this.ListElements.Size = new System.Drawing.Size(109, 289);
            this.ListElements.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elemento";
            // 
            // TxtElements
            // 
            this.TxtElements.Location = new System.Drawing.Point(127, 58);
            this.TxtElements.Name = "TxtElements";
            this.TxtElements.Size = new System.Drawing.Size(100, 23);
            this.TxtElements.TabIndex = 3;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(127, 87);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 4;
            this.BtnInsert.Text = "Insertar";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(127, 116);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(152, 303);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 6;
            this.BtnReturn.Text = "Volver";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // Pila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 339);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.TxtElements);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListElements);
            this.Controls.Add(this.label1);
            this.Name = "Pila";
            this.Text = "Pila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox ListElements;
        private Label label2;
        private TextBox TxtElements;
        private Button BtnInsert;
        private Button BtnDelete;
        private Button BtnReturn;
    }
}