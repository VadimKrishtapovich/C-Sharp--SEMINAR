/* Task 1. Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных элементов массива.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) //i-первый работй элемент(не минимальнео значение).если из начала в конец i--
        array[i]=new Random().Next(minValue, maxValue+1);
        //перевое знаечение включается, а второе -нет, поэтому +1 ставим, чтобы включалось)
    return array;
}

//для отображения
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int GetNegativeSum(int[] array)
{
    int sum =0;
    for(int i = 0;i<array.Length; i++)
        if(array[i]<0) sum+=array[i];
    return sum;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
int negativeSum=GetNegativeSum(myArray);
ShowArray(myArray);
Console.WriteLine("Sum of negative elements: "+negativeSum);
*/

/* Task 2. Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) 
        array[i]=new Random().Next(minValue, maxValue+1);
        
    return array;
}

//для отображения
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int[] CreateNegativeArray(int[] array)
{
    for(int i=0; i<array.Length; i++)
    {
        array[i]=-1*array[i];
    }
    return array;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(length, min, max);
ShowArray(array);
int[] negarray = CreateNegativeArray(array);
ShowArray(negarray);
*/

/* Task 3. Задайте массив. Напишите программу, которая определяет, присутствует ли 
заданное число в массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) 
        array[i]=new Random().Next(minValue, maxValue+1);
        
    return array;
}

//для отображения
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

bool CheckNum(int[] array, int check)
{

    for (int i=0; i<array.Length; i++)
    {
        if (array[i]==check) return true;
        

    }
    return false;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = CreateRandomArray(length, min, max);
ShowArray(array);

Console.Write("Input checking number: ");
int check = Convert.ToInt32(Console.ReadLine());

bool result = CheckNum(array, check);
Console.WriteLine(result);
*/

/* Task 4. Задайте одномерный массив из m случайных чисел. Найдите количество 
элементов массива, значения которых лежат в отрезке [a,b].


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) 
        array[i]=new Random().Next(minValue, maxValue+1);
        
    return array;
}

//для отображения
void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i]+" ");
    Console.WriteLine();
}

int CheckQty(int a, int b, int[]array)
{
    int result =0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i]>=a && array[i]<=b) result++;
    }
    return result;
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array=CreateRandomArray(length, min, max);
ShowArray(array);

Console.Write("Input first num: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second num: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = CheckQty(a, b, array);
Console.WriteLine(result);
*/

/* Task 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в масси
// [345, 897, 568, 234] -> 2

int[] array = new int[4]; //В данном случае размер массива 4 (может быть любой другой)

// Заполнение массива случайными положительными трехзначными числами
Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
    }

Console.WriteLine("Сгенерированный массив:");
ShowArray(array);

int evenCount = CountEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
  

int CountEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 == 0) count++;
    return count;
}


void ShowArray(int[] array)
{
    Console.Write("[");
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
*/

/* Task 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[4]; 

Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 101); // диапазон от -100 до 100 
    }

int SumOddPositions(int[] array)
{
int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
        return sum;
}

void ShowArray(int[] array)
{
Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
Console.WriteLine("]");
}

Console.WriteLine("Сгенерированный массив:");
int sum = SumOddPositions(array);
ShowArray(array);
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
*/

/* Task 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 };

double max = array[0]; 
double min = array[0]; 

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i]; 
        }
        else if (array[i] < min)
        {
            min = array[i]; 
        }
    }

double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");

*/
