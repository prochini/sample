using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVoucher
    {
        public long VoucherId { get; set; }
        public long VoucherCode { get; set; }
        public short VoucherCountryCode { get; set; }
        public short VoucherUsedType { get; set; }
        public short VoucherType { get; set; }
        public long VoucherCompanyCode { get; set; }
        public string VoucherName { get; set; }
        public string VoucherExtName { get; set; }
        public string VoucherImage { get; set; }
        public sbyte VoucherActivityType { get; set; }
        public string VoucherActivityCode { get; set; }
        public int VoucherReleasedCount { get; set; }
        public int VoucherIssuanceLimit { get; set; }
        public short VoucherReceiveLimit { get; set; }
        public short VoucherUsedLimitType { get; set; }
        public short VoucherUsedLimit { get; set; }
        public short? VoucherCheckLimit { get; set; }
        public short? VoucherFeeType { get; set; }
        public DateTime VoucherUsedOnDate { get; set; }
        public DateTime VoucherUsedOffDate { get; set; }
        public DateTime VoucherOnlineDate { get; set; }
        public DateTime VoucherOfflineDate { get; set; }
        public sbyte VoucherTemplateState { get; set; }
        public sbyte VoucherState { get; set; }
        public sbyte? VoucherSyncState { get; set; }
        public string VoucherVarParamA { get; set; }
        public string VoucherVarParamB { get; set; }
        public long? VoucherIntParamA { get; set; }
        public long? VoucherIntParamB { get; set; }
        public double? VoucherFloatParamA { get; set; }
        public double? VoucherFloatParamB { get; set; }
        public int VoucherDedPoint { get; set; }
        public int VoucherSpecialPoint { get; set; }
        public short VoucherShowType { get; set; }
        public string VoucherContent { get; set; }
        public string VoucherNote { get; set; }
        public long VoucherEcstoreCode { get; set; }
        public string VoucherTitle { get; set; }
        public string VoucherUrltarget { get; set; }
        public string VoucherUrl { get; set; }
        public sbyte VoucherIsScan { get; set; }
        public short VoucherIsOnline { get; set; }
    }
}
