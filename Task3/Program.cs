void FillArray(int[] array)
{
    int x = 0;
    for (int i=0; i<array.Length; i++)
    {
        x = new Random().Next(1, 100);
        array[i] = x;
    }
}


void PrintArray(int[] array)
{
    foreach (int element in array)
    {
        Console.Write(element+" ");
    }
}


Console.WriteLine("Введите длину массива:");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
FillArray(array);
PrintArray(array);