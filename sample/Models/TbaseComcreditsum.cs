using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseComcreditsum
    {
        public long ComCreditSumId { get; set; }
        public long ComCreditSumCompanyCode { get; set; }
        public double ComCreditSumQuantity { get; set; }
        public double ComCreditSumVirtualQuantity { get; set; }
        public sbyte ComCreditSumState { get; set; }
        public DateTime ComCreditSumInsertDate { get; set; }
        public string ComCreditSumMemo { get; set; }
        public string ComCreditSumVarParamA { get; set; }
        public string ComCreditSumVarParamB { get; set; }
        public long? ComCreditSumIntParamA { get; set; }
        public long? ComCreditSumIntParamB { get; set; }
        public double? ComCreditSumFloatParamA { get; set; }
        public double? ComCreditSumFloatParamB { get; set; }
    }
}
