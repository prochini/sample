using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUsercardlog2
    {
        public ulong UserCardLogId { get; set; }
        public long UserCardLogUserInfoCode { get; set; }
        public long UserCardLogUserFavouriteId { get; set; }
        public long? UserCardLogFtpdataId { get; set; }
        public long UserCardLogProjectCode { get; set; }
        public int UserCardLogCardType { get; set; }
        public int UserCardLogUsedType { get; set; }
        public int? UserCardLogUsedCount { get; set; }
        public double? UserCardLogUsedAmount { get; set; }
        public DateTime? UserCardLogUsedDate { get; set; }
        public DateTime UserCardLogDate { get; set; }
        public sbyte UserCardLogState { get; set; }
        public sbyte? UserCardLogSyncState { get; set; }
        public string UserCardLogVarParamA { get; set; }
        public string UserCardLogVarParamB { get; set; }
        public long? UserCardLogIntParamA { get; set; }
        public long? UserCardLogIntParamB { get; set; }
        public double? UserCardLogFloatParamA { get; set; }
        public double? UserCardLogFloatParamB { get; set; }
    }
}
