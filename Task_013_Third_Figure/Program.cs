Console.Clear();
Console.WriteLine("Greetings user! Let's check what is the third figure in your number.");
Console.Write("Enter your number: ");
int user = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"So your number is {user}. Got it. Gimme a second to think.");
//if (user > 100) Console.WriteLine($"The second figure is {user.ToString()[2] - '0'}.");
//else Console.WriteLine("Whooops! There isn't any in here");
while ( user > 1000) && (A);
{

    user = user / 10;
}
return user;

if (user < 1000)
{
int a = user / 10;
int result = user - (a * 10);
Console.WriteLine($"Your third figure is {result}");
}
else Console.WriteLine($"Your number {user} ain't got third figure");
