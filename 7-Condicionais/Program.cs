using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");

            int idadeJoao = 16;
			int quantidadedePessoas = 2;
            
            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade!");
            }
            else
            {
                if (quantidadedePessoas >= 2)
                {
                    Console.WriteLine("João NÃO possui mais de 18 anos de idade mas está acompanhado, pode entrar!");
                }
                else
                {
                    Console.WriteLine("João NÃO possui mais de 18 anos de idade e NÃO está acompanhado!");
                }
               
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
