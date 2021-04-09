namespace DP.CreationalPatterns.CreationalPatterns.AbstractFactory
{
    class AnimaisDoMundo
    {
        private Herbivoro _herbivoro;
        private Carnivoro _carnivoro;

        public AnimaisDoMundo(ContinenteFactory factory)
        {
            _carnivoro = factory.CriarCarnivoro();
            _herbivoro = factory.CriarHerbivoro();
        }

        public void IniciarCadeiaAlimentar()
        {
            _carnivoro.Come(_herbivoro);
        }
    }
}
