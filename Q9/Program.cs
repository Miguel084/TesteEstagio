public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Matematica.Soma(10, 5));
        Console.WriteLine(Matematica.Subtrai(10, 5));
    }
    
    public class Matematica
    {
        public static double Soma(double a, double b)
        {
            return a + b;
        }

        public static double Subtrai(double a, double b)
        {
            return a - b;
        }
    }
}
