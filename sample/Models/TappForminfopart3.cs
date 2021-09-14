using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappForminfopart3
    {
        public long FormInfoPartId { get; set; }
        public long FormInfoPartTableNo { get; set; }
        public long FormInfoPartChildTableNo { get; set; }
        public long FormInfoPartChildGroupNo { get; set; }
        public sbyte FormInfoPartState { get; set; }
        public sbyte? FormInfoPartSyncState { get; set; }
        public string FormInfoPartVarParamA { get; set; }
        public string FormInfoPartVarParamB { get; set; }
        public long? FormInfoPartIntParamA { get; set; }
        public long? FormInfoPartIntParamB { get; set; }
        public double? FormInfoPartFloatParamA { get; set; }
        public double? FormInfoPartFloatParamB { get; set; }
    }
}
