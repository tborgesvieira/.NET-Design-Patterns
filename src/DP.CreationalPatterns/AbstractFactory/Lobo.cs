using System;

namespace DP.CreationalPatterns.AbstractFactory
{
    internal class Lobo : Carnivoro
    {
        public override void Come(Herbivoro h)
        {
            Console.WriteLine($"{GetType().Name} come {h.GetType().Name}");
        }
    }
}