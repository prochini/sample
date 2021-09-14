using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpntMissionlog
    {
        public long MissionLogId { get; set; }
        public long MissionLogUserInfoCode { get; set; }
        public long MissionLogMissionCode { get; set; }
        public DateTime MissionLogDate { get; set; }
        public string MissionLogVarParamA { get; set; }
        public string MissionLogVarParamB { get; set; }
        public long? MissionLogIntParamA { get; set; }
        public long? MissionLogIntParamB { get; set; }
        public double? MissionLogFloatParamA { get; set; }
        public double? MissionLogFloatParamB { get; set; }
        public long MissionLogActionCode { get; set; }
    }
}
