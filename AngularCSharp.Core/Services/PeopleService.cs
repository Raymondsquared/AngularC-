using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AngularCSharp.Core.Exceptions;
using AngularCSharp.Core.Interfaces;
using AngularCSharp.Core.Models;

namespace AngularCSharp.Core.Services
{    
    public class PeopleService : IGenericService<Person>
    {
        private readonly IRepository _peopleRepository;
        private readonly ISerializer _jsonSerializer;

        public PeopleService(IRepository peopleRepository, ISerializer jsonSerializer)
        {
            _peopleRepository = peopleRepository;
            _jsonSerializer = jsonSerializer;
        }

        public async Task<IEnumerable<Person>> GetAllAsync()
        {
            var result = new List<Person>();

            var data = await _peopleRepository.GetAll();

            if (!String.IsNullOrEmpty(data))
            {
                try
                {
                    result = _jsonSerializer.Deserialise<List<Person>>(data);
                }
                catch (Exception ex)
                {
                    throw new CoreLayerException("can't deserialise");
                }
            }
    
            return result;
        }
    }
}
