using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseCardgrouppart
    {
        public ulong CardGroupPartId { get; set; }
        public long CardGroupPartCardGroupCode { get; set; }
        public short CardGroupPartType { get; set; }
        public string CardGroupPartNumber { get; set; }
        public DateTime CardGroupPartInsertDate { get; set; }
        public sbyte CardGroupPartState { get; set; }
        public sbyte? CardGroupPartSyncState { get; set; }
        public string CardGroupPartVarParamA { get; set; }
        public string CardGroupPartVarParamB { get; set; }
        public long? CardGroupPartIntParamA { get; set; }
        public long? CardGroupPartIntParamB { get; set; }
        public double? CardGroupPartFloatParamA { get; set; }
        public double? CardGroupPartFloatParamB { get; set; }
    }
}
