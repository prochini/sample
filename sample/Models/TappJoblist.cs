using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappJoblist
    {
        public long JobListId { get; set; }
        public long JobListTableInfoNo { get; set; }
        public long JobListCompanyCode { get; set; }
        public long? JobListUpTableInfoNo { get; set; }
        public string JobListUpDealerName { get; set; }
        public string JobListUpDealTypeName { get; set; }
        public DateTime JobListLastDealerDate { get; set; }
        public long JobListTableTypeCode { get; set; }
        public string JobListTableTypeName { get; set; }
        public long JobListDealTypeCode { get; set; }
        public string JobListDealTypeName { get; set; }
        public long JobListDealStateCode { get; set; }
        public string JobListDealStateName { get; set; }
        public long JobListDealerCode { get; set; }
        public string JobListDealerName { get; set; }
        public long? JobListHistoryTabCode { get; set; }
        public long? JobListRecorderCode { get; set; }
        public string JobListUrl { get; set; }
        public sbyte JobListState { get; set; }
        public string JobListMemo { get; set; }
        public sbyte? JobListSyncState { get; set; }
        public string JobListVarParamA { get; set; }
        public string JobListVarParamB { get; set; }
        public long? JobListIntParamA { get; set; }
        public long? JobListIntParamB { get; set; }
        public double? JobListFloatParamA { get; set; }
        public double? JobListFloatParamB { get; set; }
    }
}
