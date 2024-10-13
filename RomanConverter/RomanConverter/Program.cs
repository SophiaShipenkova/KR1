using System;
using System.Text;
public class RomanConverter
{
    static void Main()
    {
        Console.WriteLine("Введите число от 0 до 1000");
        int number = int.Parse(Console.ReadLine());
        if (number < 0 || number > 1000)
            throw new ArgumentException("Вводимое число должно быть от 0 до 1000");
        if (number == 0)
        {
            Console.WriteLine("N");
        }
        int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        StringBuilder result = new StringBuilder(); for (int i = 0; i < 13; i++)
        {
            while (number >= values[i])
            {
                number -= values[i];
                result.Append(numerals[i]);
            }
        }
        Console.WriteLine(result.ToString());
    }
}
