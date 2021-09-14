using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbasePayset
    {
        public long PaySetId { get; set; }
        public long PaySetCode { get; set; }
        public long PaySetEcstoreCode { get; set; }
        public string PaySetName { get; set; }
        public long PaySetCspaymentId { get; set; }
        public short PaySetPaymentType { get; set; }
        public string PaySetMemo { get; set; }
        public DateTime PaySetInsertDate { get; set; }
        public sbyte PaySetState { get; set; }
        public string PaySetVarParamA { get; set; }
        public string PaySetVarParamB { get; set; }
        public string PaySetVarParamC { get; set; }
        public long? PaySetIntParamA { get; set; }
        public long? PaySetIntParamB { get; set; }
        public long? PaySetIntParamC { get; set; }
        public double? PaySetFloatParamA { get; set; }
        public double? PaySetFloatParamB { get; set; }
        public double? PaySetFloatParamC { get; set; }
    }
}
