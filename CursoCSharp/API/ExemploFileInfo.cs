using System;
using System.IO;

namespace CursoCSharp.API
{
    internal class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var cam in caminhos)
            {
                FileInfo fi = new FileInfo(cam);

                if (fi.Exists)
                {
                    fi.Delete();
                    Console.WriteLine($"Arquivo {fi.Name} Excluido! ");
                }
            }
        }
        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo original de teste!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
