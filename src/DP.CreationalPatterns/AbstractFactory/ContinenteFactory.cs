namespace DP.CreationalPatterns.AbstractFactory
{
    internal abstract class ContinenteFactory
    {
        public abstract Herbivoro CriarHerbivoro();

        public abstract Carnivoro CriarCarnivoro();
    }
}