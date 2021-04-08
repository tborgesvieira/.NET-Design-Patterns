using System;
using System.Collections.Generic;

namespace DP.CreationalPatterns.Prototype
{

    /// <summary>
    /// Gerenciador Prototype
    /// </summary>
    class GerenciadorDeCores
    {
        private Dictionary<string, CorPrototype> _cores = new();

        public CorPrototype this[string key]
        {
            get {                
                return _cores[key]; 
            }
            set {                                
                _cores.Add(key, value); 
            }
        }
    }
}
