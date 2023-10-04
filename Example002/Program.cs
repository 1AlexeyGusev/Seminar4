void Mass(int col)
{
    int[] arry = new int[col];

    for (int i = 0; i < arry.Length; i++)
    {
        arry[i] = new Random().Next(0,10);
        Console.Write($"{arry[i]} ");
    }
}
Console.Write("Ввести длину массива ");
int n = Convert.ToInt32(Console.ReadLine());
Mass(n);