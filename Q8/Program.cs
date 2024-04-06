public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();
        Console.WriteLine(ContarVogais(frase));
    }

    private static int ContarVogais(string? frase)
    {
        int contador = 0;
        foreach (var letra in frase)
        {
            if (letra == 'a' || letra == 'A' || letra == 'e' || letra == 'E' || letra == 'i' || letra == 'I' || letra == 'o' || letra == 'O' || letra == 'u' || letra == 'U')
            {
                contador++;
            }
        }
        return contador;
    }
}