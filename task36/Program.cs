// Задать случайный массив и посчитать сумму его нечетных элементов
int [] createNewArray (int size, int start, int end)
{
    int [] massive = new int [size];
    for (int index = 0; index < size; index++)
    {
        massive [index] = new Random ().Next (start, end + 1);
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

int sumNumbersIntoArray (int [] mas)
{   
    int summa = 0;
    for (int j = 1; j < mas.Length; j+=2)
    {
        summa = summa + mas [j];
    }
    return summa;
}

Console.WriteLine ("Введите размер случайно генерируемого массива: ");
int length = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите начальное число диапазона случайно генерируемого массива: ");
int startNumber = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите конечное число дтиапазона случайно генерируемого массива: ");
int endNumber = Convert.ToInt32 (Console.ReadLine ());
int [] array = createNewArray (length, startNumber, endNumber);
int result = sumNumbersIntoArray (array);
Console.Write ("[");
printArray (array);
Console.Write ($"] -> {result}");