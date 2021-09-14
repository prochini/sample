using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserlevelinfo
    {
        public ulong UserLevelInfoId { get; set; }
        public long UserLevelInfoUserInfoCode { get; set; }
        public long UserLevelInfoLevelCode { get; set; }
        public DateTime UserLevelInfoDate { get; set; }
        public sbyte UserLevelInfoState { get; set; }
        public sbyte? UserLevelInfoSyncState { get; set; }
        public string UserLevelInfoVarParamA { get; set; }
        public string UserLevelInfoVarParamB { get; set; }
        public long? UserLevelInfoIntParamA { get; set; }
        public long? UserLevelInfoIntParamB { get; set; }
        public double? UserLevelInfoFloatParamA { get; set; }
        public double? UserLevelInfoFloatParamB { get; set; }
    }
}
