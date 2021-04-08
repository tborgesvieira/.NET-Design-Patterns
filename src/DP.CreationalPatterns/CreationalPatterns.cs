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
                    break;
                case "2":
                    Builder.Builder.Executar();                    
                    break;
                case "3":
                    FactoryMethod.FactoryMethod.Executar();
                    break;
                case "4":
                    Prototype.Prototype.Executar();
                    break;
                case "S":
                    Console.Clear();
                    return;                                    
            }

            Executar();
        }

        private static void Opcoes()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Abstract Factory");
            Console.WriteLine("2 - Builder");
            Console.WriteLine("3 - Factory Method");
            Console.WriteLine("4 - Prototype");
            Console.WriteLine("\nS - Sair");
            Console.WriteLine("---------------------------");
        }
    }
}
