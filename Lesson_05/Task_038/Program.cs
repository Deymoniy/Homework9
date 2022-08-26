Console.Clear();
Console.WriteLine("Greetings user! Let's see the difference between minimum and maximum numbers.");

int[] array = new int [8];

void FillArray(int[] arra)
    {
    int count = arra.Length;
    for (int i = 0; i < count; i++)
        {
        arra[i] = new Random().Next(1, 1000);
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

void Diff(int[] arra)
    {
    int max = arra[0];
    int min = arra[0];
    int diffe = 0;
   for (int i = 1; i < arra.Length; i++)
        {
        if (arra[i] > max) max = arra[i];
        else if (arra[i] < min) min = arra[i];
        }
    diffe = max - min;
    Console.WriteLine($"The difference is {diffe}.");
    }
FillArray(array);
PrintArray(array);
Diff(array);