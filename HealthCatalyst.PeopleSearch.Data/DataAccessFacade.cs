
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PeopleSearch.Data
{
    /// <summary>
    /// Exposes database related calls through EF code first
    /// </summary>
    public static class DataAccessFacade
    {
        /// <summary>
        /// Gets the name of the people by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static List<Person> GetPeopleByName(string name)
        {
            List<Person> result = null;
            using (DatabaseContext db = new DatabaseContext("SqliteContext"))
            {
                result = db.Persons.Where(p => p.FirstName.ToLower().StartsWith(name.ToLower()) || p.LastName.ToLower().StartsWith(name.ToLower())).ToList();
            }
            return result;
        }

        //Was used to quickly add some random pages to all the 'people' records
        //private void SetRandomAges()
        //{
        //    using (SQLiteConnection db = new SQLiteConnection(_connString))
        //    {
        //        var persons = db.Table<Person>().ToList();
        //        Random r = new Random();
        //        foreach (var p in persons)
        //        {
        //            int age = r.Next(18, 70);
        //            p.Age = age;
        //            db.Update(p);
        //        }
        //    }

        //}

       
    }
}

