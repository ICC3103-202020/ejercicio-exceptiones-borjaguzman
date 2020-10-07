using System;

namespace excepcion
{
    class Program

    {
        static void Main(string[] args)
        {
            calculadora funcion =  new calculadora();


            Console.WriteLine("ingrese un numero: ");
            string numerostr = Console.ReadLine();
            Console.WriteLine("ingrese un segundo numero");
            string numero2str = Console.ReadLine();
            funcion.multiplicacion(numerostr, numero2str);
        }
    }
}
