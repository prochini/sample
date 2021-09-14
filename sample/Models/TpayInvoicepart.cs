using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayInvoicepart
    {
        public long InvoicePartId { get; set; }
        public long InvoicePartInvoiceId { get; set; }
        public long? InvoicePartItemCode { get; set; }
        public string InvoicePartItemName { get; set; }
        public int InvoicePartQty { get; set; }
        public short InvoicePartUnit { get; set; }
        public double InvoicePartTax { get; set; }
        public double InvoicePartNoTaxPrice { get; set; }
        public double InvoicePartPrice { get; set; }
        public double InvoicePartAmt { get; set; }
        public double InvoicePartAllowancePrice { get; set; }
        public sbyte InvoicePartState { get; set; }
        public DateTime InvoicePartDate { get; set; }
        public string InvoicePartVarParamA { get; set; }
        public string InvoicePartVarParamB { get; set; }
        public long? InvoicePartIntParamA { get; set; }
        public long? InvoicePartIntParamB { get; set; }
        public double? InvoicePartFloatParamA { get; set; }
        public double? InvoicePartFloatParamB { get; set; }
    }
}
