Console.Clear();
Console.WriteLine("Greetings user! Let's count X to the power of Y.");
Console.Write("Enter your X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your Y: ");
int y = Convert.ToInt32(Console.ReadLine());

void Result(int a, int b)
{
    if ((a > 0) && (b > 0))
        {
        double result = Math.Pow(a, b);
        Console.WriteLine($"Your number is {result}");
        }
    else Console.WriteLine("Wrong numbers. Both numbers should be above 0.");
}
Result (x, y);
