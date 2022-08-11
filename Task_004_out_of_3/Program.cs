Console.Clear();
Console.WriteLine("Greetings user! Let's compare three numbers.");
Console.Write("Enter your first number: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your second number: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your third number: ");
int z = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.Write("The largest number is:  ");
    Console.WriteLine(x);
}
 else
{ if(y > z) {
   Console.Write("The largest number is:  ");
   Console.WriteLine(y);
    }
    else
    {
    Console.Write("The largest number is:  ");
    Console.WriteLine(z);
    }
}