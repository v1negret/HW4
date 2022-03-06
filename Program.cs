using System;
using System.Collections;


namespace HW4;
class Program
{
    public enum Severity
    {
        Warning,
        Error
    }
    static Severity severity;

    public static int a,b,c;
    public static string a1, b1, c1;

    static void FormatData(string message, Severity severity, IDictionary data)
    {
        Console.WriteLine(String.Concat(Enumerable.Repeat('-', 50)));
        Console.WriteLine(message);
        Console.WriteLine(String.Concat(Enumerable.Repeat('-', 50)));

        Console.WriteLine($"a = {data["a"]}");
        Console.WriteLine($"b = {data["b"]}");
        Console.WriteLine($"c = {data["c"]}");

    }

    static void Decision(int a, int b, int c)
    {
        int D = (int)Math.Pow(b, 2) - 4 * a * c;
        if (D > 0)
        {
            int x1 = (int)(-b + Math.Sqrt(D)) / (2 * a);
            int x2 = (int)(-b - Math.Sqrt(D)) / (2 * a);

            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else if (D == 0)
        {
            int x = -(b / 2 * a);

            Console.WriteLine($"x = {x}");
        }
        else if (D < 0)
        {
            Console.WriteLine("Уравнение не имеет корней");
        }

    }
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите значение a: ");
            a1 = Console.ReadLine();
            a = Int32.Parse(a1);

            Console.WriteLine("Введите значение b: ");
            b1 = Console.ReadLine();
            b = Int32.Parse(b1);

            Console.WriteLine("Введите значение c: ");
            c1 = Console.ReadLine();
            c = Int32.Parse(c1);

            Decision(a, b, c);
        }catch(Exception e)
        {
            e.Data.Add("a", a1);
            e.Data.Add("b", b1);
            e.Data.Add("c", c1);

            FormatData(e.Message, severity, e.Data);
        }
    }
}