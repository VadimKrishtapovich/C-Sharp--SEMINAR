/* Пример для понимания, преобразующей метод.

void ShowNumber(int n)
{
    n += 5;
    Console.WriteLine(n);
}

int a = 10;

ShowNumber(a);
Console.WriteLine(a);
*/

/* Один и тотже массив с разными именами.

void ShowFirstElement(int [] array)
{
    array[0] += 5;
    Console.WriteLine(array[0]);
}

int[] myArray = {10, 3, 8};

ShowFirstElement(myArray);
Console.WriteLine(myArray[0]);
*/

/* Создаём скопированный массив и записываем туда myArray

void ShowFirstElement(int [] array)
{
    array[0] += 5;
    Console.WriteLine(array[0]);
}

int[] myArray = {10, 3, 8};
int[] copiedArray = myArray;

ShowFirstElement(copiedArray);
Console.WriteLine(myArray[0]);
*/

/* Task 1. Напишите программу, которая перевернёт одномерный массив.
// последний элемент будет на последнем месте, а последний на первом.
// преобразующий метод, типа void.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) 
        array[i]=new Random().Next(minValue, maxValue+1);
        
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);

ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

/* Task 1.1 Таже задача только более оптимизированный по объёму и
// читабельности, но менее компактный т.к. появилась новая
// переменная j. 

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) 
        array[i]=new Random().Next(minValue, maxValue+1);
        
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);

ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

/* Task 2. Напишите программу которая принимает на вход три числа и
// и проверяет может ли существовать треугольник с сторонами
// такой длинны.

bool Check(int[] myArray)
{
    if(myArray[0] < (myArray[1] + myArray[2]) && 
    myArray[1] < (myArray[0] + myArray[2]) &&
    myArray[2] < (myArray[0] + myArray[1])) return true;
    else return false;
}

Console.Write("Input A size: ");
int a_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B size: ");
int b_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input C size: ");
int c_size = Convert.ToInt32(Console.ReadLine());
int[] myArray = {a_size, b_size, c_size};

bool result = Check(myArray);
Console.WriteLine(result);
*/

/* Task 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

int[] CreateArray(int size)
{
    int[] array = new int[size]; 
    array[0] = 0;
    array[1] = 1;
    
    for(int i = 2; i < array.Length; i++) 
    array[i] = array[i-2] + array[i-1];
    return array;
}

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
*/


/* Task 4. Напишите программу которая будет оздавать копию 
// заданного масива с помощью поэлементного копирования.

int[] CopyArray(int[] Array1)
{
    int[] Array2 = new int[Array1.Length];
    for (int i = 0; i < Array1.Length; i++)
        Array2[i] = Array1[i];
    
    return Array2;
    
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] Array1 = {1, 2, 3, 4, 5, 6};

ShowArray(CopyArray(Array1));
*/