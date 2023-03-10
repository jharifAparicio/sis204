using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS204BaseDeDatos {
    class ListaLCD {
        NodoLCD? primero = new NodoLCD();
        NodoLCD? ultimo = new NodoLCD();

        public ListaLCD() {
            primero = null;
            ultimo = null;
        }

        public void insertar(int elemento) {
            NodoLCD? nuevo = new NodoLCD();
            nuevo.dato = elemento;
            if (primero == null) {
                primero = nuevo;
                ultimo = nuevo;
                primero.siguiente = primero;
                primero.atras = ultimo;
            } else {
                ultimo!.siguiente = nuevo;
                nuevo.atras = ultimo;
                nuevo.siguiente = primero;
                ultimo = nuevo;
            }
            MessageBox.Show("inserción exitosa!!!");
        }

        public void buscar(int buscar, ref bool encontrado) {
            NodoLCD? actual = new NodoLCD();
            actual = primero;
            //bool Encontrado = false;
            //int buscado = buscar;
            if (actual != null) {
                do {
                    if (actual!.dato.Equals(buscar)) {
                        encontrado = true;
                    }
                    actual = actual!.siguiente;
                } while (actual != primero);
            }
        }

        public void modificar(int buscar, ref bool encontrado, int modifica) {
            NodoLCD? actual = new NodoLCD();
            actual = primero;
            //bool Encontrado = false;
            //int buscado = buscar;
            if (actual != null) {
                do {
                    if (actual!.dato.Equals(buscar)) {
                        actual.dato = modifica;
                        encontrado = true;
                    }
                    actual = actual!.siguiente;
                } while (actual != primero);
            }
        }

        public void eliminar(int eliminar, ref bool encontrado) {
            NodoLCD? actual = new NodoLCD();
            NodoLCD? anterior = new NodoLCD();
            actual = primero;
            anterior = null;
            //bool Encontrado = false;
            //int buscado = buscar;
            if (actual != null) {
                do {
                    if (actual!.dato.Equals(eliminar)) {
                        if (actual == primero) {
                            primero = primero.siguiente;
                            primero!.atras = ultimo;
                            ultimo!.siguiente = primero;
                        } else if (actual == ultimo) {
                            ultimo = anterior;
                            ultimo!.siguiente = primero;
                            primero!.atras = ultimo;
                        } else {
                            anterior!.siguiente = actual.siguiente;
                            actual.siguiente!.atras = anterior;

                        }
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual!.siguiente;
                } while (actual != primero);
            }
        }
    }
}
