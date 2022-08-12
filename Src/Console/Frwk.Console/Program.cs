using Frwk.Core.Services;

var decomposicao = new Decomposicao();

var numerosDivisores = MostrarNumerosDivisores();

MostrarNumerosPrimos(numerosDivisores);

List<int> MostrarNumerosDivisores()
{
    Console.Write("Número de Entrada: ");

    var numero = Convert.ToInt32(Console.ReadLine());

    var numerosDivisores = decomposicao.ListarNumerosDivisores(numero);

    Console.Write("Números divisores: ");

    foreach (var numeroDivisor in numerosDivisores)
    {
        Console.Write($"{numeroDivisor} ");
    }

    return numerosDivisores;
}

void MostrarNumerosPrimos(List<int> numerosDivisores)
{
    var numerosPrimos = decomposicao.ListarNumerosPrimos(numerosDivisores);

    Console.Write(Environment.NewLine);

    Console.Write("Divisores Primos: ");

    foreach (var numeroDivisor in numerosPrimos)
    {
        Console.Write($"{numeroDivisor} ");
    }

    Console.ReadKey();
}


