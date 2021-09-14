using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpntMissionpart
    {
        public long MissionPartId { get; set; }
        public long MissionPartMissionCode { get; set; }
        public long MissionPartActionCode { get; set; }
        public sbyte MissionPartState { get; set; }
        public sbyte? MissionPartSyncState { get; set; }
        public string MissionPartVarParamA { get; set; }
        public string MissionPartVarParamB { get; set; }
        public long? MissionPartIntParamA { get; set; }
        public long? MissionPartIntParamB { get; set; }
        public double? MissionPartFloatParamA { get; set; }
        public double? MissionPartFloatParamB { get; set; }
    }
}
