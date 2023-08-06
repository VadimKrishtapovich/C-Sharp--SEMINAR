/* Тask 1. Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от 1 до N. void метод.

void ShowNums(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNums(num -1);
    Console.Write(num + " ");
}

ShowNums(5);
*/

/* Task 2. Напишите программу, которая будет принимать на вход число и возвращать 
// сумму его цифр. int метод.

int SumOfDigits(int num)
{
    if(num !=0) return SumOfDigits(num / 10) + num % 10;
    return 0;
}

Console.Write(SumOfDigits(1234));

// Сам код рекурсии

f(1234) -> f(123) + 4
f(123) -> f(12) + 3
f(12) -> f(1) + 2
f(1) -> f(0) + 1
f(0) -> 0
f(1) -> 0 + 1 = 1
f(12) -> 1 + 2 = 3
f(123) -> 3 + 3 = 6
f(1234) -> 6 + 4 = 10
*/

/* Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.

void ShowEvenNum(int num1, int num2)
{
    if (num2 >num1)
    {
        Console.Write(num1+" ");
        ShowEvenNum(num1+1,num2);
    }
    else if (num1>num2) 
    {
        Console.Write(num1+" ");
        ShowEvenNum(num1-1,num2);
    }
    else Console.Write(num1+" ");
}

Console.Write("input num1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input num2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
ShowEvenNum(num1, num2);
*/

/* Напишите программу, которая на вход принимает два числа A и B, и возводит число А в 
// целую степень B.

double ShowPower(double num, int pow)
{
    if (pow>0)
    {
     return ShowPower(num, pow-1)*num;
    }
    else if (pow<0)
    {
        return ShowPower(num, pow+1)/num;
    }
    else return 1;
}

Console.Write("Input the number: ");
double num=Convert.ToDouble(Console.ReadLine());
Console.Write("Input the power: ");
int pow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ShowPower(num, pow));

*/

/*Task 64: Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Результат:");
PrintNumbers(N);


void PrintNumbers(int N)
{
    if (N >= 1)
    {
        Console.Write(N);
        if (N > 1)
        {
            Console.Write(", ");
        }
        PrintNumbers(N - 1);
    }
}
*/

/* Task 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int FindSum(int start, int end)
{
    int sum = 0;
    for (int i = start; i <= end; i++)
    {
        sum += i;
    }
    return sum;
}

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = FindSum(M, N);
Console.WriteLine($"Сумма натуральных элементов от {M} до {N} = {sum}");

*/

/*Task 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akerman ( int m, int n)
{
    if (m == 0) return n+1;
    if (n == 0) return Akerman(m - 1, 1);
    else return Akerman(m - 1, Akerman(m, n - 1));
}
Console.Write("Введите первый аргумент функции: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второй аргумент функции: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Akerman (m,n));
*/ 







