using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperacoesRelacionais
    {
        public static void Executar() 
        {
            //double nota = 6.0;
            Console.Write("Digite a sua nota (de 1 a 10): ");
            double.TryParse(Console.ReadLine(), out double nota);
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota Invalida? {nota > 10.0}");
            Console.WriteLine($"Nota Invalida? {nota < 0.0}");
            Console.WriteLine($"Perfeito? {nota == 10.0}");
            Console.WriteLine($"Tem como melhorar? {nota != 10.0}");
            Console.WriteLine($"Passou por média? {nota >= notaDeCorte}");
            Console.WriteLine($"Ficou em recuperação? {nota < notaDeCorte}");
            Console.WriteLine($"Reprovou? {nota <= notaDeCorte}");
        }
    }
}
