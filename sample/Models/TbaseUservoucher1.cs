using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUservoucher1
    {
        public long UserVoucherId { get; set; }
        public long UserVoucherCode { get; set; }
        public long UserVoucherUserInfoCode { get; set; }
        public long UserVoucherVoucherCode { get; set; }
        public long? UserVoucherVoucherLimitId { get; set; }
        public short UserVoucherUsedType { get; set; }
        public DateTime UserVoucherUsedOnDate { get; set; }
        public DateTime UserVoucherUsedOffDate { get; set; }
        public string UserVoucherQrcode { get; set; }
        public DateTime UserVoucherReceiveDate { get; set; }
        public long? UserVoucherUsedEcstore { get; set; }
        public DateTime? UserVoucherUsedDate { get; set; }
        public sbyte UserVoucherUsedState { get; set; }
        public sbyte UserVoucherState { get; set; }
        public sbyte? UserVoucherSyncState { get; set; }
        public string UserVoucherVarParamA { get; set; }
        public string UserVoucherVarParamB { get; set; }
        public long? UserVoucherIntParamA { get; set; }
        public long? UserVoucherIntParamB { get; set; }
        public double? UserVoucherFloatParamA { get; set; }
        public double? UserVoucherFloatParamB { get; set; }
        public long? UserVoucherTableNo { get; set; }
        public long? UserVoucherPayOrderTableNo { get; set; }
    }
}
