namespace SIS204BaseDeDatos {
    public partial class ListaEnlazadaSimple : Form {
        int posMod;

        bool existe = false;
        //creamos una instancia a partir de Lista
        Lista lista = new Lista();

        public ListaEnlazadaSimple() {
            InitializeComponent();
            bockbutons();
        }

        private void BtnInsert_Click(object sender, EventArgs e) {

            if (TxtDateIntro.Text.Equals("")) {
                MessageBox.Show("Error:caja de texto vacia");
            } else {
                lista.insertNodo(int.Parse(TxtDateIntro.Text));
                Lista.Items.Add(TxtDateIntro.Text);
                MessageBox.Show("Elemento " + TxtDateIntro.Text + " fue insertado con exito!!");
                activatebutons();
            }
            borrar();
            texto();
        }

        private void BtnDelete_Click(object sender, EventArgs e) {
            // posDel = 0;
            //bool existe = false;
            if (TxtDateIntro.Text.Equals("")) {
                MessageBox.Show("insertar datos a modificar");
                TxtDateIntro.Focus();
            } else {
                lista.delete(int.Parse(TxtDateIntro.Text), ref existe);
                if (existe.Equals(false)) {
                    MessageBox.Show("elemento inexistente");
                } else {
                    Lista.Items.Remove(TxtDateIntro.Text);
                    //posDel = 0;
                    existe = false;
                    //Console.WriteLine(Lista.IndexFromPoint());
                    if (Lista.Items.Count.Equals(0)) {
                        bockbutons();
                    }
                }
            }
            TxtDateIntro.Focus();
            borrar();

        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            if (TxtDateIntro.Text.Equals("")) {
                MessageBox.Show("insertar datos a buscar");
                TxtDateIntro.Focus();
            } else {
                lista.search(int.Parse(TxtDateIntro.Text), ref posMod, ref existe);
                if (existe.Equals(false)) {
                    MessageBox.Show("elemento inexistente");
                } else {
                    Lista.SetSelected(Lista.Items.IndexOf(TxtDateIntro.Text), true);
                    Thread.Sleep(2000);
                    Lista.SetSelected(Lista.Items.IndexOf(TxtDateIntro.Text), false);
                    posMod = 0;
                    existe = false;
                    if (Lista.Items.Count.Equals(0)) {
                        bockbutons();
                    }
                }
            }
            TxtDateIntro.Focus();
            borrar();



        }

        private void BtnModific_Click(object sender, EventArgs e) {
            if (TxtDateIntro.Equals("") || TxtModify.Equals("")) {
                MessageBox.Show("insertar todos los datos nesesarios");
            } else {
                lista.modify(int.Parse(TxtDateIntro.Text), int.Parse(TxtModify.Text));

                int index = Lista.Items.IndexOf(TxtDateIntro.Text);
                if (index >= 0) {
                    Lista.Items.Insert(index, TxtModify.Text);
                    Lista.Items.RemoveAt(index + 1);
                    //int index = lsblista.SelectedIndex;
                    //lsblista.Items.Insert(lsblista.SelectedIndex - 1, lsblista.SelectedItem.ToString());
                    //lsblista.Items.RemoveAt(index + 1);
                } else {
                    MessageBox.Show("valor inexistente, inserte otro valor que exista en la lista");
                }
            }
            borrar();
            texto();
        }

        private void BtnReturn_Click(object sender, EventArgs e) {
            this.Hide();
            lista.retornar();
        }

        public int borrar() {
            TxtDateIntro.Text = "";
            TxtModify.Text = "";
            TxtDateIntro.Focus();
            return 0;
        }

        internal int texto() {
            TxtDateIntro.Focus();
            return 0;
        }

        public int bockbutons() {
            BtnDelete.Enabled = false;
            BtnModific.Enabled = false;
            BtnSearch.Enabled = false;
            TxtModify.Enabled = false;
            return 0;
        }

        public int activatebutons() {
            BtnDelete.Enabled = true;
            BtnModific.Enabled = true;
            BtnSearch.Enabled = true;
            TxtModify.Enabled = true;
            return 0;
        }
    }
}
