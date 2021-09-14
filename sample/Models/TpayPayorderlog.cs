using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayPayorderlog
    {
        public long PayOrderLogId { get; set; }
        public long PayOrderLogPayOrderTableNo { get; set; }
        public long? PayOrderLogOrderTableNo { get; set; }
        public long? PayOrderLogEcstoreCode { get; set; }
        public double PayOrderLogAmount { get; set; }
        public double PayOrderLogRefundAmount { get; set; }
        public short PayOrderLogPayActionState { get; set; }
        public string PayOrderLogDealerName { get; set; }
        public DateTime PayOrderLogDate { get; set; }
        public string PayOrderLogVarParamA { get; set; }
        public string PayOrderLogVarParamB { get; set; }
        public long? PayOrderLogIntParamA { get; set; }
        public long? PayOrderLogIntParamB { get; set; }
        public double? PayOrderLogFloatParamA { get; set; }
        public double? PayOrderLogFloatParamB { get; set; }
        public string PayOrderLogPaymentResult { get; set; }
    }
}
