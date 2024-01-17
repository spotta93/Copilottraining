// Data/DatabaseContext.cs
using Microsoft.Data.Sqlite;
using Dapper;

public class DatabaseContext
{
    private readonly string _connectionString;

    public DatabaseContext()
    {
        _connectionString = "Data Source=C:\\Users\\spotta\\OneDrive - Black Knight\\Documents\\AI Training\\CoPilot-Lab-Files-main\\db\\Chinook.db";
    }

    public IDbConnection Connection
    {
        get
        {
            return new SqliteConnection(_connectionString);
        }
    }
}