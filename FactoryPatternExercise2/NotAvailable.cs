namespace FactoryPatternExercise2;

public class NotAvailable : IDataAccess
{
    public void Read()
    {
        Console.WriteLine("No DB available!");
    }

    public void Write()
    {
        Console.WriteLine("No DB available!");
    }
}
