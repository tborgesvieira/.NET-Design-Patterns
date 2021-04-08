using DP.Helpers;
using System;

namespace DP.CreationalPatterns.AbstractFactory
{
    public static class AbstractFactory
    {
        public static void Executar()
        {
            CabecalhoHelper.GerarCabecalho(
                "Creational Patterns", 
                "Abstract Factory", 
                5, 
                "Fornece uma interface para a criação de famílias de objetos relacionados ou dependentes sem especificar suas classes concretas");

            ContinenteFactory africa = new AfricaFactory();

            ContinenteFactory america = new AmericaFactory();

            var animaisDoMundo = new AnimaisDoMundo(africa);
            animaisDoMundo.IniciarCadeiaAlimentar();

            animaisDoMundo = new AnimaisDoMundo(america);
            animaisDoMundo.IniciarCadeiaAlimentar();

            Console.WriteLine("");
            Console.WriteLine("Pressione uma tecla para sair!");
            Console.ReadKey();
        }
    }
}
