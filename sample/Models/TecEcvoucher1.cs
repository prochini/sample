using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecEcvoucher1
    {
        public long EcvoucherId { get; set; }
        public long? EcvoucherTableNo { get; set; }
        public long EcvoucherUserVoucherCode { get; set; }
        public long EcvoucherEcstoreCode { get; set; }
        public long EcvoucherUserInfoCode { get; set; }
        public long EcvoucherVoucherCode { get; set; }
        public long EcvoucherVoucherLimitId { get; set; }
        public DateTime EcvoucherUsedDate { get; set; }
        public sbyte EcvoucherTemplateState { get; set; }
        public sbyte EcvoucherState { get; set; }
        public sbyte? EcvoucherSyncState { get; set; }
        public string EcvoucherVarParamA { get; set; }
        public string EcvoucherVarParamB { get; set; }
        public long? EcvoucherIntParamA { get; set; }
        public long? EcvoucherIntParamB { get; set; }
        public double? EcvoucherFloatParamA { get; set; }
        public double? EcvoucherFloatParamB { get; set; }
        public long EcvoucherMainStoreCode { get; set; }
        public sbyte EcvoucherCheckState { get; set; }
        public long? EcvoucherPayOrderTableNo { get; set; }
        public double? EcvoucherCostPrice { get; set; }
        public double? EcvoucherDiscount { get; set; }
        public long? EcvoucherEcuserInfoCode { get; set; }
    }
}
