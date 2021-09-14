using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserrole
    {
        public long UserRoleId { get; set; }
        public long UserRoleUserInfoCode { get; set; }
        public long UserRoleRoleInfoCode { get; set; }
        public sbyte? UserRoleSyncState { get; set; }
        public string UserRoleVarParamA { get; set; }
        public string UserRoleVarParamB { get; set; }
        public long? UserRoleIntParamA { get; set; }
        public long? UserRoleIntParamB { get; set; }
        public double? UserRoleFloatParamA { get; set; }
        public double? UserRoleFloatParamB { get; set; }
    }
}
