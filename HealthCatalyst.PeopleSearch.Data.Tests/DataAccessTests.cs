using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HealthCatalyst.PeopleSearch.Data.Tests
{
    [TestClass]
    public class DataAccessTests
    {
        [TestMethod]
        public void A_GetPersonByName()
        {
            var personByLastName = DataAccessFacade.GetPeopleByName("Peeters");
            Assert.IsTrue(personByLastName != null && personByLastName.Count==1);
        }

        [TestMethod]
        public void B_GetPeopleAllPeopleWith_P()
        {
            var peopleWithPInName = DataAccessFacade.GetPeopleByName("p");
            Assert.IsTrue(peopleWithPInName != null && peopleWithPInName.Count == 7);
        }
    }
}
