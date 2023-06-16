using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadoraEstatica
    {
        public static int Multiplicar(int a, int b)//METODO DE CLASSE OU METODO DE ESTATICA
        {
            return a * b;
        }
        public int Somar(int a, int b) //METODO DE INSTANCIA
        {
            return a + b;
        }

    }
    internal class MetodosEstaticos
    {
        public static void Executar() 
        {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine($"Resultado: {resultado}");

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}
