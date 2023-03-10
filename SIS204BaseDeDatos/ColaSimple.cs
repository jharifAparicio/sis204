using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS204BaseDeDatos {
    public partial class ColaSimple : Form {
        public string x = "";

        //creamos nuevo objeto
        FunctionsColas cs = new FunctionsColas();

        public ColaSimple() {
            InitializeComponent();
            BtnDelete.Enabled = false;
            texto();
        }

        internal int texto() {
            TxtElement.Focus();
            return 0;
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            if (TxtElement.Text.Equals("")) {
                MessageBox.Show("Error:caja de texto vacia");
            } else {
                if (cs.FullCs()) {
                    MessageBox.Show("Error: Cola llena");
                    BtnInsert.Enabled = false;
                } else {
                    cs.insertElementsCs(TxtElement.Text);
                    ListElements.Items.Add(TxtElement.Text);
                    BtnDelete.Enabled = true;
                    MessageBox.Show("Elemento " + TxtElement.Text + " fue insertado con exito!!");
                }
                borrar();
                texto();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            if (cs.EmptyCs().Equals(false)) {
                x = cs.deleteElementsCs();
                ListElements.Items.Remove(x);
                BtnInsert.Enabled = true;

                if (cs.ultimateElement == -1) {
                    MessageBox.Show("lista vaciada con exito!!");
                    BtnDelete.Enabled = false;
                } else {
                    MessageBox.Show("Elemento " + x + " eliminado con exito!!");
                }
            }
            borrar();
            texto();
        }

        private void BtnReturn_Click(object sender, EventArgs e) {
            cs.ReturnBegin();
            this.Close();
        }

        public int borrar() {
            TxtElement.Text = "";
            TxtElement.Focus();
            return 0;
        }
    }
}
