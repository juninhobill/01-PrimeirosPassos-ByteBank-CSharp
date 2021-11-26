using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Coversoes e outros tipos numéricos");

            double salario;
            salario = 1200.70;

            //O int é uma variável que suporta valores até 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine("O salário é de: " + salarioEmInteiro);

            //O long é uma variável de 64 bits
            long idade = 13000000000000;
            Console.WriteLine("A idade é de: " + idade);

            //O short é uma variável de 16 bits
            short quantidadeProdutos = 150;
            Console.WriteLine("A quantidade de produtos é de: " + quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine("A altura é de: " + altura);

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
