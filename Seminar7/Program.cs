/* Task 1. Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

int[,] CreateRandom2dArray(int rows, int colums, int minValue,
 int maxValue)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)

            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
*/

/* Task 2. Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aij = i+j. Выведите полученный массив на экран. 
// (Генерирующий метод)


int[,] CreateRandom2dArray(int rows, int colums)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = i + j;

    return array;
}


void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)

            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, columns);
Show2dArray(myArray);
*/

/* Task 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты. (Приобразующий метод)

int[,] CreateRandom2dArray(int rows, int colums, int minValue,
 int maxValue)
{
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Changer2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i,j] = array [i,j]*array[i,j];
        }
    }
}



void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)

            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


int[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Console.WriteLine();
Changer2dArray(myArray);
Show2dArray(myArray);
*/

// Task 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на 
// главной диагонали (с индексами (0,0); (1;1) и т.д. (Аналитический метод).
