using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");

            int idadeJoao = 16;
            bool acompanhado = true;
            String mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
            }
            else
            {
                mensagemAdicional = "João NÃO está acompanhado!";
            }

            if (idadeJoao >= 18 && acompanhado)
            {
                Console.WriteLine("João PODE entrar!");
                Console.WriteLine(mensagemAdicional);
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
