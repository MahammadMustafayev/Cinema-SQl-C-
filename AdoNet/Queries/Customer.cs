using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNet.Queries
{
    class Customer
    {
        public static void Create(string name, string surname, int age)
        {
            Sql.Execute($"INSERT INTO Customer VALUES (N'{name}',N'{surname}',{age})");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE Customer WHERE Id={id}");
        }
        public static void Read(string name)
        {
            Sql.Execute($"SELECT * FROM Customer WHERE N'{name}' LIKE '%a%'");
        }
        public static void Update(string name, int id)
        {
            Sql.Execute($"UPDATE Customer SET '{name}' WHERE Id={id}");
        }
        public static void Select()
        {
            Sql.Select($"SELECT * FROM Customer");
        }
    }
}
