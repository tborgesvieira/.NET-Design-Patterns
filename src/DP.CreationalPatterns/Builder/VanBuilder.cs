using static DP.CreationalPatterns.Builder.Veiculo;

namespace DP.CreationalPatterns.Builder
{
    internal class VanBuilder : VeiculoBuilder
    {
        public VanBuilder()
        {
            veiculo = new Veiculo("Van");
        }

        public override void BuildMotor()
        {
            veiculo[Partes.Motor] = "3000cc";
        }

        public override void BuildPortas()
        {
            veiculo[Partes.Portas] = "5";
        }

        public override void BuildRodas()
        {
            veiculo[Partes.Rodas] = "4";
        }
    }
}