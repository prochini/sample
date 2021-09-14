using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVoucherad
    {
        public long VoucherAdId { get; set; }
        public long VoucherAdVoucherCode { get; set; }
        public long VoucherAdAdimgId { get; set; }
        public sbyte VoucherAdState { get; set; }
        public sbyte? VoucherAdSyncState { get; set; }
        public string VoucherAdVarParamA { get; set; }
        public string VoucherAdVarParamB { get; set; }
        public long? VoucherAdIntParamA { get; set; }
        public long? VoucherAdIntParamB { get; set; }
        public double? VoucherAdFloatParamA { get; set; }
        public double? VoucherAdFloatParamB { get; set; }
    }
}
