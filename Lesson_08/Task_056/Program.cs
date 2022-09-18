// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка
Console.Clear();
Console.WriteLine("Greetings user! Let's see on which raw summ of the elements is the smallest.");
int[,] matrix = new int[4, 4];

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
    int summ2 = 0;
    int summ3 = 0;
    int summ4 = 0;
    int x = 0;
    for (int y = 0; y < array.GetLength(1); y++)
    {
        summ1 = summ1 + array[x, y];
    }

    for (int q = 0; q < array.GetLength(1); q++)
    {
        summ2 = summ2 + array[x + 1, q];
    }
    for (int w = 0; w < array.GetLength(1); w++)
    {
        summ3 = summ3 + array[x + 2, w];
    }
    for (int e = 0; e < array.GetLength(1); e++)
    {
        summ4 = summ4 + array[x + 3, e];
    }

    Console.WriteLine();
    Console.Write($"{summ1} ");
    Console.Write($"{summ2} ");
    Console.Write($"{summ3} ");
    Console.Write($"{summ4} ");
    Console.WriteLine();
if ((summ1 < summ2) && (summ1 < summ3) && (summ1 < summ4))
{
    Console.WriteLine($"First row is the smallest and it equals {summ1}");
}
else if ((summ2 < summ1) && (summ2 < summ3) && (summ2 < summ4))
{
    Console.WriteLine($"Second row is the smallest and it equals {summ2}");
}
else if ((summ3 < summ1) && (summ3 < summ2) && (summ1 < summ4))
{
    Console.WriteLine($"Third row is the smallest and it equals {summ3}");
}
else
{
    Console.WriteLine($"Forth row is the smallest and it equals {summ4}");
}
}
FillArray(matrix);
Compare(matrix);