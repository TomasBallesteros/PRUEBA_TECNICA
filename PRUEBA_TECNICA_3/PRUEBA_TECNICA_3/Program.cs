int[] myArray = new int[] { 1, 8, 6, 7, 2, 5 };

for(int i = 0; i < myArray.Length; i++)
{
    for (int j = i+1; j < myArray.Length; j++)
    {
        int suma = myArray[i] + myArray[j];
        if (suma == 10)
        {
            Console.WriteLine(myArray[i] + " " + myArray[j]);
        }
    }
}