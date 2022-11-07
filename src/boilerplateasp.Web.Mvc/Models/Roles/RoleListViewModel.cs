using System.Collections.Generic;
using boilerplateasp.Roles.Dto;

namespace boilerplateasp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<OffersListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
