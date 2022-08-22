Console.Clear();
Console.WriteLine("Greetings user! Let's see all the number going before yours doubled.");
Console.Write("Enter your number: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"So your number is {input}. Got it. Gimme a second to think.");
Console.Write("Your doubled numbers are: ");
for(int i = 1; i <= input; i++)
    {
    int temp = i * i;
    Console.Write($"{temp} ");
    }
Console.WriteLine(" ");
Console.WriteLine($"All done.");