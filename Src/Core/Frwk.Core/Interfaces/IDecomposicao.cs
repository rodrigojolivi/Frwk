namespace Frwk.Core.Interfaces
{
    public interface IDecomposicao
    {
        List<int> ListarNumerosDivisores(int numero);
        List<int> ListarNumerosPrimos(List<int> numerosDivisores);
    }
}
