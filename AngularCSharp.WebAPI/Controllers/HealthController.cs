using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularCSharp.WebAPI.Controllers
{
    public class HealthController : ApiController
    {
        [Route("health")]
        public HttpResponseMessage HealthCheck()
        {
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
