using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVoucherstore
    {
        public long VoucherStoreId { get; set; }
        public long VoucherStoreEcstoreCode { get; set; }
        public long VoucherStoreVoucherCode { get; set; }
        public sbyte? VoucherStoreSyncState { get; set; }
        public string VoucherStoreVarParamA { get; set; }
        public string VoucherStoreVarParamB { get; set; }
        public long? VoucherStoreIntParamA { get; set; }
        public long? VoucherStoreIntParamB { get; set; }
        public double? VoucherStoreFloatParamA { get; set; }
        public double? VoucherStoreFloatParamB { get; set; }
    }
}
