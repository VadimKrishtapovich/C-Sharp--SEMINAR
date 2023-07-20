/*Task 1. Напишите программу, которая принимает на вход 
//число (А) и выдаёт сумму чисел от 1 до А. 

// int Sum(int a)
// {
//     int sum = 0;
//     for (int i=1; i<=a; i++)
//     {
//         sum = sum + i;            
//     }
//     return sum;
// }  
// Console.Write("Input A := ");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = Sum(num);
// Console.WriteLine(result);
*/

/* Task 2. Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.

// int Countdigit(int num1)
// {
//     int count = 0;
//     while ( num1 > 0 )
//     {
//     num1 = num1 / 10;
//     count++;
//     }
//     return count;
// }

// Console.Write("Input N:=");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int result = Countdigit(num2);
// Console.WriteLine(result);
*/

/* Task 3. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

// int Sum( int a )
// {
//     int sum = 1;
//     for (int i=1; i<=a; i++)
//     {
//         sum = sum * i;            
//     }
//     return sum;
// }  
// Console.Write("Input A:=");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = Sum(num);
// Console.WriteLine(result);

*/

/* Task 4. МАССИВ. Написать программу, которая создает
// случайный массив целых чисел заданной длины и с 
//заданным диапазоном значений. Затем программа должна 
вывести этот массив на экран.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();    
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
*/

/* Task 5/ Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

int[] CreateFirstArray(int size, int minValue, int maxValue)
{
        int[] array = new int[size];
        
        for( int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

        return array;
}

void ShowArray(int[] array)
{
    for( int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}

    Console.Write("Input a length of array: ");
    int length = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value ");
    int max = Convert.ToInt32(Console.ReadLine());

    int[] Myarray = CreateFirstArray(length, min, max);
    ShowArray(Myarray);
    */

/* Task 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Variables(int A, int B)  // название метода Variables - переменные.
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}


void Conclusion(int A, int B, int result)  // Conclusion - вывод.
{
    Console.WriteLine($"{A} в степени {B} равно: {result}");
}

int A, B;
Console.Write("Введите число A: ");
A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень B: ");
B = Convert.ToInt32(Console.ReadLine());

int result = Variables(A, B);
Conclusion(A, B, result);
*/

/* Task 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int CalculateDigitSum(int number)
{
    int sum = 0;

    while (number > 0)
    {
        int digit = number % 10;
        sum += digit;
        number /= 10;
    }

    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digitSum = CalculateDigitSum(number);
Console.WriteLine("Сумма цифр числа: " + digitSum);

*/

/* Task 29: Напишите программу, которая задаёт массив из m элементов
// и выводит их на экран. Разработать метод CreateArray(int size), 
// генерирующий массив на основе данных, вводимых пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент массива {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void ShowArray(int[] array)
{

    Console.Write("Массив: [");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);

        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(size);
ShowArray(myArray);

*/