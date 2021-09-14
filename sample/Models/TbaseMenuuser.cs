using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseMenuuser
    {
        public long MenuUserId { get; set; }
        public short MenuUserType { get; set; }
        public long MenuUserMenuInfoCode { get; set; }
        public long MenuUserMenuOperateCode { get; set; }
        public long? MenuUserUserInfoCode { get; set; }
        public long? MenuUserRoleInfoCode { get; set; }
        public sbyte? MenuUserSyncState { get; set; }
        public string MenuUserVarParamA { get; set; }
        public string MenuUserVarParamB { get; set; }
        public long? MenuUserIntParamA { get; set; }
        public long? MenuUserIntParamB { get; set; }
        public double? MenuUserFloatParamA { get; set; }
        public double? MenuUserFloatParamB { get; set; }
    }
}
