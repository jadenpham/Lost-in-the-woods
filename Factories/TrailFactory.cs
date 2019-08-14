using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using LostInTheWoods.Models;

namespace LostInTheWoods.Factories
{
    public class TrailFactory
    {
        private string connectionString;
        public TrailFactory()
        {
            connectionString = "server=localhost;userid=root;password=root;port=3306;database=lostinwoods;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get{
                return new MySqlConnection(connectionString);
            }
        }
        public void AddNewTrail(Trail item)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "INSERT INTO trails (name, description, length, elevation, longitude, latitude) VALUES (@Name, @Description, @Length, @Elevation, @Longitude, @Latitude);";
                dbConnection.Open();
                dbConnection.Execute(query, item);
            }
        }

        public IEnumerable<Trail> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM trails").ToList();
            }
        }

        public Trail FindOne(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM trails WHERE id = @Id", new { Id = id }).FirstOrDefault();
            }
        }

    }

}