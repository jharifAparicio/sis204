namespace SIS204BaseDeDatos {
    partial class ListaEnlazadaSimple {
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
            this.TxtDateIntro = new System.Windows.Forms.TextBox();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.Lista = new System.Windows.Forms.ListBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnReturn = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnModific = new System.Windows.Forms.Button();
            this.TxtModify = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTA SIMPLEMENTE ENLAZADA";
            // 
            // TxtDateIntro
            // 
            this.TxtDateIntro.Location = new System.Drawing.Point(12, 45);
            this.TxtDateIntro.Name = "TxtDateIntro";
            this.TxtDateIntro.Size = new System.Drawing.Size(100, 23);
            this.TxtDateIntro.TabIndex = 1;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(118, 45);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(75, 23);
            this.BtnInsert.TabIndex = 2;
            this.BtnInsert.Text = "INSERTAR";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.ItemHeight = 15;
            this.Lista.Location = new System.Drawing.Point(12, 86);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(181, 244);
            this.Lista.TabIndex = 3;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(199, 86);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(79, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "ELIMINAR";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.Location = new System.Drawing.Point(199, 173);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(75, 23);
            this.BtnReturn.TabIndex = 5;
            this.BtnReturn.Text = "VOLVER";
            this.BtnReturn.UseVisualStyleBackColor = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(199, 115);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(79, 23);
            this.BtnSearch.TabIndex = 6;
            this.BtnSearch.Text = "BUSCAR";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnModific
            // 
            this.BtnModific.Location = new System.Drawing.Point(215, 144);
            this.BtnModific.Name = "BtnModific";
            this.BtnModific.Size = new System.Drawing.Size(79, 23);
            this.BtnModific.TabIndex = 7;
            this.BtnModific.Text = "MODIFICAR";
            this.BtnModific.UseVisualStyleBackColor = true;
            this.BtnModific.Click += new System.EventHandler(this.BtnModific_Click);
            // 
            // TxtModify
            // 
            this.TxtModify.Location = new System.Drawing.Point(199, 46);
            this.TxtModify.Name = "TxtModify";
            this.TxtModify.Size = new System.Drawing.Size(100, 23);
            this.TxtModify.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ingresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Modifica";
            // 
            // ListaEnlazadaSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 342);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtModify);
            this.Controls.Add(this.BtnModific);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.TxtDateIntro);
            this.Controls.Add(this.label1);
            this.Name = "ListaEnlazadaSimple";
            this.Text = "ListaEnlazadaSimple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox TxtDateIntro;
        private Button BtnInsert;
        private ListBox Lista;
        private Button BtnDelete;
        private Button BtnReturn;
        private Button BtnSearch;
        private Button BtnModific;
        private TextBox TxtModify;
        private Label label2;
        private Label label3;
    }
}