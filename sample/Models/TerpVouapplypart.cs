using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpVouapplypart
    {
        public long VouApplyPartId { get; set; }
        public long VouApplyPartTableNo { get; set; }
        public long VouApplyPartVoucherCode { get; set; }
        public sbyte VouApplyPartState { get; set; }
        public sbyte? VouApplyPartSyncState { get; set; }
        public string VouApplyPartVarParamA { get; set; }
        public string VouApplyPartVarParamB { get; set; }
        public long? VouApplyPartIntParamA { get; set; }
        public long? VouApplyPartIntParamB { get; set; }
        public double? VouApplyPartFloatParamA { get; set; }
        public double? VouApplyPartFloatParamB { get; set; }
    }
}
