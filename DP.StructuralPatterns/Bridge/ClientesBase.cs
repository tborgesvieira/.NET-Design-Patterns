using System;

namespace DP.StructuralPatterns.Bridge
{
    /// <summary>
    /// Classe de abstração
    /// </summary>
    class ClientesBase
    {
        private Dado _dados;
        protected string _grupo;

        public ClientesBase(string grupo)
        {
            _grupo = grupo;
        }

        public Dado Dado
        {
            get
            {
                return _dados;
            }

            set
            {
                _dados = value;
            }
        }

        public virtual void Proximo()
        {
            _dados.ProximoRegistro();
        }

        public virtual void Anterior()
        {
            _dados.RegistroAnterior();
        }

        public virtual void Adicionar(string cliente)
        {
            _dados.AdicionarRegistro(cliente);
        }

        public virtual void Excluir(string cliente)
        {
            _dados.ExcluirRegistro(cliente);
        }

        public virtual void Exibir()
        {
            _dados.ExibirRegistro();
        }

        public virtual void ExibirTodos()
        {
            Console.WriteLine($"Cliente Grupo: {_grupo}");
            _dados.ExibirTodosRegistros();
        }
    }
}