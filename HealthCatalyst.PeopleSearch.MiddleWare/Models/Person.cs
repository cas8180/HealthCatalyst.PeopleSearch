using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PeopleSearch.MiddleWare.Models
{
    public class Person
    {
        public long? ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int? Age { get; set; }

        public string Interests { get; set; }

    }
}
