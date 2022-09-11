// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
Console.WriteLine("Greetings user! Let's see which number in our array has you coordinates.");
int[,] matrix = new int[5, 5];
Console.Write("Enter your 1st number: ");
int numx = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your 2nd number: ");
int numy = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 100);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
if ((numx < matrix.GetLength(0)) && (numy < matrix.GetLength(1))
    && (numx > 0)
    && (numy > 0))
{
    Console.WriteLine($"Your number is {matrix[numx - 1, numy - 1]}");
}
else Console.WriteLine("Your number is out of the array");