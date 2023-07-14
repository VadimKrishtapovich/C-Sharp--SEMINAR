
/* Task 1. Необходимо написать программу, которая по заданному номеру 
// четверти покажет диапозон возможных координат точек в этой четверти.

void ShowDiapazone(int quad)  // Показывать диапазон
{
    if(quad == 1) Console.Write("x > 0 and y> 0");
    else if(quad == 2) Console.Write("x < 0 and y > 0");
    else if(quad == 3) Console.Write("x < 0 and y < 0");
    else if(quad == 4) Console.Write("x > 0 and y < 0");
    else Console.WriteLine("Wrong Inpun");
}

Console.Write("Input a number of quadrant (from 1 to 4): ");
int quad = Convert.ToInt32(Console.ReadLine());

ShowDiapazone(quad);
*/

/* Task 2. Напишите программу, которая принимает на вход координаты 
/ точки X и Y, причём не нулевые и выдаёт номер четверти плоскости 
/ в которой находится эта точка.

// int Coordinates (int cordinate1, int cordinate2)
// {
//     if( cordinate1> 0 && cordinate2 > 0) return 1;
//     if( cordinate1< 0 && cordinate2 > 0) return 2;
//     if( cordinate1 < 0 && cordinate2 < 0) return 3;
//     if( cordinate1 > 0 && cordinate2 < 0) return 4;
//     else return -1;
// }
// Console.Write("Input Coordinates x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Coordinates y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int result = Coordinates(x, y);
// Console.WriteLine(result);
*/

/* Task 3. Напишите программу, которая принимает на вход координаты 
// двух точек и находит растояние между ними в координатной плоскости.

// Console.Write(Math.Sqrt());  Необходимая формула находит  
//                              квадратный корень свего аргумента.


// double Distanse(int x1, int x2, int y1,int y2)
// {
//     double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
//     return result;
// }

// Console.Write("Input x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double result = Distanse(x1,x2,y1,y2);
// Console.WriteLine(result);
*/

/* Task 4. Напришите программу, которая принимает на вход число (N) и 
// выдайёт таблицу квадратов чисел от 1 до N. Вводи 4. 
// выводим:
// 1-1
// 2-4
// 3-9
// 4-16

// void QuaresNumbers(int num)
// {
//     int count = 1;
//     while(count <= num)
//     {
//         Console.WriteLine($"Таблица квадратов: {count}-{count*count}");
//         count++;
//     }
// }
// Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// QuaresNumbers(num);

*/

// Task 19.Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool IsPalindrome(int number)

{   //Делаем разбивку на отдельные числа
    int digit1 = number / 10000;
    int digit2 = (number / 1000) % 10;           
    int digit3 = (number / 100) % 10;
    int digit4 = (number / 10) % 10;
    int digit5 = number % 10;

    // Проверяем, равны ли цифры в обратном порядке
    if (digit1 == digit5 && digit2 == digit4)
{
    return true;
}
    else return false;
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (IsPalindrome(number))
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
   Console.WriteLine("Число не является палиндромом.");
}
  



