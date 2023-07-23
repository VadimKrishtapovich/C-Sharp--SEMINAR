1.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

2.

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    Console.Write(array[i]+ " ");
    Console.WriteLine();
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);

3.

int[] CopyArray(int[] Array1)
{
    int[] Array2 = new int[Array1.Length];
    for (int i = 0; i < Array1.Length; i++)
            Array2[i] = Array1[i];
    
    return Array2;
    
}