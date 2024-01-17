// Data/DatabaseContext.cs
using Microsoft.Data.Sqlite;
using Dapper;
using System.Data;

public class DatabaseContext
{
    private readonly string _connectionString;

    public DatabaseContext()
    {
        _connectionString = @"Data Source=C:\\Users\\spotta\\db\\Chinook.db";
    }

    public IDbConnection Connection
    {
        get
        {
            return new SqliteConnection(_connectionString);
            
        }
    }
}