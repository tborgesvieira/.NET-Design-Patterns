using DP.Helpers;
using System;

namespace DP.CreationalPatterns.Singleton
{
    public static class Singleton
    {
        public static void Executar()
        {
            CabecalhoHelper.GerarCabecalho(
                "Creational Patterns",
                "Singleton",
                4,
                "O padrão Singleton garante a existência de apenas uma instância de uma classe, mantendo um ponto global de acesso ao seu objeto.");

            var b1 = LoadBalancer.ObterLoadBalancer();
            
            
            //Looping para chamar várias instâncias
            for(int i=0; i<6; i++)
            {
                var balancer = LoadBalancer.ObterLoadBalancer();

                if(balancer == b1)
                {
                    Console.WriteLine($"Instância {i} é igual b1 - Chamando Servidor: {balancer.Server}\n");
                }
            }

            RodapeHelper.Rodape();
        }
    }
}
