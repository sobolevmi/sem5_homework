// Задать случайно сгенерированный массив и высчитать разницу между максимальным и минимальным элементами
double [] createNewArray (int size, int start, int end)
{
    double [] massive = new double [size];
    Random rand = new Random ();
    for (int index = 0; index < size; index++)
    {
        massive [index] = rand.Next (start, end + 1) + rand.NextDouble ();
    }
    return massive;
}

void printArray (double [] arr)
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

double maxMinusMin (double [] mas)
{
    double min = mas [0];
    double max = mas [0];
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
    double result = max - min;
    return result;
}

Console.WriteLine ("Введите размер массива: ");
int length = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите начальное число диапазона чисел в массиве: ");
int startNumber = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите конечное число диапазона чисел в массиве: ");
int endNumber = Convert.ToInt32 (Console.ReadLine ());
double [] array = createNewArray (length, startNumber, endNumber);
Console.Write ("[");
printArray (array);
double res = maxMinusMin (array);
Console.WriteLine ($"] -> {res}");