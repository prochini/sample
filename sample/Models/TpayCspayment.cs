using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayCspayment
    {
        public long CspaymentId { get; set; }
        public long CspaymentContractStoreCode { get; set; }
        public long CspaymentCompanyCode { get; set; }
        public long CspaymentPfpaymentCode { get; set; }
        public short CspaymentPayType { get; set; }
        public string CspaymentName { get; set; }
        public string CspaymentShowName { get; set; }
        public string CspaymentImage { get; set; }
        public short CspaymentRefundCount { get; set; }
        public long CspaymentSort { get; set; }
        public sbyte CspaymentState { get; set; }
        public sbyte? CspaymentSyncState { get; set; }
        public string CspaymentVarParamA { get; set; }
        public string CspaymentVarParamB { get; set; }
        public long? CspaymentIntParamA { get; set; }
        public long? CspaymentIntParamB { get; set; }
        public double? CspaymentFloatParamA { get; set; }
        public double? CspaymentFloatParamB { get; set; }
    }
}
