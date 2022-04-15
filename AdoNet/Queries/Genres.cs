using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNet.Queries
{
    class Genres
    {
        public static void Create(string name)
        {
            Sql.Execute($"INSERT INTO Genres VALUES (N'{name}')");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE Genres WHERE Id={id}");
        }
        public static void Read(string name)
        {
            Sql.Execute($"SELECT * FROM Genres WHERE N'{name}' LIKE '%a%'");
        }
        public static void Update(string name, int id)
        {
            Sql.Execute($"UPDATE Genres SET N'{name}' WHERE Id={id}");
        }
        public static void Select()
        {
            Sql.Select($"SELECT * FROM Genres");
        }
    }
}
