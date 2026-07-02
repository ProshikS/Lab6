using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Checking
{
    public static int ReadInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (int.TryParse(Console.ReadLine(), out int value)&&value>0)
            {
                return value;
            }
            Console.WriteLine("Неккоректное значение. Повторите ввод");
        }
    }

    public static double ReadDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out double value))
            {
                return value;
            }
            Console.WriteLine("Неккоректное значение. Повторите ввод");
        }
    }
}
