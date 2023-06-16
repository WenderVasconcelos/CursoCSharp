using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento com uma nota de 1 a 5:");
            int.TryParse(Console.ReadLine(), out int nota);

            if (nota > 5 || nota < 1)
            {
                Console.WriteLine("Nota incorreta, informe uma nota de 1 a 5, te orienta!");
                return;
            }

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Nota inválida!");
                    break;
                case 1:
                    Console.WriteLine("Ruim");
                    break;
                case 2:
                    Console.WriteLine("Regular");
                    break;
                case 3:
                    Console.WriteLine("Mediana");
                    break;
                case 4:
                    Console.WriteLine("Boa");
                    break;
                case 5:
                    Console.WriteLine("Ótima");
                    break;

            }
        }
    }
}
