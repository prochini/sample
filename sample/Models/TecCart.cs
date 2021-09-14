using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecCart
    {
        public long CartId { get; set; }
        public long CartCode { get; set; }
        public long? CartUserInfoCode { get; set; }
        public long CartEcstoreCode { get; set; }
        public string CartEcstoreName { get; set; }
        public long CartProductCode { get; set; }
        public string CartAttributeValueCode { get; set; }
        public string CartAttributeValueName { get; set; }
        public long? CartUserDefineCode { get; set; }
        public string CartUserDefineName { get; set; }
        public int CartQuantity { get; set; }
        public double CartAmount { get; set; }
        public sbyte CartOrderState { get; set; }
        public sbyte CartState { get; set; }
        public DateTime CartInsertDate { get; set; }
        public string CartVarParamA { get; set; }
        public string CartVarParamB { get; set; }
        public long? CartIntParamA { get; set; }
        public long? CartIntParamB { get; set; }
        public double? CartFloatParamA { get; set; }
        public double? CartFloatParamB { get; set; }
        public long? CartOrderId { get; set; }
    }
}
