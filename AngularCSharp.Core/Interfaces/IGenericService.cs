using System.Collections.Generic;
using System.Threading.Tasks;

namespace AngularCSharp.Core.Interfaces
{
    public interface IGenericService<T>
    {
        Task<IEnumerable<T>> GetAllAsync();

    }
}
