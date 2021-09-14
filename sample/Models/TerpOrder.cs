using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TerpOrder
    {
        public long OrderId { get; set; }
        public long OrderTableNo { get; set; }
        public long? OrderPayOrderTableNo { get; set; }
        public long? OrderMainStoreCode { get; set; }
        public long OrderEcstoreCode { get; set; }
        public long OrderUserInfoCode { get; set; }
        public long OrderEclogisticsId { get; set; }
        public string OrderQrcode { get; set; }
        public string OrderCurrency { get; set; }
        public double? OrderTaxRate { get; set; }
        public long OrderRecCountry { get; set; }
        public long OrderRecCity { get; set; }
        public long OrderRecCityArea { get; set; }
        public string OrderRecAddress { get; set; }
        public string OrderRecName { get; set; }
        public string OrderRecTel { get; set; }
        public double OrderShippingAmount { get; set; }
        public short OrderDeliveryWays { get; set; }
        public double OrderAmount { get; set; }
        public double OrderChangeAmount { get; set; }
        public string OrderConsumerMsg { get; set; }
        public DateTime? OrderDepartDate { get; set; }
        public DateTime? OrderArrivalDate { get; set; }
        public DateTime OrderInsertDate { get; set; }
        public DateTime? OrderDeadlineDate { get; set; }
        public DateTime? OrderPaymentDate { get; set; }
        public sbyte OrderState { get; set; }
        public string OrderVarParamA { get; set; }
        public string OrderVarParamB { get; set; }
        public long? OrderIntParamA { get; set; }
        public long? OrderIntParamB { get; set; }
        public double? OrderFloatParamA { get; set; }
        public double? OrderFloatParamB { get; set; }
        public string OrderRecEmail { get; set; }
        public double OrderChangeShippingAmount { get; set; }
        public double OrderPlatChangeAmount { get; set; }
        public DateTime? OrderAppreciationDate { get; set; }
        public long OrderUserPointId { get; set; }
        public double OrderReceiptAmount { get; set; }
        public string OrderReceiptText { get; set; }
        public short OrderType { get; set; }
        public string OrderNote { get; set; }
    }
}
