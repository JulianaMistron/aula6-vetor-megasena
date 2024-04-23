int size = 6, aux = 0;
int[] vetorSorteio = new int[size];
int[] vetorOrdenado = new int[size];

for (int i = 0; i < size; i++)
{
    vetorSorteio[i] = new Random().Next(0, 60);
    vetorOrdenado[i] = vetorSorteio[i];
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

Console.ReadLine();