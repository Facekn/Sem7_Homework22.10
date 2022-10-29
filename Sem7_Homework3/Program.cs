//В прямоугольной матрице найти строку с наименьшей суммой элементов.

 void FillArray (int[,] array,int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    array[i,j] = random.Next(min,max);
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
       {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($" {array[i, j]} ");
            Console.WriteLine();
       }
}
int []  SumStroki (int[,] array)
{ 
  int[] newarray = new int [array.GetLength(0)];
    
  for (int i = 0; i < array.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
      sum = sum + array[i,j];      
    }
    newarray[i] = sum;
    
  }
  return newarray;

}
int PoiskMin (int[] array)
{
  int min = array[0];
  int index = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (min > array[i])
    {
        min = array[i];
        index = i;
    }
  }
  return index;
}
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int [,] array = new int [m,n];

FillArray(array, 0,10);
Console.WriteLine();
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
SumStroki (array);
int [] newarray = SumStroki (array);  
Console.Write($"Суммы каждой из строк: ");
for (int i = 0; i < newarray.Length; i++)
{
  Console.Write($"[{newarray[i]}] ");
}
int stroka = PoiskMin (newarray)+1;

Console.WriteLine();
Console.Write($"Наименьшая сумма элементов находится в {stroka} строке ");  



