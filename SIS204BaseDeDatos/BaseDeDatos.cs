using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIS204BaseDeDatos {
    public partial class BaseDeDatos : Form {
        uint[] CI = new uint[50];
        string[] nombres = new string[50];
        string[] apellido = new string[50];
        short[] Edad = new short[50];
        string[] Direccion = new string[50];

        int ultimoElemento = -1;
        int limmax = 49;

        int posicionDelete = -1;

        int posicionMaxMin;
        public BaseDeDatos() {
            InitializeComponent();
            bloquear_botones();
        }


        private void BtRegistrar_Click(object sender, EventArgs e) {

            if (TxtCi.Text.Length == 0 ||
                     TxtNombre.Text.Length == 0 ||
                     TxtApellido.Text.Length == 0 ||
                     TxtEdad.Text.Length == 0 ||
                     TxtDireccion.Text.Length == 0) {
                MessageBox.Show("llenar los campos correspondientes");
            } else {
                if (ultimoElemento == limmax) {
                    BtRegistrar.Enabled = false;
                    MessageBox.Show("base de dato llena");
                } else {
                    //aumentamos en 1 la posicion del ultimo elemento

                    ultimoElemento++;
                    int ubi = ultimoElemento;

                    //guardamos todos los datos
                    CI[ubi] = uint.Parse(TxtCi.Text);
                    nombres[ubi] = Convert.ToString(TxtNombre.Text);
                    apellido[ubi] = Convert.ToString(TxtApellido.Text);
                    Edad[ubi] = short.Parse(TxtEdad.Text);
                    Direccion[ubi] = Convert.ToString(TxtDireccion.Text);



                    //borramos todos los datos de los campos de texto
                    borrarTxtBox();

                    //habilitaremos los botones
                    habilitar_botones();
                }
            }
        }

        private void BtMostrar_Click(object sender, EventArgs e) {
            consola();
        }

        private void BtBuscar_Click(object sender, EventArgs e) {
            if (TxtCi.Text.Equals("")) {
                MessageBox.Show("ingresar en numero de carnet a buscar");
            } else {
                if (ultimoElemento >= 0) {


                    uint carnet = uint.Parse(TxtCi.Text);

                    for (int h = 0; h <= ultimoElemento; h++) {
                        uint carnetVerificar = CI[h];
                        if (carnet == carnetVerificar) {
                            posicionDelete = h;

                            //mostraremos los resultados de la busqueda en los textBOx
                            mostrarTexBox(posicionDelete);

                            //habilitamos en boton eliminar
                            BtEliminar.Enabled = true;
                            break;

                        }

                        if (h == ultimoElemento) {
                            MessageBox.Show("no existe el carnet ingresado");
                            TxtCi.Clear();
                            break;
                        }
                    }

                } else {
                    MessageBox.Show("no existen datos en los arrays");
                    bloquear_botones();
                }
            }

        }

        private void BtEliminar_Click(object sender, EventArgs e) {
            if (ultimoElemento >= 0 & posicionDelete >= 0 & posicionDelete <= ultimoElemento) {
                //borramos el elemento de los array´s

                //recorremos el array
                if (ultimoElemento == posicionDelete) {
                    CI[posicionDelete] = 0;
                    nombres[posicionDelete] = "";
                    apellido[posicionDelete] = "";
                    Edad[posicionDelete] = 0;
                    Direccion[posicionDelete] = "";

                    ultimoElemento--;
                } else {
                    for (int i = posicionDelete; i <= ultimoElemento; i++) {
                        CI[i] = CI[i + 1];
                        nombres[i] = nombres[i + 1];
                        apellido[i] = apellido[i + 1];
                        Edad[i] = Edad[i + 1];
                        Direccion[i] = Direccion[i + 1];
                    }
                    ultimoElemento--;
                }

            } else {
                MessageBox.Show("insertar datos o no existe el dato a eliminar");
            }
            //borramos la consola
            Console.Clear();

            //borramos los textBox
            borrarTxtBox();

            //llamamos a consola par mostrar la lista nueva
            consola();

            //bloqueamos el boton de eliminar
            BtEliminar.Enabled = false;

        }

        private void BtMayor_Click(object sender, EventArgs e) {
            //borramos los textBox
            //por si existe algun datos escrito
            borrarTxtBox();

            posicionMaxMin = 0;
            int Mayor = 0;
            for (int i = 0; i <= ultimoElemento; i++) {
                if (Mayor < Edad[i]) {
                    Mayor = Edad[i];
                    posicionMaxMin = i;
                }
            }

            //mostraremos el mayor en los textBox
            mostrarTexBox(posicionMaxMin);
        }

        private void Menor_Click(object sender, EventArgs e) {
            //borramos los textBox
            //por si existe algun datos escrito
            borrarTxtBox();

            posicionMaxMin = 0;
            int Menor = Edad[0];
            for (int i = 0; i <= ultimoElemento; i++) {
                /*verificamos si el valor de array en posicion i
                es menor que el valor de la varible menor
                */
                if (Menor < Edad[i]) {
                    Menor = Edad[i];
                    posicionMaxMin = i;
                }
            }

            //mostraremos el mayor en los textBox
            mostrarTexBox(posicionMaxMin);
        }

        private void BtVolver_Click(object sender, EventArgs e) {
            Console.Clear();
            Inicio frm = new Inicio();
            this.Close();
            frm.Show();
        }

        public int bloquear_botones() {
            BtBuscar.Enabled = false;
            BtEliminar.Enabled = false;
            BtMayor.Enabled = false;
            BtMostrar.Enabled = false;
            Menor.Enabled = false;
            return 0;
        }

        public int habilitar_botones() {
            BtBuscar.Enabled = true;
            BtEliminar.Enabled = true;
            BtMayor.Enabled = true;
            BtMostrar.Enabled = true;
            Menor.Enabled = true;
            return 0;
        }
        public int borrarTxtBox() {
            TxtCi.Clear();
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtEdad.Clear();
            TxtDireccion.Clear();
            return 0;
        }

        private void mostrarTexBox(int pos) {
            TxtCi.Text = Convert.ToString(CI[pos]);
            TxtNombre.Text = Convert.ToString(nombres[pos]);
            TxtApellido.Text = Convert.ToString(apellido[pos]);
            TxtEdad.Text = Convert.ToString(Edad[pos]);
            TxtDireccion.Text = Convert.ToString(Direccion[pos]);
        }

        private int consola() {
            //limpiamos consola
            Console.Clear();

            //declaramos la posicion
            int student = 1;
            if (ultimoElemento >= 0) {
                for (int i = 0; i <= ultimoElemento; i++) {
                    Console.WriteLine("estudiante # " + student);
                    Console.WriteLine(CI[i]);
                    Console.WriteLine(nombres[i]);
                    Console.WriteLine(apellido[i]);
                    Console.WriteLine(Edad[i]);
                    Console.WriteLine(Direccion[i]);
                    Console.WriteLine("-----------------------");

                    //incrementamos en 1 al numero de lista del estudnate
                    student++;
                }

            } else {
                MessageBox.Show("insertar datos");
                bloquear_botones();
            }
            //borramos los textBox
            borrarTxtBox();

            return 0;
        }
    }
}
