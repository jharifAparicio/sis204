namespace SIS204BaseDeDatos {
    public partial class Inicio : Form {
        public Inicio() {
            InitializeComponent();
        }

        private void BtBaseDeDatos_Click(object sender, EventArgs e) {
            BaseDeDatos baseDate = new BaseDeDatos();
            this.Hide();
            baseDate.Show();
        }

        private void BtListas_Click(object sender, EventArgs e) {

            Pila pilas = new Pila();
            this.Hide();
            pilas.Show();
        }

        private void BtColas_Click(object sender, EventArgs e) {
            Colas colas = new Colas();
            this.Hide();
            colas.Show();
        }
        private void BtListasEnlazadas_Click(object sender, EventArgs e) {
            ListasEnlazadas listE = new ListasEnlazadas();
            this.Hide();
            listE.Show();
        }

        private void BtSalir_Click(object sender, EventArgs e) {
            Application.Exit();
        }


    }

}