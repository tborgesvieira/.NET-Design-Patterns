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

    class AfricaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivoro() => new Leao();

        public override Herbivoro CriarHerbivoro() => new Gnu();
    }

    class AmericaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivoro() => new Lobo();

        public override Herbivoro CriarHerbivoro() => new Bufalo();
    }

    abstract class Herbivoro {}

    abstract class Carnivoro
    {
        public abstract void Come(Herbivoro h);
    }

    abstract class ContinenteFactory
    {
        public abstract Herbivoro CriarHerbivoro();
        public abstract Carnivoro CriarCarnivoro();
    }

    class Gnu : Herbivoro {}    

    class Leao : Carnivoro
    {
        public override void Come(Herbivoro h)
        {
            Console.WriteLine($"{this.GetType().Name} come {h.GetType().Name}");
        }
    }

    class Bufalo : Herbivoro { }

    class Lobo : Carnivoro
    {
        public override void Come(Herbivoro h)
        {
            Console.WriteLine($"{this.GetType().Name} come {h.GetType().Name}");
        }
    }

    class AnimaisDoMundo
    {
        private Herbivoro _herbivoro;
        private Carnivoro _carnivoro;

        public AnimaisDoMundo(ContinenteFactory factory)
        {
            _carnivoro = factory.CriarCarnivoro();
            _herbivoro = factory.CriarHerbivoro();
        }

        public void IniciarCadeiaAlimentar()
        {
            _carnivoro.Come(_herbivoro);
        }
    }
}
