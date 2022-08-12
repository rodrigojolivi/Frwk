using Frwk.Core.Interfaces;

namespace Frwk.Core.Services
{
    public class Decomposicao : IDecomposicao
    {
        public List<int> ListarNumerosDivisores(int numero)
        {
            var soma = 0;

            var numerosDivisores = new List<int>();

            for (int i = 1; i < numero; i++)
            {
                while (soma <= numero)
                {
                    if (numero % i == 0)
                    {
                        soma += i;

                        numerosDivisores.Add(i);
                    }

                    i++;
                }
            }

            return numerosDivisores;
        }

        public List<int> ListarNumerosPrimos(List<int> numerosDivisores)
        {
            var numerosPrimos = new List<int>();

            foreach (var numeroDivisor in numerosDivisores)
            {
                if (EhNumeroPrimo(numeroDivisor))
                {
                    numerosPrimos.Add(numeroDivisor);
                }
            }

            return numerosPrimos;
        }

        private bool EhNumeroPrimo(int numero)
        {
            var divisor = 2;

            while (divisor < numero)
            {
                var resto = numero % divisor;

                if (resto == 0) return false;

                divisor++;
            }

            return true;
        }
    }
}
