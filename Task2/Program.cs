Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int SumOfDigits = 0;
while (number > 0)
{
    SumOfDigits += number % 10;
    number /= 10;
}
Console.WriteLine($"Сумма цифр числа равна: {SumOfDigits}");