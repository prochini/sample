using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseDealstate
    {
        public long DealStateId { get; set; }
        public long DealStateDealTypeCode { get; set; }
        public long DealStateCode { get; set; }
        public string DealStateName { get; set; }
        public string DealStateShowName { get; set; }
        public sbyte DealStateState { get; set; }
        public sbyte? DealStateSyncState { get; set; }
        public string DealStateVarParamA { get; set; }
        public string DealStateVarParamB { get; set; }
        public long? DealStateIntParamA { get; set; }
        public long? DealStateIntParamB { get; set; }
        public double? DealStateFloatParamA { get; set; }
        public double? DealStateFloatParamB { get; set; }
    }
}
