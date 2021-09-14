using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseCachemapping
    {
        public long CacheMappingId { get; set; }
        public long CacheMappingBeactionCode { get; set; }
        public long CacheMappingBeoperCode { get; set; }
        public long CacheMappingFeactionCode { get; set; }
        public sbyte CacheMappingState { get; set; }
        public sbyte? CacheMappingSyncState { get; set; }
        public string CacheMappingVarParamA { get; set; }
        public string CacheMappingVarParamB { get; set; }
        public long? CacheMappingIntParamA { get; set; }
        public long? CacheMappingIntParamB { get; set; }
        public double? CacheMappingFloatParamA { get; set; }
        public double? CacheMappingFloatParamB { get; set; }
    }
}
