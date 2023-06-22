using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.TopicosAvancados
{
    internal class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>()
            {
                new Aluno() {Nome = "Jaime", Idade = 22, Nota = 8.0},
                new Aluno() {Nome = "Wender", Idade = 24, Nota = 10.0},
                new Aluno() {Nome = "Junior", Idade = 21, Nota = 3.0},
                new Aluno() {Nome = "Joanesburgo", Idade = 25, Nota = 6.0},
                new Aluno() {Nome = "Salada", Idade = 26, Nota = 7.0},
                new Aluno() {Nome = "Fresno", Idade = 27, Nota = 4.0}
            };

            var wender = alunos.Single(a => a.Nome.Equals("Wender"));
            Console.WriteLine($"{wender.Nome} {wender.Nota}");

            var fulano = alunos.SingleOrDefault(a => a.Nome.Equals("Fulano"));
            if ( fulano == null )
            {
                Console.WriteLine("ALUNO INEXISTENTE");
            }

            var jaime = alunos.First(a => a.Nome.Equals("Jaime"));
            Console.WriteLine(jaime.Nota);

            var sicrano = alunos.FirstOrDefault(a => a.Nota.Equals("James"));
            
            if (sicrano == null)
            {
                Console.WriteLine("ALUNO INEXISTENTE");
            }

            Console.WriteLine("FUNÇÃO SKIP");

            var exemploSpkip = alunos.Skip(1).Take(3);
            foreach( var a  in exemploSpkip)
            {
                Console.WriteLine(a.Nome);
            }
        }
    }
}

