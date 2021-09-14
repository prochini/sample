using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpDeliveryorder
    {
        public long DeliveryOrderId { get; set; }
        public long DeliveryOrderPartnerCode { get; set; }
        public long DeliveryOrderCode { get; set; }
        public long DeliveryOrderEcstoreCode { get; set; }
        public long DeliveryOrderUserInfoCode { get; set; }
        public string DeliveryOrderExtId { get; set; }
        public string DeliveryOrderExtNo { get; set; }
        public DateTime? DeliveryOrderExtDate { get; set; }
        public string DeliveryOrderExtState { get; set; }
        public DateTime DeliveryOrderDate { get; set; }
        public sbyte DeliveryOrderState { get; set; }
        public string DeliveryOrderVarParamA { get; set; }
        public string DeliveryOrderVarParamB { get; set; }
        public long? DeliveryOrderIntParamA { get; set; }
        public long? DeliveryOrderIntParamB { get; set; }
        public double? DeliveryOrderFloatParamA { get; set; }
        public double? DeliveryOrderFloatParamB { get; set; }
    }
}
