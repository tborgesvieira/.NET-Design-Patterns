using DP.Helpers;
using System;

namespace DP.StructuralPatterns
{
    public class StructuralPatterns
    {
        public static void Executar()
        {
            Console.Clear();
            Opcoes();
            var opcao = Console.ReadKey().KeyChar.ToString().ToUpper();
            Executar(opcao);
        }

        private static void Executar(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    Adapter.Adapter.Executar();
                    break;

                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                    Console.WriteLine("\nAinda não implementado, pressione uma tecla para continuar...\n");
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
                "Structural Pattern",
                "São padrões que facilitam o design, identificando uma maneira simples de realizar\nrelacionamentos entre entidades.");

            Console.WriteLine("---------------------------");
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Adapter");
            Console.WriteLine("2 - Bridge");
            Console.WriteLine("3 - Composite");
            Console.WriteLine("4 - Decorator");
            Console.WriteLine("5 - Facade");
            Console.WriteLine("6 - Flyweight");
            Console.WriteLine("7 - Proxy");
            Console.WriteLine("\nS - Sair");
            Console.WriteLine("---------------------------");
        }
    }
}