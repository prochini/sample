using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TecEclogistic
    {
        public long EclogisticsId { get; set; }
        public long EclogisticsEcstoreCode { get; set; }
        public string EclogisticsName { get; set; }
        public double EclogisticsAmount { get; set; }
        public sbyte EclogisticsState { get; set; }
        public string EclogisticsVarParamA { get; set; }
        public string EclogisticsVarParamB { get; set; }
        public string EclogisticsVarParamC { get; set; }
        public long? EclogisticsIntParamA { get; set; }
        public long? EclogisticsIntParamB { get; set; }
        public long? EclogisticsIntParamC { get; set; }
        public double? EclogisticsFloatParamA { get; set; }
        public double? EclogisticsFloatParamB { get; set; }
        public double? EclogisticsFloatParamC { get; set; }
    }
}
