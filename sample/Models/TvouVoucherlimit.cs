using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVoucherlimit
    {
        public long VoucherLimitId { get; set; }
        public long VoucherLimitVoucherCode { get; set; }
        public double VoucherLimitCostPrice { get; set; }
        public double VoucherLimitAfpcostPrice { get; set; }
        public int VoucherLimitUsedCount { get; set; }
        public int VoucherLimitIssuanceLimit { get; set; }
        public double VoucherLimitDiscount { get; set; }
        public double VoucherLimitMinUnit { get; set; }
        public double VoucherLimitMaxUnit { get; set; }
        public long? VoucherLimitProductCode1 { get; set; }
        public short? VoucherLimitCount1 { get; set; }
        public long? VoucherLimitProductCode2 { get; set; }
        public short? VoucherLimitCount2 { get; set; }
        public long? VoucherLimitProductCode3 { get; set; }
        public short? VoucherLimitCount3 { get; set; }
        public long? VoucherLimitProductCode4 { get; set; }
        public short? VoucherLimitCount4 { get; set; }
        public long? VoucherLimitProductCode5 { get; set; }
        public short? VoucherLimitCount5 { get; set; }
        public sbyte? VoucherLimitSyncState { get; set; }
        public sbyte VoucherLimitState { get; set; }
        public string VoucherLimitVarParamA { get; set; }
        public string VoucherLimitVarParamB { get; set; }
        public long? VoucherLimitIntParamA { get; set; }
        public long? VoucherLimitIntParamB { get; set; }
        public double? VoucherLimitFloatParamA { get; set; }
        public double? VoucherLimitFloatParamB { get; set; }
    }
}
