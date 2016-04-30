using System.Threading.Tasks;

namespace AngularCSharp.Core.Interfaces
{
    public interface IRepository
    {
        Task<string> GetAll();
    }
}
