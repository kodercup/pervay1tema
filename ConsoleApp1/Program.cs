class Program
{
    static double Calculate(double x)
    {
        return 7 * x * x * 3 * x + 6;
    }

    static double Calc(double a)
    {
        return 12 * a * a + 7 * a + 12;

    }

    static void Main(string[] args)
    {
        Console.WriteLine("Программа вычисления функции y = 7x^2 + 3 x + 6 ");
        Console.WriteLine("Программа вычисления y = 12a^2 + 7a + 12 ");

        Console.WriteLine("Введите значение x: ");

        Console.WriteLine("Введите значение а : ");

        double x = Convert.ToDouble(Console.ReadLine());

        double a = Convert.ToDouble(Console.ReadLine());

        double result = Calculate(x);
        double res = Calc(a);

        Console.WriteLine($"Результат: {result}");
        Console.WriteLine($"Результат {res}");

    }

}
