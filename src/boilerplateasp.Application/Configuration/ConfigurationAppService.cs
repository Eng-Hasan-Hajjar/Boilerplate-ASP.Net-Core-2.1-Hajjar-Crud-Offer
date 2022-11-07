using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using boilerplateasp.Configuration.Dto;

namespace boilerplateasp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : boilerplateaspAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
