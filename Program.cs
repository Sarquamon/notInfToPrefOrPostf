using System;

namespace notInfijaToPrefija
{
    class Program
    {
        static void Main(string[] args)
        {
            notInfijaToPrefija hola = new notInfijaToPrefija();

            string expresion = "b-a";
            string ecuAPrefijo = Infijo2PrefijoTxt(expresion);

            System.Console.WriteLine("Esta es la ecuacion: " + ecuAPrefijo);
        }
    }
}
