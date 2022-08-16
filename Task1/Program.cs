Console.WriteLine("Для окончания работы введите \"стоп\"");
int A = 0;
int B = 0;
string input = "";
double result = 0;
while (true)
{
    Console.WriteLine("Введите число А:");
    input = Console.ReadLine().ToLower();
    if (input == "стоп")
    {
        break;
    }
    A = Convert.ToInt32(input);
    Console.WriteLine("Введите число B:");
    B = Convert.ToInt32(Console.ReadLine());
    result = Math.Pow(A, B);
    Console.WriteLine($"Число А в степени В равно: {result}");
}