using DP.Helpers;

namespace DP.StructuralPatterns.Adapter
{
    public static class Adapter
    {
        public static void Executar()
        {
            CabecalhoHelper.GerarCabecalho(
                "Structural Patterns",
                "Adapter",
                4,
                "O padrão converte a interface de uma classe para outra interface que o cliente espera encontrar,\n\"traduzindo\" solicitações do formato requerido pelo usuário para o formato compatível com o a classe\nadaptee e as redirecionando.");

            IAparelho a = new Liquidificador();
            a.On();
            a.Off();

            a = new Lavadora();
            a.On();

            RodapeHelper.Rodape();
        }
    }
}