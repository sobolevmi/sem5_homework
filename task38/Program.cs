// Задать случайно сгенерированный массив и высчитать разницу между максимальным и минимальным элементами
int [] createNewArray (int size, int start, int end)
{
    int [] massive = new int [size];
    for (int index = 0; index < size; index++)
    {
        massive [index] = new Random().Next (start, end + 1);
    }
    return massive;
}

void printArray (int [] arr)
{
    int i = 0;
    for (i = 0; i < arr.Length - 1; i++)
    {
        Console.Write (arr [i] + " ");
    }
    if (i == arr.Length - 1)
    {
        Console.Write (arr [i]);
    }
}

int maxMinusMin (int [] mas)
{
    int min = mas [0];
    int max = mas [0];
    for (int j = 1; j < mas.Length; j++)
    {
        if (mas [j] < min)
        {
            min = mas [j];
        }
        if (mas [j] > max)
        {
            max = mas [j];
        }
    }
    int result = max - min;
    return result;
}

Console.WriteLine ("Введите размер массива: ");
int length = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите начальное число диапазона чисел в массиве: ");
int startNumber = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите конечное число диапазона чисел в массиве: ");
int endNumber = Convert.ToInt32 (Console.ReadLine ());
int [] array = createNewArray (length, startNumber, endNumber);
Console.Write ("[");
printArray (array);
int res = maxMinusMin (array);
Console.WriteLine ($"] -> {res}");