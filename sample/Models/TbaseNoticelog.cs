using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseNoticelog
    {
        public long NoticeLogId { get; set; }
        public sbyte NoticeLogType { get; set; }
        public sbyte NoticeLogMode { get; set; }
        public long NoticeLogFromCode { get; set; }
        public long NoticeLogToUserCode { get; set; }
        public string NoticeLogToExtCode { get; set; }
        public string NoticeLogTo { get; set; }
        public string NoticeLogCheckCode { get; set; }
        public string NoticeLogTitle { get; set; }
        public string NoticeLogContect { get; set; }
        public DateTime? NoticeLogSendDate { get; set; }
        public DateTime? NoticeLogLimitDate { get; set; }
        public sbyte? NoticeLogSendState { get; set; }
        public string NoticeLogResult { get; set; }
        public DateTime NoticeLogDate { get; set; }
        public sbyte? NoticeLogState { get; set; }
        public string NoticeLogFromAccount { get; set; }
        public long? NoticeLogFromEccode { get; set; }
    }
}
