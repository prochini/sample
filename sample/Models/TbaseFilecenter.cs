using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseFilecenter
    {
        public long FileCenterId { get; set; }
        public long FileCenterMapTable { get; set; }
        public long FileCenterMapTableCode { get; set; }
        public short FileCenterType { get; set; }
        public string FileCenterName { get; set; }
        public string FileCenterFile { get; set; }
        public sbyte FileCenterState { get; set; }
        public sbyte? FileCenterSyncState { get; set; }
        public string FileCenterVarParamA { get; set; }
        public string FileCenterVarParamB { get; set; }
        public long? FileCenterIntParamA { get; set; }
        public long? FileCenterIntParamB { get; set; }
        public double? FileCenterFloatParamA { get; set; }
        public double? FileCenterFloatParamB { get; set; }
    }
}
