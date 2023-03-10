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
    public partial class DeCola : Form {
        //creamos una varible temporal 
        private string x;
        //creamos un objeto con la clase Colas
        FunctionsColas Dc = new FunctionsColas();

        public DeCola() {
            InitializeComponent();
            BlocBtnsDelets();
            x = "";
            texto();
        }

        internal int texto() {
            TxtElement.Focus();
            return 0;
        }

        private void BtnInsertForFront_Click(object sender, EventArgs e) {
            if (TxtElement.Text.Equals("")) {
                MessageBox.Show("Error:caja de texto vacia");
            } else {
                if (Dc.FullCs()) {
                    MessageBox.Show("Error: Cola llena");
                    BlocBtnsInserts();
                } else {
                    Dc.insertElementsCs(TxtElement.Text);
                    ListElements.Items.Add(TxtElement.Text);
                    activateBtnsDelets();
                    MessageBox.Show("Elemento " + TxtElement.Text + " fue insertado con exito!!");
                }
            }
            borrar();
            texto();
        }
        private void BtnInsertForBack_Click(object sender, EventArgs e) {
            if (TxtElement.Text.Equals("")) {
                MessageBox.Show("Error:caja de texto vacia");
            } else {
                if (Dc.FullCs()) {
                    MessageBox.Show("Error: Cola llena");
                    BlocBtnsInserts();
                } else {
                    Dc.InsertElementsCd(TxtElement.Text);
                    ListElements.Items.Insert(0, TxtElement.Text);

                    //ListElements.Items.Add(TxtElement.Text);
                    activateBtnsDelets();
                    MessageBox.Show("Elemento " + TxtElement.Text + " fue insertado con exito!!");
                }
            }
            borrar();
            texto();
        }

        private void BtnDeleteForFront_Click(object sender, EventArgs e) {
            if (Dc.EmptyCs().Equals(false)) {
                x = Dc.deleteElementsCs();
                ListElements.Items.Remove(x);
                activateBtnsInserts();

                if (Dc.ultimateElement == -1) {
                    MessageBox.Show("lista vaciada con exito!!");
                    BlocBtnsDelets();
                } else {
                    MessageBox.Show("Elemento " + x + " eliminado con exito!!");
                }
            }
        }

        private void BtnDeleteForBack_Click(object sender, EventArgs e) {
            if (Dc.EmptyCs().Equals(false)) {
                x = Dc.deleteElementsCd();

                ListElements.Items.RemoveAt(Dc.ultimateElement + 1);
                activateBtnsInserts();

                if (Dc.ultimateElement == -1) {
                    MessageBox.Show("lista vaciada con exito!!");
                    BlocBtnsDelets();
                } else {
                    MessageBox.Show("Elemento " + x + " eliminado con exito!!");
                }
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e) {
            Dc.ReturnBegin();
            this.Close();
        }

        internal int BlocBtnsInserts() {
            BtnInsertForBack.Enabled = false;
            BtnInsertForFront.Enabled = false;
            return 0;
        }

        internal int BlocBtnsDelets() {
            BtnDeleteForBack.Enabled = false;
            BtnDeleteForFront.Enabled = false;
            return 0;
        }

        internal int activateBtnsInserts() {
            BtnDeleteForFront.Enabled = true;
            BtnDeleteForBack.Enabled = true;
            return 0;
        }

        internal int activateBtnsDelets() {
            BtnDeleteForFront.Enabled = true;
            BtnDeleteForBack.Enabled = true;
            return 0;
        }
        public int borrar() {
            TxtElement.Text = "";
            TxtElement.Focus();
            return 0;
        }
    }
}
