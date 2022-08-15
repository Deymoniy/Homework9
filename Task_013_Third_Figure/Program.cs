Console.Clear();
Console.WriteLine("Greetings user! Let's check what is the third figure in your number.");
Console.Write("Enter your number: ");
int user = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"So your number is {user}. Got it. Gimme a second to think.");
if (user > 100) Console.WriteLine($"The second figure is {user.ToString()[2] - '0'}.");
else Console.WriteLine("Whooops! There isn't any in here");