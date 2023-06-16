using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ValorVsReferencia
    {
        public class Dependente
        {
            public string Nome;
            public int Idade;
        }
        public static void Executar()
        {
            int numero = 3;
            int copiarNumero = numero;
            Console.WriteLine($"{numero} {copiarNumero}");
            numero++;
            Console.WriteLine($"{numero} {copiarNumero}");

            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} - {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} - {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            copiaDep.Idade = 21;

            Console.WriteLine($"{dep.Nome} - {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} - {copiaDep.Idade}");
        }
    }
}
