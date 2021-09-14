using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappPayinfopart2
    {
        public long PayInfoPartId { get; set; }
        public long PayInfoPartPayOrderTableNo { get; set; }
        public int? PayInfoPartUpItemNo { get; set; }
        public int PayInfoPartItemNo { get; set; }
        public long? PayInfoPartTableNo { get; set; }
        public long PayInfoPartTargetCode { get; set; }
        public long PayInfoPartPayItemCode { get; set; }
        public string PayInfoPartPayItemName { get; set; }
        public string PayInfoPartPayItemExtName { get; set; }
        public short PayInfoPartFeeType { get; set; }
        public double PayInfoPartCamount { get; set; }
        public double PayInfoPartMaxAmount { get; set; }
        public double PayInfoPartMinAmount { get; set; }
        public double PayInfoPartTax { get; set; }
        public double PayInfoPartNoTax { get; set; }
        public double PayInfoPartAmount { get; set; }
        public double PayInfoPartAlterAmount { get; set; }
        public double PayInfoPartShareAmount { get; set; }
        public double PayInfoPartSpareAmount { get; set; }
        public sbyte PayInfoPartPaymentState { get; set; }
        public long PayInfoPartPayType { get; set; }
        public sbyte PayInfoPartCalculateType { get; set; }
        public sbyte PayInfoPartIsReport { get; set; }
        public short PayInfoPartPayToCurrency { get; set; }
        public sbyte PayInfoPartState { get; set; }
        public DateTime PayInfoPartInsertDate { get; set; }
        public string PayInfoPartVarParamA { get; set; }
        public string PayInfoPartVarParamB { get; set; }
        public string PayInfoPartVarParamC { get; set; }
        public long? PayInfoPartIntParamA { get; set; }
        public long? PayInfoPartIntParamB { get; set; }
        public long? PayInfoPartIntParamC { get; set; }
        public double? PayInfoPartFloatParamA { get; set; }
        public double? PayInfoPartFloatParamB { get; set; }
        public double? PayInfoPartFloatParamC { get; set; }
    }
}
