using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecEcstorelink
    {
        public ulong EcstoreLinkId { get; set; }
        public long EcstoreLinkEcstoreCode { get; set; }
        public string EcstoreLinkName { get; set; }
        public string EcstoreLinkUrltarget { get; set; }
        public string EcstoreLinkUrl { get; set; }
        public string EcstoreLinkIcon { get; set; }
        public long EcstoreLinkSort { get; set; }
        public DateTime EcstoreLinkInsertDate { get; set; }
        public sbyte EcstoreLinkState { get; set; }
        public sbyte? EcstoreLinkSyncState { get; set; }
        public string EcstoreLinkVarParamA { get; set; }
        public string EcstoreLinkVarParamB { get; set; }
        public long? EcstoreLinkIntParamA { get; set; }
        public long? EcstoreLinkIntParamB { get; set; }
        public double? EcstoreLinkFloatParamA { get; set; }
        public double? EcstoreLinkFloatParamB { get; set; }
    }
}
