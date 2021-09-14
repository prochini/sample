using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayPayorder
    {
        public long PayOrderId { get; set; }
        public long PayOrderTableNo { get; set; }
        public string PayOrderExtNo { get; set; }
        public string PayOrderPaymentNo { get; set; }
        public long PayOrderType { get; set; }
        public short PayOrderFundsMode { get; set; }
        public long? PayOrderContractStoreCode { get; set; }
        public long? PayOrderPaymentFlowCode { get; set; }
        public long? PayOrderPfpaymentCode { get; set; }
        public long? PayOrderPfpaymentPartCode { get; set; }
        public string PayOrderPfpaymentPartValue { get; set; }
        public string PayOrderInfo { get; set; }
        public string PayOrderCurrency { get; set; }
        public double PayOrderCost { get; set; }
        public double PayOrderTrueAmount { get; set; }
        public double PayOrderShippingAmount { get; set; }
        public double PayOrderAmount { get; set; }
        public double PayOrderPayAmount { get; set; }
        public double PayOrderMobiiFee { get; set; }
        public double PayOrderExtraFee { get; set; }
        public long? PayOrderRefundCount { get; set; }
        public double PayOrderRefundAmount { get; set; }
        public DateTime? PayOrderExpiry { get; set; }
        public long PayOrderUserInfoCode { get; set; }
        public sbyte? PayOrderCarrierType { get; set; }
        public string PayOrderCarrierCode { get; set; }
        public string PayOrderLoveCode { get; set; }
        public short? PayOrderInvoiceMode { get; set; }
        public string PayOrderInvoiceType { get; set; }
        public sbyte? PayOrderInvoiceStatus { get; set; }
        public string PayOrderInvoiceNo { get; set; }
        public string PayOrderInvoiceRandom { get; set; }
        public string PayOrderInvoiceTaxId { get; set; }
        public string PayOrderInvoiceTitle { get; set; }
        public string PayOrderInvoiceAddress { get; set; }
        public DateTime? PayOrderInvoiceDate { get; set; }
        public short PayOrderInvoiceState { get; set; }
        public string PayOrderExtMemberId { get; set; }
        public string PayOrderMemberEmail { get; set; }
        public string PayOrderMemberName { get; set; }
        public string PayOrderMemberPhone { get; set; }
        public string PayOrderTableNote { get; set; }
        public string PayOrderSupplierPayUrl { get; set; }
        public string PayOrderPayUrl { get; set; }
        public string PayOrderResultUrl { get; set; }
        public short PayOrderPayState { get; set; }
        public DateTime? PayOrderPayDate { get; set; }
        public short PayOrderRefundState { get; set; }
        public DateTime? PayOrderRefundDate { get; set; }
        public short PayOrderAllocateState { get; set; }
        public DateTime? PayOrderAllocateDate { get; set; }
        public short PayOrderCancelState { get; set; }
        public DateTime? PayOrderCancelDate { get; set; }
        public short PayOrderRequestState { get; set; }
        public DateTime? PayOrderRequestDate { get; set; }
        public short PayOrderClearState { get; set; }
        public DateTime? PayOrderClearDate { get; set; }
        public short PayOrderExtraFeeState { get; set; }
        public DateTime? PayOrderExtraFeeDate { get; set; }
        public short PayOrderAlertCount { get; set; }
        public DateTime PayOrderInsertDate { get; set; }
        public DateTime PayOrderUpdateDate { get; set; }
        public sbyte PayOrderState { get; set; }
        public string PayOrderMemo { get; set; }
        public string PayOrderVarParamA { get; set; }
        public string PayOrderVarParamB { get; set; }
        public long? PayOrderIntParamA { get; set; }
        public long? PayOrderIntParamB { get; set; }
        public double? PayOrderFloatParamA { get; set; }
        public double? PayOrderFloatParamB { get; set; }
        public string PayOrderPaymentResult { get; set; }
        public string PayOrderCard4No { get; set; }
        public long? PayOrderMainStoreCode { get; set; }
        public long? PayOrderEcstoreCode { get; set; }
        public long? PayOrderUserDeviceCode { get; set; }
        public string PayOrderReceiptNo { get; set; }
        public double? PayOrderReceiptAmount { get; set; }
    }
}
