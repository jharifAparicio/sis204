using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SIS204BaseDeDatos {
    class ListaLCS {
        private NodoLCS? primero = new NodoLCS();
        private NodoLCS? ultimo = new NodoLCS();

        public ListaLCS() {
            primero = null;
            ultimo = null;
        }

        public void insertar(int dato) {
            NodoLCS nuevo = new NodoLCS();
            nuevo.dato = dato;

            if (primero == null) {
                primero = nuevo;
                primero.siguente = primero;
                ultimo = primero;
            } else {
                ultimo!.siguente = nuevo;
                nuevo.siguente = primero;
                ultimo = nuevo;
            }
        }

        public void buscar(int dato, ref bool existe) {
            NodoLCS actual = new NodoLCS();
            actual = primero!;
            bool encontrado = false;
            int nodoBuscado = dato;

            if (actual != null) {
                do {
                    if (actual.dato == nodoBuscado) {
                        encontrado = true;
                    }
                    actual = actual.siguente!;
                } while (actual != primero && encontrado != true);
            }
            existe = encontrado;
        }

        public void modificar(int dato, ref bool existe, int modifica) {
            NodoLCS? actual = new NodoLCS();
            actual = primero!;
            bool encontrado = false;
            int nodoBuscado = dato;

            if (actual != null) {
                do {
                    if (actual.dato == nodoBuscado) {
                        actual.dato = modifica;
                        encontrado = true;
                    }
                    actual = actual.siguente!;
                } while (actual != primero && encontrado != true);
            }
            existe = encontrado;
        }

        public void eliminar(int dato, ref bool existe) {
            NodoLCS? actual = new NodoLCS();
            NodoLCS? anterior = new NodoLCS();
            anterior = null;
            actual = primero!;
            bool encontrado = false;
            int nodoBuscado = dato;

            if (actual != null) {
                do {
                    if (actual.dato == nodoBuscado) {
                        if (actual == primero) {
                            primero = primero.siguente;
                            ultimo!.siguente = primero;
                        } else if (actual == ultimo) {
                            anterior!.siguente = primero;
                            ultimo = anterior;
                        } else {
                            anterior!.siguente = actual.siguente;
                        }
                        encontrado = true;
                    }
                    anterior = actual;
                    actual = actual.siguente!;
                } while (actual != primero && encontrado != true);
            }
            existe = encontrado;
        }
    }
}
