using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Membros
    {
        public static void Executar ()
        {
            Pessoa sicrano = new Pessoa ();

            sicrano.Nome = "Renato";
            sicrano.Idade = 21;

            //Console.WriteLine($"{sicrano.Nome} tem {sicrano.Idade} anos.");

            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            var fulano = new Pessoa();
            fulano.Nome = "Wender";
            fulano.Idade = 25;

            var apresentacaoFulano = fulano.Apresentar();

            Console.WriteLine(apresentacaoFulano.Length);
            Console.WriteLine(apresentacaoFulano);


        }
    }
}
