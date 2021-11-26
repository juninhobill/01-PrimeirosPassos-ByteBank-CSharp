using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");

            int idadeJoao = 16;
            //int quantidadedePessoas = 2;
            //bool acompanhado = quantidadedePessoas >= 2;
            bool acompanhado = true;

            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("João PODE entrar!");
			}
            else
            {
                Console.WriteLine("João NÃO PODE entrar!");
            }

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
