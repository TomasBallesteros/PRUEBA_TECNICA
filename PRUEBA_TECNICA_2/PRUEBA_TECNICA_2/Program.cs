int[] myArray = new int[] { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };
int[] numeros = new int[] { 1, 2, 3, 4, 5 };

for (int i = 0; i < numeros.Length; i++)
{
    string conteo = "";

    for (int j = 0; j < myArray.Length; j++)
    {
        if (myArray[j] == numeros[i])
        {
            conteo = conteo + "*";
        }
    }
    Console.WriteLine(numeros[i] + ": " + conteo);
}