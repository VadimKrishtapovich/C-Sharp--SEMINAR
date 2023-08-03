/* int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");

        Console.WriteLine();
    }
    Console.WriteLine();
 }

 Console.Write("Input number of rows: ");
 int rows = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input number of columns: ");
 int col = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input min possible value: ");
 int min = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input max possible value: ");
 int max = Convert.ToInt32(Console.ReadLine());

 int[,] myArray = CreateRandom2dArray(rows, col, min, max);
 Show2dArray(myArray);
*/

/*Задайте двумерный массив. Напишите программу, которая поменяет местами первую
 и последнюю строку массива.

void ChangeRows (int[,] array, int row1, int row2)
{
    if (row1 >=0 && row1 < array.GetLength(0) &&
        row2 >=0 && row1 < array.GetLength(0) &&
        row1 != row2)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            int temp = array[row1,j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, col, min, max);
Show2dArray(myArray);

Console.Write("Input number of first row to change: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of second row to change: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows (myArray, r1, r2);
Show2dArray(myArray);
*/

//Задайте двумерный массив. 
//Напишите программу, которая заменяет строки на столбцы.*/
// методы CreateRandom2dArray. 

/*void ChangeArray (int[,]array)
 {
     if (array.GetLength(0) == array.GetLength(1))
     for (int i = 1; i < array.GetLength(0); i++)
         for (int j = 0; j < i; j++)
         {
             int temp = array[i,j];
             array [i,j] = array[j,i];
             array [j,i] = temp;
         }
 }

 int[,] newArray = CreateRandom2dArray (rows, col, min, max);
 Show2dArray (newArray);
 ChangeArray (newArray);
 Show2dArray (newArray);*/


/*Из двумерного массива целых чисел удалить строку и столбец, на пересечении
 которых расположен наименьший элемент.*/
// Подсказка: Делим на две подзадачи: 
//  1.Найти местоположение минимального элемента.
//  2. Удаление  

/*int[] IndexOfMin(int[,] array)
{
    int[] coordinates = new int[2];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                coordinates[0] = i;
                coordinates[1] = j;
            }
        }
    return coordinates;
}

void ChangeToZero(int[,] array, int[] coordinates)
{
    for (int i = coordinates[0], j = 0; j < array.GetLength(1); j++)
        array[i, j] = 0;
    for (int j = coordinates[1], i = 0; i < array.GetLength(0); i++)
        array[i, j] = 0;
}*/

/*int[,] DeletedRowsColumns (int[,]array, int[] coordinates)
{
    int[,] newArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    for (int i=0, m=0; i < array.GetLength(0); i++, m++)
    {
        if (i != coordinates[0])
            for (int j=0, l=0; j<array.GetLength(1); j++, l++)
            {
                if (j != coordinates[1]) newArray[m,l] = array[i,j];
                else l--;
            }
        else m--;
    }
return newArray;
}

int [,] firstArray = CreateRandom2dArray (rows, col, min, max);
Show2dArray (firstArray);
int [] coord = IndexOfMin (firstArray);
int[,] result = DeletedRowsColumns (firstArray, coord);
Show2dArray (result);*/

/* Task 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] myArray = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

void SortRowsDescending(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        int[] row = new int[columns];
        for (int j = 0; j < columns; j++)
        {
            row[j] = array[i, j];
        }

        Array.Sort(row);
        Array.Reverse(row);
        
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = row[j];
        }
    }
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

Console.WriteLine("Заданный массив:");
ShowArray(myArray);

SortRowsDescending(myArray);

Console.WriteLine("Упорядоченный массив:");
ShowArray(myArray);

*/

/* Task 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

int[,] myArray = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

   
int FindRowWithMinSum(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int minRowIndex = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < columns; j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minRowIndex = i;
            }
        }

        return minRowIndex;
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

Console.WriteLine("Заданный массив:");
ShowArray(myArray);

int minRowIndex = FindRowWithMinSum(myArray);

Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex + 1} строка");

*/

/* Task 58: Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:


// 18 20
// 15 18


int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int n = matrixA.GetLength(0); // Число строк первой матрицы
    int m = matrixA.GetLength(1); // Число столбцов первой матрицы
    int k = matrixB.GetLength(1); // Число столбцов второй матрицы

    int[,] resultMatrix = new int[n, k];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < k; j++)
        {
            int sum = 0;
            for (int x = 0; x < m; x++)
            {
                sum += matrixA[i, x] * matrixB[x, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}

void ShowMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrixA = {
            { 2, 4 },
            { 3, 2 }
        };

int[,] matrixB = {
            { 3, 4 },
            { 3, 3 }
        };

int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

Console.WriteLine("Результирующая матрица:");
ShowMatrix(resultMatrix);
*/

/* Task 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] Create3dArray(int rows, int columns, int depth)
{
    int[,,] array = new int[rows, columns, depth];
    Random random = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                int num;
                do
                {
                    num = random.Next(10, 100); // Генерируем двузначное число
                } while (IsNumberUsed(array, num, i, j, k));

                array[i, j, k] = num;
            }
        }
    }

    return array;
}

bool IsNumberUsed(int[,,] array, int number, int row, int column, int depth)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == number)
                    return true;
            }
        }
    }
    return false;
}

void Show3dArray(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int depth = array.GetLength(2);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int[,,] myArray = Create3dArray(2, 2, 2);
Console.WriteLine("Массив размером 2 x 2 x 2:");
Show3dArray(myArray);
*/

/* Task 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void FillSpiralArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    int value = 1;
    int top = 0, bottom = rows - 1, left = 0, right = columns - 1;

    while (value <= rows * columns)
    {
        // Заполняем верхний ряд слева направо
        for (int i = left; i <= right && value <= rows * columns; i++)
        {
            array[top, i] = value++;
        }
        top++;

        // Заполняем крайний правый столбец сверху донизу/
        for (int i = top; i <= bottom && value <= rows * columns; i++)
        {
            array[i, right] = value++;
        }
        right--;

        // Заполняем нижнюю строку справа налево
        for (int i = right; i >= left && value <= rows * columns; i--)
        {
            array[bottom, i] = value++;
        }
        bottom--;

        // Заполняем крайний левый столбец снизу вверх
        for (int i = bottom; i >= top && value <= rows * columns; i--)
        {
            array[i, left] = value++;
        }
        left++;
    }
}

void Show2dArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{array[i, j]:D2} ");
        }
        Console.WriteLine();
    }
}

int[,] myArray = new int[4, 4];
FillSpiralArray(myArray);
Show2dArray(myArray);
*/
