// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
Console.WriteLine("Greetings user! Let's fill your array spirally.");
int[,] matrix = new int[4, 4];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = 0;
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

void Spiral(int[,] array)
{
    int col = 0;
    int row = 0;
    int count = 1;
    for (col = 0; col < array.GetLength(1); col++)
    {
        array[row, col] = count;
        count++;
    }
    for (row = 1; row < array.GetLength(0); row++)
    {
        array[row, col - 1] = count;
        count++;
    }
    for (col = array.GetLength(1) - 2; col >= 0; col--)
    {
        array[row - 1, col] = count;
        count++;
    }
    for (row = array.GetLength(1) - 2; row > 0; row--)
    {
        array[row, 0] = count;
        count++;
    }
    for (col = 1; col < array.GetLength(1) - 1; col++)
    {
        array[1, col] = count;
        count++;
    }
    for (row = 2; row < array.GetLength(0) - 1; row++)
    {
        array[row, array.GetLength(0) - 2] = count;
        count++;
    }
    for (col = array.GetLength(1) - 2; col >= 1; col--)
    {
        array[array.GetLength(1) - 2, col] = count;
        count++;
    }
}
Console.WriteLine("Here is your starting array. Boooooooring!");
FillArray(matrix);
Spiral(matrix);
Console.WriteLine("Here is your new awesome cool array! ");
PrintArray(matrix);
