// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
Console.WriteLine("Greetings user! Let's see arithmetic means for randomly generated array.");
int[,] matrix = new int[5, 5];

void FillArray(int[,] array)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Compare(int[,] array)
{
    int summ1 = 0;
    int x = 0;
    for (int y = 0; y < array.GetLength(1); y++)
    {
        summ1 = summ1 + array[x, y];
        Console.Write($"{summ1} ");
    }
    Console.WriteLine();
    
}
FillArray(matrix);
Compare(matrix);