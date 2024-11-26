using System;

public class AbsoluteDifference
{
    public static int CalculateDifference(int n)
    {
        int difference = Math.Abs(n - 123);
        if (n > 123)
        {
            difference *= 3;
        }
        return difference;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число n:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int n))
        {
            int result = CalculateDifference(n);
            Console.WriteLine($"Абсолютная разность между {n} и 123: {result}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Введите целое число.");
        }
    }
}