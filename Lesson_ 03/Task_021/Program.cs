Console.Clear();
Console.WriteLine("Greetings user! Let's calculate the distance between two points in 3d.");
Console.Write("Enter your first x: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your first y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your first z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your First dot is ({x1}, {y1}, {z1}). Moving to the next dot.");

Console.Write("Enter your second x: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your second y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your second z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your First dot is {x1}, {y1}, {z1}).");
Console.WriteLine("Got it. Gimme a second to think.");
double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1),2));
Console.WriteLine($"Your distance is {result}");