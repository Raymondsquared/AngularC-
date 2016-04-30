using System;
using System.Threading.Tasks;
using AngularCSharp.Core.Interfaces;

namespace AngularCSharp.Infrastructure.DAL
{
    public class DefaultPeopleRepository : IRepository
    {
        public async Task<string> GetAll()
        {
            return String.Empty;
        }
    }
}
