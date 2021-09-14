using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpntMissionjoblist
    {
        public ulong MissionJobListId { get; set; }
        public long MissionJobListUserInfoCode { get; set; }
        public long? MissionJobListtOtherCode { get; set; }
        public long MissionJobListActionCode { get; set; }
        public DateTime? MissionJobListHandleDate { get; set; }
        public sbyte MissionJobListHandleState { get; set; }
        public DateTime MissionJobListDate { get; set; }
        public string MissionJobListVarParamA { get; set; }
        public string MissionJobListVarParamB { get; set; }
        public long? MissionJobListIntParamA { get; set; }
        public long? MissionJobListIntParamB { get; set; }
        public double? MissionJobListFloatParamA { get; set; }
        public double? MissionJobListFloatParamB { get; set; }
    }
}
