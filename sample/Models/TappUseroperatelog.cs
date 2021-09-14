using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappUseroperatelog
    {
        public long UserOperateLogId { get; set; }
        public long UserOperateLogUserInfoCode { get; set; }
        public long UserOperateLogOperateCode { get; set; }
        public DateTime UserOperateLogDate { get; set; }
        public sbyte? UserOperateLogSyncState { get; set; }
        public string UserOperateLogVarParamA { get; set; }
        public string UserOperateLogVarParamB { get; set; }
        public long? UserOperateLogIntParamA { get; set; }
        public long? UserOperateLogIntParamB { get; set; }
        public double? UserOperateLogFloatParamA { get; set; }
        public double? UserOperateLogFloatParamB { get; set; }
    }
}
