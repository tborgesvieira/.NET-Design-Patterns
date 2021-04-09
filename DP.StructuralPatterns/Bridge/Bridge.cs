using DP.Helpers;

namespace DP.StructuralPatterns.Bridge
{
    public static class Bridge
    {
        public static void Executar()
        {
            CabecalhoHelper.GerarCabecalho(
                "Structural Patterns",
                "Bridge",
                3,
                "Padrão utilizado quando é desejável que uma interface (abstração) possa variar independentemente das suas implementações.");

            var clientes = new Clientes("Grupo 1")
            {
                //Define Implementação Concreta
                Dado = new ClientesDado()
            };

            //Bridge
            clientes.Exibir();
            clientes.Proximo();
            clientes.Exibir();
            clientes.Proximo();
            clientes.Exibir();
            clientes.Adicionar("Cliente 4");

            clientes.ExibirTodos();

            clientes.Excluir("Cliente 1");

            RodapeHelper.Rodape();
        }
    }
}