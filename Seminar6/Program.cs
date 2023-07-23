/* примеры для понимания.

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

// Создаём скопированный массив и записываем туда myArray

void ShowFirstElement(int [] array)
{
    array[0] += 5;
    Console.WriteLine(array[0]);
}

int[] myArray = {10, 3, 8};
int[] copiedArray = myArray;

ShowFirstElement(copiedArray);

Console.WriteLine(myArray[0]);

