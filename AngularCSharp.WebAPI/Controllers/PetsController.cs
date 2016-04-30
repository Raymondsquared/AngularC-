using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using AngularCSharp.Core;
using AngularCSharp.Core.Interfaces;
using AngularCSharp.Core.Models;

namespace AngularCSharp.WebAPI.Controllers
{
    //not safe but for the sake of testing
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class PetsController : ApiController
    {
        private readonly IPetService _petService;

        public PetsController(IPetService petService)
        {
            _petService = petService;
        }

        [Route("api/v1/cats")]
        public async Task<HttpResponseMessage> GetAllCatsGroupByGender(Constants.GroupBy groupBy)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK);
            try
            {
                response = Request.CreateResponse(HttpStatusCode.OK, await _petService.GetAllCatsAsync(groupBy));
            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

            return response;
        }
    }
}
