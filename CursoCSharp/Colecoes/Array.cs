using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "LOUISE";
            alunos[1] = "WENDER";
            alunos[2] = "FLORISBELA";
            alunos[3] = "RIANDERSON";
            alunos[4] = "EINSTEIN";

            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8, 8.4, 8.2, 6.8 };
            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            //for (int i = 0; i < notas.Length; i++)
            //{
            //    Console.WriteLine("FOR " + notas[i]);
            //}
            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'B', 'C', 'D', 'E' };
            foreach(char letra in letras)
            {
                Console.WriteLine(letra);
            }
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
