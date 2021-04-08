using System;

namespace DP.Helpers
{
    public static class CabecalhoHelper
    {
        public static void GerarCabecalho(string grupo, string nomePadrao, int frequenciaUso, string explicacao)
        {
            Console.Clear();
            Console.WriteLine($"Grupo: {grupo}");
            Console.WriteLine($"Padrão: {nomePadrao}");
            Console.WriteLine($"Frequência de uso: {AvaliacaoHelper.Avaliar(frequenciaUso)}");
            Console.WriteLine(explicacao);            
            Console.WriteLine("");
        }
    }
}
