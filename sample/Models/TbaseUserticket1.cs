using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserticket1
    {
        public ulong UserTicketId { get; set; }
        public long UserTicketUserInfoCode { get; set; }
        public long UserTicketCode { get; set; }
        public string UserTicketExtCode { get; set; }
        public string UserTicketQrcode { get; set; }
        public string UserTicketUniqueId { get; set; }
        public double UserTicketRefundFee { get; set; }
        public sbyte UserTicketUsedState { get; set; }
        public DateTime? UserTicketOpenDate { get; set; }
        public DateTime? UserTicketRefundDate { get; set; }
        public DateTime UserTicketDate { get; set; }
        public DateTime? UserTicketLimitDate { get; set; }
        public string UserTicketBuyModel { get; set; }
        public string UserTicketRefundModel { get; set; }
        public sbyte UserTicketState { get; set; }
        public sbyte? UserTicketSyncState { get; set; }
        public string UserTicketVarParamA { get; set; }
        public string UserTicketVarParamB { get; set; }
        public long? UserTicketIntParamA { get; set; }
        public long? UserTicketIntParamB { get; set; }
        public double? UserTicketFloatParamA { get; set; }
        public double? UserTicketFloatParamB { get; set; }
        public long UserTicketProdCode { get; set; }
    }
}
