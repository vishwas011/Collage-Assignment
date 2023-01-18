using var connection = new Microsoft.Data.Sqlite.SqliteConnection();
connection.ConnectionString = "Filename=Employee.db";
connection.Open();
using var command = connection.CreateCommand();
if(args.Length == 0)
{
    command.CommandText = "SELECT * FROM Employee";
    using var dataReader = command.ExecuteReader();
    while(dataReader.Read())
        Console.WriteLine("{0, -6}{1, 6}{2, 6}{3, 6}{4, 6}", dataReader.GetInt32(0), dataReader.GetInt32(1), dataReader.GetInt32(2),dataReader.GetInt32(3), dataReader.GetString(4));
         //Console.WriteLine("{0} {1}", dataReader.GetInt32(0), dataReader.GetInt32(1));
}
else 
{
    int EmpId = int.Parse(args[0]);
  //  command.CommandText = $"UPDATE Employee sal = sal + 2000 where EmpId ={EmpId}";
    int n = command.ExecuteNonQuery();
    if(n == 0)
        Console.WriteLine("No such product!");
}