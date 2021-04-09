namespace DP.StructuralPatterns.Bridge
{
    /// <summary>
    /// Classe abstrata da implementação
    /// </summary>
    abstract class Dado
    {
        public abstract void ProximoRegistro();
        public abstract void RegistroAnterior();
        public abstract void AdicionarRegistro(string nome);
        public abstract void ExcluirRegistro(string nome);
        public abstract void ExibirRegistro();
        public abstract void ExibirTodosRegistros();
    }
}