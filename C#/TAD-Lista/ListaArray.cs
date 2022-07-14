namespace Lista
{
    class ListaArray
    {
        private object[] lista;


        public ListaArray()
        {
            lista = new object[1];
        }

        public bool isEmpty()
        {
            return lista.Length == 0;
        }

        public int size()
        {
            return lista.Length;
        }

        public bool isFirst(object element)
        {
            if (isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return element == lista[0];
            }
        }

        public bool isLast(object element)
        {

            if (isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return element == lista[size() - 1];
            }

        }

        public object first()
        {
            if (isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return lista[1];
            }
        }

        public object last()
        {
            if (isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return lista[size() - 1];
            }
        }

        public object before(int pos)
        {
            if (pos > size() || pos <= 1 || isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return lista[pos - 2];
            }
        }

        public object after(int pos)
        {
            if (pos >= size() || pos < 1 || isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return lista[pos];
            }
        }

        public object elementAtRank(int rank)
        {
            if (rank >= size() || rank < 0 || isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                return lista[rank];
            }
        }


        public object removeAtRank(int rank)
        {
            if (rank >= size() || rank < 0 || isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                object element = lista[rank];
                for (int i = rank; i < size() - 1; i++)
                {
                    lista[i] = lista[i + 1];
                }
                lista[size() - 1] = null;
                return element;
            }
        }



        public void replaceAtRank(int rank, object element)
        {
            if (rank > size() || rank < 0 || isEmpty())
            {
                throw new listaException("Lista vazia");
            }
            else
            {
                if (lista.Length == size())
                {
                    increasseArray();
                }
                lista[rank] = element;
            }


        }




        private void increasseArray()
            {
                object[] newLista = new object[size() * 2];
                for (int i = 0; i < size(); i++)
                {
                    newLista[i] = lista[i];
                }
                lista = newLista;
            }

    }

}