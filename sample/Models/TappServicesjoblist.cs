using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappServicesjoblist
    {
        public long ServicesJobListId { get; set; }
        public long? ServicesJobListServiceInfoCode { get; set; }
        public short? ServicesJobListJobState { get; set; }
        public string ServicesJobListDealerName { get; set; }
        public string ServicesJobListLogUrl { get; set; }
        public short? ServicesJobListResult { get; set; }
        public string ServicesJobListMessage { get; set; }
        public DateTime? ServicesJobListRunDate { get; set; }
        public DateTime? ServicesJobListEndDate { get; set; }
        public DateTime? ServicesJobListDate { get; set; }
        public sbyte ServicesJobListState { get; set; }
        public sbyte? ServicesJobListSyncState { get; set; }
        public string ServicesJobListVarParamA { get; set; }
        public string ServicesJobListVarParamB { get; set; }
        public long? ServicesJobListIntParamA { get; set; }
        public long? ServicesJobListIntParamB { get; set; }
        public double? ServicesJobListFloatParamA { get; set; }
        public double? ServicesJobListFloatParamB { get; set; }
    }
}
