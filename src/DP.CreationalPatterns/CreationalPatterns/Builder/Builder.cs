using DP.Helpers;

namespace DP.CreationalPatterns.Builder
{
    public static class Builder
    {
        public static void Executar()
        {
            CabecalhoHelper.GerarCabecalho(
                "Creational Patterns",
                "Builder",
                2,
                "Permite a separação da construção de um objeto complexo da sua representação, de forma que o mesmo processo de construção possa criar diferentes representações");

            VeiculoBuilder veiculoBuilder;

            var automoveis = new Automoveis();

            //Constroi e exibe os dados do veículo
            veiculoBuilder = new MotocicletaBuilder();
            automoveis.Construtor(veiculoBuilder);
            veiculoBuilder.Veiculo.ExibirDados();

            veiculoBuilder = new VanBuilder();
            automoveis.Construtor(veiculoBuilder);
            veiculoBuilder.Veiculo.ExibirDados();

            veiculoBuilder = new CarroBuilder();
            automoveis.Construtor(veiculoBuilder);
            veiculoBuilder.Veiculo.ExibirDados();

            RodapeHelper.Rodape();
        }        
    }
}
