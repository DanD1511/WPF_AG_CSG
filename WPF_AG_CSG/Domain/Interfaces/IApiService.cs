using System.Collections.Generic;
using System.Threading.Tasks;

namespace WPF_AG_CSG.Domain.Interfaces
{
    public interface IApiService
    {
        Task<string> Post(string uri, Dictionary<string, object> data);
    }
}
