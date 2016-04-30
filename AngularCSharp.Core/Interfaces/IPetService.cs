using System.Collections.Generic;
using System.Threading.Tasks;
using AngularCSharp.Core.Models;

namespace AngularCSharp.Core.Interfaces
{
    public interface IPetService
    {
        Task<IEnumerable<GenderPetsResponseDto>> GetAllCatsAsync(Constants.GroupBy groupBy);
    }
}
