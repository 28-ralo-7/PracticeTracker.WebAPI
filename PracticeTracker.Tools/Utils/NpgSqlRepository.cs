using System.Collections.Immutable;
using Npgsql;
using Microsoft.Extensions;
namespace PracticeTracker.Tools.Utils;

public class NpgSqlRepository
{
    private String ConnectionString = "Host=localhost;Port=5432;Database=practice_tracker;Username=postgres;Password=1";
    private NpgsqlConnection connection;
    
    public NpgSqlRepository()
    {
        connection = new NpgsqlConnection(ConnectionString);
        connection.Open();
    }
    
    public T Get<T>(String command) where T : new()
    {
        using (NpgsqlCommand cmd = new NpgsqlCommand(command, connection))
        {
            using (NpgsqlDataReader reader = cmd.ExecuteReader())
                while (reader.Read())
                {
                    T objectDb = Read<T>(reader);
                    return objectDb;
                }
        }

        return new T();
    }

    private static T Read<T>(NpgsqlDataReader reader)
    {
        var objectDb = Activator.CreateInstance<T>();

        for (int i = 0; i < reader.FieldCount; i++)
        {
            string propertyName = reader.GetName(i);
            var property = typeof(T).GetProperties()
                .FirstOrDefault(p => string.Equals(p.Name, propertyName, StringComparison.OrdinalIgnoreCase)); 

            if (property != null)
            {
                object value = reader.GetValue(i);

                if (value != DBNull.Value)
                {
                    property.SetMethod?.Invoke(objectDb, new object[] { Convert.ChangeType(value, property.PropertyType) });
                }
            }
        }

        return objectDb;
    }
    
    
}