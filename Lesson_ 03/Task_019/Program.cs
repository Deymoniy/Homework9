Console.Clear();
Console.WriteLine("Greetings user! Let's check if your 5-digit number is a palindrome");
Console.Write("Enter your five - digit number: ");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"So your number is {input}. Got it. Gimme a second to think.");

if (input <10000)
    {
    Console.WriteLine("Wrong Number. You need 5-digit number!");    
    }
else if ((input % 10) == (input / 10000))
    {
    int temp1 = (input / 1000) % 10;
    int temp2 = (input / 10) % 10;
    if (temp1 == temp2)
        {
            Console.WriteLine("Yes,it is is a palindrome!");
        }
        else Console.WriteLine("No, it isn't is a palindrome!");
    }
else Console.WriteLine("No, it isn't a palindrome!");