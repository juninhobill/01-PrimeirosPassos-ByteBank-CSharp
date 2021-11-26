using System;

namespace AtribuicoesDeVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 6 - Atribuições e Variáveis");

            int idade = 32;
            int idadeGustavo = idade;

            idade = 20;

            Console.WriteLine("Idade é: " + idade);
            Console.WriteLine("Idade Gustavo é: " + idadeGustavo);

            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
