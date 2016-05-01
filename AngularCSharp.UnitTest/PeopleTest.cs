using System;
using System.Linq;
using AngularCSharp.Core.Serializers;
using AngularCSharp.Core.Services;
using AngularCSharp.Infrastructure.DAL;
using AngularCSharp.Infrastructure.DAL.WebServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AngularCSharp.UnitTest
{
    [TestClass]
    public class PeopleTest
    {
        private readonly PeopleService _peopleService = new PeopleService(new WebServicePeopleRepository("http://agl-developer-test.azurewebsites.net/people.json"), new JsonSerializer());

        [TestMethod]
        public void getAllPeopleIsNotNullOtEmpty()
        {
            Assert.IsNotNull(_peopleService.GetAllAsync().Result);
            Assert.IsTrue(_peopleService.GetAllAsync().Result.Any());
        }

        [TestMethod]
        public void getAllPeopleReturnedAllData()
        {            
            Assert.IsTrue(_peopleService.GetAllAsync().Result.Count() == 6);
        }
    }
}
