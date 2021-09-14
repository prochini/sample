using System;
using System.Collections.Generic;

#nullable disable

namespace sample.Models
{
    public partial class TvouVouflashsalepart
    {
        public long VouFlashSalePartId { get; set; }
        public long VouFlashSalePartVouFlashSaleCode { get; set; }
        public long VouFlashSalePartVoucherCode { get; set; }
        public int VouFlashSalePartSpecialPoint { get; set; }
        public int VouFlashSalePartFreqCount { get; set; }
        public int VouFlashSalePartFreqedCount { get; set; }
        public sbyte VouFlashSalePartState { get; set; }
        public string VouFlashSalePartVarParamA { get; set; }
        public string VouFlashSalePartVarParamB { get; set; }
        public long? VouFlashSalePartIntParamA { get; set; }
        public long? VouFlashSalePartIntParamB { get; set; }
        public double? VouFlashSalePartFloatParamA { get; set; }
        public double? VouFlashSalePartFloatParamB { get; set; }
    }
}
