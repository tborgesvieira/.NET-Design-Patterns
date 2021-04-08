using System;

namespace DP.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Opcoes();
        }
        
        private static void OpcaoSelecionada()
        {
            var operacao = Console.ReadKey().KeyChar.ToString().ToUpper();

            switch (operacao)
            {
                case "S":
                    Console.Clear();                    
                    break;
                case "1":
                    _ = new CreationalPatterns.CreationalPatterns();
                    Console.Clear();
                    Opcoes();
                    break;
                default:
                    OperacaoInvalida();
                    break;
            }
        }

        private static void OperacaoInvalida()
        {
            Console.Clear();
            Console.WriteLine("Opção selecionada é inválida!");
            Console.WriteLine("");
            Opcoes();            
        }

        private static void Opcoes()
        {
            Console.WriteLine("Selecione o padrão:");
            Console.WriteLine("");
            Console.WriteLine("1 - Creational Patterns (Padrões de criação)");
            Console.WriteLine("S - Sair");
            OpcaoSelecionada();
        }
    }
}
