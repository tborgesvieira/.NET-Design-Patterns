using System;

namespace DP.CreationalPatterns
{
    public class CreationalPatterns
    {
        public CreationalPatterns()
        {
            Console.Clear();
            Opcoes();
            var opcao = Console.ReadKey().ToString();
            Executar(opcao);
        }

        private void Executar(string opcao)
        {
            switch (opcao)
            {
                case "S":
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!");
                    Console.WriteLine();
                    Opcoes();
                    break;
            }
        }

        private void Opcoes()
        {            
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("S - Sair");
        }
    }
}
