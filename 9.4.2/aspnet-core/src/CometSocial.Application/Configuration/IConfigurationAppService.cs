using System.Threading.Tasks;
using CometSocial.Configuration.Dto;

namespace CometSocial.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
