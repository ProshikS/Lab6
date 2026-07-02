using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Базовый класс:");

        //конструктор без параметров
        Box box1 = new Box();
        Console.WriteLine("box1 (конструктор по умолчанию): " + box1);
        Console.WriteLine("Максимальная сторона: "+box1.Bigger());
        Console.WriteLine();

        //конструктор с параметрами
        Box box2 = new Box(6, 2, 10);
        Console.WriteLine("box2 (с параметрами 6, 2, 10): " + box2);
        Console.WriteLine("Максимальная сторона: "+ box2.Bigger());
        Console.WriteLine();

        //конструктор копирования
        Box box3 = new Box(box2);
        Console.WriteLine("box3 (копия box2): " + box3);
        Console.WriteLine("Максимальная сторона: "+ box3.Bigger());
        Console.WriteLine();

        //тесты для .Bigger()
        Box box4 = new Box(3, 8, 5);
        Console.WriteLine("box4 " + box4);
        Console.WriteLine("Максимальная сторона: " + box4.Bigger());
        Box box5 = new Box(12, 4, 9);
        Console.WriteLine("box5 " + box5);
        Console.WriteLine("Максимальная сторона: " + box5.Bigger());
        Box box6 = new Box(6, 6, 6);
        Console.WriteLine("box6 " + box6);
        Console.WriteLine("Максимальная сторона: " + box6.Bigger());
        Console.WriteLine();

        Console.WriteLine("\n\n\nДочерний класс:\n");

        //конструктор без параметров
        Package package1 = new Package();
        Console.WriteLine("package1 (конструктор по умолчанию): " + package1);
        Console.WriteLine("Максимальная сторона (наследуемый метод): "
            + package1.Bigger());
        Console.WriteLine("Упаковка: "+ package1.Packing());
        Console.WriteLine("Транспортировка: "+ package1.Transportation());
        Console.WriteLine();

        //конструктор с параметрами
        Package package2 = new Package(1, 2, 3, 5, "Да");
        Console.WriteLine("package2:" + package2);
        Console.WriteLine("Максимальная сторона: "+ package2.Bigger());
        Console.WriteLine("Упаковка: "+ package2.Packing());
        Console.WriteLine("Транспортировка: "+ package2.Transportation());
        Console.WriteLine();

        //конструктор копирования
        Package package3 = new Package(package2);
        Console.WriteLine("package3 (копия package2): " + package3);
        Console.WriteLine("Упаковка: "+ package3.Packing());
        Console.WriteLine("Транспортировка: "+ package3.Transportation());
        Console.WriteLine();

        //проверка .Transportation()
        Package package4 = new Package(10, 10, 10, 30, "Нет");
        Console.WriteLine("package4: "+ package4);
        Console.WriteLine($"Транспортировка: {package4.Transportation()}");

        Package package5 = new Package(2, 2, 2, 60, "Нет");
        Console.WriteLine("package5: "+package5);
        Console.WriteLine("Транспортировка: "+ package5.Transportation());

        Package package6 = new Package(6, 6, 6, 10, "Да");
        Console.WriteLine("package6: "+package6);
        Console.WriteLine("Транспортировка: "+ package6.Transportation());
        Console.WriteLine();


        //ввод с клавиатуры
        int length = Checking.ReadInt("Введите длину посылки: ");
        int width = Checking.ReadInt("Введите ширину посылки: ");
        int height = Checking.ReadInt("Введите высоту посылки: ");
        int weight = Checking.ReadInt("Введите вес посылки: ");
        Console.WriteLine("Посылка хрупкая? (Да/Нет)");
        string answer = Console.ReadLine();
        Package p = new Package(length, width, height, weight, answer);
        Console.WriteLine("p: " + p);
        Console.WriteLine("Упаковка: " + p.Packing());
        Console.WriteLine("Транспортировка: " + p.Transportation());
    }
}