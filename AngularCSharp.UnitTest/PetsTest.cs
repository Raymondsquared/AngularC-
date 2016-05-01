using System;
using System.Linq;
using AngularCSharp.Core;
using AngularCSharp.Core.Serializers;
using AngularCSharp.Core.Services;
using AngularCSharp.Infrastructure.DAL;
using AngularCSharp.Infrastructure.DAL.WebServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AngularCSharp.UnitTest
{
    [TestClass]
    public class PetsTest
    {        
        private readonly PetService _petService = new PetService(new PeopleService(new WebServicePeopleRepository("http://agl-developer-test.azurewebsites.net/people.json"), new JsonSerializer()));

        [TestMethod]
        public void getCatsIsNotNullOrEmpty()
        {
            Assert.IsNotNull(_petService.GetAllCatsAsync(Constants.GroupBy.Gender).Result);
            Assert.IsTrue(_petService.GetAllCatsAsync(Constants.GroupBy.Gender).Result.Any());
        }
        [TestMethod]
        public void getCatsIsWorking()
        {
            Assert.IsTrue(_petService.GetAllCatsAsync(Constants.GroupBy.Gender).Result.Count() == 2);
            Assert.IsTrue(_petService.GetAllCatsAsync(Constants.GroupBy.Gender).Result.SelectMany(g => g.Pets).Count() == 7);
        }
    }
}
