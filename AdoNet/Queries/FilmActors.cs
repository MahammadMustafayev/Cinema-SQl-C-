using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNet.Queries
{
    class FilmActors
    {
        public static void Create(int filmId, int actorId)
        {
            Sql.Execute($"INSERT INTO FilmActors VALUES({filmId},{actorId})");
        }
        public static void Update(int filmId, int id)
        {
            Sql.Execute($"UPDATE FilmActors SET {filmId} WHERE Id={id}");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE FilmActors WHERE Id={id}");
        }
        public static void Select()
        {
            Sql.Select($"SELECT * FROM FilmActors");
        }
    }
}
