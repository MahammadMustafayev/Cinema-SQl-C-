using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNet.Queries
{
    class Sessionss
    {
        public static void Create(DateTime time)
        {
            Sql.Execute($"INSERT INTO Sessionss VALUES ({time})");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE Sessionss WHERE Id={id}");
        }
        
        public static void Update(DateTime time, int id)
        {
            Sql.Execute($"UPDATE Sessionss SET {time} WHERE Id={id}");
        }
        public static void Select()
        {
            Sql.Select($"SELECT * FROM Sessionss");
        }
    }
}
