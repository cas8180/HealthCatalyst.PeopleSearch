using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;

namespace HealthCatalyst.PeopleSearch.Web.Models
{
    public class SearchResultViewModel
    {
        public SearchResultViewModel()
        {

        }
        public SearchResultViewModel(PeopleSearch.MiddleWare.Models.Person p)
        {
            //Contract.Requires<NullReferenceException>(p == null);
            Name = $"{p.FirstName} {p.LastName}";
            Image = $"/content/images/{p.ID}.jpg";
            Age = p.Age;
            Interests = p.Interests;
        }

        public string Name { get; set; }
        public string Image { get; set; }
        public int? Age { get; set; }
        public string Interests { get; set; }
    }
}