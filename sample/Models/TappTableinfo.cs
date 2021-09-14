using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TappTableinfo
    {
        public long TableInfoId { get; set; }
        public long TableInfoTableNo { get; set; }
        public long? TableInfoMainTableNo { get; set; }
        public short? TableInfoMainGroupNo { get; set; }
        public long? TableInfoUpTableInfoNo { get; set; }
        public DateTime? TableInfoUpTableInfoModifyDate { get; set; }
        public string TableInfoUpTableTypeName { get; set; }
        public string TableInfoUpDealerName { get; set; }
        public short? TableInfoUpGroupNo { get; set; }
        public long TableInfoTableTypeCode { get; set; }
        public string TableInfoTableTypeName { get; set; }
        public long TableInfoTableTypeWorkflowId { get; set; }
        public long? TableInfoUpCompanyCode { get; set; }
        public long? TableInfoCompanyCode { get; set; }
        public long? TableInfoDealTypeCode { get; set; }
        public string TableInfoDealTypeName { get; set; }
        public long? TableInfoDealStateCode { get; set; }
        public string TableInfoDealStateName { get; set; }
        public string TableInfoDealStateShowName { get; set; }
        public long? TableInfoNextDealTypeCode { get; set; }
        public string TableInfoNextDealTypeName { get; set; }
        public long TableInfoDealerCode { get; set; }
        public string TableInfoDealerName { get; set; }
        public DateTime TableInfoModifyDate { get; set; }
        public long TableInfoInsertDealerCode { get; set; }
        public short TableInfoTemplateState { get; set; }
        public sbyte? TableInfoShippingState { get; set; }
        public sbyte? TableInfoDeliveryState { get; set; }
        public sbyte? TableInfoRevenueState { get; set; }
        public sbyte? TableInfoActuallyPaidState { get; set; }
        public sbyte? TableInfoPaymentState { get; set; }
        public sbyte TableInfoLockState { get; set; }
        public short TableInfoGroupNo { get; set; }
        public string TableInfoIpaddress { get; set; }
        public DateTime TableInfoDate { get; set; }
        public string TableInfoContent { get; set; }
        public string TableInfoMemo { get; set; }
        public sbyte? TableInfoSyncState { get; set; }
        public string TableInfoVarParamA { get; set; }
        public string TableInfoVarParamB { get; set; }
        public long? TableInfoIntParamA { get; set; }
        public long? TableInfoIntParamB { get; set; }
        public double? TableInfoFloatParamA { get; set; }
        public double? TableInfoFloatParamB { get; set; }
    }
}
