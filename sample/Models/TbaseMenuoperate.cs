using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseMenuoperate
    {
        public long MenuOperateId { get; set; }
        public long MenuOperateCode { get; set; }
        public long MenuOperateMenuInfoCode { get; set; }
        public string MenuOperateName { get; set; }
        public string MenuOperateUrl { get; set; }
        public long? MenuOperateTableTypeCode { get; set; }
        public long? MenuOperateDealTypeCode { get; set; }
        public short MenuOperateType { get; set; }
        public short MenuOperateIsLog { get; set; }
        public sbyte MenuOperateState { get; set; }
        public string MenuOperateMemo { get; set; }
        public sbyte? MenuOperateSyncState { get; set; }
        public string MenuOperateVarParamA { get; set; }
        public string MenuOperateVarParamB { get; set; }
        public long? MenuOperateIntParamA { get; set; }
        public long? MenuOperateIntParamB { get; set; }
        public double? MenuOperateFloatParamA { get; set; }
        public double? MenuOperateFloatParamB { get; set; }
    }
}
