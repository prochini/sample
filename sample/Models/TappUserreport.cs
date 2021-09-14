using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappUserreport
    {
        public long UserReportId { get; set; }
        public long UserReportCountryCode { get; set; }
        public long? UserReportUpCategoryCode { get; set; }
        public long? UserReportUpItemCode { get; set; }
        public long UserReportCategoryCode { get; set; }
        public string UserReportCategoryName { get; set; }
        public long UserReportItemCode { get; set; }
        public string UserReportItemName { get; set; }
        public string UserReportParamA { get; set; }
        public string UserReportParamB { get; set; }
        public string UserReportParamC { get; set; }
        public string UserReportParamD { get; set; }
        public long? UserReportParamE { get; set; }
        public long? UserReportParamF { get; set; }
        public long? UserReportParamG { get; set; }
        public long? UserReportParamH { get; set; }
        public string UserReportParamI { get; set; }
        public string UserReportParamJ { get; set; }
        public long? UserReportSort { get; set; }
        public sbyte UserReportState { get; set; }
        public sbyte? UserReportSyncState { get; set; }
        public string UserReportMemo { get; set; }
        public string UserReportVarParamA { get; set; }
        public string UserReportVarParamB { get; set; }
        public long? UserReportIntParamA { get; set; }
        public long? UserReportIntParamB { get; set; }
        public double? UserReportFloatParamA { get; set; }
        public double? UserReportFloatParamB { get; set; }
        public DateTime? UserReportParamK { get; set; }
        public DateTime? UserReportParamL { get; set; }
        public sbyte? UserReportIsShow { get; set; }
    }
}
