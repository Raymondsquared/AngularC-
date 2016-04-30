using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularCSharp.Core.Interfaces;
using AngularCSharp.Core.Models;

namespace AngularCSharp.Core.Services
{    
    public class PetService : IPetService
    {
        private readonly IGenericService<Person> _peopleService;

        public PetService(IGenericService<Person> peopleService)
        {
            _peopleService = peopleService;            
        }
        
        public async Task<IEnumerable<GenderPetsResponseDto>> GetAllCatsAsync(Constants.GroupBy groupBy)
        {

            var result = new List<GenderPetsResponseDto>();
            
            var people = await _peopleService.GetAllAsync();
            if (people != null && people.Any())
            {
                //LINQ
                var groupedObjects = people
                    .Where
                    (
                        pep =>
                            pep.pets != null &&
                            pep.pets.Any
                            (
                                pet => String.Equals(pet.type, "Cat", StringComparison.CurrentCultureIgnoreCase)
                            )
                    )
                    .GroupBy(pep => pep.gender)
                    .Select(newGroup => new
                    {
                        Gender = newGroup.Key,
                        Pets = newGroup
                            .SelectMany(pep => pep.pets.Where( pet => String.Equals(pet.type, "Cat", StringComparison.CurrentCultureIgnoreCase)))
                            .OrderBy(pet => pet.name)
                    });


                //MAP TO DTO
                result.AddRange
                (
                    groupedObjects
                        .Select
                        (
                            groupedObject => 
                                new GenderPetsResponseDto()
                                {
                                    Gender = groupedObject.Gender,
                                    Pets = groupedObject.Pets
                                }
                        )
                );
            }

            return result;
        }
    }
}
