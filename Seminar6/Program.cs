/* Пример для понимания, преобразующей метод.

void ShowNumber(int n)
{
    n += 5;
    Console.WriteLine(n);
}

int a = 10;

ShowNumber(a);
Console.WriteLine(a);
*/

/* Один и тотже массив с разными именами.

void ShowFirstElement(int [] array)
{
    array[0] += 5;
    Console.WriteLine(array[0]);
}

int[] myArray = {10, 3, 8};

ShowFirstElement(myArray);
Console.WriteLine(myArray[0]);
*/

/* Создаём скопированный массив и записываем туда myArray

void ShowFirstElement(int [] array)
{
    array[0] += 5;
    Console.WriteLine(array[0]);
}

int[] myArray = {10, 3, 8};
int[] copiedArray = myArray;

ShowFirstElement(copiedArray);
Console.WriteLine(myArray[0]);
*/

/* Task 1. Напишите программу, которая перевернёт одномерный массив.
// последний элемент будет на последнем месте, а последний на первом.
// преобразующий метод, типа void.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) 
        array[i]=new Random().Next(minValue, maxValue+1);
        
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);

ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

/* Task 1.1 Таже задача только более оптимизированный по объёму и
// читабельности, но менее компактный т.к. появилась новая
// переменная j. 

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size]; 
    for(int i = 0; i < array.Length; i++) 
        array[i]=new Random().Next(minValue, maxValue+1);
        
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);

ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);
*/

/* Task 2. Напишите программу которая принимает на вход три числа и
// и проверяет может ли существовать треугольник с сторонами
// такой длинны.

bool Check(int[] myArray)
{
    if(myArray[0] < (myArray[1] + myArray[2]) && 
    myArray[1] < (myArray[0] + myArray[2]) &&
    myArray[2] < (myArray[0] + myArray[1])) return true;
    else return false;
}

Console.Write("Input A size: ");
int a_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input B size: ");
int b_size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input C size: ");
int c_size = Convert.ToInt32(Console.ReadLine());
int[] myArray = {a_size, b_size, c_size};

bool result = Check(myArray);
Console.WriteLine(result);
*/

/* Task 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

int[] CreateArray(int size)
{
    int[] array = new int[size]; 
    array[0] = 0;
    array[1] = 1;
    
    for(int i = 2; i < array.Length; i++) 
    array[i] = array[i-2] + array[i-1];
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    Console.Write(array[i]+ " ");
    Console.WriteLine();
}

Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
*/

/* Task 4. Напишите программу которая будет оздавать копию 
// заданного масива с помощью поэлементного копирования.

int[] CopyArray(int[] Array1)
{
    int[] Array2 = new int[Array1.Length];
    for (int i = 0; i < Array1.Length; i++)
        Array2[i] = Array1[i];
    
    return Array2;
    
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int[] Array1 = {1, 2, 3, 4, 5, 6};

ShowArray(CopyArray(Array1));
*/

/* Просто bool method......
bool IsEven(int value)
{
    return value % 2 == 0;
}
Console.WriteLine("Введите число и мы ответим вам чётное оно или нет: ");
int value = Convert.ToInt32(Console.ReadLine());
bool result = IsEven(value);
Console.Write(result);
*/

/* Task 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// Мой вариант.


Console.Write("Введите количество чисел M: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];

for (int i = 0; i < array.Length; i++)
{
    Console.Write("Введите число " + (i + 1) + ": ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int countPositiveNumbers = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        countPositiveNumbers++;
    }
}

Console.WriteLine("Количество чисел больше 0: " + countPositiveNumbers);
*/

/* Task 41.1(ниже пример решения c gb) "мне не нравится". Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4


int Prompt(string message)  // Считать число с консоли.
{
    System.Console.Write(message); // вывести сообщение
    string value = Console.ReadLine(); // Считывает с консоли строку.
    int result = Convert.ToInt32(value); //Преобразует строку в целое число

    return result; // возвращение результата.
}

int[] InputArray(int length) // Вводим массив
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Введите {i + 1}-й элемент: ");
    }
    return array;
}


void PrintArray(int[] array)                            // Термин "плейсхолдер" обычно используется для обозначения маркера или заполнителя, который 
                                                        //указывает место в строке, где нужно вставить конкретное значение. В контексте интерполяции 
                                                        //строк в C#, плейсхолдеры представляются фигурными скобками {} и используются для вставки 
                                                        //значений переменных в строку.
{
    for (int i = 0; i < array.Length; i++)              // $ перед строкой делает ее интерполированной. Это позволяет встраивать значения переменных 
                                                        //непосредственно в строку.
    {
        Console.Write($"a[{i}] = {array[i]}");         //a[{i}] - это строка, в которой {i} является плейсхолдером для значения переменной i. 
                                                       //Во время выполнения программы, значение i будет подставлено вместо этого плейсхолдера. 
                                                       //Например, если i равно 0, то вместо {i} будет подставлено 0. = - это просто символ равенства.
                                                       //{array[i]} - это еще один плейсхолдер, который относится к элементу массива array с индексом i.
                                                       // Во время выполнения программы, значение элемента массива array[i] будет подставлено вместо этого 
                                                       //плейсхолдера.

                                                        //Программа будет выводить каждый элемент массива array в формате a[индекс] = значение, 
                                                        //где индекс - это номер элемента в массиве, а значение - само значение этого элемента.
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = Prompt("Введите количество элементов: ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.Write($" Количество чисел боьше 0: {CountPositiveNumbers(array)}: ");

*/

/* Task 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

const int Coefficient = 0;
const int Constant = 1;
const int X_coord = 0;
const int Y_coord = 1;
const int Line1 = 1;
const int Line2 = 2;

double[] lineData1 = InputLineData(Line1);
double[] lineData2 = InputLineData(Line2);

if (ValidateLines(lineData1, lineData2))
{
    double[] coord = FindCoords(lineData1, lineData2);
    Console.Write($"Точка пересечений уравнений y = {lineData1[Coefficient]} * x {lineData1[Constant]} && y = {lineData2[Coefficient]} * x {lineData2[Constant]}");
    Console.WriteLine($"имеет координаты ({coord[X_coord]}, {coord[Y_coord]})");
}

// Ввод числа

double Prompt(string message)
{
    System.Console.Write(message); // вывести сообщение
    string value = Console.ReadLine(); // Считывает с консоли строку.
    int result = Convert.ToInt32(value); //Преобразует строку в целое число

    return result;
}

// Ввод данных по прямой

double[] InputLineData(int numberOfLine)
{
    double[] lineData = new double[2];
    lineData[Coefficient] = Prompt($"Введите коэфициент для {numberOfLine} прямой: ");
    lineData[Constant] = Prompt($"Введите константу для {numberOfLine} прямой: ");

    return lineData;
}

// Поиск координат

double[] FindCoords(double[] lineData1, double[] lineData2)
{
    double[] coord = new double[2];
    coord[X_coord] = (lineData1[Constant] - lineData2[Constant])
    / (lineData2[Coefficient] - lineData1[Coefficient]);
    coord[Y_coord] = lineData1[Constant] * coord[X_coord]
    + lineData1[Constant];

    return coord;

}

bool ValidateLines(double[] lineData1, double[] lineData2)
{
    if (lineData1[Coefficient] == lineData2[Coefficient])
    {
        if (lineData1[Constant] == lineData2[Constant]);
        {
            Console.WriteLine("Прямые совпадают");

        }
        return false;
    }

    else
        {
            Console.WriteLine("Прямые праллельны");
            return false;
        }
        return true;
}

*/

