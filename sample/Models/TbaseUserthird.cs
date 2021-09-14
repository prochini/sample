using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserthird
    {
        public long UserThirdId { get; set; }
        public long UserThirdUserInfoCode { get; set; }
        public string UserThirdToken { get; set; }
        public string UserThirdJsonData { get; set; }
        public sbyte UserThirdState { get; set; }
        public sbyte? UserThirdSyncState { get; set; }
        public string UserThirdVarParamA { get; set; }
        public string UserThirdVarParamB { get; set; }
        public long? UserThirdIntParamA { get; set; }
        public long? UserThirdIntParamB { get; set; }
        public double? UserThirdFloatParamA { get; set; }
        public double? UserThirdFloatParamB { get; set; }
        public short UserThirdMode { get; set; }
    }
}
