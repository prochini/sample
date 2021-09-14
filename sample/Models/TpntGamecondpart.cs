using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpntGamecondpart
    {
        public ulong GameCondPartId { get; set; }
        public long GameCondPartGameCode { get; set; }
        public short GameCondPartType { get; set; }
        public long GameCondPartItemCode { get; set; }
        public string GameCondPartItemName { get; set; }
        public sbyte GameCondPartState { get; set; }
        public sbyte? GameCondPartSyncState { get; set; }
        public string GameCondPartVarParamA { get; set; }
        public string GameCondPartVarParamB { get; set; }
        public long? GameCondPartIntParamA { get; set; }
        public long? GameCondPartIntParamB { get; set; }
        public double? GameCondPartFloatParamA { get; set; }
        public double? GameCondPartFloatParamB { get; set; }
    }
}
