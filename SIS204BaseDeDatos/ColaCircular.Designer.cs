namespace SIS204BaseDeDatos {
    partial class ColaCircular {
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
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.ListElements = new System.Windows.Forms.ListBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.TxtElement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(118, 261);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 11;
            this.BtnReturn.Text = "VOLVER";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(12, 261);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "ELIMINAR";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // ListElements
            // 
            this.ListElements.FormattingEnabled = true;
            this.ListElements.ItemHeight = 15;
            this.ListElements.Location = new System.Drawing.Point(12, 71);
            this.ListElements.Name = "ListElements";
            this.ListElements.Size = new System.Drawing.Size(181, 184);
            this.ListElements.TabIndex = 9;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(118, 42);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 8;
            this.BtnInsert.Text = "INSERTAR";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // TxtElement
            // 
            this.TxtElement.Location = new System.Drawing.Point(12, 42);
            this.TxtElement.Name = "TxtElement";
            this.TxtElement.Size = new System.Drawing.Size(100, 23);
            this.TxtElement.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "COLA CIRCULAR";
            // 
            // ColaCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 306);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.ListElements);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.TxtElement);
            this.Controls.Add(this.label1);
            this.Name = "ColaCircular";
            this.Text = "ColaCircular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnReturn;
        private Button BtnDelete;
        private ListBox ListElements;
        private Button BtnInsert;
        private TextBox TxtElement;
        private Label label1;
    }
}