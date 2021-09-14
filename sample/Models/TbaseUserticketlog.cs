using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserticketlog
    {
        public long UserTicketLogId { get; set; }
        public long UserTicketLogUserTicketCode { get; set; }
        public sbyte UserTicketLogUsedState { get; set; }
        public sbyte UserTicketLogKrtcstate { get; set; }
        public long UserTicketLogInOutStation { get; set; }
        public DateTime UserTicketLogStateDate { get; set; }
        public string UserTicketLogFileName { get; set; }
        public DateTime UserTicketLogDate { get; set; }
        public sbyte UserTicketLogState { get; set; }
        public sbyte? UserTicketLogSyncState { get; set; }
        public string UserTicketLogVarParamA { get; set; }
        public string UserTicketLogVarParamB { get; set; }
        public long? UserTicketLogIntParamA { get; set; }
        public long? UserTicketLogIntParamB { get; set; }
        public double? UserTicketLogFloatParamA { get; set; }
        public double? UserTicketLogFloatParamB { get; set; }
    }
}
