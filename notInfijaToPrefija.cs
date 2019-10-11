namespace notInfijaToPrefija
{
    public class notInfToPref
    {
        public static string ecInfToPre(string infijo)
        {
            //Inicializamos nuestra pila p1 con el resultado de la funcion conversor
            //de infijo a prefijo
            Pila p1 = InfToPreConv(infijo);

            //Creamos una cadena que estará vacia, a esta le meteremos los datos
            //reordenados de la pila
            string text = "";
            while (p1.i > 0)
            {
                text += p1.pop();
            }

            //Retornamos la cadena ya con la expresion reordenada
            return text;
        }

        public static Pila InfToPreConv(string infijo)
        {
            infijo = '(' + infijo;
            int size = infijo.Length;
            Pila PilasDefinitiva = new Pila(size);
            Pila PilasTemp = new Pila(size);
            PilasTemp.push(')');
            for (int i = size - 1; i > -1; i--)
            {
                char caracter = infijo[i];
                switch (caracter)
                {
                    case ')':
                        PilasTemp.push(caracter);
                        break;
                    case '+':
                    case '-':
                    case '^':
                    case '*':
                    case '/':
                        while (Jerarquia(caracter) > Jerarquia(PilasTemp.nextPop()))
                            PilasDefinitiva.push(PilasTemp.pop());
                        PilasTemp.push(caracter);
                        break;
                    case '(':
                        while (PilasTemp.nextPop() != ')')
                            PilasDefinitiva.push(PilasTemp.pop());
                        PilasTemp.pop();
                        break;
                    default:
                        PilasDefinitiva.push(caracter);
                        break;
                }
            }
            return PilasDefinitiva;
        }

        public static int Jerarquia(char elemento)
        {
            int res = 0;
            switch (elemento)
            {
                case ')':
                    res = 5; break;
                case '^':
                    res = 4; break;
                case '*':
                case '/':
                    res = 3; break;
                case '+':
                case '-':
                    res = 2; break;
                case '(':
                    res = 1; break;
            }
            return res;
        }
    }
}