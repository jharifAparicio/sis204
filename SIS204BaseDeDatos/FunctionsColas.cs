using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SIS204BaseDeDatos {
    public class FunctionsColas {
        //creamos  los elementos necesarios
        public string[] elements = new string[50];
        public int ultimateElement;
        public int PrimaryElement;
        public int MaxElements = 50;

        //Variable que guardara la varible a eliminar
        string ultimateE = "";
        string primaryE = "";

        //creamos el costructor
        public FunctionsColas() {
            ultimateElement = -1;
            PrimaryElement = -1;
        }
        //se verifica si el array de elementos esta llena o vacia
        public bool EmptyCs() {
            if (ultimateElement == -1) {
                return true;
            } else {
                return false;
            }
        }

        //estas son funciones que se usaran en las colas simples
        public bool FullCs() {
            if (ultimateElement == MaxElements - 1) {
                return true;
            } else {
                return false;
            }
        }

        public void insertElementsCs(string insert) {
            if (FullCs()) {
                MessageBox.Show("Error: La pila de elementos esta LLENA");
            } else {
                ultimateElement++;
                elements[ultimateElement] = insert;
            }
        }

        public string deleteElementsCs() {

            string ultimateE = elements[0];

            if (EmptyCs()) {
                MessageBox.Show("Error: la pila esta vacia");
            } else {
                ultimateElement--;
                for (int i = 0; i <= ultimateElement; i++) {
                    elements[i] = elements[i + 1];
                }
            }
            return ultimateE;
        }

        //funciones que se usara en Colas circulares

        //Funcion Vacía: logico
        //inicio
        //sif Ultimo = 0 and primero = 0 entonces Vacía = cierto
        //sino
        //Vacía = Falso
        //fin

        public bool EmptyCc() {
            if (ultimateElement == -1 && PrimaryElement == -1) {
                return true;
            } else {
                return false;
            }
        }

        //        Funcion Llena: logico
        //iniciar
        //si(Ultimo= MaxCola) y(Primero= 1)) O
        //(Ultimo+1=Primero) entonces Llena = cierto
        //sino
        //Llena = Falso
        //fin

        public bool FullCc() {
            if ((ultimateE.Equals(MaxElements) && PrimaryElement == 1) ||
                (ultimateE + 1).Equals(PrimaryElement)) {
                return true;
            } else {
                return false;
            }
        }

        //Proceso Insert(elem: tipo-elem )
        //inicio
        //si LLena entonces ‘Cola Llena’
        //sino
        //hacer
        //si ultimo = Maxcola entonces
        // ultimo = 1
        // sino inc(último )
        //info[ultimo]=x
        //si primero=0 entonces Primero:=1
        //fin hacer
        //fin

        public void insertElementsCc(string insert) {
            if (FullCc()) {
                MessageBox.Show("Error: La pila de elementos esta LLENA");
            } else {
                if (ultimateElement.Equals(MaxElements - 1)) {
                    ultimateElement = 0;
                } else {
                    ultimateElement++;
                    elements[ultimateElement] = insert;
                }
            }
        }

        //Funcion Eliminar(elem: tipo-elem )
        //inicio
        //si Vacia entonces ‘Cola Vacía
        //sino
        //hacer
        //Eliminar= info[primero]
        //si primero=ultimo entonces
        // primero=0
        // ultimo=0
        //sino
        //si primero=maxcola entonces primero=1
        //sino primero = primero + 1
        //fin

        public string deleteElementsCc() {

            ultimateE = elements[PrimaryElement];
            if (EmptyCc()) {
                MessageBox.Show("Error: Pila esta LLENA");
            } else {
                elements[PrimaryElement] = "";
                if (PrimaryElement.Equals(ultimateElement)) {
                    PrimaryElement = -1;
                    ultimateElement = 1;
                } else {
                    if (PrimaryElement.Equals(MaxElements)) {
                        PrimaryElement = 0;
                    } else {
                        PrimaryElement++;
                    }
                }
            }
            return ultimateE;
        }

        //añdiremos las funciones que faltan para las Decolas o BiColas

        //Proceso InsertarDelante(x:tipoinfo)
        //inicio
        //si llena entonces ERROR,cola llena
        //sino
        //hacer
        //Inc(ultimo)
        //Desde i:=último-1 hasta 1 do
        //info[I + 1]=info[I]
        //info[ultimo] = x;
        //fin hacer
        //fin

        public void InsertElementsCd(string insert) {
            if (FullCs()) {
                MessageBox.Show("Error: Cola LLENA");
            } else {
                ultimateElement++;
                for (int i = ultimateElement - 1; i >= 0; i--) {
                    elements[i + 1] = elements[i];
                }
                elements[0] = insert;
            }
        }

        //Función EliminarAtrás: Tipoinfo
        //inicio
        //si vacía(Q) entonces Error, cola vacía
        //sino
        //hacer
        //Eliminar = info[ultimo]
        //Dec(Ultimo)
        //Fin hacer
        //fin;

        public string deleteElementsCd() {
            if (EmptyCs()) {
                MessageBox.Show("Error: Cola VACIA");
            } else {
                elements[ultimateElement] = "";
                ultimateElement--;
            }
            return primaryE;
        }
        //esta funcion se usara en cuanquiera de los 3 tipos de colas
        //Simple, Circular y Decola
        public int ReturnBegin() {
            Colas colas = new Colas();
            colas.Show();
            return 0;
        }
    }
}
