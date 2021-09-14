using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayCspaymentpart
    {
        public long CspaymentPartId { get; set; }
        public long CspaymentPartCspaymentId { get; set; }
        public long CspaymentPartPfpaymentPartCode { get; set; }
        public string CspaymentPartName { get; set; }
        public string CspaymentPartShowName { get; set; }
        public short CspaymentPartValue { get; set; }
        public short CspaymentPartFeeType { get; set; }
        public double CspaymentPartFee { get; set; }
        public double CspaymentPartMinFee { get; set; }
        public double CspaymentPartMaxFee { get; set; }
        public sbyte CspaymentPartState { get; set; }
        public sbyte? CspaymentPartSyncState { get; set; }
        public string CspaymentPartVarParamA { get; set; }
        public string CspaymentPartVarParamB { get; set; }
        public long? CspaymentPartIntParamA { get; set; }
        public long? CspaymentPartIntParamB { get; set; }
        public double? CspaymentPartFloatParamA { get; set; }
        public double? CspaymentPartFloatParamB { get; set; }
    }
}
