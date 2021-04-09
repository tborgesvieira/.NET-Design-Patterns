using DP.CreationalPatterns.AbstractFactory;

namespace DP.CreationalPatterns.CreationalPatterns.AbstractFactory
{
    class AmericaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivoro() => new Lobo();

        public override Herbivoro CriarHerbivoro() => new Bufalo();
    }
}
