namespace DP.CreationalPatterns.AbstractFactory
{
    internal class AfricaFactory : ContinenteFactory
    {
        public override Carnivoro CriarCarnivoro() => new Leao();

        public override Herbivoro CriarHerbivoro() => new Gnu();
    }
}