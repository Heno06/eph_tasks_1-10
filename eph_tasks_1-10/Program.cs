namespace eph_tasks_1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            double y = double.Parse(Console.ReadLine());
            double z = (x + 4) / Math.Pow(Math.Pow(y, 2) + 4, 3.0 / 5);
            Console.WriteLine((y + 1) * (x + Math.Pow(x, 2) + Math.Pow(1, 6) * Math.Sin(Math.Pow(x, 2) - 3) - Math.Tan(y)));
            Console.WriteLine((Math.Pow(x, 2) - 4) /(Math.Pow(y, 2)+2) + Math.Pow(2, Math.Sin(Math.Sqrt(Math.Pow(x, 2)+1))));
            Console.WriteLine(1 / Math.Tan(Math.Abs(Math.Pow(x, 2) - y) / (Math.Pow(x, 2) + Math.Pow(y, 2))) + Math.Log10(Math.Pow(x, 2) + 1));
            Console.WriteLine(Math.Log(Math.Exp(x + 1)) + Math.Pow(Math.Pow(x, 2) + 4, 1.0 / 3));
            Console.WriteLine((Math.Pow(2, x) - 5) / (Math.Pow(3, y) + 2) + Math.Log(Math.Pow(Math.Abs(x) + 1, 4), 2) + Math.Pow(y, 2));
            Console.WriteLine(Math.Atan((3 * x + 4) / (Math.Pow(y, 2) + 4)) + Math.Sqrt(Math.Pow(x, 2) + 3));
            Console.WriteLine(Math.Pow(Math.Pow(Math.Pow(x, 2) + Math.Pow(y, 2), 5) + 4, 1.0 / 7) + Math.Sin(Math.Cos(x + y)));
            Console.WriteLine(Math.Pow(Math.Pow((Math.Pow(x, 2) + Math.Pow(y, 2)), 5) + 4, 7) + Math.Sin(Math.Cos(x + y)));
            Console.WriteLine(Math.Pow(x * x + Math.Pow(Math.Pow(y, 2) + 4, 1.0 / 3), 1.0 / 4) + Math.Pow(Math.Abs(x) + Math.Abs(y), 10));
            Console.WriteLine(Math.Sin(Math.Pow((x + z), 2)) + 3 * z + y / Math.Pow(x, 2));
            Console.WriteLine(Math.Sin(Math.PI / 12 + x) * Math.Cos(Math.Pow((y + z) / (Math.PI + Math.Pow(z, 2)), 2)) + Math.Exp(Math.Pow(z, 4)));
        }
    }
}
