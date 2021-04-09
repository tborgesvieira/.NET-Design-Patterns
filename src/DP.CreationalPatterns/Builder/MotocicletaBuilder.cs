using static DP.CreationalPatterns.Builder.Veiculo;

namespace DP.CreationalPatterns.Builder
{
    internal class MotocicletaBuilder : VeiculoBuilder
    {
        public MotocicletaBuilder()
        {
            veiculo = new Veiculo("Motocicleta");
        }

        public override void BuildMotor()
        {
            veiculo[Partes.Motor] = "600cc";
        }

        public override void BuildPortas()
        {
            veiculo[Partes.Portas] = "0";
        }

        public override void BuildRodas()
        {
            veiculo[Partes.Rodas] = "2";
        }
    }
}