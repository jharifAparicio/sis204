using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS204BaseDeDatos {
    public partial class ColaCircular : Form {
        //Creamos la varible que guardara el valor que sera guardado
        public string x = "";
        //Creamos un objeto a partir de FunctionsColas
        FunctionsColas Cc = new FunctionsColas();

        public ColaCircular() {
            InitializeComponent();
            BtnDelete.Enabled = false;
            TxtElement.Focus();
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            if (Cc.FullCc()) {
                MessageBox.Show("Error: Cola LLENA");
                BtnInsert.Enabled = false;
            } else {
                Cc.insertElementsCc(TxtElement.Text);
                ListElements.Items.Add(TxtElement.Text);
                BtnDelete.Enabled = true;
                MessageBox.Show("Elemento " + TxtElement.Text + " fue insertado con exito!!");

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            if (Cc.EmptyCc().Equals(false)) {
                x = Cc.deleteElementsCs();
                ListElements.Items.Remove(x);
                BtnInsert.Enabled = true;

                if (Cc.ultimateElement == -1) {
                    MessageBox.Show("lista vaciada con exito!!");
                    BtnDelete.Enabled = false;
                } else {
                    MessageBox.Show("Elemento " + x + " eliminado con exito!!");
                }
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e) {
            Cc.ReturnBegin();
            this.Close();
        }
    }
}
