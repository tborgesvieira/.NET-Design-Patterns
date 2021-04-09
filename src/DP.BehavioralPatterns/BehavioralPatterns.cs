using DP.Helpers;
using System;

namespace DP.BehavioralPatterns
{
    public static class BehavioralPatterns
    {
        public static void Executar()
        {
            Console.Clear();
            Opcoes();
            var opcao = Console.ReadLine().ToUpper();
            Executar(opcao);
        }

        private static void Executar(string opcao)
        {
            switch (opcao)
            {
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "11":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nAinda não implementado, pressione uma tecla para continuar...\n");
                    Console.ResetColor();
                    Console.ReadKey();
                    break;

                case "S":
                    Console.Clear();
                    return;
            }

            Executar();
        }

        private static void Opcoes()
        {
            CabecalhoHelper.GerarCabecalho(
                "Behavioral Patterns",
                "São padrões que identificam padrões de comunicação comuns entre objetos.\nAo fazer isso, esses padrões aumentam a flexibilidade na realização da comunicação.");

            Console.WriteLine("---------------------------");
            Console.WriteLine("Informe uma opção e de enter");
            Console.WriteLine("1 - Chain of Responsibility");
            Console.WriteLine("2 - Command");
            Console.WriteLine("3 - Interpreter");
            Console.WriteLine("4 - Iterator");
            Console.WriteLine("5 - Mediator");
            Console.WriteLine("6 - Memento");
            Console.WriteLine("7 - Observer");
            Console.WriteLine("8 - State");
            Console.WriteLine("9 - Strategy");
            Console.WriteLine("10 - Template Method");
            Console.WriteLine("11 - Visitor");
            Console.WriteLine("\nS - Sair");
            Console.WriteLine("---------------------------");
        }
    }
}
