// Task 1. Напишите программу, которая перевернёт одномерный массив
//  (последний элемент будет на первом месте,а первый - на 
//  последнем и т.д.)

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size]; 

    for (int i = 0; i < size; i++ )
    
    array[i] = new Random().Next(minValue, maxValue + 1); 

    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] + " ");

        Console.WriteLine();

}
void ReversArray( int[] array)
{
    for (i=0, j = array.Length -1; i < j; i++, j--)
        {
            int temp = array [i];
            array[i] = array [j];
            array[j] = temp;
        }
}


Console.WriteLine("введите длинну массива:= ");
int length = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите min");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите max");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
ReversArray(myArray);




/*Task 1. Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)

        Console.Write(array[i] + " ");

        Console.WriteLine();
}
/*
bool IsTrinoga ( int[] array )
{
        if (array[0] + array[1] > array[2] && array[1] + array[2] > array[0] && array[2] + array[0] > array[1])
        return true; 
        else return false;
}

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size]; 

    for (int i = 0; i < size; i++ )
    
        array[i] = new Random().Next(minValue, maxValue + 1); 

    return array;
}

int [] myarray = CreateRandomArray(3, 10, 100);

ShowArray(myarray);

Console.WriteLine(IsTrinoga(myarray));*/


// Task 2. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.

// int [] Fibonachi ( int n)
// {
//   int[] array = new int [n];
//   array[0]  = 0;
//   array[1] = 1;
//   for ( int i = 2; i < n; i++)
//     array[i] = array[i-1] + array[i-2];
// return array;
// }
// Console.WriteLine("Input a namber");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = Fibonachi(n);
// ShowArray(array);



// Task 3. Напишите программу, которая будет создавать копию заданного массива с 
// помощью поэлементного копирования.
