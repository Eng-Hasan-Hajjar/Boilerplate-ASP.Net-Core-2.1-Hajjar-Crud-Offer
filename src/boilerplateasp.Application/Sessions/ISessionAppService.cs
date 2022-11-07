using System.Threading.Tasks;
using Abp.Application.Services;
using boilerplateasp.Sessions.Dto;

namespace boilerplateasp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
