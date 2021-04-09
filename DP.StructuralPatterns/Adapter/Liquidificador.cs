using System;

namespace DP.StructuralPatterns.Adapter
{
    //Adapter
    internal class Liquidificador : TomadaABNT, IAparelho
    {
        public Liquidificador()
        {
            Console.WriteLine("\nUtilizando o Liquidificador");
        }

        //Request
        public void On()
        {
            Ligado = true;
            Console.WriteLine("\to liquidificador está ligado");
        }

        //Request
        public void Off()
        {
            Ligado = false;
            Console.WriteLine("\to liquidificador está desligado");
        }
    }
}