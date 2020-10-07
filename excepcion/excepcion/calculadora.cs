using System;
using System.Collections.Generic;
using System.Text;

namespace excepcion
{
    class calculadora
    {
        public void multiplicacion(string n1, string n2)
        {
            try
            {
                var numero = int.Parse(n1);
                var numero2 = int.Parse(n2);
                var resultado = numero * numero2;
                Console.WriteLine("la multiplicacion de {0} y {1} es {2}", numero, numero2, resultado);
            }
            catch (SoloNumerosEnteros e) 
            {
                Console.Write(e.Message);
                Console.WriteLine("los numeros que ingreso deben ser numeros enteros");
            }
        }

    }
}
