using static DP.CreationalPatterns.Builder.Veiculo;

namespace DP.CreationalPatterns.Builder
{
    internal class CarroBuilder : VeiculoBuilder
    {
        public CarroBuilder()
        {
            veiculo = new Veiculo("Carro");
        }

        public override void BuildMotor()
        {
            veiculo[Partes.Motor] = "1400cc";
        }

        public override void BuildPortas()
        {
            veiculo[Partes.Portas] = "4";
        }

        public override void BuildRodas()
        {
            veiculo[Partes.Rodas] = "4";
        }
    }
}