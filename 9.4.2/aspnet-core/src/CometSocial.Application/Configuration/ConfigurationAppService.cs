using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CometSocial.Configuration.Dto;

namespace CometSocial.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CometSocialAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
