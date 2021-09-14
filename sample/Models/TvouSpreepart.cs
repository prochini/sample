using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouSpreepart
    {
        public long SpreePartId { get; set; }
        public long SpreePartSpreeCode { get; set; }
        public short SpreePartType { get; set; }
        public string SpreePartName { get; set; }
        public long? SpreePartVoucherCode { get; set; }
        public int? SpreePartPoint { get; set; }
        public sbyte SpreePartState { get; set; }
        public sbyte? SpreePartSyncState { get; set; }
        public string SpreePartVarParamA { get; set; }
        public string SpreePartVarParamB { get; set; }
        public long? SpreePartIntParamA { get; set; }
        public long? SpreePartIntParamB { get; set; }
        public double? SpreePartFloatParamA { get; set; }
        public double? SpreePartFloatParamB { get; set; }
    }
}
