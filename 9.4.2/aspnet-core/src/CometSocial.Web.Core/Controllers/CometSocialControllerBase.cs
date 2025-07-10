using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CometSocial.Controllers
{
    public abstract class CometSocialControllerBase: AbpController
    {
        protected CometSocialControllerBase()
        {
            LocalizationSourceName = CometSocialConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
