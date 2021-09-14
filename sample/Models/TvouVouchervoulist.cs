using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVouchervoulist
    {
        public long VoucherVouListId { get; set; }
        public long? VoucherVouListVouListCode { get; set; }
        public long? VoucherVouListVoucherCode { get; set; }
        public sbyte? VoucherVouListMode { get; set; }
        public sbyte? VoucherVouListSyncState { get; set; }
        public string VoucherVouListVarParamA { get; set; }
        public string VoucherVouListVarParamB { get; set; }
        public long? VoucherVouListIntParamA { get; set; }
        public long? VoucherVouListIntParamB { get; set; }
        public double? VoucherVouListFloatParamA { get; set; }
        public double? VoucherVouListFloatParamB { get; set; }
    }
}
