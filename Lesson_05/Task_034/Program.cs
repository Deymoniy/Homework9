Console.Clear();
Console.WriteLine("Greetings user! Let's see number of even-nembers in a random array.");

int[] array = new int [8];

void FillArray(int[] arra)
    {
    int count = arra.Length;
    for (int i = 0; i < count; i++)
        {
        arra[i] = new Random().Next(99, 1000);
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

void Even(int[] arra)
    {
    int count = 0;
   for (int i = 0; i < arra.Length; i++)
   {
    if (arra[i] % 2 == 0) count++;
   }
    Console.WriteLine($"The amount of even numbers is {count}.");
    }
FillArray(array);
PrintArray(array);
Even(array);