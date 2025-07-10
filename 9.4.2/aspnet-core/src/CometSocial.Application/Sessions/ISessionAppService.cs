using System.Threading.Tasks;
using Abp.Application.Services;
using CometSocial.Sessions.Dto;

namespace CometSocial.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
