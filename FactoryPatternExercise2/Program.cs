namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hullo thar. Looks like you need to connect to a DB. Give me a number 1-3!");
            
            Random rnd = new Random();
            var dBActual = rnd.Next(1, 6);
            var whatever = Console.ReadLine();
            
            var connectedDB = DBAccessFactory.ConnectDatabase(dBActual);
            
            connectedDB.Read();
            connectedDB.Write();

            Console.WriteLine("If you think this is an error, you're wrong.\nI didn't listen to what you wanted and just connected to a random database.\n60% of the time it works everytime." );
            
        }
    }
}
