Console.Clear();
Console.WriteLine("Greetings user! Let's check if that's a weekend day.");
Console.Write("Enter a number of the day: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"So your number is {input}. Got it. Gimme a second to think.");
string[]week = {"Monday","Tuesday","Wednesday", "Thirsday", "Friday", "Saturday", "Sunday"};
if ((input < 8) && (input > 0))
{
    if(input <= 5) Console.WriteLine($"Your day is {week[input - 1]}. And it's not a weekend.");
    else Console.WriteLine($"Your day is {week[input]}. And it is a weekend. Yay!");
}
else
{
    Console.WriteLine($"Number {input} is wrong. Please enter number from 1 to 7.");
}