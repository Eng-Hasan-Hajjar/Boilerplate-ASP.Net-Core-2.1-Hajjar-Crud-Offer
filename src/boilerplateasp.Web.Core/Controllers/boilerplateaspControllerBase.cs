using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace boilerplateasp.Controllers
{
    public abstract class boilerplateaspControllerBase: AbpController
    {
        protected boilerplateaspControllerBase()
        {
            LocalizationSourceName = boilerplateaspConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
