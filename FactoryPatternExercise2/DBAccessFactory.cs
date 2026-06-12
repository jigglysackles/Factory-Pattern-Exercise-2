namespace FactoryPatternExercise2;

public static class DBAccessFactory
{
    public static IDataAccess ConnectDatabase(int dBNumber)
    {
        switch (dBNumber)
        {
            case 1:
                return new DB1();
            case 2:
                return new DB2();
            case 3:
                return new DB3();
            default:
                return new NotAvailable();
        }
    }
}