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
    public partial class Pila : Form {
        //creamos una variable que guarde los valores
        string element = "";
        //creamos un nuevo objeto de la clase pilas
        FunctionsPilas pila = new FunctionsPilas();

        public Pila() {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            if (TxtElements.Text.Equals("")) {
                MessageBox.Show("ingrese algun dato");
            } else {
                string a = TxtElements.Text;
                //se llaman p, que es un objeto
                if (pila.Full()) {
                    MessageBox.Show("Error: la pila esta llena");
                    BtnInsert.Enabled = false;
                } else {
                    pila.InsertElement(a);
                    ListElements.Items.Add(a);
                    BtnDelete.Enabled = true;
                }
                TxtElements.Text = " ";
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            if (pila.Empty()) {
                MessageBox.Show("Error: La pila esta vacia");
                BtnDelete.Enabled = false;
            } else {
                element = pila.Delete();
                ListElements.Items.Remove(element);
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e) {
            Inicio frm = new Inicio();
            this.Close();
            frm.Show();
        }
    }
}
