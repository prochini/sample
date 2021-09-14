using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpVendingorder
    {
        public ulong VendingOrderId { get; set; }
        public long VendingOrderEcstoreCode { get; set; }
        public string VendingOrderExtNo { get; set; }
        public string VendingOrderExtGoodsId { get; set; }
        public string VendingOrderExtGoodsPrice { get; set; }
        public string VendingOrderLimitDate { get; set; }
        public sbyte VendingOrderExtState { get; set; }
        public long? VendingOrderUserInfoCode { get; set; }
        public long? VendingOrderUserVoucherCode { get; set; }
        public short? VendingOrderUserGroupNo { get; set; }
        public DateTime VendingOrderDate { get; set; }
        public sbyte VendingOrderState { get; set; }
        public string VendingOrderVarParamA { get; set; }
        public string VendingOrderVarParamB { get; set; }
        public long? VendingOrderIntParamA { get; set; }
        public long? VendingOrderIntParamB { get; set; }
        public double? VendingOrderFloatParamA { get; set; }
        public double? VendingOrderFloatParamB { get; set; }
    }
}
