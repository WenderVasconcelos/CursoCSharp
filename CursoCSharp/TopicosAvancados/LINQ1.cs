using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    internal class LINQ1
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>()
            {
                new Aluno() {Nome = "Wender", Idade = 24, Nota = 10.0},
                new Aluno() {Nome = "Jaime", Idade = 22, Nota = 8.0},
                new Aluno() {Nome = "Junior", Idade = 21, Nota = 3.0}
            };

            Console.WriteLine("=====APROVADOS=====");

            var aprovados = alunos
                .Where(a => a.Nota >= 7)
                .OrderByDescending(a => a.Nome);

            foreach (var a in aprovados) 
            { 
                Console.WriteLine(a.Nome);
            }

            Console.WriteLine("===== CHAMADA =====");
            var chamada = alunos
                .OrderBy(a => a.Nome)
                .Select(a => a.Nome);

            foreach(var a in chamada)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("===== APROVADOS POR IDADE =====");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;
            foreach (var a in alunosAprovados)
            {
                Console.WriteLine(a);
            }
        }
    }
}

