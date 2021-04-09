namespace DP.CreationalPatterns.FactoryMethod
{
    /// <summary>
    /// Classe concreta
    /// </summary>
    internal class Resumo : Documento
    {
        //Implementação do Factory Method
        public override void CriarPaginas()
        {
            Paginas.Add(new HabilidadesPagina());
            Paginas.Add(new EducacaoPagina());
            Paginas.Add(new ExperienciaPagina());
        }
    }
}