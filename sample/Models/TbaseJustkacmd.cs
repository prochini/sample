using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseJustkacmd
    {
        public long JustKaCmdId { get; set; }
        public string JustKaCmdMessageId { get; set; }
        public string JustKaCmdMessageDatetime { get; set; }
        public string JustKaCmdUid { get; set; }
        public string JustKaCmdSuid { get; set; }
        public string JustKaCmdOuid { get; set; }
        public string JustKaCmdMuid { get; set; }
        public sbyte? JustKaCmdResult { get; set; }
        public DateTime? JustKaCmdDate { get; set; }
        public string JustKaCmdVarParamA { get; set; }
        public string JustKaCmdVarParamB { get; set; }
        public long? JustKaCmdIntParamA { get; set; }
        public long? JustKaCmdIntParamB { get; set; }
        public double? JustKaCmdFloatParamA { get; set; }
        public double? JustKaCmdFloatParamB { get; set; }
    }
}
