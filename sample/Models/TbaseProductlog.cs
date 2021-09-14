using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseProductlog
    {
        public long ProductLogId { get; set; }
        public long ProductLogProductCode { get; set; }
        public long ProductLogProdActionState { get; set; }
        public string ProductLogDealerName { get; set; }
        public DateTime ProductLogDate { get; set; }
        public sbyte? ProductLogSyncState { get; set; }
        public string ProductLogVarParamA { get; set; }
        public string ProductLogVarParamB { get; set; }
        public long? ProductLogIntParamA { get; set; }
        public long? ProductLogIntParamB { get; set; }
        public double? ProductLogFloatParamA { get; set; }
        public double? ProductLogFloatParamB { get; set; }
        public sbyte? ProductLogProdPassState { get; set; }
        public string ProductLogJsonProduct { get; set; }
        public string ProductLogMemo { get; set; }
    }
}
