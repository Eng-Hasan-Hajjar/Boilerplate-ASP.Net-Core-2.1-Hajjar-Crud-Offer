using System.Threading.Tasks;
using boilerplateasp.Configuration.Dto;

namespace boilerplateasp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
