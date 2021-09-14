using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseProdlistattrmap
    {
        public long ProdListAttrMapId { get; set; }
        public long? ProdListAttrMapProdListCode { get; set; }
        public long? ProdListAttrMapAttributeCode { get; set; }
        public string ProdListAttrMapAttributeName { get; set; }
        public string ProdListAttrMapAttributeColor { get; set; }
        public long? ProdListAttrMapAttributeValueCode { get; set; }
        public string ProdListAttrMapAttributeValueName { get; set; }
        public sbyte? ProdListAttrMapMode { get; set; }
        public sbyte? ProdListAttrMapSyncState { get; set; }
        public string ProdListAttrMapVarParamA { get; set; }
        public string ProdListAttrMapVarParamB { get; set; }
        public long? ProdListAttrMapIntParamA { get; set; }
        public long? ProdListAttrMapIntParamB { get; set; }
        public double? ProdListAttrMapFloatParamA { get; set; }
        public double? ProdListAttrMapFloatParamB { get; set; }
        public int? ProdListAttrMapProdCount { get; set; }
        public sbyte? ProdListAttrMapIsShow { get; set; }
    }
}
