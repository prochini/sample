using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayPgorderlog
    {
        public long PgorderLogId { get; set; }
        public long PgorderLogPgorderNo { get; set; }
        public double PgorderLogAmount { get; set; }
        public short PgorderLogPayActionState { get; set; }
        public string PgorderLogDealerName { get; set; }
        public DateTime PgorderLogDate { get; set; }
        public string PgorderLogVarParamA { get; set; }
        public string PgorderLogVarParamB { get; set; }
        public long? PgorderLogIntParamA { get; set; }
        public long? PgorderLogIntParamB { get; set; }
        public double? PgorderLogFloatParamA { get; set; }
        public double? PgorderLogFloatParamB { get; set; }
    }
}
