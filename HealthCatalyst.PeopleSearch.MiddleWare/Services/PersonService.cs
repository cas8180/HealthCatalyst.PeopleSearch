using AutoMapper;
using HealthCatalyst.PeopleSearch.Data;
using HealthCatalyst.PeopleSearch.MiddleWare.Contracts;
using System;
using System.Collections.Generic;
using System.IO;

namespace HealthCatalyst.PeopleSearch.MiddleWare.Services
{
    public class PersonService : IPersonServices
    {
        private MapperConfiguration _config = null;
        private IMapper _mapper = null;
        private static PersonService _instance = null;
        private static readonly object _lock = new object();

        //Singleton instance
        public static PersonService Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PersonService();
                    }
                    return _instance;
                }
            }
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="PersonService"/> class from being created.
        /// </summary>
        private PersonService()
        {
            _config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Data.Person, Models.Person>()
                .ForMember(x => x.ID, opt => opt.MapFrom(src => src.CustomerId));
            });

            _mapper = _config.CreateMapper();

            //This will give us a relative path regardless of what environment this gets deployed to
            //the main reason for this is because we have no knowledge of how or where this will run
            //so we are using a relative path to how the current solution is currently structurered
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            AppDomain.CurrentDomain.SetData("DataDirectory", $"{di.Parent.FullName}\\DB");
        }

        /// <summary>
        /// Gets the name of the people by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public List<Models.Person> GetPeopleByName(string name)
        {
            //we would normally add any business logic here

            var peopleByName = DataAccessFacade.GetPeopleByName(name);
            //Map to the service level model
            return _mapper.Map<List<Models.Person>>(peopleByName);
        }
    }
}