using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    delegate double Operacao(double x, double y);
    internal class LambdaDelegate
    {        
        public static void Executar()
        {
            Operacao sum = (x ,y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao div = (x, y) => x / y;
            Operacao mul = (x, y) => x * y;

            Console.WriteLine(sum(3,3));
            Console.WriteLine(sub(3,3));
            Console.WriteLine(div(3,3));
            Console.WriteLine(mul(3,3));
        }
    }
}
