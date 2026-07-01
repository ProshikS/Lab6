internal class Program
{
    private static void Main(string[] args)
    {
        // Создание точек
        Point p1 = new Point(3.7, 4.2);
        Point p2 = new Point(1.0, 2.0);

        Console.WriteLine("p1: " + p1);
        Console.WriteLine("p2: " + p2);

        // Проверка конструктора копирования
        Point p3 = new Point(p1);
        Console.WriteLine("p3 (копия p1): " + p3);

        // Проверка приведения
        int x = (int)p1;
        double y = p1; // неявное
        Console.WriteLine($"Явное приведение p1 к int: "+x);
        Console.WriteLine($"Неявное приведение p1 к double: "+y);

        // Проверка оператора + (расстояние)
        double length = p1 + p2;
        Console.WriteLine($"Расстояние между p1 и p2: " + length);

        // Проверка операторов + с целым числом
        Point p4 = p1 + 10;
        Point p5 = 20 + p1;
        Console.WriteLine($"p1 + 10: {p4}");
        Console.WriteLine($"20 + p1: {p5}");

        // Проверка операторов ++ и --
        Console.WriteLine($"p1 до ++: {p1}");
        p1++;
        Console.WriteLine($"p1 после ++: {p1}");
        p1--;
        Console.WriteLine($"p1 после --: {p1}");
    }
}