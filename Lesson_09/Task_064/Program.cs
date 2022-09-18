// Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
Console.Clear();
Console.WriteLine("Greetings user! Let's see how many of your inputs are bigger higher then 0.");
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
Console.WriteLine($"{minimal} {maximal}");
Console.Write("Your natural number are: ");
for(int x = minimal; x <= maximal; x++)
{
    Console.Write($" {x}");
} 