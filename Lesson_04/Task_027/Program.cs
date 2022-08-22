Console.Clear();
Console.WriteLine("Greetings user! Let's count the summ of figures in your number");
Console.Write("Enter your number: ");
int x = Convert.ToInt32(Console.ReadLine());
int result = 0;
int Summ (int arg)
{
while ( arg > 0)
    {
    int figure = arg % 10;
    arg = arg / 10;
    result = result + figure;
    }
return result;
}
Console.Write($"Your answer is {Summ(x)}.");