using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Dynamic
    {
        public static void Executar()
        {
            dynamic obj = "teste";
            obj = 3;

            obj++;

            Console.WriteLine(obj);

            dynamic a = new System.Dynamic.ExpandoObject();
            a.Nome = "DOWNY";
            a.Nota = 8.2;
            a.Idade = 24;

            Console.WriteLine($"{a.Nome} {a.Nota} {a.Idade}");
        }
    }
}
