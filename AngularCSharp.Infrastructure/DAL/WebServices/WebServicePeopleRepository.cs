using System;
using System.Threading.Tasks;
using AngularCSharp.Core.Exceptions;
using AngularCSharp.Core.Helpers;
using AngularCSharp.Core.Interfaces;

namespace AngularCSharp.Infrastructure.DAL.WebServices
{
    public class WebServicePeopleRepository : IRepository
    {
        private readonly string _endPoint;

        public WebServicePeopleRepository(string endPoint)
        {
            _endPoint = endPoint;
        }

        public async Task<string> GetAll()
        {
            string result;

            try
            {
                result = await HttpClientHelper.GetAsync(_endPoint);
            }
            catch (Exception ex)
            {
                throw new InfrastructureLayerException("web request throws exception");
            }

            return result;

        }
    }
}
