using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayPaymentflow
    {
        public long PaymentFlowId { get; set; }
        public long PaymentFlowCountryCode { get; set; }
        public long PaymentFlowCode { get; set; }
        public string PaymentFlowName { get; set; }
        public sbyte PaymentFlowState { get; set; }
        public sbyte? PaymentFlowSyncState { get; set; }
        public string PaymentFlowVarParamA { get; set; }
        public string PaymentFlowVarParamB { get; set; }
        public long? PaymentFlowIntParamA { get; set; }
        public long? PaymentFlowIntParamB { get; set; }
        public double? PaymentFlowFloatParamA { get; set; }
        public double? PaymentFlowFloatParamB { get; set; }
    }
}
