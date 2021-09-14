using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappServiceinfo
    {
        public long ServiceInfoId { get; set; }
        public long ServiceInfoCode { get; set; }
        public short ServiceInfoApcode { get; set; }
        public string ServiceInfoName { get; set; }
        public sbyte ServiceInfoRunMode { get; set; }
        public string ServiceInfoDateToRun { get; set; }
        public string ServiceInfoClockToRun { get; set; }
        public double? ServiceInfoTimeUpRun { get; set; }
        public sbyte ServiceInfoUimode { get; set; }
        public sbyte ServiceInfoState { get; set; }
        public sbyte? ServiceInfoSyncState { get; set; }
        public string ServiceInfoVarParamA { get; set; }
        public string ServiceInfoVarParamB { get; set; }
        public long? ServiceInfoIntParamA { get; set; }
        public long? ServiceInfoIntParamB { get; set; }
        public double? ServiceInfoFloatParamA { get; set; }
        public double? ServiceInfoFloatParamB { get; set; }
    }
}
