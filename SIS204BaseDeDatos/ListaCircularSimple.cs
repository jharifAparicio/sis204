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
    public partial class ListaCircularSimple : Form {
        ListaLCS lcs = new ListaLCS();

        int x;
        int modific;
        bool existe;
        int index;
        public ListaCircularSimple() {
            InitializeComponent();
            blockbotones();
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);
                lcs.insertar(x);
                Lista.Items.Add(x);
                activeBotones();
            } else {
                MessageBox.Show("ingrese datos validos");
            }
            borrar();
        }

        private void BtnModific_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("") || !TxtModify.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);
                modific = int.Parse(TxtModify.Text);
                lcs.modificar(x, ref existe, modific);
                if (existe.Equals(true)) {
                    index = Lista.Items.IndexOf(x);
                    Lista.Items.Insert(index, modific);
                    Lista.Items.RemoveAt(index + 1);
                } else {
                    MessageBox.Show("elemento no existente");
                }
            } else {
                MessageBox.Show("ingresar datos validos");
            }
            borrar();
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);
                lcs.eliminar(x, ref existe);
                if (existe.Equals(true)) {
                    index = Lista.Items.IndexOf(x);
                    Lista.Items.RemoveAt(index);
                } else {
                    MessageBox.Show("elemento no existente");
                }
            } else {
                MessageBox.Show("ingresar datos validos");
            }

            if (Lista.Items.Count.Equals(0)) {
                blockbotones();
                MessageBox.Show("lista vacia");
            }
            borrar();
        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);
                lcs.buscar(x, ref existe);
                if (existe.Equals(true)) {
                    index = Lista.Items.IndexOf(x);
                    Lista.SetSelected(index, true);
                    Thread.Sleep(1000);
                    Lista.SetSelected(index, false);
                } else {
                    MessageBox.Show("elemento inexistente");
                }
            } else {
                MessageBox.Show("ingresar datos validos");
            }
            borrar();
        }

        private void BtnReturn_Click(object sender, EventArgs e) {
            ListasEnlazadas frm = new ListasEnlazadas();
            this.Hide();
            frm.Show();
        }

        public void borrar() {
            TxtDateIntro.Clear();
            TxtModify.Clear();
            TxtDateIntro.Focus();
        }

        public void blockbotones() {
            BtnDelete.Enabled = false;
            BtnModific.Enabled = false;
            BtnSearch.Enabled = false;
            TxtModify.Enabled = false;
        }

        public void activeBotones() {
            BtnDelete.Enabled = true;
            BtnModific.Enabled = true;
            BtnSearch.Enabled = true;
            TxtModify.Enabled = true;
        }
    }
}
