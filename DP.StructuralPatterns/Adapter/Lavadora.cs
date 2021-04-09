using System;
using System.Threading;

namespace DP.StructuralPatterns.Adapter
{
    internal class Lavadora : TomadaABNT, IAparelho
    {
        public Lavadora()
        {
            Console.WriteLine("\nUtilizando a Lavadora");
        }

        //Request
        public void On()
        {
            Ligado = true;
            Console.WriteLine("a lavadora está lavando roupas");
            Lavar();
            Centrifugar();
            Enxaguar();
            Centrifugar();
            Enxaguar();
            Centrifugar();
            Off();
        }

        //Request
        public void Off()
        {
            Ligado = false;
            Console.WriteLine("agora a lavadora está desligada");
        }

        public void Lavar()
        {
            Console.WriteLine("\tadicionando água e sabão em pó...");
            Thread.Sleep(2000);
            Console.WriteLine("\tlavando...");
        }

        private void Enxaguar()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\tenxaguando...");
        }

        private void Centrifugar()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\tcentrifugando...");
        }
    }
}