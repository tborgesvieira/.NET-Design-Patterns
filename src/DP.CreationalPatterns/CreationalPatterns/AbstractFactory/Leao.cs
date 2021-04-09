using System;

namespace DP.CreationalPatterns.CreationalPatterns.AbstractFactory
{
    class Leao : Carnivoro
    {
        public override void Come(Herbivoro h)
        {
            Console.WriteLine($"{GetType().Name} come {h.GetType().Name}");
        }
    }
}
