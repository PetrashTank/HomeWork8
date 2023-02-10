/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.WriteLine("Введите размер трехмерного массива ");
int x = Input("X: ");
int y = Input("Y: ");
int z = Input("Z: ");
Console.WriteLine("");
int[,,] array3D = new int[x, y, z];
FillArray(array3D);
void FillArray(int[,,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {

            for (int k = 0; k < array.GetLength(1); k++)
            {

                array[i, j, k] = random.Next(10, 100);
                Console.Write($"{array[i, j, k]} ");
                Console.Write($"({i},{j},{k}) ");
            }
            Console.WriteLine(" ");
        }
    }
}
int Input(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
