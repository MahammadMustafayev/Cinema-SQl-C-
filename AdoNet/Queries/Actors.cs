using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNet.Queries
{
    class Actors
    {
        public static void Create(string name,string surname,int age)
        {
            Sql.Execute($"INSERT INTO Actors VALUES (N'{name}',N'{surname}',{age})");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE Actors WHERE Id={id}");
        }
        public static void Read(string name)
        {
            Sql.Execute($"SELECT * FROM Actors WHERE {name} LIKE '%a%'");
        }
        public static void Update(string name, int id)
        {
            Sql.Execute($"UPDATE Actors SET {name} WHERE Id={id}");
        }
        public static void Select()
        {
            Sql.Select($"SELECT * FROM Actors");
        }
    }
}
