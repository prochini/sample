using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseAttributevalue
    {
        public long AttributeValueId { get; set; }
        public long AttributeValueAttributeCode { get; set; }
        public long AttributeValueCode { get; set; }
        public short AttributeValueSetMode { get; set; }
        public string AttributeValueName { get; set; }
        public string AttributeValueEname { get; set; }
        public string AttributeValueShowName { get; set; }
        public long AttributeValueSort { get; set; }
        public sbyte AttributeValueState { get; set; }
        public sbyte? AttributeValueSyncState { get; set; }
        public string AttributeValueVarParamA { get; set; }
        public string AttributeValueVarParamB { get; set; }
        public long? AttributeValueIntParamA { get; set; }
        public long? AttributeValueIntParamB { get; set; }
        public double? AttributeValueFloatParamA { get; set; }
        public double? AttributeValueFloatParamB { get; set; }
    }
}
