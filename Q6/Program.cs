public class Program
{
    public static void Main(string[] args)
    {
        VideoGame playStation = new PlayStation();
        playStation.Ligar();
        
        VideoGame xbox = new Xbox();
        xbox.Ligar();
    }

    public class VideoGame
    {   
        public string Nome { get; set; }
        
        public virtual void Ligar()
        {
            Console.WriteLine("Ligando o video game...");
        }
    }
    
    public class PlayStation : VideoGame
    {
        public override void Ligar()
        {
            Console.WriteLine("Ligando o PlayStation...");
        }
    }
    
    public class Xbox : VideoGame
    {
        public override void Ligar()
        {
            Console.WriteLine("Ligando o Xbox...");
        }
    }
}