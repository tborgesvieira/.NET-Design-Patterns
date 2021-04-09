namespace DP.CreationalPatterns.FactoryMethod
{
    class Relatorio : Documento
    {
        //Implementação do Factory Method
        public override void CriarPaginas()
        {
            Paginas.Add(new IntroducaoPagina());
            Paginas.Add(new ResultadosPagina());
            Paginas.Add(new ConclusaoPagina());
            Paginas.Add(new SumarioPagina());
            Paginas.Add(new BibliografiaPagina());
        }
    }
}
