using System;
using System.Collections.Generic;

namespace DP.CreationalPatterns.Builder
{
    internal class Veiculo
    {
        private string _veiculoTipo;
        private Dictionary<string, string> _partes = new();

        public enum Partes
        {
            Motor,
            Rodas,
            Portas
        }

        public Veiculo(string veiculoTipo)
        {
            _veiculoTipo = veiculoTipo;
        }

        public string this[Partes partes]
        {
            get { return _partes[partes.ToString()]; }
            set { _partes[partes.ToString()] = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine($"Tipo do Veículo: {_veiculoTipo}");
            Console.WriteLine($" #Motor : {_partes[Partes.Motor.ToString()]}");
            Console.WriteLine($" #Rodas : {_partes[Partes.Rodas.ToString()]}");
            Console.WriteLine($" #Portas: {_partes[Partes.Portas.ToString()]}");
        }
    }
}