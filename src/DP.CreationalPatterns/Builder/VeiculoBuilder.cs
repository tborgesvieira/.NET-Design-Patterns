namespace DP.CreationalPatterns.Builder
{
    internal abstract class VeiculoBuilder
    {
        protected Veiculo veiculo;

        public Veiculo Veiculo
        {
            get { return veiculo; }
        }

        public abstract void BuildMotor();

        public abstract void BuildRodas();

        public abstract void BuildPortas();
    }
}