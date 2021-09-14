using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TpayPgorder
    {
        public long PgorderId { get; set; }
        public long PgorderNo { get; set; }
        public string PgorderPaymentNo { get; set; }
        public long PgorderType { get; set; }
        public long? PgorderContractStoreCode { get; set; }
        public long? PgorderPaymentFlowCode { get; set; }
        public long? PgorderPfpaymentCode { get; set; }
        public long? PgorderPfpaymentPartCode { get; set; }
        public string PgorderPfpaymentPartValue { get; set; }
        public string PgorderSupplierPayUrl { get; set; }
        public string PgorderExtOrderNo { get; set; }
        public string PgorderExtMemberId { get; set; }
        public string PgorderMemberEmail { get; set; }
        public string PgorderMemberName { get; set; }
        public string PgorderMemberPhone { get; set; }
        public long? PgorderPgmemberNo { get; set; }
        public long? PgorderPgmemberToken { get; set; }
        public string PgorderInfo { get; set; }
        public string PgorderCurrency { get; set; }
        public double PgorderPayAmount { get; set; }
        public long? PgorderRefundCount { get; set; }
        public double PgorderRefundAmount { get; set; }
        public DateTime? PgorderExpiry { get; set; }
        public string PgorderCard4No { get; set; }
        public string PgorderPayUrl { get; set; }
        public string PgorderResultUrl { get; set; }
        public short PgorderPayState { get; set; }
        public DateTime? PgorderPayDate { get; set; }
        public short PgorderRefundState { get; set; }
        public DateTime? PgorderRefundDate { get; set; }
        public short PgorderAllocateState { get; set; }
        public DateTime? PgorderAllocateDate { get; set; }
        public short PgorderCancelState { get; set; }
        public DateTime? PgorderCancelDate { get; set; }
        public short PgorderRequestState { get; set; }
        public DateTime? PgorderRequestDate { get; set; }
        public short PgorderClearState { get; set; }
        public DateTime? PgorderClearDate { get; set; }
        public short PgorderExtraFeeState { get; set; }
        public DateTime? PgorderExtraFeeDate { get; set; }
        public short PgorderAlertCount { get; set; }
        public DateTime PgorderInsertDate { get; set; }
        public DateTime PgorderUpdateDate { get; set; }
        public sbyte PgorderState { get; set; }
        public string PgorderPaymentResult { get; set; }
        public string PgorderMemo { get; set; }
        public string PgorderVarParamA { get; set; }
        public string PgorderVarParamB { get; set; }
        public long? PgorderIntParamA { get; set; }
        public long? PgorderIntParamB { get; set; }
        public double? PgorderFloatParamA { get; set; }
        public double? PgorderFloatParamB { get; set; }
    }
}
