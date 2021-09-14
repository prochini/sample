using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseListmap
    {
        public long ListMapId { get; set; }
        public long ListMapChannelId { get; set; }
        public long ListMapProdListCode { get; set; }
        public long ListMapUserDefineCode { get; set; }
        public sbyte? ListMapSyncState { get; set; }
        public string ListMapVarParamA { get; set; }
        public string ListMapVarParamB { get; set; }
        public long? ListMapIntParamA { get; set; }
        public long? ListMapIntParamB { get; set; }
        public double? ListMapFloatParamA { get; set; }
        public double? ListMapFloatParamB { get; set; }
    }
}
