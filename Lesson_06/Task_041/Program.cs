Console.Clear();
Console.WriteLine("Greetings user! Let's see how many of your inputs are bigger higher then 0.");

int[] array = new int [6];

Console.Write("Enter your 1st number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
array[0] = num1;
Console.Write("Enter your 2nd number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
array[1] = num2;
Console.Write("Enter your 3rd number: ");
int num3 = Convert.ToInt32(Console.ReadLine());
array[2] = num3;
Console.Write("Enter your 4th number: ");
int num4 = Convert.ToInt32(Console.ReadLine());
array[3] = num4;
Console.Write("Enter your 5th number: ");
int num5 = Convert.ToInt32(Console.ReadLine());
array[4] = num5;
Console.Write("Enter your 6th number: ");
int num6 = Convert.ToInt32(Console.ReadLine());
array[5] = num6;

void PrintArray (int[] arra)
    {
    Console.Write("Here is your array: [ ");
    int count = arra.Length;
    for (int i = 0; i < count; i++) 
        {
        Console.Write($"{arra[i]} ");
        }   
    Console.WriteLine("].");
    }

int Higher(int[] arra)
    {
    int count = arra.Length;
    int more = 0;
        for (int i = 0; i < count; i++)
            {
            if (arra[i]> 0) more++;
            }
    return more;
    }

PrintArray(array);
int x = Higher(array);
Console.WriteLine($"The amount of numbers higher then 0 is {x}");
