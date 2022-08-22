Console.Clear();
Console.WriteLine("Greetings user! Let's count X to the power of Y.");
Console.Write("Enter your X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your Y: ");
int y = Convert.ToInt32(Console.ReadLine());
double result = Math.Pow(x, y);
Console.WriteLine($"Your number is {result}");