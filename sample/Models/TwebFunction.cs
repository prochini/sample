using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TwebFunction
    {
        public long FunctionId { get; set; }
        public long FunctionCountryCode { get; set; }
        public long FunctionCode { get; set; }
        public string FunctionName { get; set; }
        public string FunctionUrl { get; set; }
        public string FunctionIcon { get; set; }
        public long FunctionSort { get; set; }
        public sbyte FunctionState { get; set; }
        public sbyte? FunctionSyncState { get; set; }
        public string FunctionVarParamA { get; set; }
        public string FunctionVarParamB { get; set; }
        public long? FunctionIntParamA { get; set; }
        public long? FunctionIntParamB { get; set; }
        public double? FunctionFloatParamA { get; set; }
        public double? FunctionFloatParamB { get; set; }
        public sbyte FunctionIsTop { get; set; }
        public sbyte FunctionIsOther { get; set; }
        public short FunctionMode { get; set; }
        public string FunctionUrltarget { get; set; }
        public sbyte FunctionIsActive { get; set; }
        public long? FunctionCategaryCode { get; set; }
        public sbyte FunctionIsShow { get; set; }
    }
}
