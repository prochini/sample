using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecAuthstore
    {
        public long AuthStoreId { get; set; }
        public long AuthStoreCountryCode { get; set; }
        public long? AuthStoreCompanyCode { get; set; }
        public long AuthStoreCode { get; set; }
        public string AuthStoreName { get; set; }
        public sbyte AuthStoreState { get; set; }
        public sbyte? AuthStoreSyncState { get; set; }
        public string AuthStoreVarParamA { get; set; }
        public string AuthStoreVarParamB { get; set; }
        public long? AuthStoreIntParamA { get; set; }
        public long? AuthStoreIntParamB { get; set; }
        public double? AuthStoreFloatParamA { get; set; }
        public double? AuthStoreFloatParamB { get; set; }
    }
}
