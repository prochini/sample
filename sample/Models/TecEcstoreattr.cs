using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecEcstoreattr
    {
        public long EcstoreAttrId { get; set; }
        public long EcstoreAttrEcstoreCode { get; set; }
        public sbyte EcstoreAttrAttributeType { get; set; }
        public long EcstoreAttrAttributeCode { get; set; }
        public string EcstoreAttrAttributeName { get; set; }
        public long EcstoreAttrAttributeValueCode { get; set; }
        public string EcstoreAttrAttributeValueName { get; set; }
        public sbyte? EcstoreAttrSyncState { get; set; }
        public string EcstoreAttrVarParamA { get; set; }
        public string EcstoreAttrVarParamB { get; set; }
        public long? EcstoreAttrIntParamA { get; set; }
        public long? EcstoreAttrIntParamB { get; set; }
        public double? EcstoreAttrFloatParamA { get; set; }
        public double? EcstoreAttrFloatParamB { get; set; }
        public sbyte? EcstoreAttrIsShow { get; set; }
    }
}
