using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecEclogisticspart
    {
        public long EclogisticsPartId { get; set; }
        public long EclogisticsPartEclogisticsId { get; set; }
        public long? EclogisticsPartCountry { get; set; }
        public long? EclogisticsPartCity { get; set; }
        public string EclogisticsPartVarParamA { get; set; }
        public string EclogisticsPartVarParamB { get; set; }
        public string EclogisticsPartVarParamC { get; set; }
        public long? EclogisticsPartIntParamA { get; set; }
        public long? EclogisticsPartIntParamB { get; set; }
        public long? EclogisticsPartIntParamC { get; set; }
        public double? EclogisticsPartFloatParamA { get; set; }
        public double? EclogisticsPartFloatParamB { get; set; }
        public double? EclogisticsPartFloatParamC { get; set; }
    }
}
