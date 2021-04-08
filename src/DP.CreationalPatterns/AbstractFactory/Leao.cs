using System;

namespace DP.CreationalPatterns.AbstractFactory
{
    class Leao : Carnivoro
    {
        public override void Come(Herbivoro h)
        {
            Console.WriteLine($"{this.GetType().Name} come {h.GetType().Name}");
        }
    }
}
