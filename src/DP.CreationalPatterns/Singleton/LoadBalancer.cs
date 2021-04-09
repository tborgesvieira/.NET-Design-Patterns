using System;
using System.Collections.Generic;

namespace DP.CreationalPatterns.Singleton
{
    /// <summary>
    /// Classe 'Singleton'
    /// </summary>
    internal class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        // Objeto para lock da sincronização
        private static object syncLock = new object();

        public LoadBalancer()
        {
            // Lista de servidores
            _servers.Add("Server 1");
            _servers.Add("Server 2");
            _servers.Add("Server 3");
            _servers.Add("Server 4");
            _servers.Add("Server 5");
        }

        public static LoadBalancer ObterLoadBalancer()
        {
            //Faz o lock quando for criar a nova instância para
            //que no looping não seja gerada mais de 1 instância
            if (_instance == null)
            {
                lock (syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new LoadBalancer();
                    }
                }
            }

            return _instance;
        }

        //Gera um servidor randomico no load balancer
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }
}