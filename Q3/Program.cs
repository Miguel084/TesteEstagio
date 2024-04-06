namespace Q3;

public static class Program
{
    public static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("Miguel de Oliveira", 19);
        pessoa.Apresentar();
    }

    private class Pessoa(string nome, int idade)
    {
        private string Nome { get; set; } = nome;
        private int Idade { get; set; } = idade;

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome} e tenho {Idade} anos de idade.");
        }
    }
}