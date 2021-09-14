using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseDealtype
    {
        public long DealTypeId { get; set; }
        public long DealTypeCode { get; set; }
        public long DealTypeTableTypeCode { get; set; }
        public string DealTypeUrl { get; set; }
        public string DealTypeJobUrl { get; set; }
        public string DealTypeName { get; set; }
        public string DealTypeShowName { get; set; }
        public sbyte DealTypeIsInvalid { get; set; }
        public sbyte DealTypeIsSave { get; set; }
        public sbyte DealTypeIsOver { get; set; }
        public sbyte DealTypeState { get; set; }
        public sbyte? DealTypeSyncState { get; set; }
        public string DealTypeVarParamA { get; set; }
        public string DealTypeVarParamB { get; set; }
        public long? DealTypeIntParamA { get; set; }
        public long? DealTypeIntParamB { get; set; }
        public double? DealTypeFloatParamA { get; set; }
        public double? DealTypeFloatParamB { get; set; }
    }
}
