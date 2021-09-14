using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappUserlog
    {
        public long UserLogId { get; set; }
        public short? UserLogType { get; set; }
        public long UserLogUserInfoCode { get; set; }
        public DateTime? UserLogLogInTime { get; set; }
        public DateTime? UserLogLogOutTime { get; set; }
        public string UserLogIp { get; set; }
        public short UserLogOnlineState { get; set; }
        public sbyte? UserLogSyncState { get; set; }
        public string UserLogVarParamA { get; set; }
        public string UserLogVarParamB { get; set; }
        public long? UserLogIntParamA { get; set; }
        public long? UserLogIntParamB { get; set; }
        public double? UserLogFloatParamA { get; set; }
        public double? UserLogFloatParamB { get; set; }
    }
}
