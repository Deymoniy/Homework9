Console.Clear();
Console.WriteLine("Greetings user! Let's see if your number is even.");
Console.Write("Enter your number: ");
int x = Convert.ToInt32(Console.ReadLine());
if ( x % 2 == 0)
{
    Console.WriteLine("Yes, it is even.");
}
else
{
    Console.WriteLine("No, it isn't even.");
}