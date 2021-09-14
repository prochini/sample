using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUsermission3
    {
        public long UserMissionId { get; set; }
        public long UserMissionMissionCode { get; set; }
        public long UserMissionUserInfoCode { get; set; }
        public sbyte UserMissionFreqCount { get; set; }
        public short UserMissionCompleteCount { get; set; }
        public sbyte UserMissionIsReleased { get; set; }
        public DateTime UserMissionRelLimtDate { get; set; }
        public DateTime? UserMissionReleasedDate { get; set; }
        public DateTime UserMissionDate { get; set; }
        public sbyte UserMissionState { get; set; }
        public sbyte? UserMissionSyncState { get; set; }
        public string UserMissionVarParamA { get; set; }
        public string UserMissionVarParamB { get; set; }
        public long? UserMissionIntParamA { get; set; }
        public long? UserMissionIntParamB { get; set; }
        public double? UserMissionFloatParamA { get; set; }
        public double? UserMissionFloatParamB { get; set; }
        public double UserMissionAmountPoint { get; set; }
        public DateTime? UserMissionUpdateDate { get; set; }
        public int UserMissionAmountCount { get; set; }
    }
}
