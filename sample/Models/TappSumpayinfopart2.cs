using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappSumpayinfopart2
    {
        public long SumPayInfoPartId { get; set; }
        public long? SumPayInfoPartTableNo { get; set; }
        public long SumPayInfoPartPayOrderNo { get; set; }
        public long SumPayInfoPartReceiverCode { get; set; }
        public string SumPayInfoPartReceiverName { get; set; }
        public double SumPayInfoPartFormAmount { get; set; }
        public double SumPayInfoPartAmount { get; set; }
        public double SumPayInfoPartCreditAmount { get; set; }
        public double SumPayInfoPartRefundAmount { get; set; }
        public sbyte SumPayInfoPartPaymentState { get; set; }
        public DateTime? SumPayInfoPartPaymentDate { get; set; }
        public sbyte SumPayInfoPartActuallyState { get; set; }
        public DateTime? SumPayInfoPartActuallyDate { get; set; }
        public sbyte SumPayInfoPartRefundState { get; set; }
        public DateTime? SumPayInfoPartRefundDate { get; set; }
        public sbyte SumPayInfoPartInvoiceState { get; set; }
        public DateTime? SumPayInfoPartInvoiceDate { get; set; }
        public sbyte SumPayInfoPartDealState { get; set; }
        public short SumPayInfoPartPayToCurrency { get; set; }
        public sbyte SumPayInfoPartState { get; set; }
        public sbyte SumPayInfoPartChanged { get; set; }
        public string SumPayInfoPartVarParamA { get; set; }
        public string SumPayInfoPartVarParamB { get; set; }
        public string SumPayInfoPartVarParamC { get; set; }
        public long? SumPayInfoPartIntParamA { get; set; }
        public long? SumPayInfoPartIntParamB { get; set; }
        public long? SumPayInfoPartIntParamC { get; set; }
        public double? SumPayInfoPartFloatParamA { get; set; }
        public double? SumPayInfoPartFloatParamB { get; set; }
        public double? SumPayInfoPartFloatParamC { get; set; }
        public long SumPayInfoPartPayOrderTableNo { get; set; }
        public long SumPayInfoPartBaseCode { get; set; }
    }
}
