using System.Threading.Tasks;
using Abp.Application.Services;
using CometSocial.Authorization.Accounts.Dto;

namespace CometSocial.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
