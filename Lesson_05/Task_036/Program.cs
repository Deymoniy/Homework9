Console.Clear();
Console.WriteLine("Greetings user! Let's see number of even-nembers in a random array.");

int[] array = new int [8];

void FillArray(int[] arra)
    {
    int count = arra.Length;
    for (int i = 0; i < count; i++)
        {
        arra[i] = new Random().Next(-1000, 1000);
        }
    }

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

void Summ(int[]arra)
{
    int summa = 0;
    int i = 1;
    while (i < arra.Length)
        {
        summa = summa + arra[i];
        i = i + 2;
        }
    Console.WriteLine($"There is your summ ({summa})");
    
}
FillArray(array);
PrintArray(array);
Summ(array);
