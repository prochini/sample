using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecEcstoreprodlist
    {
        public long EcstoreProdListId { get; set; }
        public long? EcstoreProdListProdListCode { get; set; }
        public long? EcstoreProdListEcstoreCode { get; set; }
        public sbyte? EcstoreProdListSyncState { get; set; }
        public string EcstoreProdListVarParamA { get; set; }
        public string EcstoreProdListVarParamB { get; set; }
        public long? EcstoreProdListIntParamA { get; set; }
        public long? EcstoreProdListIntParamB { get; set; }
        public double? EcstoreProdListFloatParamA { get; set; }
        public double? EcstoreProdListFloatParamB { get; set; }
    }
}
