using System;

namespace DP.StructuralPatterns.Bridge
{
    /// <summary>
    /// Classe Refinada
    /// </summary>
    class Clientes : ClientesBase
    {
        public Clientes(string grupo) : base(grupo)
        {
        }

        public override void ExibirTodos()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ExibirTodos();
            Console.WriteLine("------------------------");
        }
    }
}