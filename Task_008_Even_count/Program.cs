Console.Clear();
Console.WriteLine("Greetings user! Let's see all even numbers before your number.");
Console.Write("Enter your number: ");
int x = Convert.ToInt32(Console.ReadLine());
int count = 2;
Console.Write("So here are your even numbers: ");
while(count <= x)
{
    Console.Write(" ");
    Console.Write(count);
    count = count + 2;
}
