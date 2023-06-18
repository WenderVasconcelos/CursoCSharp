using CursoCSharp.ClassesEMetodos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesDictionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladioador");
            filmes.Add(2001, "Gladioador 1");
            filmes.Add(2002, "Gladioador 2");
            filmes.Add(2003, "Gladioador 3");

            if (filmes.ContainsKey(2003))
            {
                Console.WriteLine($"2003: {filmes[2003]}");
                Console.WriteLine($"2003: {filmes.GetValueOrDefault(2003)}");
            }

            Console.WriteLine(filmes.ContainsValue("CHIQUINHO"));
            Console.WriteLine($"Removeu? {filmes.Remove(2003)}");

            filmes.TryGetValue(2002, out string filme2002);
            Console.WriteLine($"Filme 2002? {filme2002}");

            foreach (var chaves in filmes.Keys) 
            {
                Console.WriteLine(chaves);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }

            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} - {filme.Key}");
            }
        }
    }
}
