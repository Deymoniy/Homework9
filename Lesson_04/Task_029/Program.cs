Console.Clear();
Console.WriteLine("Greetings user! My programm is going to create an array for you.");

int[] array = new int [8];

void FillArray(int[] arra)
    {
    int count = arra.Length;
    for (int i = 0; i < count; i++)
        {
        arra[i] = new Random().Next(0, 100);
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
    Console.Write("].");
    }
FillArray(array);
PrintArray(array);