int size = 6, aux = 0;
int[] vetorSorteio = new int[size];
int[] vetorOrdenado = new int[size];

for (int i = 0; i < size; i++)
{
    vetorSorteio[i] = new Random().Next(1, 61);
    vetorOrdenado[i] = vetorSorteio[i];
}
for (int i = 0; i < size; i++)
{
    int numeroSorteado;
    bool repetido;

    do
    {
        numeroSorteado = new Random().Next(1, 61);
        repetido = false;

        // Verificar se o número já foi sorteado antes
        for (int j = 0; j < i; j++)
        {
            if (vetorSorteio[j] == numeroSorteado)
            {
                repetido = true;
                break;
            }
        }
    } while (repetido);

    vetorSorteio[i] = numeroSorteado;
    vetorOrdenado[i] = numeroSorteado;
}
Console.WriteLine("Números sorteados: ");
for (int i = 0; i < size; i++)
    Console.Write(vetorSorteio[i] + " ");

Console.ReadLine();

for (int referencia = 0; referencia < size; referencia++)//laço de referencia = 1
{
    for (int comparacao = referencia + 1; comparacao < size; comparacao++)//laço de comparação = j
    {
        if (vetorOrdenado[referencia] > vetorOrdenado[comparacao])
        {
            aux = vetorOrdenado[referencia];
            vetorOrdenado[referencia] = vetorOrdenado[comparacao];
            vetorOrdenado[comparacao] = aux;
        }
    }
}
Console.WriteLine("Ordenado");
for (int i = 0; i < size; i++)
    Console.Write(vetorOrdenado[i] + " ");