using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappSystemlog
    {
        public ulong SystemLogId { get; set; }
        public long? SystemLogActionCode { get; set; }
        public long? SystemLogCompanyCode { get; set; }
        public short SystemLogType { get; set; }
        public long? SystemLogUserInfoCode { get; set; }
        public string SystemLogDealerName { get; set; }
        public string SystemLogException { get; set; }
        public long? SystemLogErrorCode { get; set; }
        public string SystemLogOnErrorSql { get; set; }
        public string SystemLogRequestModel { get; set; }
        public string SystemLogResponseModel { get; set; }
        public long? SystemLogOperateCode { get; set; }
        public string SystemLogOperateName { get; set; }
        public string SystemLogIp { get; set; }
        public string SystemLogServicesVer { get; set; }
        public DateTime SystemLogDate { get; set; }
        public sbyte? SystemLogSyncState { get; set; }
        public string SystemLogVarParamA { get; set; }
        public string SystemLogVarParamB { get; set; }
        public long? SystemLogIntParamA { get; set; }
        public long? SystemLogIntParamB { get; set; }
        public double? SystemLogFloatParamA { get; set; }
        public double? SystemLogFloatParamB { get; set; }
    }
}
