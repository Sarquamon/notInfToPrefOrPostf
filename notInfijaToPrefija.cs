namespace notInfijaToPrefija
{
    public class notInfijaToPrefija
    {
        public static string Infijo2PrefijoTxt(string infijo)
        {
            Pila p1 = Infijo2Prefijo(infijo);
            string text = "";
            while (p1.i > 0)
            {
                text += p1.pop();
            }
            return text;

        }

        public static Pila Infijo2Prefijo(string infijo)
        {
            infijo = '(' + infijo; // Agregamos al final del infijo un ')'
            int tamaño = infijo.Length;
            Pila PilasDefinitiva = new Pila(tamaño);
            Pila PilasTemp = new Pila(tamaño);
            PilasTemp.push(')'); // Agregamos a la Pila temporal un '('
            for (int i = tamaño - 1; i > -1; i--)
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