// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}
Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр числа {number} равна {SumDigits(number)}");