namespace Q2;

public static class Program
{
    public static void Main(string[] args)
    {
        double media = CalculaMedia([10, 5]);
        Console.WriteLine(media);
    }
    
    public static double CalculaMedia(int[] numeros)
    {
        double soma = 0;
        foreach (var t in numeros)
        {
            soma += t;
        }
        return soma / numeros.Length;
    }
}