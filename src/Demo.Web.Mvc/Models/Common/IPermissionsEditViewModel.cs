using System.Collections.Generic;
using Demo.Roles.Dto;

namespace Demo.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}