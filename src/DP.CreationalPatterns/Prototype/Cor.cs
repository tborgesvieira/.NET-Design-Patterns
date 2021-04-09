using DP.Helpers;
using System;

namespace DP.CreationalPatterns.Prototype
{
    /// <summary>
    /// Classe concreta que implementa 'CorPrototype'
    /// </summary>
    partial class Cor : CorPrototype
    {
        private readonly int _vermelho;
        private readonly int _verde;
        private readonly int _azul;

        public Cor(int vermelho, int verde, int azul)
        {
            _vermelho = vermelho;
            _verde = verde;
            _azul = azul;

            Console.ForegroundColor = ConsoleColorHelper.FromRgbColor(_vermelho, _verde, _azul);
            Console.WriteLine("\nCriando cor RGB: {0}, {1}, {2}", _vermelho, _verde, _azul);
            Console.ResetColor();
        }

        //Cria uma cópia
        public override CorPrototype Clone()
        {
            Console.ForegroundColor = ConsoleColorHelper.FromRgbColor(_vermelho, _verde, _azul);
            Console.WriteLine("\nClonando cor RGB: {0}, {1}, {2}", _vermelho, _verde, _azul);
            Console.ResetColor();

            return this.MemberwiseClone() as CorPrototype;
        }
    }
}