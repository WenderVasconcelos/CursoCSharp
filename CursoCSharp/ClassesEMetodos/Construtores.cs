using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro() { }
    }
    class Construtores
    {
        public static void Executar()
        {
            //PRIMEIRO CARRO UTILIZA O CONSTRUTOR PADRÃO DA LINHA 23
            var carro1 = new Carro();
            carro1.Modelo = "GOL";
            carro1.Fabricante = "VW";
            carro1.Ano = 1996;
            Console.WriteLine($"{carro1.Modelo} {carro1.Fabricante} {carro1.Ano}");

            //CARRO 2 UTILIZA O CONTRUTOR COM PARAMETROS SETADOS DA LINHA 15
            var carro2 = new Carro("Golf", "VW", 2014);
            Console.WriteLine($"{carro2.Modelo} {carro2.Fabricante} {carro2.Ano}");

            //CARRO 3 É UMA OUTRA FORMA DE PREENCHER OS PARAMETROS 
            var carro3 = new Carro()
            {
                Modelo = "Jetta",
                Fabricante = "VW",
                Ano = 2022
            };
            Console.WriteLine($"{carro3.Modelo} {carro3.Fabricante} {carro3.Ano}");
        }
    }
}
