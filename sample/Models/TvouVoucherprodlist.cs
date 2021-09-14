using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVoucherprodlist
    {
        public long VoucherProdListId { get; set; }
        public long? VoucherProdListProdListCode { get; set; }
        public long? VoucherProdListVoucherCode { get; set; }
        public sbyte? VoucherProdListMode { get; set; }
        public sbyte? VoucherProdListSyncState { get; set; }
        public string VoucherProdListVarParamA { get; set; }
        public string VoucherProdListVarParamB { get; set; }
        public long? VoucherProdListIntParamA { get; set; }
        public long? VoucherProdListIntParamB { get; set; }
        public double? VoucherProdListFloatParamA { get; set; }
        public double? VoucherProdListFloatParamB { get; set; }
    }
}
