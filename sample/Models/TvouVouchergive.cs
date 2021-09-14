using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVouchergive
    {
        public long VoucherGiveId { get; set; }
        public long VoucherGiveVoucherCode { get; set; }
        public short VoucherGiveType { get; set; }
        public long VoucherGiveMapCode { get; set; }
        public sbyte? VoucherGiveSyncState { get; set; }
        public sbyte VoucherGiveState { get; set; }
        public string VoucherGiveVarParamA { get; set; }
        public string VoucherGiveVarParamB { get; set; }
        public long? VoucherGiveIntParamA { get; set; }
        public long? VoucherGiveIntParamB { get; set; }
        public double? VoucherGiveFloatParamA { get; set; }
        public double? VoucherGiveFloatParamB { get; set; }
    }
}
