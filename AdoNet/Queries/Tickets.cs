using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNet.Queries
{
    class Tickets
    {
        /*CUD Emeliyyati*/
        public static void Create(DateTime soldDate,decimal price,int place,int customerId,int hallId,int filmId,int sessionssId)
        {
            Sql.Execute($"INSERT INTO Tickets VALUES({soldDate},{price},{place},{customerId},{hallId},{filmId},{sessionssId})" );
        }
        public static void Update(decimal price,int id)
        {
            Sql.Execute($"UPDATE Tickets SET {price} WHERE Id={id}");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE Tickets WHERE Id={id} ");
        }
        public static void Select()
        {
            Sql.Select($"SELECT * FROM Tickets");
        }
    }
}
