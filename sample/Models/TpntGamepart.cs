using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpntGamepart
    {
        public long GamePartId { get; set; }
        public long GamePartGameCode { get; set; }
        public short GamePartType { get; set; }
        public long GamePartItemId { get; set; }
        public long GamePartItemCode { get; set; }
        public string GamePartItemName { get; set; }
        public string GamePartItemImage { get; set; }
        public string GamePartAttributeValueCode { get; set; }
        public string GamePartAttributeValueName { get; set; }
        public int GamePartReleasedQty { get; set; }
        public int GamePartQty { get; set; }
        public double? GamePartProportion { get; set; }
        public sbyte GamePartState { get; set; }
        public sbyte? GamePartSyncState { get; set; }
        public string GamePartVarParamA { get; set; }
        public string GamePartVarParamB { get; set; }
        public long? GamePartIntParamA { get; set; }
        public long? GamePartIntParamB { get; set; }
        public double? GamePartFloatParamA { get; set; }
        public double? GamePartFloatParamB { get; set; }
        public double GamePartValues { get; set; }
    }
}
