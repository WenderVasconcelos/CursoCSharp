using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIF
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui um bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            if (entrada.ToLower() == "s")
                bomComportamento = true;

            if (nota >=9 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }
                
        }
    }
}
