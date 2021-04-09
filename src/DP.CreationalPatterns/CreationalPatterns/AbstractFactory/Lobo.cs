using System;

namespace DP.CreationalPatterns.CreationalPatterns.AbstractFactory
{
    class Lobo : Carnivoro
    {
        public override void Come(Herbivoro h)
        {
            Console.WriteLine($"{GetType().Name} come {h.GetType().Name}");
        }
    }
}
