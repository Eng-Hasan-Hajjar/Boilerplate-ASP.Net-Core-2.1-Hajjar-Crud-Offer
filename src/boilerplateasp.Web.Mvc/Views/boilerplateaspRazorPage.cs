using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace boilerplateasp.Web.Views
{
    public abstract class boilerplateaspRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected boilerplateaspRazorPage()
        {
            LocalizationSourceName = boilerplateaspConsts.LocalizationSourceName;
        }
    }
}
