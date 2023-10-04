// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Пожалуйста, введите число: ");
int number = int.Parse(Console.ReadLine());

int CountNumber (int number)
{
    int count = 1;
    while (number > 10)
    {
        number /= 10;
        count++;
    }
    return count;
}

Console.WriteLine($"Количество цифр в числе {number} равно {CountNumber(number)}");