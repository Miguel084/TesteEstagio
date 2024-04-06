namespace Q5;

public class Program
{
    public static void Main(string[] args)
    {
        string meuNome = "Miguel de Oliveira";
        Console.WriteLine(InverteString(meuNome));
    }
    
    public static string InverteString(string texto)
    {
        return new string(texto.Reverse().ToArray());
    }
}