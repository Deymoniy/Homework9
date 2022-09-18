// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Console.WriteLine("Greetings user! Let's multiply two randomly generated arrays.");
int[,] matrix = new int[2, 2];
int[,] matrix2 = new int [2, 2];
void FillArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Multiply(int[,]array, int[,]array2)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            Console.Write($"{array[x,y] * array2[x,y]} ");
        }
    }
}
Console.WriteLine("Your first array is ");
FillArray(matrix);
Console.WriteLine("Your second array is ");
FillArray(matrix2);
Console.WriteLine("Multiplied array looks like this is ");
Multiply(matrix, matrix2);