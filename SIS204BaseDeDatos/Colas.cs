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
    public partial class Colas : Form {
        public Colas() {
            InitializeComponent();
            BtnReturn.Focus();
        }

        private void BtnColaSimple_Click(object sender, EventArgs e) {
            ColaSimple colasimple = new ColaSimple();
            this.Hide();
            colasimple.Show();
        }

        private void BtnColaCircular_Click(object sender, EventArgs e) {
            ColaCircular colacircular = new ColaCircular();
            this.Hide();
            colacircular.Show();
        }

        private void BtnDeCola_Click(object sender, EventArgs e) {
            DeCola decola = new DeCola();
            this.Hide();
            decola.Show();
        }

        private void BtnReturn_Click(object sender, EventArgs e) {
            Inicio frm = new Inicio();
            this.Close();
            frm.Show();
        }
    }
}
