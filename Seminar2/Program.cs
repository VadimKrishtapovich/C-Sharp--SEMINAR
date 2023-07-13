/* Разряды и степени.
// 13254 / 10 = 1325
// 13254 / 100 = 132
// 13254 / 1000 = 13
// 13254 / 10000 = 1


// 13254 % 10 = 4
// 13254 % 100 = 54
// 13254 % 1000 = 254
// 13254 % 10000 = 3254
*/

/* Task 1. Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

// int CutNumber(int num)
// {
//     int hundreds = num / 100;
//     int units = num % 10;

//     int result = hundreds * 10 + units;
//     return result;
// }

// int randNumber = new Random().Next(100, 1000);
// int newNumber = CutNumber(randNumber);

// Console.WriteLine($"New version of {randNumber} is {newNumber}");

*/

/* Task 2. Напишите программу,которая принимает на вход число и проверяет
// кратно ли оно одновременны a и b.

bool IsDividable(int num, int a, int b)
{
    if(num % a == 0 && num % b == 0) return true;
    else return false;
}


Console.Write("Input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider: ");
int div1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider: ");
int div2 = Convert.ToInt32(Console.ReadLine());

bool result = IsDividable(number, div1, div2); 
Console.WriteLine(result);
*/

/* Task 3. Напишите программу, которая выводит случайное число из отрезка 
//[10, 99] и показывает наибольшую цифру числа. Например 49 (из 4 и 9).

int MaxNumber(int deknumber)
{
    int firstnumber = deknumber / 10;
    int secondnumber = deknumber % 10;

    if(firstnumber > secondnumber) return firstnumber;
    else return secondnumber;
}

int randNumber = new Random().Next(10, 100);
Console.Write(randNumber );
int result = MaxNumber(randNumber);

Console.Write($" New version of {randNumber} is {result}");
*/

// Task 4/ Напишите программу, которая принимает на вход два числа 
//и проверяет, является ли одно число квадратом другого.

// bool QuadResult(int num1, int num2)
// {
//     if(num1 % num2 == 0 || num2%num1 == 0) return true;
//     else return false;
// }

// Console.Write("Input a first namber: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input a second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// bool result = QuadResult(num1, num2);
// Console.WriteLine(result);

/* Task 10. Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
{
    int number = Convert.ToInt32(Console.ReadLine());

    int num2 = (number / 10) % 10;

    Console.Write("Вторая цифра числа: " + num2);
}
*/

/*  Task 13. Напишите программу которая выводит третью цифру заданого числа. 
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6.


    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    int thirdDigit = GetThirdDigit(number);
    
    int GetThirdDigit(int number)  // Возвращает третью цифру числа в качестве результата.
{
    int thirdDigit = (number / 100) % 10;
    return thirdDigit;
}

    Console.WriteLine($"Третья цифра числа: {thirdDigit}");
*/

// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. 6 -> да, 7 -> да, 1 -> нет.

