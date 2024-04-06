namespace Q4;

public class Program
{
    public static void Main(string[] args)
    {
        Retangulo retangulo = new Retangulo(10, 5);
        Console.WriteLine(retangulo.CalculaArea());
    }

    public class Retangulo(double largura, double altura)
    {
        private double Largura { get; set; } = largura;
        private double Altura { get; set; } = altura;
        
        
        public double CalculaArea()
        {
            return Largura * Altura;
        }
    }
}