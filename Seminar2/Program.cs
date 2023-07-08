/*
// Task 1. Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.

Console.Write("")
int num = Convert.Toint32
*/




//Напишите программу, которая выводит случайное число из отрезка 
//[10, 99] 
//и показывает наибольшую цифру числа.

int MaxNumber(int deknumber)
{
    int firstnumber = deknumber / 10;
    int secondnumber = deknumber % 10;
    
    if(firstnumber > secondnumber) return firstnumber;
    else return secondnumber;
}

 int randNumber = new Random().Next(10,100);
int result = MaxNumber(randNumber);


Console.WriteLine($"New version of {randNumber} is {result}");

//Напишите программу, которая принимает на вход два числа 
//и проверяет, 
//является ли одно число квадратом другого.



