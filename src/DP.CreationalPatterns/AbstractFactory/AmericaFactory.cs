namespace DP.CreationalPatterns.AbstractFactory
{
    class AmericaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivoro() => new Lobo();

        public override Herbivoro CriarHerbivoro() => new Bufalo();
    }
}
