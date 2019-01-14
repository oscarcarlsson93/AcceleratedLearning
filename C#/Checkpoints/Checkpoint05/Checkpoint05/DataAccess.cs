using Checkpoint05.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;



namespace Checkpoint05
{
    class DataAccess
    {
        string conString = "Server = (localdb)\\mssqllocaldb; Database = GnomeDb";

        internal List<Gnome> GetGnomesFromDatabase()
        {
            var sql = @"SELECT GnomeName, GnomeBeard, GnomeIsEvil, Temperament, RaceName
                        FROM Gnome
                        JOIN GnomeRace on Gnome.RaceId = GnomeRace.RaceId";

            using (SqlConnection connection = new SqlConnection(conString))
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                var list = new List<Gnome>();

                while (reader.Read())
                {

                     var gnome = new Gnome
                    {
                        
                        GnomeName = reader.GetSqlString(0).Value,
                        Beard = reader.GetSqlString(1).Value,
                        IsEvil = reader.GetSqlString(2).Value,
                        Temperament = reader.GetSqlInt32(3).Value,
                        Race = reader.GetSqlString(4).Value,    
                    };
                    list.Add(gnome);
                }

                return list;
            }
        }
    }
}
