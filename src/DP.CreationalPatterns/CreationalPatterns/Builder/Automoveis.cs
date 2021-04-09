namespace DP.CreationalPatterns.Builder
{
    class Automoveis
    {
        public void Construtor(VeiculoBuilder veiculoBuilder)
        {
            veiculoBuilder.BuildMotor();
            veiculoBuilder.BuildPortas();
            veiculoBuilder.BuildRodas();
        }
    }
}
