using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PeopleSearch.Data
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(string connStringName) : base(connStringName)
        { }
        public DbSet<Person> Persons { get; set; }
    }
}
