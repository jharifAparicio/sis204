using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SIS204BaseDeDatos {
    class ListaLDE {
        public NodoLDE? primero = new NodoLDE();
        public NodoLDE? ultimo = new NodoLDE();

        public ListaLDE() {
            primero = null;
            ultimo = null;
        }

        public void insertarNodo(int dato) {
            NodoLDE nuevo = new NodoLDE();
            nuevo.Dato = dato;

            if (primero == null) {
                primero = nuevo;
                primero.Siguiente = null;
                primero.Atras = null;
                ultimo = primero;
            } else {
                ultimo!.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Atras = ultimo;
                ultimo = nuevo;
            }
        }

        public void buscar(int dato, ref bool existe) {
            NodoLDE actual = new NodoLDE();
            actual = primero!;
            bool encantrado = false;
            int nodoBuscado = dato;
            while (actual != null && encantrado == false) {
                if (actual.Dato == nodoBuscado) {
                    encantrado = true;
                } else {
                    actual = actual.Siguiente!;
                }
            }
            existe = encantrado;
        }

        public void modificar(int dato, ref bool existe, int modificado) {
            NodoLDE actual = new NodoLDE();
            actual = primero!;
            bool encantrado = false;
            int nodoBuscado = dato;
            while (actual != null && encantrado == false) {
                if (actual.Dato == nodoBuscado) {
                    actual.Dato = modificado;
                    encantrado = true;
                } else {
                    actual = actual.Siguiente!;
                }
            }
            existe = encantrado;
        }

        public void eliminar(int dato, ref bool existe) {
            NodoLDE actual = new NodoLDE();
            NodoLDE? anterior = new NodoLDE();
            anterior = null;
            actual = primero!;
            bool encontrado = false;
            int nodoBuscado = dato;
            while (actual != null && encontrado == false) {
                if (actual.Dato == nodoBuscado) {
                    if (actual == primero) {
                        primero = primero.Siguiente;
                        if (!(primero == null)) {
                            primero.Atras = null;
                        }
                        //primero!.Atras = null;
                    } else if (actual == ultimo) {
                        anterior!.Siguiente = null;
                        ultimo = anterior;
                    } else {
                        anterior!.Siguiente = actual.Siguiente;
                        actual.Siguiente!.Atras = anterior;
                    }
                    encontrado = true;
                }
                anterior = actual;
                actual = actual.Siguiente!;
            }
            existe = encontrado;
        }
    }
}