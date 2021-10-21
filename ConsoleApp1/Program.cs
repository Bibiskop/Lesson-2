using System;

namespace Home_work
{
    class Program
{
    static void Main(string[] args)
    {
        Task_1();
        Task_2();
        Task_3();
        Task_4();
        Task_5();
        Task_6();
    }

    static void Task_1()
    {

        Console.Write("Имя: ");
        string name = Console.ReadLine();

        Console.Write("Фамилия: ");
        string surname = Console.ReadLine();

        Console.Write("Возраст: ");
        string age = Console.ReadLine();

        Console.Write("Рост: ");
        string h = Console.ReadLine();

        Console.Write("Вес: ");
        string m = Console.ReadLine();

        Console.WriteLine(name + " " + surname + " " + age + " " + h + " " + m);
        Console.WriteLine("{0} {1} {2} {3} {4}", name, surname, age, h, m);
        Console.WriteLine($"{name} {surname} {age} {h} {m}");
    }

    static void Task_2()
    {
        Console.WriteLine("Рост, м: ");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Вес, кг: ");
        double m = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("ИМЦ = " + m / (h * h));
    }

    static void Task_3()
    {
        Console.Write("x1 = ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1 = ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("x2 = ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2 = ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine("{0:F2}", r);
        Console.WriteLine("{0:F2}", Distance(x1, y1, x2, y2));
    }

    static double Distance(double x1, double y1, double x2, double y2)
    {
        double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        return r;
    }

    static void Task_4()
    {
        int a = 1;
        int b = 2;
        Console.WriteLine(a + " " + b);

        int t = a;
        a = b; //2
        b = t; //1
        Console.WriteLine(a + " " + b);

        b = a + b; //3
        a = b - a; //3-2=1
        b = b - a; //3-1=2
        Console.WriteLine(a + " " + b);
    }

    static void Task_5()
    {
        string name = "Юра";
        string surname = "Куценко";
        string city = "Москва";

        Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);

        Console.WriteLine("{0} {1} {2}", name, surname, city);
        PrintInCenter(name + " " + surname + " " + city, Console.WindowWidth / 2, Console.WindowHeight / 2 + 1);
    }

    static void PrintInCenter(string message, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(message);
    }

    static void Task_6()
    {
        myTemplates.Print("Вывод текста с помощью собственного метода Print из класса myTemplates.\n" +
            "Далее перегруженный метод выводит double и int.\n" +
            "Потом собственный метод Input просит ввести текст.\n" +
            "Далее перегруженный метод Input с приветственным сообщением.");
        myTemplates.Print(1.34);
        myTemplates.Print(34);
        myTemplates.Input();
        myTemplates.Input("Введите значение: ");
    }
}

public static class myTemplates
{
    public static void Print(string msg)
    {
        Console.WriteLine(msg);
    }
    public static void Print(int x)
    {
        Console.WriteLine(x);
    }
    public static void Print(double x)
    {
        Console.WriteLine(x);
    }
    public static string Input()
    {
        string msg = Console.ReadLine();
        return msg;
    }
    public static string Input(string header)
    {
        Console.WriteLine(header);
        string msg = Console.ReadLine();
        return msg;
    }
}
}

