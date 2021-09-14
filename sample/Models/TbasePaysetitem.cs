using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbasePaysetitem
    {
        public long PaySetItemId { get; set; }
        public long PaySetItemCode { get; set; }
        public long PaySetItemPaySetCode { get; set; }
        public string PaySetItemName { get; set; }
        public string PaySetItemExtName { get; set; }
        public sbyte PaySetItemCalculateType { get; set; }
        public short PaySetItemFeeType { get; set; }
        public double PaySetItemAmount { get; set; }
        public double PaySetItemMinAmount { get; set; }
        public double PaySetItemMaxAmount { get; set; }
        public sbyte PaySetItemPaymentSetClass { get; set; }
        public long PaySetItemSort { get; set; }
        public DateTime PaySetItemInsertDate { get; set; }
        public sbyte PaySetItemState { get; set; }
        public string PaySetItemVarParamA { get; set; }
        public string PaySetItemVarParamB { get; set; }
        public string PaySetItemVarParamC { get; set; }
        public long? PaySetItemIntParamA { get; set; }
        public long? PaySetItemIntParamB { get; set; }
        public long? PaySetItemIntParamC { get; set; }
        public double? PaySetItemFloatParamA { get; set; }
        public double? PaySetItemFloatParamB { get; set; }
        public double? PaySetItemFloatParamC { get; set; }
        public short PaySetItemPaymentClass { get; set; }
    }
}
