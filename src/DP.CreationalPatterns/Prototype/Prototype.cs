using DP.Helpers;

namespace DP.CreationalPatterns.Prototype
{
    public static class Prototype
    {
        public static void Executar()
        {
            CabecalhoHelper.GerarCabecalho(
                "Creational Patterns",
                "Prototype",
                3,
                "O padrão Prototype permite a criação de novos objetos a partir de um modelo original ou protótipo que é clonado.");

            GerenciadorDeCores gerenciadorDeCores = new();

            //Inicializando as cores
            gerenciadorDeCores["vermelho"] = new Cor(255, 0, 0);
            gerenciadorDeCores["verde"] = new Cor(0, 255, 0);
            gerenciadorDeCores["azul"] = new Cor(0, 0, 255);

            //Cor personalizada
            gerenciadorDeCores["roxo"] = new Cor(128, 0, 128);
            

            //Usando cores clonadas
            Cor vermeho = gerenciadorDeCores["vermelho"].Clone() as Cor;            
            Cor verde = gerenciadorDeCores["verde"].Clone() as Cor;            
            Cor azul = gerenciadorDeCores["azul"].Clone() as Cor;            

            RodapeHelper.Rodape();
        }
    }
}
