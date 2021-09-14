using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseTabletype
    {
        public long TableTypeId { get; set; }
        public long? TableTypeWorkflowId { get; set; }
        public long TableTypeCode { get; set; }
        public short TableTypeGroupNo { get; set; }
        public string TableTypeName { get; set; }
        public string TableTypeShowName { get; set; }
        public string TableTypeUrl { get; set; }
        public string TableTypeExtUrl { get; set; }
        public string TableTypeHead { get; set; }
        public string TableTypeDescription { get; set; }
        public sbyte TableTypeState { get; set; }
        public sbyte? TableTypeSyncState { get; set; }
        public string TableTypeVarParamA { get; set; }
        public string TableTypeVarParamB { get; set; }
        public long? TableTypeIntParamA { get; set; }
        public long? TableTypeIntParamB { get; set; }
        public double? TableTypeFloatParamA { get; set; }
        public double? TableTypeFloatParamB { get; set; }
    }
}
