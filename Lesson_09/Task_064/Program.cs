// Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.Clear();
Console.WriteLine("Greetings user! Let's see all the natural numbers between your entered numbers.");
Console.Write("Enter your 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your numbers are {num1} and {num2}");
int minimal = 0;
int maximal = 0;
if (num1 > num2)
{
    maximal = num1;
    minimal = num2;
}
else
{
    maximal = num2;
    minimal = num1;
}
Console.WriteLine($"I'll show you natural numbers from {minimal} to {maximal}.");
void CheckingNumbers(int min, int max)
{
    if ((min < 0) && (max < 0))
    {
        Console.WriteLine("Sorry, negative numbers can't be natural.");
    }
    else
    {
        if (min < 0)
        {
            min = min + (min * -1) + 1;
        }
        Console.Write("Your natural number are: ");
        for (int x = min; x <= max; x++)
        {
            if (min < 0)
            {
                min = min + (min * -1) + 1;
            }
            if (x == 0)
            {
                x++;
                Console.Write($" {x}");
            }
            else Console.Write($" {x}");
        }
    }
}

CheckingNumbers(minimal, maximal);