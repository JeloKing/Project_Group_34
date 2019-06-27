using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Week4Poging2.Models;
using Xamarin.Forms;

namespace Week4Poging2
{
    class DatabaseManager
    {
        private SQLiteConnection database;

        public DatabaseManager()
        {
            database = Xamarin.Forms.DependencyService.Get<DependencyService>().CreateConnection();
        }

        public List<Movies> GetAllMovies()
        {
            return database.Query<Movies>("SELECT * FROM Movie").ToList();
        }

        public List<Series> GetAllSeries()
        {
            return database.Query<Series>("SELECT * FROM Series").ToList();
        }

        //public List<Movies> GetAllMoviesByUser()
        //{

        //}

        //public List<Series> GetAllSeriesByUser()
        //{

        //}

        public bool DoesAccountExist(string Username, string Password)
        {
            var searchUser = "SELECT * FROM User WHERE Username = @0 AND Password = @1";
            var test = database.Query<User>(searchUser, Username, Password);
            if (test.Count == 1)
            {
                test.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddUser(string Username, string Password)
        {
            var insertCommandUser = "INSERT INTO User (Username, Password) VALUES(@0, @1)";
            if (DoesAccountExist(Username, Password) == true)
            {
                return false;
            }
            else
            {
                database.Execute(insertCommandUser, Username, Password);
                return true;
            }
        }

        public bool AddMovie(string Title, string Description, string Year)
        {
            var insertCommand = "INSERT INTO Movie (Title, Description, Imagesource) VALUES(@0, @1, @2)";
            database.Execute(insertCommand, Title, Description, Year);
            return true;
        }

        //public void AddSeries(string title, string description, string yearStarted, string yearEnded, int numberOfEpisodes, int numberOfSeasons)
        //{

        //}

        //public User GetUser()
        //{

        //}


    }
}
