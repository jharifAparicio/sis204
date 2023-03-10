namespace SIS204BaseDeDatos {
    partial class ColaSimple {
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
            this.TxtElement = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.ListElements = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(57, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "COLA SIMPLE";
            // 
            // TxtElement
            // 
            this.TxtElement.Location = new System.Drawing.Point(24, 41);
            this.TxtElement.Name = "TxtElement";
            this.TxtElement.Size = new System.Drawing.Size(100, 23);
            this.TxtElement.TabIndex = 1;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(130, 41);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 2;
            this.BtnInsert.Text = "INSERTAR";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // ListElements
            // 
            this.ListElements.FormattingEnabled = true;
            this.ListElements.ItemHeight = 15;
            this.ListElements.Location = new System.Drawing.Point(24, 70);
            this.ListElements.Name = "ListElements";
            this.ListElements.Size = new System.Drawing.Size(181, 184);
            this.ListElements.TabIndex = 3;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(24, 260);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "ELIMINAR";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(130, 260);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 5;
            this.BtnReturn.Text = "VOLVER";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // ColaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 301);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.ListElements);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.TxtElement);
            this.Controls.Add(this.label1);
            this.Name = "ColaSimple";
            this.Text = "ColaSimple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtElement;
        private Button BtnInsert;
        private ListBox ListElements;
        private Button BtnDelete;
        private Button BtnReturn;
    }
}