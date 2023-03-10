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
    public partial class ListasEnlazadas : Form {
        public ListasEnlazadas() {
            InitializeComponent();
        }

        private void BtnListSimpElaz_Click(object sender, EventArgs e) {
            ListaEnlazadaSimple frm = new ListaEnlazadaSimple();
            this.Close();
            frm.Show();
        }

        private void BtnDoblemente_Click(object sender, EventArgs e) {
            listasDoblementeEnlazadas frm = new listasDoblementeEnlazadas();
            this.Close();
            frm.Show();
        }

        private void BtnSimplementeCircu_Click(object sender, EventArgs e) {
            ListaCircularSimple frm = new ListaCircularSimple();
            this.Close();
            frm.Show();
        }

        private void BtnDoblementeCir_Click(object sender, EventArgs e) {
            listaCircularDoble frm = new listaCircularDoble();
            this.Close();
            frm.Show();
        }

        private void BtnNodoCabeza_Click(object sender, EventArgs e) {

        }

        private void BtnReturn_Click(object sender, EventArgs e) {
            Inicio frm = new Inicio();
            this.Close();
            frm.Show();
        }
    }
}
