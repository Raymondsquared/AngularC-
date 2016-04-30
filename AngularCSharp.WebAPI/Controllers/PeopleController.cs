using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using AngularCSharp.Core.Interfaces;
using AngularCSharp.Core.Models;

namespace AngularCSharp.WebAPI.Controllers
{
    public class PeopleController : ApiController
    {
        private readonly IGenericService<Person> _peopleService;

        public PeopleController(IGenericService<Person> peopleService)
        {
            _peopleService = peopleService;
        }

        [Route("api/v1/people")]
        public async Task<HttpResponseMessage> GetAll()
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            try
            {
                response = Request.CreateResponse(HttpStatusCode.OK, await _peopleService.GetAllAsync());
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }
    }
}
