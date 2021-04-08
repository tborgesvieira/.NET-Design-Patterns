namespace DP.CreationalPatterns.AbstractFactory
{
    class AfricaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivoro() => new Leao();

        public override Herbivoro CriarHerbivoro() => new Gnu();
    }
}
