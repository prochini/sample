using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecAuthstorepart
    {
        public long AuthStorePartId { get; set; }
        public long AuthStorePartAuthStoreCode { get; set; }
        public sbyte AuthStorePartType { get; set; }
        public string AuthStorePartText { get; set; }
        public sbyte AuthStorePartState { get; set; }
        public sbyte? AuthStorePartSyncState { get; set; }
        public string AuthStorePartVarParamA { get; set; }
        public string AuthStorePartVarParamB { get; set; }
        public long? AuthStorePartIntParamA { get; set; }
        public long? AuthStorePartIntParamB { get; set; }
        public double? AuthStorePartFloatParamA { get; set; }
        public double? AuthStorePartFloatParamB { get; set; }
    }
}
