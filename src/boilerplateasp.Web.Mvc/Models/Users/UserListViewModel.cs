using System.Collections.Generic;
using boilerplateasp.Roles.Dto;
using boilerplateasp.Users.Dto;

namespace boilerplateasp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
