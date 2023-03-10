using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS204BaseDeDatos {
    class NodoLDE {
        private int dato;
        private NodoLDE? siguiente;
        private NodoLDE? atras;

        public int Dato {
            get {
                return dato;
            }
            set {
                dato = value;
            }
        }

        public NodoLDE? Siguiente {
            get {
                return siguiente;
            }
            set {
                siguiente = value!;
            }
        }

        public NodoLDE? Atras {
            get {
                return atras;
            }
            set {
                atras = value!;
            }
        }
    }
}
