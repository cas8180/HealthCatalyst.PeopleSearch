using HealthCatalyst.PeopleSearch.MiddleWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCatalyst.PeopleSearch.MiddleWare.Contracts
{
    public interface IPersonServices
    {
        List<Person> GetPeopleByName(string name);
    }
}
