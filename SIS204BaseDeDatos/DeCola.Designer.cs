namespace SIS204BaseDeDatos {
    partial class DeCola {
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
            this.BtnDeleteForBack = new System.Windows.Forms.Button();
            this.ListElements = new System.Windows.Forms.ListBox();
            this.BtnInsertForFront = new System.Windows.Forms.Button();
            this.TxtElement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInsertForBack = new System.Windows.Forms.Button();
            this.BtnDeleteForFront = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(186, 252);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 11;
            this.BtnReturn.Text = "VOLVER";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnDeleteForBack
            // 
            this.BtnDeleteForBack.Location = new System.Drawing.Point(93, 252);
            this.BtnDeleteForBack.Name = "BtnDeleteForBack";
            this.BtnDeleteForBack.Size = new System.Drawing.Size(75, 58);
            this.BtnDeleteForBack.TabIndex = 10;
            this.BtnDeleteForBack.Text = "ELIMINAR POR DETRAS";
            this.BtnDeleteForBack.UseVisualStyleBackColor = true;
            this.BtnDeleteForBack.Click += new System.EventHandler(this.BtnDeleteForBack_Click);
            // 
            // ListElements
            // 
            this.ListElements.FormattingEnabled = true;
            this.ListElements.ItemHeight = 15;
            this.ListElements.Location = new System.Drawing.Point(12, 57);
            this.ListElements.Name = "ListElements";
            this.ListElements.Size = new System.Drawing.Size(156, 184);
            this.ListElements.TabIndex = 9;
            // 
            // BtnInsertForFront
            // 
            this.BtnInsertForFront.Location = new System.Drawing.Point(174, 57);
            this.BtnInsertForFront.Name = "BtnInsertForFront";
            this.BtnInsertForFront.Size = new System.Drawing.Size(75, 56);
            this.BtnInsertForFront.TabIndex = 8;
            this.BtnInsertForFront.Text = "INSERTAR POR DELANTE";
            this.BtnInsertForFront.UseVisualStyleBackColor = true;
            this.BtnInsertForFront.Click += new System.EventHandler(this.BtnInsertForFront_Click);
            // 
            // TxtElement
            // 
            this.TxtElement.Location = new System.Drawing.Point(174, 119);
            this.TxtElement.Name = "TxtElement";
            this.TxtElement.Size = new System.Drawing.Size(75, 23);
            this.TxtElement.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "DECOLAS";
            // 
            // BtnInsertForBack
            // 
            this.BtnInsertForBack.Location = new System.Drawing.Point(174, 148);
            this.BtnInsertForBack.Name = "BtnInsertForBack";
            this.BtnInsertForBack.Size = new System.Drawing.Size(75, 56);
            this.BtnInsertForBack.TabIndex = 12;
            this.BtnInsertForBack.Text = "INSERTAR POR DETRAS";
            this.BtnInsertForBack.UseVisualStyleBackColor = true;
            this.BtnInsertForBack.Click += new System.EventHandler(this.BtnInsertForBack_Click);
            // 
            // BtnDeleteForFront
            // 
            this.BtnDeleteForFront.Location = new System.Drawing.Point(12, 252);
            this.BtnDeleteForFront.Name = "BtnDeleteForFront";
            this.BtnDeleteForFront.Size = new System.Drawing.Size(75, 58);
            this.BtnDeleteForFront.TabIndex = 13;
            this.BtnDeleteForFront.Text = "ELIMINAR POR DELANTE";
            this.BtnDeleteForFront.UseVisualStyleBackColor = true;
            this.BtnDeleteForFront.Click += new System.EventHandler(this.BtnDeleteForFront_Click);
            // 
            // DeCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 329);
            this.Controls.Add(this.BtnDeleteForFront);
            this.Controls.Add(this.BtnInsertForBack);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnDeleteForBack);
            this.Controls.Add(this.ListElements);
            this.Controls.Add(this.BtnInsertForFront);
            this.Controls.Add(this.TxtElement);
            this.Controls.Add(this.label1);
            this.Name = "DeCola";
            this.Text = "DeCola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnReturn;
        private Button BtnDeleteForBack;
        private ListBox ListElements;
        private Button BtnInsertForFront;
        private TextBox TxtElement;
        private Label label1;
        private Button BtnInsertForBack;
        private Button BtnDeleteForFront;
    }
}