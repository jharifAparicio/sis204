namespace SIS204BaseDeDatos {
    class Lista {
        private Nodo Primary = new Nodo(); //primero
        private Nodo Last = new Nodo(); //ultimo
        private Nodo Current = new Nodo(); //actual
        private Nodo previous = new Nodo(); //anterior

        int pos = 0;
        public Lista() {
            Primary = null;
            Last = null;
        }

        public void insertNodo(int insert) {
            Nodo New = new Nodo();

            // dato  del nuevo nodo
            New.Date = insert;

            if (Primary == null) {
                Primary = New;
                Primary.Next = null;
                Last = New;
            } else {
                Last.Next = New;
                New.Next = null;
                Last = New;
            }
            //MessageBox.Show("nodo insertado");
        }

        //desplegar
        public bool Empty() {
            Current = Primary;
            if (Primary == null) {
                //no hay nodos en la lista
                Console.WriteLine("lista vacia");
                return true;
            } else {
                return false;
            }
        }

        public void search(int Sought, ref int posicion, ref bool existe) {
            if (Empty() == false) {
                pos = 0;
                Current = Primary;
                bool Found = false; //indica si fue encontrado
                int nodeSearched = Sought;

                //hay nodos en la lista
                while (Current != null && Found != true) {
                    if (Current.Date == nodeSearched) {
                        Found = true;
                        posicion = pos;
                        existe = Found;
                    } else {
                        Current = Current.Next;
                        pos++;
                    }
                }
            }
        }

        public void modify(int serch, int dateModify) {
            //int pos = 0;
            Current = Primary;
            bool Found = false; //indica si fue encontrado

            int nodeSearched = serch;

            if (Empty().Equals(false)) {
                //hay nodos en la lista
                while (Current != null && Found != true) {
                    if (Current.Date == nodeSearched) {
                        // MessageBox.Show("nodo encontrado insertar nuevo dato");
                        Current.Date = dateModify;
                        Found = true;

                    } else {
                        Current = Current.Next;
                    }
                    //pos++;
                    //Posicion = pos;

                }
            }
        }

        public void delete(int Delete, ref bool found) {
            ///pos = 0;
            bool Found = false;
            if (Primary != null) {

                Current = Primary;
                previous = null;

                //hay nodos en la lista
                while (Current != null && Found != true) {

                    if (Current.Date == Delete) {
                        if (Current == Primary) {
                            Current = Current.Next;

                        } else if (Current == Last) {
                            Last.Next = null;
                        } else {
                            Last.Next = Current.Next;
                        }
                        Found = true;
                        found = Found;
                    } else {
                        Current = Current.Next;
                        // pos++;
                    }

                }
            }
        }

        public int retornar() {
            ListasEnlazadas inicio = new ListasEnlazadas();
            inicio.Show();
            return 0;
        }
    }
}
