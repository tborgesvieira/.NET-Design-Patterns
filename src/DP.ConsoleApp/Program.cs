using System;
using System.Text;

namespace DP.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Projeto foi feito com base nos exemplos do site https://www.dofactory.com/net/design-patterns");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("");
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
                    CreationalPatterns.CreationalPatterns.Executar();
                    Console.Clear();
                    Opcoes();
                    break;

                case "2":
                    StructuralPatterns.StructuralPatterns.Executar();
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
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Para um melhor entendimento como sugestão utilizar o debug.");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Selecione o padrão:");
            Console.WriteLine("");
            Console.WriteLine("1 - Creational Patterns (Padrões de criação)");
            Console.WriteLine("2 - Structural Patterns (Design estrutural)");
            Console.WriteLine("\nS - Sair");
            Console.WriteLine("-----------------------------------------------------------");
            OpcaoSelecionada();
        }
    }
}