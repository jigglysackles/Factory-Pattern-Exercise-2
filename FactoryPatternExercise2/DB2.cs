namespace FactoryPatternExercise2;

public class DB2 : IDataAccess
{
    public void Read()
    {
        Console.WriteLine("Reading from DB2!");
    }

    public void Write()
    {
        Console.WriteLine("Writing to DB2!");
    }
}