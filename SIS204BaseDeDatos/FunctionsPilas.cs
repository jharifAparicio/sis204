using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace SIS204BaseDeDatos {
    public class FunctionsPilas {

        public string[] Elements = new string[50];
        public int ultimateElements;
        public int MaxElements = 50;
        public int Element;

        public FunctionsPilas() {
            ultimateElements = -1;
        }

        public bool Empty() {
            if (ultimateElements == -1) {
                return true;
            } else {
                return false;
            }
        }

        public bool Full() {
            if (ultimateElements == MaxElements - 1) {
                return true;
            } else {
                return false;
            }
        }

        public void InsertElement(string insert) {
            if (Full()) {
                MessageBox.Show("Error: La pila de elementos esta LLENA");
            } else {
                ultimateElements++;
                Elements[ultimateElements] = insert;
            }
        }

        public string Delete() {
            string valor = " ";
            if (Empty()) {
                MessageBox.Show("Error: La pila de elementos esta VACIA");
            } else {
                valor = Elements[ultimateElements];
                ultimateElements--;
            }
            return valor;
        }


    }
}
