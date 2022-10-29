//Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная)


void FillArray(int[,] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(min, max);
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" {array[i, j]} ");
        Console.WriteLine();
    }
}

int[,] ChangedArray(int[,] array)
{
    int[,] newarray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newarray[i, j] = array[j, i];
        }
    }
    return newarray;
}

Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[m, n];
int[,] newarray = new int[m, n];
FillArray(array, 1, 10);
PrintArray(array);
Console.WriteLine();
if (m == n)
{
    newarray = ChangedArray(array);
    PrintArray(newarray);
}
else Console.WriteLine("Замена невозможна");
