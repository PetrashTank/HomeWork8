/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");
int[,] array = new int[m, n];
FillArray(array);

int minSum = 0;
int sum = FindSum(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSum = FindSum(array, i);
  if (sum > tempSum)
  {
    sum = tempSum;
    minSum = i;
  }
}
Console.WriteLine($"Минимальная сумма элементов {sum} в строке {minSum+1}");

int Input(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void FillArray (int[,] array)
{
    Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(0,10); 
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
}
int FindSum(int[,] array, int i)
{
int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}
