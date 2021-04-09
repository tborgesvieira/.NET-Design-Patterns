namespace DP.CreationalPatterns.Builder
{
    internal class Automoveis
    {
        public void Construtor(VeiculoBuilder veiculoBuilder)
        {
            veiculoBuilder.BuildMotor();
            veiculoBuilder.BuildPortas();
            veiculoBuilder.BuildRodas();
        }
    }
}