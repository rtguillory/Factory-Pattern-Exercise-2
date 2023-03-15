namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Enter the type of database you would like to use.\nYou can type list, sql, or mongo.");
            string userDBType = Console.ReadLine();

            IDataAccess dbType = DataAccessFactory.GetDataAccessType(userDBType);
            dbType.LoadData();
            dbType.SaveData();
        }
    }
}
