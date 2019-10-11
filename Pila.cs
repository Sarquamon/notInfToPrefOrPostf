namespace notInfijaToPrefija
{
    public class Pila
    {
        public int size;
        public char[] items;
        public int i;

        public Pila(int tamaño)
        {
            this.size = tamaño;
            this.items = new char[tamaño];
            this.i = 0;
        }
        public bool push(char item)
        {
            if (i < size)
            {
                items[i++] = item;
                return true;
            }

            return false;

        }
        public char pop()
        {
            if (i <= 0)
            {
                var a = '0';
                return a;
            }
            return items[--i];

        }
        public char nextPop()
        {
            if (i <= 0)
            {
                var a = '0';
                return a;
            }
            return items[i - 1];
        }
    }
}
