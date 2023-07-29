/* Task 1. Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами.

double[,] CreateRandom2dArray(double rows, double colums, double minValue,
 double maxValue)
{
    double[,] array = new double[rows, colums];

    for (double i = 0; i < rows; i++)
        for (double j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}


void Show2dArray(double[,] array)
{
    for (double i = 0; i < array.GetLength(0); i++)
    {
        for (double j = 0; j < array.GetLength(0); j++)

            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
double rows = Convert.Todouble32(Console.ReadLine());
Console.Write("Input a number of columns: ");
double columns = Convert.Todouble32(Console.ReadLine());
Console.Write("Input a min possible value: ");
double minValue = Convert.Todouble32(Console.ReadLine());
Console.Write("Input a max possible value: ");
double maxValue = Convert.Todouble32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
*/

/* Task 2. Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aij = i+j. Выведите полученный массив на экран. 
// (Генерирующий метод)


double[,] CreateRandom2dArray(double rows, double colums)
{
    double[,] array = new double[rows, colums];

    for (double i = 0; i < rows; i++)
        for (double j = 0; j < colums; j++)
            array[i, j] = i + j;

    return array;
}


void Show2dArray(double[,] array)
{
    for (double i = 0; i < array.GetLength(0); i++)
    {
        for (double j = 0; j < array.GetLength(0); j++)

            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
double rows = Convert.Todouble32(Console.ReadLine());
Console.Write("Input a number of columns: ");
double columns = Convert.Todouble32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows, columns);
Show2dArray(myArray);
*/

/* Task 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса 
// чётные, и замените эти элементы на их квадраты. (Приобразующий метод)

double[,] CreateRandom2dArray(double rows, double colums, double minValue,
 double maxValue)
{
    double[,] array = new double[rows, colums];

    for (double i = 0; i < rows; i++)
        for (double j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Changer2dArray(double[,] array)
{
    for(double i = 0; i < array.GetLength(0); i += 2)
    {
        for (double j = 0; j < array.GetLength(1); j += 2)
        {
            array[i,j] = array [i,j]*array[i,j];
        }
    }
}



void Show2dArray(double[,] array)
{
    for (double i = 0; i < array.GetLength(0); i++)
    {
        for (double j = 0; j < array.GetLength(0); j++)

            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
double rows = Convert.Todouble32(Console.ReadLine());
Console.Write("Input a number of columns: ");
double columns = Convert.Todouble32(Console.ReadLine());
Console.Write("Input a min possible value: ");
double minValue = Convert.Todouble32(Console.ReadLine());
Console.Write("Input a max possible value: ");
double maxValue = Convert.Todouble32(Console.ReadLine());


double[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);
Show2dArray(myArray);
Console.WriteLine();
Changer2dArray(myArray);
Show2dArray(myArray);
*/

/* Task 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на 
// главной диагонали (с индексами (0,0); (1;1) и т.д. (Аналитический метод).

double[,] CreateRandom2dArray(double rows, double columns, double minValue, double maxValue)
{
    double[,] array = new double[rows, columns];
    for(double i=0; i<rows; i++)
    
        for(double j=0; j<columns;j++)
        
            array[i,j] = new Random().Next(minValue, maxValue+1);
        
    return array;
}

void Show2dArray(double [,] array)
{
    for(double i = 0; i<array.GetLength(0); i++)
    {
        for(double j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+ " ");

        Console.WriteLine();
    }
}

double CountSum(double[,] array)
{
    double result = 0;
    for(double i = 0, j = 0; i<array.GetLength(0) && j<array.GetLength(1); i++ , j++)
    result = result + array[i,j];
    return result;
}

Console.Write("input a number of rows: ");
double rows = Convert.Todouble32(Console.ReadLine());
Console.Write("input a number of columns: ");
double columns = Convert.Todouble32(Console.ReadLine());
Console.Write("input a min possible value: ");
double minValue = Convert.Todouble32(Console.ReadLine());
Console.Write("input a max possible value: ");
double maxValue = Convert.Todouble32(Console.ReadLine());

double [,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);

double result = CountSum(myArray);
Console.WriteLine(result);

// Пояснение к Task 4...... 
// Главная диагональ в двумерном массиве (или матрице) - это линия, 
// которая проходит от верхнего левого угла до нижнего правого угла 
// и содержит элементы с одинаковыми индексами по строкам и столбцам.

*/

/* Тask 45. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// Авотоматическое рандомное заполнение вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandom2dArray(double rows, double columns)
{
    double[,] array = new double[rows, columns];
    Random random = new Random();

    for (double i = 0; i < rows; i++)
    {
        for (double j = 0; j < columns; j++)
        {
            array[i, j] = random.NextDouble() * 10; // Генерируем случайное вещественное число в диапазоне [0, 10)
        }
    }

    return array;
}

void Show2dArray(double[,] array)
{
    double rows = array.GetLength(0);
    double columns = array.GetLength(1);

    for (double i = 0; i < rows; i++)
    {
        for (double j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

double m = 3; // Количество строк
double n = 4; // Количество столбцов

double[,] myArray = CreateRandom2dArray(m, n);

Show2dArray(myArray);

*/

/* Тask 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
// Пользователь вводит количество строк и столбцов и происходит случайное заполнение 
// вещественными числами с огруглением.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] array = new double[rows, columns];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            double randomValue = random.NextDouble() * (maxValue - minValue) + minValue;
            array[i, j] = Math.Round(randomValue, 1);
        }
    }

    return array;
}

void Show2dArray(double[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "   ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
double minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
double maxValue = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(rows, columns, minValue, maxValue);

Show2dArray(myArray);
*/

/* Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7->числа с такими индексами в массиве нет

// int[,] array = {
//     { 1, 4, 7, 2 },
//     { 5, 9, 2, 3 },
//     { 8, 4, 2, 4 }
//     };

// Console.Write("Введите номер строки: ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите номер столбца: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int rows = array.GetLength(0);
// int columns = array.GetLength(1);

// if (row >= 0 && row < rows && column >= 0 && column < columns)
// {
//     int element = array[row, column];
//     Console.WriteLine($"Значение элемента с позицией ({row}, {column}): {element}");
// }
// else
// {
//     Console.WriteLine("Элемент с такими индексами в массиве не существует.");
// }
*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.

/* Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] myArray = {
    { 1, 4, 7, 2 },
    { 5, 9, 2, 3 },
    { 8, 4, 2, 4 } };

Console.WriteLine("Заданный массив:");
ShowArray(myArray);

int rows = myArray.GetLength(0);
int columns = myArray.GetLength(1);

double[] columnAverage = new double[columns];

for (int j = 0; j < columns; j++)
{
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += myArray[i, j];
    }
    columnAverage[j] = sum / rows;
}

Console.WriteLine("Среднее арифметическое каждого столбца:");

for (int j = 0; j < columns; j++)
{
    Console.Write($"{columnAverage[j]:0.0}; ");
}

void ShowArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

*/  
