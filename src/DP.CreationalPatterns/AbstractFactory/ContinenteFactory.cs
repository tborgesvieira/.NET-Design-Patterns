namespace DP.CreationalPatterns.AbstractFactory
{
    abstract class ContinenteFactory
    {
        public abstract Herbivoro CriarHerbivoro();
        public abstract Carnivoro CriarCarnivoro();
    }
}
