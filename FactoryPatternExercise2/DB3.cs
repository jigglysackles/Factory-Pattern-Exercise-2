namespace FactoryPatternExercise2;

public class DB3 : IDataAccess
{
    public void Read()
    {
        Console.WriteLine("Reading from DB3!");
    }

    public void Write()
    {
        Console.WriteLine("Writing to DB3!");
    }
}