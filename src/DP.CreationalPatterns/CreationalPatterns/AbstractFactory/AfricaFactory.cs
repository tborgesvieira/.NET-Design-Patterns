using DP.CreationalPatterns.AbstractFactory;

namespace DP.CreationalPatterns.CreationalPatterns.AbstractFactory
{
    class AfricaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivoro() => new Leao();

        public override Herbivoro CriarHerbivoro() => new Gnu();
    }
}
