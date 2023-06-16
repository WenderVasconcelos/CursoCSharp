using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIfElseIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Quadro de honra!");
            }
            else if (nota >= 7.0)
            {
                Console.WriteLine("Parabéns brother, voce está aprovado!");
            } 
            else if (nota >= 5.0)
            {
                Console.WriteLine("Ih Brother, tu ta em recuperação");
            }
            else
            {
                Console.WriteLine("Vai estudar, BURRO!");
            }

            Console.WriteLine("The End!");
        }
    }
}
