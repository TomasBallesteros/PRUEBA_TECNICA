int[] myArray = new int[] { 1, 78, 22, 78, 5 };

int mayor = 0;

for(int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > mayor)
    {
        mayor = myArray[i];
    }
}

Console.WriteLine(mayor);