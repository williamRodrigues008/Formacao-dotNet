using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desenvolvimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aulaDeIntroducao = "Introdução à coleção";
            string aulaModelando = "Modelando tipos";
            string aulaConfiguração = "Trabalhando com 'Sets'";

            //string[] aulas = new string[] {
            //    aulaDeIntroducao,
            //    aulaModelando,
            //    aulaConfiguração
            //};

            //Console.WriteLine("O indice de Aula Modelando é o " + Array.IndexOf(aulas, aulaModelando));

            //string[] aulas2 = new string[3];
            //aulas2[0] = aulaDeIntroducao;
            //aulas2[1] = aulaModelando;
            //aulas2[2] = aulaConfiguração;

            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //List<string> listas = new List<string>
            //{
            //    aulaDeIntroducao,
            //    aulaModelando,
            //    aulaConfiguração
            //};

            List<string> listas = new List<string>();
            listas.Add(aulaDeIntroducao);
            listas.Add(aulaModelando);
            listas.Add(aulaConfiguração);
            
            ImprimirLista(listas);

        }

        private static void ImprimirLista(List<string> listas)
        {

            listas[0] = "Tipos de dados";

            Console.WriteLine("Primeira aula: " + listas.First());
            Console.WriteLine("Primeira aula contendo tipos: " + listas.FirstOrDefault(aula => aula.Contains("Tipos")));

            Console.WriteLine("Ultima aula: " + listas.Last());
            Console.WriteLine("Aulas contendo 'tipo', são ela(s): " + listas.LastOrDefault(aulas => aulas.Contains("tipos")));

            Console.WriteLine();
            Console.WriteLine();

            listas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
            Console.WriteLine();
        }
    }
}
