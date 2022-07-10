// Задать одномерный массив, заполненный случайными положительными трехзначными числами, 
// и показать количество четных чисел в массиве
int [] createNewArray (int size, int start, int end)
{
    int [] massive = new int [size];
    for (int i = 0; i < size; i++)
    {
        massive [i] = new Random().Next (start, end + 1);
    }
    return massive;
}

void printArray (int [] massive)
{
    Console.Write ($"[{massive [0]}, ");
    for (int j = 1; j < massive.Length - 1; j++)
    {
        Console.Write ($"{massive [j]}, ");
    }
    Console.Write ($"{massive [massive.Length - 1]}]");
}

Console.WriteLine ("Введите размер случайно генерируемого массива: ");
int length = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите начальное число диапазона случайно генерируемых чисел (от 100 до 999): ");
int startNumber = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите конечное число диапазона случайно генерируемых чисел (от 100 до 999): ");
int finishNumber = Convert.ToInt32 (Console.ReadLine ());
if ((startNumber >= 100) && (startNumber <= 999) && (finishNumber >= 100) && (finishNumber <= 999))
{
    int [] array = createNewArray (length, startNumber, finishNumber);
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array [i] % 2 == 0)
        {
            count++;
        }
    }
    printArray (array);
    Console.WriteLine ($" -> {count}");
}
else Console.WriteLine ("Введено неверное число");