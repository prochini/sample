using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseMenuinfo
    {
        public long MenuInfoId { get; set; }
        public long MenuInfoCode { get; set; }
        public long? MenuInfoUpMenuInfoCode { get; set; }
        public long MenuInfoLayNo { get; set; }
        public long? MenuInfoTableTypeCode { get; set; }
        public string MenuInfoIcon { get; set; }
        public string MenuInfoName { get; set; }
        public string MenuInfoUrl { get; set; }
        public short MenuInfoAttribute { get; set; }
        public long? MenuInfoSort { get; set; }
        public sbyte MenuInfoState { get; set; }
        public string MenuInfoMemo { get; set; }
        public sbyte? MenuInfoSyncState { get; set; }
        public string MenuInfoVarParamA { get; set; }
        public string MenuInfoVarParamB { get; set; }
        public long? MenuInfoIntParamA { get; set; }
        public long? MenuInfoIntParamB { get; set; }
        public double? MenuInfoFloatParamA { get; set; }
        public double? MenuInfoFloatParamB { get; set; }
    }
}
