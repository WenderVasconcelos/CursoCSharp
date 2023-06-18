using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            //DEFINE QUE SÓ PODEM SER INSERIDOS ELEMENTOS STRING NA FILA, ASSIM COMO PODE SER DEFINIDO QUAISQUER OUTRO TIPO.
            var fila = new Queue<string>();

            //ADICIONA ITENS À FILA
            fila.Enqueue("Wender");
            fila.Enqueue("Louise");
            fila.Enqueue("Isabel");

            //PEGA O PRIMEIRO ELEMENTO DA FILA SEM REMOVER
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count());

            //REMOVE O PRIMEIRO ELEMENTO DA FILA
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count());

            foreach (var item in fila)
            {
                Console.WriteLine(item);

            }
            // esse queue precisa do importe não generico de "using System.Collections;"
            //Nesse queue pode ser inserido mais de um tipo.
            var salada = new Queue();

            salada.Enqueue("Wender");
            salada.Enqueue(3);
            salada.Enqueue(true);
            salada.Enqueue(2.5);

            Console.WriteLine(salada.Contains("Wender"));

        }
    }
}
