using System.Collections.Generic;
using boilerplateasp.Roles.Dto;

namespace boilerplateasp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}