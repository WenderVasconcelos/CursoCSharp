using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    internal class GetSet
    {
        public class Moto
        {
            private string Marca ;
            private string Modelo;
            private uint Cilindrada;

            //uint nao permite sinais neste caso é obrigatório informar o numero sem +-/* pois em caso contrario ele vai gerar um erro de compilação

            public Moto(string marca, string modelo, uint cilindrada)
            {
                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;

                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);
            }
            public Moto() 
            { 
            }
            public string GetMarca()
            {
                return Marca;
            }
            public void SetMarca(string marca)
            {
                Marca = marca;
            }
            public string GetModelo()
            {
                return Modelo;
            }
            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }
            public uint GetCilindrada()
            {
                return Cilindrada;
            }
            public void SetCilindrada(uint cilindrada)
            {
                //if (cilindrada > 0 && cilindrada < 5000) 
                //{
                //    Cilindrada = cilindrada;
                //}
                
                //TRANSFORMAR O VALOR NEGATIVO EM POSITIVO OU VICE E VERSA
                //Cilindrada = Math.Abs(cilindrada);

                Cilindrada = cilindrada;

            }
        }
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);

            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());
        }
    }
}
