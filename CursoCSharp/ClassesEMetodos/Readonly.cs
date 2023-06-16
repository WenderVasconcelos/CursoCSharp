using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Readonly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento;

            public Cliente (string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }

            public string GetDataDeNascimento()
            {
                return String.Format($"{Nascimento.Day:D2}/{Nascimento.Month:D2}/{Nascimento.Year}");
            }
        }
        public static void Executar()
        {
            var novoCliente = new Cliente("Wender Lima", new DateTime(1998, 2, 20));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}
