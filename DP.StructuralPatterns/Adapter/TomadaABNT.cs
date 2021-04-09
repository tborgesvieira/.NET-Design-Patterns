using System;

namespace DP.StructuralPatterns.Adapter
{
    //Adaptee
    internal class TomadaABNT
    {
        //SpecificRequest
        private bool _ligado;

        public bool Ligado
        {
            get
            {
                return _ligado;
            }
            set
            {
                _ligado = value;
                Console.WriteLine(">>> {0}ligando", _ligado ? "" : "des");
            }
        }
    }
}