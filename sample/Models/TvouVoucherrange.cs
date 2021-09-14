using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVoucherrange
    {
        public long VoucherRangeId { get; set; }
        public long VoucherRangeVoucherCode { get; set; }
        public short VoucherRangeType { get; set; }
        public long VoucherRangeMapCode { get; set; }
        public sbyte? VoucherRangeSyncState { get; set; }
        public sbyte VoucherRangeState { get; set; }
        public string VoucherRangeVarParamA { get; set; }
        public string VoucherRangeVarParamB { get; set; }
        public long? VoucherRangeIntParamA { get; set; }
        public long? VoucherRangeIntParamB { get; set; }
        public double? VoucherRangeFloatParamA { get; set; }
        public double? VoucherRangeFloatParamB { get; set; }
    }
}
