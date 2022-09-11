// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Greetings user! Let's see arithmetic means for randomly generated array.");
double[,] matrix = new double[5, 5];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double random = new Random().Next(-100, 100);
        double anotherRandom = new Random().Next(1, 10);
        matrix[i, j] = Math.Round(random / anotherRandom, 2);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}