using System;
using System.IO;

namespace CursoCSharp.API
{
    internal class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta".ParseHome();

            if (!File.Exists(arquivo)) 
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Um novo arquivo criado!");
                }
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));

        }
    }
}
