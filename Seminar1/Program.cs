// int a = 25;
// double b = 36.6;
// string c = "Hello world";
// bool d = true;

// int number1 = 5;
// int number2 = 7;

// Console.WriteLine("My numbers is " + number1);
// Console.WriteLine($"My numbers is {number2} ");

// Console.Write ("Input a number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Your nubber is " + num);

//Task 1. Напишите программу, которая на вход принимает два числа и проверяет, 
// является .....


Console.Write("Input a first number: ");
int num1= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2= Convert.ToInt32(Console.ReadLine());

int quad2 = num2 * num2;

if(num1 == quad2)
{
    Console.Write("Yes");
}
    else
    {
    Console.Write("No");
    }


    //Task 2 Напишите программу, которая на вход принимает 
    //одно число (N), а на выходе показывает все целые числа 
    //в промежутке от -number до number.
