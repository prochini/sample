using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpaySetbasevalue
    {
        public long SetBaseValueId { get; set; }
        public long SetBaseValueCompanyCode { get; set; }
        public string SetBaseValueHashKey { get; set; }
        public string SetBaseValueHashIv { get; set; }
        public string SetBaseValueLimitIp { get; set; }
        public sbyte SetBaseValueState { get; set; }
        public sbyte? SetBaseValueSyncState { get; set; }
        public string SetBaseValueVarParamA { get; set; }
        public string SetBaseValueVarParamB { get; set; }
        public long? SetBaseValueIntParamA { get; set; }
        public long? SetBaseValueIntParamB { get; set; }
        public double? SetBaseValueFloatParamA { get; set; }
        public double? SetBaseValueFloatParamB { get; set; }
    }
}
