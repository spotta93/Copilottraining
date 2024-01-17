// Data/DatabaseContext.cs
using Microsoft.Data.Sqlite;
using Dapper;

public class DatabaseContext
{
    private readonly string _connectionString;

    public DatabaseContext()
    {
        _connectionString = "Data Source=c:\\users\\johndohoney\\reports.db";
    }

    public IDbConnection Connection
    {
        get
        {
            return new SqliteConnection(_connectionString);
        }
    }
}