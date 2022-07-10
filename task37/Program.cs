// Задать массив, осуществить в нем произведение парное умножение элементов (первого - с последним, 
// второго - с предпоследним и т.д.). Результат вывести на экран новым массивом
int [] createNewArray (int size, int start, int end)
{
    int [] massive = new int [size];
    for (int j = 0; j < size; j++)
    {
        massive [j] = new Random().Next (start, end + 1);
    }
    return massive;
}

void printArray (int [] massive)
{
    int index = 0;
    for (index = 0; index < massive.Length - 1; index++)
    {
        Console.Write (massive [index] + ", ");
    }
    if (index == massive.Length - 1)
    {
        Console.Write (massive [index]);
    }
}

int [] NewArray (int [] massive)
{
    int sizeNewArray = 0;
    int k = 1;
    for (int i = 0; i < massive.Length - k; i++)
    {
        sizeNewArray = sizeNewArray + 1;
        k++;
    }
    int [] result = new int [sizeNewArray];
    for (int n = 0; n < result.Length; n++)
    {
        result [n] = massive [n] * massive [massive.Length - n - 1];
    }
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
Console.Write ("] - > ");
int [] array1 = NewArray (array);
Console.Write ("[");
printArray (array1);
Console.Write ("]");