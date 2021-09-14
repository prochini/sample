using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayInvoice
    {
        public long InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public long? InvoicePayOrderTableNo { get; set; }
        public string InvoicePayOrderExtNo { get; set; }
        public sbyte? InvoiceInsertMode { get; set; }
        public sbyte? InvoiceClass { get; set; }
        public sbyte? InvoiceType { get; set; }
        public sbyte? InvoiceMode { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceRegisterNo { get; set; }
        public string InvoiceRanCode { get; set; }
        public double InvoicePrice { get; set; }
        public string InvoiceInvoiceImage { get; set; }
        public DateTime InvoiceInvoiceDate { get; set; }
        public string InvoiceAllowanceNo { get; set; }
        public string InvoiceAllowanceImage { get; set; }
        public double? InvoiceAllowancePrice { get; set; }
        public DateTime? InvoiceAllowanceDate { get; set; }
        public DateTime? InvoiceInvalidDate { get; set; }
        public string InvoiceInvalidText { get; set; }
        public sbyte? InvoiceHandleState { get; set; }
        public DateTime? InvoiceFinanceCheckDate { get; set; }
        public long? InvoiceFinanceCode { get; set; }
        public DateTime? InvoiceInvalidChangeDate { get; set; }
        public sbyte? InvoiceState { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceVarParamA { get; set; }
        public string InvoiceVarParamB { get; set; }
        public long? InvoiceIntParamA { get; set; }
        public long? InvoiceIntParamB { get; set; }
        public double? InvoiceFloatParamA { get; set; }
        public double? InvoiceFloatParamB { get; set; }
        public long? InvoiceVreimburseTableNo { get; set; }
        public sbyte? InvoiceTaxType { get; set; }
    }
}
