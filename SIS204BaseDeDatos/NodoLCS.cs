using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS204BaseDeDatos {
    class NodoLCS {
        private int Dato;
        private NodoLCS? Siguiente;

        public int dato {
            get {
                return Dato;
            }
            set {
                Dato = value;
            }
        }

        public NodoLCS? siguente {
            get {
                return Siguiente;
            }
            set {
                Siguiente = value;
            }
        }
    }
}
