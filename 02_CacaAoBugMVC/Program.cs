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
            Console.WriteLine("*** Passsagem de Parâmetro por Valor ***");
            //Passa o conteúdo da variavel de Origem para a variavel de Destino.
            //O método de destino não altera o valor de variavel do método de origem.
            double valor = 10;
            if (PassagemParametroValor(valor))
                Console.WriteLine($"Valor de método Main-> PassagemParametroValor {valor}");

            Console.WriteLine("\n\n*** Passagem de Parametro por Referencia REF ***");
            //Passa o endereço da mémoria da variavel de origem para a variavel de Destino.
            //A variavel de origem pode estar inicializada.
            //O método de destino pode alterar o valor da variavel do método de origem.
            double valor1 = 10;
            if (PassagemParametroReferenciaRef(ref valor1))
            {
                Console.WriteLine($"Valor do método Main PassagemParametroReferenciaRef {valor1}");
            }

            Console.WriteLine("\n\n*** Passagem de Parametro por Referencia OUT ***");
            //Passa o endereço da mémoria da variavel de origem para a variavel de Destino.
            //A variavel de origem não pode estar inicializada.
            //O método de destino deve inicializar a variável do metodo de origem.
            //O método de destino pode alterar o valor da variavel do método de origem.
            double valor2;
            if (PassagemParametroReferenciaOut(out valor2))
            {
                Console.WriteLine($"Valor do método Main PassagemParametroReferenciaOut {valor2}");
            }

            Console.WriteLine("\n\n*** Passagem de Parametro por Referencia IN ***");
            //Passa o endereço da mémoria da variavel de origem para a variavel de Destino.
            //A variavel de origem deve estar inicializada.
            //O método de destino não deve alterar o valor da varíavel do método de origem.
            double valor3 = 100;
            if (PassagemParametroReferenciaIn(in valor3))
            {
                Console.WriteLine($"Valor do método Main PassagemParametroReferenciaIn {valor3}");
            }
        }

        public static bool PassagemParametroValor(double valor)
        {
            valor = valor * 10;
            Console.WriteLine($"valor do método PassagemParametroValor {valor}");
            return true;
        }

        public static bool PassagemParametroReferenciaRef(ref double valor1)
        {
            valor1 = 10;
            valor1 = valor1 * 10;
            Console.WriteLine($"Valor de método PassagemParametroReferenciaRef {valor1}");
            return true;
        }

        public static bool PassagemParametroReferenciaOut(out double valor2)
        {
            valor2 = 10;
            valor2 = valor2 * 10;
            Console.WriteLine($"Valor de método PassagemParametroReferenciaOut {valor2}");
            return true;
        }

        public static bool PassagemParametroReferenciaIn(in double valor3)
        {
            Console.WriteLine($"Valor de método PassagemParametroReferenciaIn {valor3}");
            return true;
        }
    }
}
