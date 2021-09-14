using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayPfpaymentpart
    {
        public long PfpaymentPartId { get; set; }
        public long PfpaymentPartPfpaymentCode { get; set; }
        public long PfpaymentPartCode { get; set; }
        public string PfpaymentPartExtCode { get; set; }
        public string PfpaymentPartName { get; set; }
        public short PfpaymentPartValue { get; set; }
        public short PfpaymentPartFeeType { get; set; }
        public double PfpaymentPartFee { get; set; }
        public double PfpaymentPartMinFee { get; set; }
        public double PfpaymentPartMaxFee { get; set; }
        public sbyte PfpaymentPartState { get; set; }
        public sbyte? PfpaymentPartSyncState { get; set; }
        public string PfpaymentPartVarParamA { get; set; }
        public string PfpaymentPartVarParamB { get; set; }
        public long? PfpaymentPartIntParamA { get; set; }
        public long? PfpaymentPartIntParamB { get; set; }
        public double? PfpaymentPartFloatParamA { get; set; }
        public double? PfpaymentPartFloatParamB { get; set; }
    }
}
