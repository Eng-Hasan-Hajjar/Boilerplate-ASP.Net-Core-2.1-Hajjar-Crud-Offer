using Abp.AspNetCore.Mvc.ViewComponents;

namespace boilerplateasp.Web.Views
{
    public abstract class boilerplateaspViewComponent : AbpViewComponent
    {
        protected boilerplateaspViewComponent()
        {
            LocalizationSourceName = boilerplateaspConsts.LocalizationSourceName;
        }
    }
}
