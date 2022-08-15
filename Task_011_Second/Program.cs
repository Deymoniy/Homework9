Console.Clear();
Console.WriteLine("Greetings user! Let's check what is the second figure in your number.");
Console.Write("Enter your three - digit number: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"So your number is {input}. Got it. Gimme a second to think.");
if ((input < 1000) & (input > 99))
    {
    int x = input / 10;
    int result = x % 10;
    Console.WriteLine($"There is your second figure {result}");
    }
else
    {
    Console.WriteLine("Wrong number");
    }