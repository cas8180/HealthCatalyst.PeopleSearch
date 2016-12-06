using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthCatalyst.PeopleSearch.MiddleWare.Services;

namespace HealthCatalyst.PeopleSearch.MiddleWare.Test
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void A_GetPersonByName()
        {
            var personByLastName = PersonService.Instance.GetPeopleByName("Peeters");
            Assert.IsTrue(personByLastName != null && personByLastName.Count == 1);
        }

        [TestMethod]
        public void B_GetPeopleAllPeopleWith_P()
        {
            var peopleWithPInName = PersonService.Instance.GetPeopleByName("p");
            Assert.IsTrue(peopleWithPInName != null && peopleWithPInName.Count == 7);
        }
    }
}
