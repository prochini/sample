using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseAttribute
    {
        public long AttributeId { get; set; }
        public sbyte AttributeType { get; set; }
        public short AttributeMode { get; set; }
        public short AttributeSetMode { get; set; }
        public long AttributeCode { get; set; }
        public string AttributeName { get; set; }
        public string AttributeEname { get; set; }
        public string AttributeShowName { get; set; }
        public string AttributeColor { get; set; }
        public long AttributeSort { get; set; }
        public sbyte AttributeState { get; set; }
        public sbyte? AttributeSyncState { get; set; }
        public string AttributeVarParamA { get; set; }
        public string AttributeVarParamB { get; set; }
        public long? AttributeIntParamA { get; set; }
        public long? AttributeIntParamB { get; set; }
        public double? AttributeFloatParamA { get; set; }
        public double? AttributeFloatParamB { get; set; }
    }
}
