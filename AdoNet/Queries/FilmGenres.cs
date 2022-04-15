using System;
using System.Collections.Generic;
using System.Text;

namespace AdoNet.Queries
{
    class FilmGenres
    {
        public static void Create(int filmId,int genresId)
        {
            Sql.Execute($"INSERT INTO FilmGenres VALUES({filmId},{genresId})");
        }
        public static void Update(int filmId,int id)
        {
            Sql.Execute($"UPDATE FilmGenres SET {filmId} WHERE Id={id}");
        }
        public static void Delete(int id)
        {
            Sql.Execute($"DELETE FilmGenres WHERE Id={id}");
        }
        public static void Select()
        {
            Sql.Select($"SELECT * FROM FilmGenres");
        }
    }
}
