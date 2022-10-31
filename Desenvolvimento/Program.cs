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

            string[] aulas = new string[] {
                aulaDeIntroducao,
                aulaModelando,
                aulaConfiguração
            };

            string[] aulas2 = new string[3];
            aulas2[0] = aulaDeIntroducao;
            aulas2[1] = aulaModelando;
            aulas2[2] = aulaConfiguração;

            foreach (var aula in aulas2)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
