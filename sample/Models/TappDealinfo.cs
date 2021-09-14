using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappDealinfo
    {
        public long DealInfoId { get; set; }
        public long DealInfoTableNo { get; set; }
        public long? DealInfoMainTableNo { get; set; }
        public string DealInfoIpaddress { get; set; }
        public long? DealInfoUpTableInfoNo { get; set; }
        public DateTime? DealInfoUpTableInfoModifyDate { get; set; }
        public long DealInfoTableTypeCode { get; set; }
        public string DealInfoTableTypeName { get; set; }
        public long DealInfoTableTypeWorkflowId { get; set; }
        public long? DealInfoUpCompanyCode { get; set; }
        public long? DealInfoCompanyCode { get; set; }
        public long DealInfoDealerCode { get; set; }
        public string DealInfoDealerName { get; set; }
        public long? DealInfoDealTypeCode { get; set; }
        public string DealInfoDealTypeName { get; set; }
        public long? DealInfoDealStateCode { get; set; }
        public string DealInfoDealStateName { get; set; }
        public string DealInfoDealStateShowName { get; set; }
        public long DealInfoInsertDealerCode { get; set; }
        public sbyte? DealInfoShippingState { get; set; }
        public sbyte? DealInfoDeliveryState { get; set; }
        public sbyte? DealInfoRevenueState { get; set; }
        public sbyte? DealInfoActuallyPaidState { get; set; }
        public sbyte? DealInfoPaymentState { get; set; }
        public sbyte DealInfoLockState { get; set; }
        public DateTime DealInfoDate { get; set; }
        public string DealInfoContent { get; set; }
        public string DealInfoMemo { get; set; }
        public sbyte? DealInfoSyncState { get; set; }
        public string DealInfoVarParamA { get; set; }
        public string DealInfoVarParamB { get; set; }
        public long? DealInfoIntParamA { get; set; }
        public long? DealInfoIntParamB { get; set; }
        public double? DealInfoFloatParamA { get; set; }
        public double? DealInfoFloatParamB { get; set; }
    }
}
