using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class Nullable
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;
            int? num2 = null;
            
            if (num1.HasValue)
            {
                Console.WriteLine($"valor de num1 é {num1}");
            }
            else
            {
                Console.WriteLine("A variavel não possui valor.");
            }

            int valor = num1 ?? 1000; //SE O VALOR DE NUM1 NÃO ESTIVER NULLO ELE VAI SETAR O VALOR PADRAO DEFINIDO, QUE É 1000
            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();
            Console.WriteLine(resultado);
        }
    }
}
