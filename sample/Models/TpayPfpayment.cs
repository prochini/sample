using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayPfpayment
    {
        public long PfpaymentId { get; set; }
        public long PfpaymentCode { get; set; }
        public long PfpaymentPaymentFlowCode { get; set; }
        public short PfpaymentPayType { get; set; }
        public string PfpaymentName { get; set; }
        public string PfpaymentUrl { get; set; }
        public long PfpaymentMethod { get; set; }
        public short PfpaymentRefundCount { get; set; }
        public long PfpaymenttSort { get; set; }
        public sbyte PfpaymentState { get; set; }
        public sbyte? PfpaymentSyncState { get; set; }
        public string PfpaymentVarParamA { get; set; }
        public string PfpaymentVarParamB { get; set; }
        public long? PfpaymentIntParamA { get; set; }
        public long? PfpaymentIntParamB { get; set; }
        public double? PfpaymentFloatParamA { get; set; }
        public double? PfpaymentFloatParamB { get; set; }
    }
}
