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

// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в 
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