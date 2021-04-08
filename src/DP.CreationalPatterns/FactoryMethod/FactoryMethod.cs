using DP.Helpers;
using System;

namespace DP.CreationalPatterns.FactoryMethod
{
    public static class FactoryMethod
    {
        public static void Executar()
        {
            CabecalhoHelper.GerarCabecalho(
                "Creational Patterns",
                "Factory Method",
                5,
                "O padrão Factory Method por sua vez encapsula a criação de objetos, no entanto, a diferença é que neste padrão encapsula-se a criação de objetos deixando as subclasses decidirem quais objetos criar.");

            // Nota: construtor chama o Factory Method
            Documento[] documentos = new Documento[2];

            documentos[0] = new Resumo();
            documentos[1] = new Relatorio();

            //Exibe documento e paginas
            foreach(Documento documento in documentos)
            {
                Console.WriteLine($"\n {documento.GetType().Name} --");

                foreach (Pagina page in documento.Paginas)
                {
                    Console.WriteLine($" #{page.GetType().Name}" );
                }
            }

            RodapeHelper.Rodape();
        }
    }
}
