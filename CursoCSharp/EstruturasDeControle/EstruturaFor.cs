﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine($"O valor de i é {i}.");
            //    i ++;
            //}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"O valor de i é {i}.");
            //}

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine($"Informe a nota do aluno {1}: ");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;

            }

            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine($"A Média da turma é: {media}");

        }
    }
}
