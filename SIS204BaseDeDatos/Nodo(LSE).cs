using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS204BaseDeDatos {
    public class Nodo {
        private int date;
        private Nodo next;

        public int Date {
            get {
                return date;
            }
            set {
                date = value;
            }
        }

        public Nodo Next {
            get {
                return next;
            }
            set {
                next = value;
            }
        }
    }
}
