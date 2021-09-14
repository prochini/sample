using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TbaseProduct
    {
        public long ProductId { get; set; }
        public long ProductCountryCode { get; set; }
        public long ProductCode { get; set; }
        public string ProductExtCode { get; set; }
        public long ProductEcstoreCode { get; set; }
        public short ProductType { get; set; }
        public short ProductExClass { get; set; }
        public string ProductJson { get; set; }
        public string ProductUrl { get; set; }
        public string ProductName { get; set; }
        public string ProductExtName { get; set; }
        public string ProductKeyWord { get; set; }
        public string ProductDepiction { get; set; }
        public string ProductPrimeImage { get; set; }
        public string ProductIcon { get; set; }
        public double? ProductCostPrice { get; set; }
        public double ProductSellPrice { get; set; }
        public double ProductSpecialPrice { get; set; }
        public DateTime? ProductSpecialOnDate { get; set; }
        public DateTime? ProductSpecialOffDate { get; set; }
        public double ProductReceiptPrice { get; set; }
        public double ProductDiscountCoin { get; set; }
        public short ProductSellUnit { get; set; }
        public long ProductStockWarning { get; set; }
        public long? ProductSort1 { get; set; }
        public long ProductSort2 { get; set; }
        public sbyte ProductPassState { get; set; }
        public sbyte ProductTemplateState { get; set; }
        public sbyte ProductState { get; set; }
        public DateTime? ProductOnlineDate { get; set; }
        public DateTime? ProductOfflineDate { get; set; }
        public sbyte? ProductSyncState { get; set; }
        public string ProductMemo { get; set; }
        public string ProductVarParamA { get; set; }
        public string ProductVarParamB { get; set; }
        public long? ProductIntParamA { get; set; }
        public long? ProductIntParamB { get; set; }
        public double? ProductFloatParamA { get; set; }
        public double? ProductFloatParamB { get; set; }
        public long ProductClick { get; set; }
        public sbyte ProductIsHot { get; set; }
        public string ProductShopping { get; set; }
        public string ProductOrderNotice { get; set; }
        public long ProductSupplierCode { get; set; }
        public string ProductReceiptText { get; set; }
        public short ProductIsOnline { get; set; }
        public short? ProductFlowState { get; set; }
        public DateTime? ProductUsedOnDate { get; set; }
        public DateTime? ProductUsedOffDate { get; set; }
    }
}
