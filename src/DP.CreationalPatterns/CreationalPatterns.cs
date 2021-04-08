using System;

namespace DP.CreationalPatterns
{
    public class CreationalPatterns
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
                    AbstractFactory.AbstractFactory.Executar();
                    Executar();
                    break;
                case "S":
                    Console.Clear();
                    break;
                default:                    
                    Executar();
                    break;
            }
        }

        private static void Opcoes()
        {            
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("S - Sair");
        }
    }
}
