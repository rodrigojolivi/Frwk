using Frwk.Core.Services;

namespace Frwk.Tests
{
    public class DecomposicaoTest
    {
        [Fact(DisplayName = "Lista os números divisores e retorna sucesso")]
        [Trait("Categoria", "Números divisores")]
        public void Listar_Numeros_Divisores_Returna_Sucesso_Test()
        {
            var decomposicao = new Decomposicao();

            var resultado = decomposicao.ListarNumerosDivisores(45);

            Assert.True(resultado.Count == 6);
            Assert.Equal(1, resultado[0]);
            Assert.Equal(3, resultado[1]);
            Assert.Equal(5, resultado[2]);
            Assert.Equal(9, resultado[3]);
            Assert.Equal(15, resultado[4]);
            Assert.Equal(45, resultado[5]);
        }

        [Fact(DisplayName = "Lista os números primos e retorna sucesso")]
        [Trait("Categoria", "Números primos")]
        public void Listar_Numeros_Primos_Returna_Sucesso_Test()
        {
            var decomposicao = new Decomposicao();

            var numerosDivisores = new List<int> { 1, 3, 5, 9, 15, 45 };

            var resultado = decomposicao.ListarNumerosPrimos(numerosDivisores);

            Assert.True(resultado.Count == 3);
            Assert.Equal(1, resultado[0]);
            Assert.Equal(3, resultado[1]);
            Assert.Equal(5, resultado[2]);
        }
    }
}