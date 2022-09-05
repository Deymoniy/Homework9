Console.Clear();
Console.WriteLine("Greetings user! Let's see if your lines are crossing");
Console.Write("Enter your b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

if((k1==k2) && (b1 == b2)) Console.WriteLine("Those are the same lines.");

else if (k1 == k2) Console.WriteLine("They are parallel");

else 
    {
    double x = (b2-b1)/(k1-k2);
    double y =  (k1 * x) + b1;
    Console.WriteLine($"The crossing is at {x} , {y}");
    }

