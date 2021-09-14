using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseUserspree3
    {
        public long UserSpreeId { get; set; }
        public long UserSpreeUserInfoCode { get; set; }
        public long? UserSpreeVoucherCode { get; set; }
        public long UserSpreeSpreeCode { get; set; }
        public DateTime UserSpreeReceiveDate { get; set; }
        public sbyte UserSpreeState { get; set; }
        public sbyte? UserSpreeSyncState { get; set; }
        public string UserSpreeVarParamA { get; set; }
        public string UserSpreeVarParamB { get; set; }
        public long? UserSpreeIntParamA { get; set; }
        public long? UserSpreeIntParamB { get; set; }
        public double? UserSpreeFloatParamA { get; set; }
        public double? UserSpreeFloatParamB { get; set; }
    }
}
