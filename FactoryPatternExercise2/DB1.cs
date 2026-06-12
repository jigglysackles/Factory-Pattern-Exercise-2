namespace FactoryPatternExercise2;

public class DB1 : IDataAccess
{
    public void Read()
    {
        Console.WriteLine("Reading from DB1!");
    }

    public void Write()
    {
        Console.WriteLine("Writing to DB1!");
    }
}