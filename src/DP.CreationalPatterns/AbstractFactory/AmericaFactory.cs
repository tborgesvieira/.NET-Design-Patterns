namespace DP.CreationalPatterns.AbstractFactory
{
    internal class AmericaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivoro() => new Lobo();

        public override Herbivoro CriarHerbivoro() => new Bufalo();
    }
}