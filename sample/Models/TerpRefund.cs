using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpRefund
    {
        public long RefundId { get; set; }
        public long RefundTableNo { get; set; }
        public long? RefundPayOrderTableNo { get; set; }
        public long? RefundMainStoreCode { get; set; }
        public long RefundEcstoreCode { get; set; }
        public long RefundUserInfoCode { get; set; }
        public string RefundCurrency { get; set; }
        public double? RefundTaxRate { get; set; }
        public double RefundRefundAmount { get; set; }
        public string RefundRefundResult { get; set; }
        public DateTime RefundInsertDate { get; set; }
        public sbyte RefundState { get; set; }
        public string RefundVarParamA { get; set; }
        public string RefundVarParamB { get; set; }
        public long? RefundIntParamA { get; set; }
        public long? RefundIntParamB { get; set; }
        public double? RefundFloatParamA { get; set; }
        public double? RefundFloatParamB { get; set; }
    }
}
