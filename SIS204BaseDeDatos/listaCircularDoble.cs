using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIS204BaseDeDatos {
    public partial class listaCircularDoble : Form {

        ListaLCD LCD = new ListaLCD();

        int x;
        int nuevo;
        bool existe = false;
        public listaCircularDoble() {
            InitializeComponent();
            blockbotones();
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);

                LCD.insertar(x);

                Lista.Items.Add(x);
                activeBotones();
            } else {
                MessageBox.Show("ingresar datos validos");
            }
            borrar();
        }

        private void BtnModific_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("") && !TxtModify.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);
                nuevo = int.Parse(TxtModify.Text);

                LCD.modificar(x, ref existe, nuevo);

                if (existe.Equals(true)) {
                    int index = Lista.Items.IndexOf(x);
                    Lista.Items.Insert(index, nuevo);
                    Lista.Items.RemoveAt(index + 1);
                } else {
                    MessageBox.Show("elemento inexistente");
                }

            } else {
                MessageBox.Show("ingresar datos validos o faltan datos");
            }
            borrar();
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);
                existe = false;

                LCD.eliminar(x, ref existe);
                if (existe.Equals(true)) {
                    int index = Lista.Items.IndexOf(x);
                    Lista.Items.RemoveAt(index);
                    MessageBox.Show("elemento eliminado exitosamente");

                    if (Lista.Items.Count.Equals(0)) {
                        blockbotones();
                    }
                } else {
                    MessageBox.Show("elemento inexistente");
                }
            } else {
                MessageBox.Show("insertar datos validos");
            }
            borrar();
        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);

                LCD.buscar(x, ref existe);
                if (existe.Equals(true)) {
                    int index = Lista.Items.IndexOf(x);

                    Lista.SetSelected(index, true);
                    Thread.Sleep(1000);
                    Lista.SetSelected(index, false);
                } else {
                    MessageBox.Show("elemento inexistente");
                }
            } else {
                MessageBox.Show("insertar datos validos");
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
