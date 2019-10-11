using notInfijaToPrefija;

class Program
{
    static void Main(string[] args)
    {
        string expresion = "b-a";
        string ecuAPrefijo = ecInfToPre(expresion);

        System.Console.WriteLine("Esta es la ecuacion: " + ecuAPrefijo);
    }
}