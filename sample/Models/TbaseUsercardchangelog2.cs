using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUsercardchangelog2
    {
        public long UserCardChangeLogId { get; set; }
        public long UserCardChangeLogUserInfoCode { get; set; }
        public long UserCardChangeLogUserFavouriteId { get; set; }
        public int UserCardChangeLogCardType { get; set; }
        public string UserCardChangeLogCardName { get; set; }
        public string UserCardChangeLogCardCode { get; set; }
        public sbyte UserCardChangeLogType { get; set; }
        public DateTime? UserCardChangeLogDate { get; set; }
        public sbyte? UserCardChangeLogSyncState { get; set; }
        public string UserCardChangeLogVarParamA { get; set; }
        public string UserCardChangeLogVarParamB { get; set; }
        public long? UserCardChangeLogIntParamA { get; set; }
        public long? UserCardChangeLogIntParamB { get; set; }
        public double? UserCardChangeLogFloatParamA { get; set; }
        public double? UserCardChangeLogFloatParamB { get; set; }
    }
}
