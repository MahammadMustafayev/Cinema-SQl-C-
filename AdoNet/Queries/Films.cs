using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNet.Queries
{
    class Films
    {
        public static void Create(string name, DateTime releaseDate)
        {
            Sql.Execute($"INSERT INTO Films VALUES (N'{name}',{releaseDate})");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE Films WHERE Id={id}");
        }
        public static void Read(string name)
        {
            Sql.Execute($"SELECT * FROM Films WHERE N'{name}' LIKE '%a%'");
        }
        public static void Update(string name, int id)
        {
            Sql.Execute($"UPDATE Films SET N'{name}' WHERE Id={id}");
        }
        public static void Select()
        {
            Sql.Select($"SELECT * FROM Films");
        }
        
    }
}
