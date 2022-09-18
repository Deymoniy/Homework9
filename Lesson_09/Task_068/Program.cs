// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9 
Console.Clear();
Console.WriteLine("Greetings user! Let's see how your two numbers will work in Ackerman function.");
Console.Write("Enter your 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter your 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int ack(int x, int y)
{
    if (x == 0)
    {
        return y + 1;
    }
    else if ((x > 0) && (y == 0))
    {
        return ack(x - 1, 1);
    }
    else if ((x > 0) && (y > 0))
    {
        return ack(x - 1, ack(x, y - 1));
    }
    else
        return y + 1;
}
Console.WriteLine($"There is your function solved via Ackerman function {ack(num1, num2)}");

