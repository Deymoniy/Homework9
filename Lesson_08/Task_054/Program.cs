// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.Clear();
Console.WriteLine("Greetings user! Let's see randomly generated array.");
int[,] matrix = new int[4, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 50);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int x = 0; x < matrix.GetLength(0); x++)
{
    for (int y = 1; y < matrix.GetLength(1); y++)
    {
        if (matrix[x, y] > matrix[x, y - 1])
        {
            int tmp = matrix[x, y - 1];
            matrix[x, y - 1] = matrix[x, y];
            matrix[x, y] = tmp;
            y = 0;
        }
    }
}
for (int z = 0; z < matrix.GetLength(0); z++)
{
    for (int r = 0; r < matrix.GetLength(0); r++)
    {
        Console.Write(matrix[z, r]);
        Console.Write(" ");
    }
    Console.WriteLine();
}