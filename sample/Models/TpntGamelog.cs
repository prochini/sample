using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpntGamelog
    {
        public long GameLogId { get; set; }
        public long GameLogUserInfoCode { get; set; }
        public long GameLogGameCode { get; set; }
        public long GameLogGamePartId { get; set; }
        public DateTime GameLogDate { get; set; }
        public string GameLogVarParamA { get; set; }
        public string GameLogVarParamB { get; set; }
        public long? GameLogIntParamA { get; set; }
        public long? GameLogIntParamB { get; set; }
        public double? GameLogFloatParamA { get; set; }
        public double? GameLogFloatParamB { get; set; }
        public short GameLogGamePartType { get; set; }
        public sbyte GameLogSendState { get; set; }
    }
}
