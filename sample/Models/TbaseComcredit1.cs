using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseComcredit1
    {
        public long ComCreditId { get; set; }
        public long ComCreditCompanyCode { get; set; }
        public string ComCreditText { get; set; }
        public double ComCreditRegQuantity { get; set; }
        public double ComCreditAddQuantity { get; set; }
        public double ComCreditAmountQuantity { get; set; }
        public DateTime ComCreditDate { get; set; }
        public sbyte ComCreditState { get; set; }
        public string ComCreditVarParamA { get; set; }
        public string ComCreditVarParamB { get; set; }
        public long? ComCreditIntParamA { get; set; }
        public long? ComCreditIntParamB { get; set; }
        public double? ComCreditFloatParamA { get; set; }
        public double? ComCreditFloatParamB { get; set; }
    }
}
