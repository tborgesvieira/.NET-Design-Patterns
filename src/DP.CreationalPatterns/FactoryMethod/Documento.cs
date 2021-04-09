using System.Collections.Generic;

namespace DP.CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// Classe abstrata de criação do documento
    /// </summary>
    internal abstract class Documento
    {
        private List<Pagina> _paginas = new();

        //Ao construir a classe chama o abstract Factory Method
        public Documento()
        {
            this.CriarPaginas();
        }

        public List<Pagina> Paginas
        {
            get { return _paginas; }
        }

        //Factory Method
        public abstract void CriarPaginas();
    }
}