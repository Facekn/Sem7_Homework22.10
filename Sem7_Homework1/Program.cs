//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void FillArray (int [,] array, int min, int max)
{
     Random random = new Random();
     for (int i = 0; i < array.GetLength(0); i++)     
        for (int j = 0; j < array.GetLength(1); j++)        
         array[i,j] = random.Next(min,max);     
}
void Printarray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {     
        for (int j = 0; j < array.GetLength(1); j++)  
        Console.Write($" {array[i,j]} ");
        Console.WriteLine();
    }
}
void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] > array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
}
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");

int [,] array = new int [m,n];
FillArray (array, 1,10);
Console.WriteLine();
Console.WriteLine("Изначальный массив:");
Printarray (array);
Console.WriteLine();
NewArray(array);
Console.WriteLine("Сортированный массив:");
Printarray (array); 

