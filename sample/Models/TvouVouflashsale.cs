using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVouflashsale
    {
        public long VouFlashSaleId { get; set; }
        public long VouFlashSaleCode { get; set; }
        public short VouFlashSaleCountryCode { get; set; }
        public string VouFlashSaleName { get; set; }
        public string VouFlashSaleExtName { get; set; }
        public DateTime VouFlashSaleOnlineDate { get; set; }
        public DateTime VouFlashSaleOfflineDate { get; set; }
        public sbyte VouFlashSaleState { get; set; }
        public sbyte? VouFlashSaleSyncState { get; set; }
        public string VouFlashSaleVarParamA { get; set; }
        public string VouFlashSaleVarParamB { get; set; }
        public long? VouFlashSaleIntParamA { get; set; }
        public long? VouFlashSaleIntParamB { get; set; }
        public double? VouFlashSaleFloatParamA { get; set; }
        public double? VouFlashSaleFloatParamB { get; set; }
        public short VouFlashSaleIsOnline { get; set; }
    }
}
