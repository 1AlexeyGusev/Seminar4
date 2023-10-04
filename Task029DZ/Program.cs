// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество элементов в массиве: ");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Введите min: ");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите max: ");
int max = int.Parse(Console.ReadLine());
int[] array = new int[length];
GenArray(array, min, max);
PrintArray(array);

void GenArray(int[] gen, int min, int max)
{
    for (int i = 0; i < length; i++)
    {
        gen[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
}
//     return array;
// }
// void [] Print(GenArray)
// {
//     Console.WriteLine({GenArray});
// }

// Console.Write($"{GenArray(length, min, max)}");

// int[] GenArray()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next();
//     }
//     return array;
// }
// Console.WriteLine($"{GenArray()}");
