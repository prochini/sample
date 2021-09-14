using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouSpree
    {
        public long SpreeId { get; set; }
        public long SpreeCode { get; set; }
        public short SpreeCountryCode { get; set; }
        public string SpreeName { get; set; }
        public string SpreeExtName { get; set; }
        public string SpreeImage { get; set; }
        public int SpreeReleasedCount { get; set; }
        public int SpreeIssuanceLimit { get; set; }
        public short SpreeReceiveLimit { get; set; }
        public string SpreeContent { get; set; }
        public DateTime SpreeUsedOnDate { get; set; }
        public DateTime SpreeUsedOffDate { get; set; }
        public DateTime SpreeOnlineDate { get; set; }
        public DateTime SpreeOfflineDate { get; set; }
        public sbyte SpreeState { get; set; }
        public sbyte? SpreeSyncState { get; set; }
        public string SpreeVarParamA { get; set; }
        public string SpreeVarParamB { get; set; }
        public long? SpreeIntParamA { get; set; }
        public long? SpreeIntParamB { get; set; }
        public double? SpreeFloatParamA { get; set; }
        public double? SpreeFloatParamB { get; set; }
        public long SpreeCompanyCode { get; set; }
        public long SpreeEcstoreCode { get; set; }
        public string SpreeImg { get; set; }
        public string SpreeUrltarget { get; set; }
        public string SpreeUrl { get; set; }
        public short SpreeIsOnline { get; set; }
    }
}
