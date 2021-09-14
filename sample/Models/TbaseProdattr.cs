using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseProdattr
    {
        public long ProdAttrId { get; set; }
        public long ProdAttrProductCode { get; set; }
        public sbyte ProdAttrAttributeType { get; set; }
        public long ProdAttrAttributeCode { get; set; }
        public string ProdAttrAttributeName { get; set; }
        public long ProdAttrAttributeValueCode { get; set; }
        public string ProdAttrAttributeValueName { get; set; }
        public sbyte? ProdAttrSyncState { get; set; }
        public string ProdAttrVarParamA { get; set; }
        public string ProdAttrVarParamB { get; set; }
        public long? ProdAttrIntParamA { get; set; }
        public long? ProdAttrIntParamB { get; set; }
        public double? ProdAttrFloatParamA { get; set; }
        public double? ProdAttrFloatParamB { get; set; }
        public sbyte? ProdAttrIsShow { get; set; }
    }
}
