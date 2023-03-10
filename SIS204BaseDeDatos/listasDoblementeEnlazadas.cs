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
    public partial class listasDoblementeEnlazadas : Form {
        ListaLDE listaLDE = new ListaLDE();

        int x;
        int modificado;
        bool existe;
        public listasDoblementeEnlazadas() {
            InitializeComponent();
            bloquearBotones();
        }

        private void BtnInsert_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);
                listaLDE.insertarNodo(x);

                listaPU.Items.Add(x);
                listaUP.Items.Insert(0, x);
            } else {
                MessageBox.Show("porfavor insertar datos validos");
            }
            limpiar();
            activarBotones();
        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);
                listaLDE.buscar(x, ref existe);
                if (existe.Equals(true)) {
                    //hablitamos la seleccion de los items
                    listaPU.SetSelected(listaPU.Items.IndexOf(x), true);
                    listaUP.SetSelected(listaUP.Items.IndexOf(x), true);
                    //esperamos 1 segundo
                    Thread.Sleep(1000);
                    //deshabilitams la seleccion de los items
                    listaPU.SetSelected(listaPU.Items.IndexOf(x), false);
                    listaUP.SetSelected(listaUP.Items.IndexOf(x), false);

                } else {
                    MessageBox.Show("no existe el elemento " + x + " en la lista");
                }
            } else {
                MessageBox.Show("porfavor insertar datos validos");
            }
            limpiar();
        }

        private void BtnModific_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("") && !TxtModify.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);
                modificado = int.Parse(TxtModify.Text);

                listaLDE.modificar(x, ref existe, modificado);

                if (existe.Equals(true)) {
                    int index1 = listaUP.Items.IndexOf(x);
                    int index2 = listaPU.Items.IndexOf(x);

                    listaUP.Items.Insert(index1, modificado);
                    listaUP.Items.RemoveAt(index1 + 1);

                    listaPU.Items.Insert(index2, modificado);
                    listaPU.Items.RemoveAt(index2 + 1);

                    listaUP.SetSelected(index1, true);
                    listaPU.SetSelected(index2, true);

                    Thread.Sleep(1000);

                    listaUP.SetSelected(index1, false);
                    listaPU.SetSelected(index2, false);

                    MessageBox.Show("elemento modificado exitosamente");
                } else {
                    MessageBox.Show("no existe el elemento " + x + " en la lista");
                }
            } else {
                MessageBox.Show("porfavor insertar datos validos");
            }
            limpiar();
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            if (!TxtDateIntro.Text.Equals("")) {
                x = int.Parse(TxtDateIntro.Text);

                listaLDE.eliminar(x, ref existe);

                if (existe.Equals(true)) {
                    int index1 = listaUP.Items.IndexOf(x);
                    int index2 = listaPU.Items.IndexOf(x);

                    listaUP.Items.RemoveAt(index1);
                    listaPU.Items.RemoveAt(index2);
                    if (listaPU.Items.Count.Equals(0)) {
                        bloquearBotones();
                    }
                } else {
                    MessageBox.Show("no existe el elemento " + x + " en la lista");
                }



            } else {
                MessageBox.Show("porfavor insertar datos validos");
            }
            limpiar();
        }

        private void BtnReturn_Click(object sender, EventArgs e) {
            ListasEnlazadas frm = new ListasEnlazadas();
            this.Hide();
            frm.Show();
        }

        public void bloquearBotones() {
            BtnDelete.Enabled = false;
            BtnModific.Enabled = false;
            BtnSearch.Enabled = false;
        }

        public void activarBotones() {
            BtnDelete.Enabled = true;
            BtnModific.Enabled = true;
            BtnSearch.Enabled = true;
        }

        public void limpiar() {
            TxtDateIntro.Clear();
            TxtModify.Clear();
            TxtDateIntro.Focus();
        }
    }
}
