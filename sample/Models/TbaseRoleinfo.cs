using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseRoleinfo
    {
        public long RoleInfoId { get; set; }
        public long RoleInfoCode { get; set; }
        public string RoleInfoName { get; set; }
        public short RoleInfoType { get; set; }
        public sbyte RoleInfoState { get; set; }
        public string RoleInfoMemo { get; set; }
        public sbyte? RoleInfoSyncState { get; set; }
        public string RoleInfoVarParamA { get; set; }
        public string RoleInfoVarParamB { get; set; }
        public long? RoleInfoIntParamA { get; set; }
        public long? RoleInfoIntParamB { get; set; }
        public double? RoleInfoFloatParamA { get; set; }
        public double? RoleInfoFloatParamB { get; set; }
    }
}
