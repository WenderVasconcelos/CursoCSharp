﻿using System;
using System.IO;

namespace CursoCSharp.API
{
    internal class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"~/source/repos/CursoCSharp/CursoCSharp".ParseHome();
            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

            Console.WriteLine("== Arquivos ==============");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos) 
            { 
                Console.WriteLine(arquivo); 
            }

            Console.WriteLine("\n== Diretorios ==============");
            var diretorios = dirInfo.GetDirectories();
            foreach (var diretorio in diretorios)
            {
                Console.WriteLine(diretorio);
            }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent);
        }
    }
}
