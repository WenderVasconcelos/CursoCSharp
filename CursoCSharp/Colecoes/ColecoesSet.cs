﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    internal class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Oitava temporada Game of Thrones", 99.9),
                new Produto("Blusa", 20),
                new Produto("Blusa", 20),
            };

            carrinho.UnionWith(combo);

            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach(var item in carrinho)
            {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");               
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            //Console.Write(carrinho.LastIndexOf(livro));
        }
    }
}