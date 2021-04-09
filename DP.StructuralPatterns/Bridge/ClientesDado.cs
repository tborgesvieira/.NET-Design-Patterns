using System;
using System.Collections.Generic;
using System.Threading;

namespace DP.StructuralPatterns.Bridge
{
    class ClientesDado : Dado
    {
        private List<string> _clientes = new();
        private int _corrente = 0;

        public ClientesDado()
        {
            //Carrega os dados
            _clientes.Add("Cliente 1");
            _clientes.Add("Cliente 2");
            _clientes.Add("Cliente 3");
        }

        public override void AdicionarRegistro(string nome)
        {
            Console.WriteLine($"Adicionando {nome}");
            _clientes.Add(nome);
            Thread.Sleep(1000);           
        }

        public override void ExcluirRegistro(string nome)
        {
            Console.WriteLine($"Excluindo {nome}");
            _clientes.Remove(nome);
            Thread.Sleep(1000);
        }

        public override void ExibirRegistro()
        {
            Console.WriteLine($"Exibindo {_clientes[_corrente]}");
            Thread.Sleep(1000);
        }

        public override void ExibirTodosRegistros()
        {
            foreach (var cliente in _clientes)
            {
                Console.WriteLine($"\t{cliente}");
            }
        }

        public override void ProximoRegistro()
        {
            if (_corrente <= _clientes.Count - 1)
            {
                _corrente++;
            }
        }

        public override void RegistroAnterior()
        {
            if (_corrente > 0)
            {
                _corrente--;
            }
        }
    }
}