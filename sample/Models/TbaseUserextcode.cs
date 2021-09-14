using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserextcode
    {
        public long UserExtCodeId { get; set; }
        public long UserExtCodeUserInfoCode { get; set; }
        public long UserExtCodePartnerCode { get; set; }
        public string UserExtCodeExtCode { get; set; }
        public string UserExtCodeCode { get; set; }
        public DateTime? UserExtCodeExpiry { get; set; }
        public DateTime? UserExtCodeDate { get; set; }
        public sbyte UserExtCodeState { get; set; }
        public sbyte? UserExtCodeSyncState { get; set; }
        public string UserExtCodeVarParamA { get; set; }
        public string UserExtCodeVarParamB { get; set; }
        public long? UserExtCodeIntParamA { get; set; }
        public long? UserExtCodeIntParamB { get; set; }
        public double? UserExtCodeFloatParamA { get; set; }
        public double? UserExtCodeFloatParamB { get; set; }
    }
}
