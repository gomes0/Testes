using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CacaAoBugMVC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 10;
            Console.WriteLine("*** Passsagem de Parâmetro por Valor ***");
            if (PassagemParametroValor(valor))
                Console.WriteLine($"Valor de método Main-> PassagemParametroValor {valor}");

            Console.WriteLine("\n\n*** Passagem de Parametro por Referencia REF ***");
            double valor1 = 10;
            if(PassagemParametroReferencia(ref valor))
            {
                Console.WriteLine($"Valor do método Main PassagemParametroReferenciaRef {valor1}");
            }
        }

        public static bool PassagemParametroValor(double valor)
        {
            valor = valor * 10;
            Console.WriteLine($"valor do método PassagemParametroValor {valor}");
            return true;
        }

        public static bool PassagemParametroReferencia( ref double valor1)
        {
            valor1 = valor1 * 10;
            Console.WriteLine($"Valor de método PassagemParametroReferencia {valor1}");
            return true;
        }
    }
}
