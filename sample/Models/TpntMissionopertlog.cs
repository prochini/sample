using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpntMissionopertlog
    {
        public ulong MissionOpertLogId { get; set; }
        public long MissionOpertLogMissionCode { get; set; }
        public long MissionOpertLogActionState { get; set; }
        public string MissionOpertLogDealerName { get; set; }
        public string MissionOpertLogJsonMission { get; set; }
        public string MissionOpertLogMemo { get; set; }
        public DateTime MissionOpertLogDate { get; set; }
        public sbyte? MissionOpertLogSyncState { get; set; }
        public string MissionOpertLogVarParamA { get; set; }
        public string MissionOpertLogVarParamB { get; set; }
        public long? MissionOpertLogIntParamA { get; set; }
        public long? MissionOpertLogIntParamB { get; set; }
        public double? MissionOpertLogFloatParamA { get; set; }
        public double? MissionOpertLogFloatParamB { get; set; }
        public string MissionOpertLogJsonMissionPart { get; set; }
    }
}
