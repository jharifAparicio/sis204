using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS204BaseDeDatos {
    internal class NodoLCD {
        private int Dato;
        private NodoLCD? Siguiente;
        private NodoLCD? Atras;

        public int dato {
            get {
                return Dato;
            }
            set {
                Dato = value;
            }
        }

        public NodoLCD? siguiente {
            get {
                return Siguiente;
            }
            set {
                Siguiente = value;
            }
        }

        public NodoLCD? atras {
            get {
                return Siguiente;
            }
            set {
                Siguiente = value;
            }
        }

    }
}
