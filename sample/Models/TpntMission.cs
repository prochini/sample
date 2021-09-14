using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpntMission
    {
        public long MissionId { get; set; }
        public long MissionCode { get; set; }
        public short MissionCountryCode { get; set; }
        public short MissionType { get; set; }
        public string MissionName { get; set; }
        public string MissionExtName { get; set; }
        public sbyte MissionAutoReleased { get; set; }
        public string MissionImage { get; set; }
        public int MissionReleasedCount { get; set; }
        public int MissionIssuanceLimit { get; set; }
        public short MissionCompleteCount { get; set; }
        public sbyte MissionFreq { get; set; }
        public short MissionFreqValue { get; set; }
        public double MissionValue { get; set; }
        public double MissionLimitValue { get; set; }
        public DateTime MissionOnDate { get; set; }
        public DateTime MissionOffDate { get; set; }
        public DateTime MissionOnlineDate { get; set; }
        public DateTime MissionOfflineDate { get; set; }
        public sbyte MissionTemplateState { get; set; }
        public sbyte MissionState { get; set; }
        public sbyte? MissionSyncState { get; set; }
        public string MissionVarParamA { get; set; }
        public string MissionVarParamB { get; set; }
        public long? MissionIntParamA { get; set; }
        public long? MissionIntParamB { get; set; }
        public double? MissionFloatParamA { get; set; }
        public double? MissionFloatParamB { get; set; }
        public long MissionUpMissionCode { get; set; }
        public sbyte MissionIsDoneUp { get; set; }
        public string MissionInfo { get; set; }
        public string MissionUrltitle { get; set; }
        public string MissionUrl { get; set; }
        public short MissionCompleteType { get; set; }
        public string MissionCurrentUrltarget { get; set; }
        public string MissionCurrentUrl { get; set; }
        public string MissionReDirUrl { get; set; }
        public sbyte? MissionIsSendMsg { get; set; }
        public short MissionIsOnline { get; set; }
        public string MissionVoucher { get; set; }
        public string MissionCompleteRule { get; set; }
        public double MissionReleasedValue { get; set; }
        public int MissionReceiveLimit { get; set; }
        public double MissionLimitTotalValue { get; set; }
        public string MissionRuleDec { get; set; }
        public string MissionCondition { get; set; }
    }
}
