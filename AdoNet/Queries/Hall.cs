using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNet.Queries
{
    class Hall
    {
        public static void Create(string name,int seatCount)
        {
            Sql.Execute($"INSERT INTO Hall VALUES (N'{name}',{seatCount})");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE Hall WHERE Id={id}");
        }
        public static void Read(string name)
        {
            Sql.Execute($"SELECT * FROM Hall WHERE {name} LIKE '%a%'");
        }
        public static void Update(string name, int id)
        {
            Sql.Execute($"UPDATE Hall SET {name} WHERE Id={id}");
        }
        public static void Select()
        {
            Sql.Select($"SELECT * FROM Hall");
        }
    }
}
